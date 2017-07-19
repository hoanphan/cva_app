using System;
using System.Net;
using System.Net.Mail;
using System.ServiceProcess;
using System.Threading;
using System.Configuration;
using System.IO;

namespace AutoSendMailService
{
    public partial class AutoSendMail : ServiceBase
    {
        System.Timers.Timer createOrderTimer;

        public AutoSendMail()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //createOrderTimer = new System.Timers.Timer();
            //createOrderTimer.Elapsed += new System.Timers.ElapsedEventHandler(SendMail);
            //createOrderTimer.Interval = 1000*60*60*8;
            //createOrderTimer.Enabled = true;
            //createOrderTimer.AutoReset = true;
            //createOrderTimer.Start();     
            this.WriteToFile("Simple Service started {0}");
            this.ScheduleService();
        }


        protected override void OnStop()
        {
            this.WriteToFile("Simple Service stopped {0}");
            this.Schedular.Dispose();
        }        

        private Timer Schedular;

        public void ScheduleService()
        {
            try
            {
                Schedular = new Timer(new TimerCallback(SchedularCallback));
                string mode = ConfigurationManager.AppSettings["Mode"].ToUpper();
                this.WriteToFile("Simple Service Mode: " + mode + " {0}");

                //Set the Default Time.
                DateTime scheduledTimeSendMark = DateTime.MinValue;


                if (mode == "MONTHLY")
                {
                    //Get the Scheduled Time from AppSettings.                    
                    scheduledTimeSendMark = DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["ScheduledTimeSendMark"]);
                    if (DateTime.Now > scheduledTimeSendMark)
                    {
                        //If Scheduled Time is passed set Schedule for the next day.
                        scheduledTimeSendMark = scheduledTimeSendMark.AddDays(1);
                    }
                }

                if (mode.ToUpper() == "INTERVAL")
                {
                    //Get the Interval in Minutes from AppSettings.
                    int intervalMinutes = Convert.ToInt32(ConfigurationManager.AppSettings["IntervalMinutes"]);

                    //Set the Scheduled Time by adding the Interval to Current Time.
                    scheduledTimeSendMark = DateTime.Now.AddMinutes(intervalMinutes);
                    if (DateTime.Now > scheduledTimeSendMark)
                    {
                        //If Scheduled Time is passed set Schedule for the next Interval.
                        scheduledTimeSendMark = scheduledTimeSendMark.AddMinutes(intervalMinutes);
                    }
                }

                TimeSpan timeSpan = scheduledTimeSendMark.Subtract(DateTime.Now);
                string schedule = string.Format("{0} day(s) {1} hour(s) {2} minute(s) {3} seconds(s)", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                
                this.WriteToFile("Simple Service scheduled to run after: " + schedule + " {0}");

                //BLL.DSEmailAutoSendBLL.GuiMailTrenCung();

                //Get the difference in Minutes between the Scheduled and Current Time.
                int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);

                //Change the Timer's Due Time.
                Schedular.Change(dueTime, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace);

                //Stop the Windows Service.
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
        }

        private void SchedularCallback(object e)
        {
            this.WriteToFile("Simple Service Log: {0}");
            this.ScheduleService();
        }

        private void WriteToFile(string text)
        {
            string path = "C:\\ServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                writer.Close();
            }
        }

    }
}
