using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoSendSMS
{
    public partial class AutoSendSMS : ServiceBase
    {
        mCore.SMS objSMS = new mCore.SMS();
        static SerialPort port = new SerialPort();
        static BLL.SMSClass objclsSMS = new BLL.SMSClass();

        public AutoSendSMS()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {    
            this.WriteToFile("Dich vu nhan tin SMS tu dong bat dau {0}");
            string ComPort = "", Parity = "";
            int BaudRate = 0, DataBits = 0;
            float StopBit = 0.0f;
            if (BLL.ModemConfigBLL.LayThongTinModem(ref ComPort, ref BaudRate, ref DataBits, ref Parity, ref StopBit) == true)
            {
                SetCommParameters(ComPort, BaudRate, DataBits, 0, 0);
                if (objSMS.Connect())
                {
                    WriteToFile("Ket noi thanh cong toi Modem");
                }
            }
            //Connect("COM1", 9600, 8, 400, 300);
            this.ScheduleService();
        }


        protected override void OnStop()
        {
            this.WriteToFile("Dich vu nhan tin SMS tu dong ket thuc {0}");
            try
            {
                objclsSMS.ClosePort(port);
            }
            catch (Exception ex)
            {
                this.WriteToFile("Dich vu gap Loi khi dong ket noi voi Modem: " + ex.Message.ToString());
            }
            this.Schedular.Dispose();
        }

        private void SetCommParameters(string comPort, int baudRate, int dataBits, int parity, int stopBit)
        {
            //Set communication parameters
            //check if port is already connected

            try
            {
                if (!objSMS.IsConnected)
                {
                    objSMS.Port = comPort;
                    objSMS.BaudRate = (mCore.BaudRate)(baudRate);
                    objSMS.DataBits = (mCore.DataBits)(dataBits);
                    objSMS.Parity = (mCore.Parity)parity;
                    objSMS.StopBits = (mCore.StopBits)(stopBit+1);
                    objSMS.FlowControl = 0;
                    objSMS.DisableCheckPIN = true;
                }
            }
            catch (mCore.GeneralException ex)
            {
                
            }
        }

        private Timer Schedular;

        public void ScheduleService()
        {
            try
            {
                Schedular = new Timer(new TimerCallback(SchedularCallback));
                string mode = ConfigurationManager.AppSettings["Mode"].ToUpper();
                this.WriteToFile("Che do chay: " + mode + " {0}");

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
                    int intervalSeconds = Convert.ToInt32(ConfigurationManager.AppSettings["IntervalSeconds"]);

                    //Set the Scheduled Time by adding the Interval to Current Time.
                    scheduledTimeSendMark = DateTime.Now.AddSeconds(intervalSeconds);
                    if (DateTime.Now > scheduledTimeSendMark)
                    {
                        //If Scheduled Time is passed set Schedule for the next Interval.
                        scheduledTimeSendMark = scheduledTimeSendMark.AddSeconds(intervalSeconds);
                    }
                }

                TimeSpan timeSpan = scheduledTimeSendMark.Subtract(DateTime.Now);
                string schedule = string.Format("{0} ngay {1} gio {2} phut {3} giay", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                
                DateTime GioHienTai = DateTime.Now;
                if ((GioHienTai.Hour > 7) && (GioHienTai.Hour < 21))
                {
                    string SoDienThoai = BLL.DSSMSAutoSendBLL.GuiTinNhanDauTien(port, objclsSMS);
                    this.WriteToFile("Gui tin nhan den: " + SoDienThoai + " vao " + schedule + " {0}");
                }                                 

                //BLL.DSEmailAutoSendBLL.GuiMailTrenCung();

                //Get the difference in Minutes between the Scheduled and Current Time.
                int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);

                //Change the Timer's Due Time.
                Schedular.Change(dueTime, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                WriteToFile("Dich vu gap loi: {0} " + ex.Message + ex.StackTrace);

                //Stop the Windows Service.
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
        }

        private void SchedularCallback(object e)
        {
            //this.WriteToFile("Log: {0}");
            this.ScheduleService();
        }

        private void WriteToFile(string text)
        {
            string path = "C:\\AutoSMSServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                writer.Close();
            }
        }

        private void Connect(string comPort, int baudRate, int dataBit, int readTimeout, int writeTimeout)
        {
            try
            {
                //Open communication port 
                port = objclsSMS.OpenPort(comPort, baudRate, dataBit, readTimeout, writeTimeout);
                if (port != null)
                {
                    //UTL.Ultils.ThongBao("Kết nối thành công với modem ở cổng " + comPort + ".", MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Invalid port settings");
                    this.WriteToFile("Dich vu gap loi Thiet lap cong chua dung.");
                }
            }
            catch (Exception ex)
            {
                this.WriteToFile("Chua ket noi duoc den Modem GSM. Loi: " + ex.ToString());
            }
        }
    }
}
