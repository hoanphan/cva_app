using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Net;
using System.Net.Mail;
using System.Threading;
using UTL;
using System.Windows.Forms;
using System.IO.Ports;
using DevExpress.XtraEditors;
//using EASendMail;

namespace BLL
{
    public class DSEmailSMSGuiToanBoBLL
    {
        static SerialPort port = new SerialPort();
        static SMSClass objclsSMS = new SMSClass();
        static ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();

        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void TaoMailDeGui()
        {
            DateTime now = DateTime.Now;
            int thangHienTai = now.Month;                        
            DSThang thang = DSThangBLL.LayThang(thangHienTai);
            string maHocky = thang.MaHocKy;

            string tg = "\"border-collapse:collapse;border-spacing:0;\"";
            string td = "\"font-family:Arial, sans-serif; font-size:14px; padding: 10px 5px; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px; overflow: hidden; word-break:normal; width: 800px;\"";
            string th = "\"font-family:Arial, sans-serif; font-size:14px; font-weight:normal; padding: 10px 5px; border-style:solid; border-width:1px; overflow: hidden; word-break:normal;\"";
            string tgor59 = "\"font-weight:bold; background-color:#cbcefb; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";
            string tgug4v = "\"font-weight:bold; background-color:#cbcefb;text-align:center; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";
            string tgdongchan = "\"background-color:#cbcefb;text-align:center; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";
            string tgdongle = "\"background-color:#ffffff;text-align:center; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";

            #region ChenNoiDungGui
            List<DSLop> Lops = DSLopBLL.LoadAll();
            foreach (DSLop Lop in Lops)
            {
                List<DSHocSinh> HocSinhs = DSHocSinhBLL.LayDSHocSinhTheoLop(Lop.MaLop, true);
                List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocTheoLopKy(Lop.MaLop, maHocky);
                List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
                foreach (DSHocSinh HocSinh in HocSinhs)
                {
                    bool coMonThayDoi = false;
                    string TieuDeEmail = "Kết quả học tập tháng " + thangHienTai + " - Năm học: " + DSNamHocBLL.LayTenNamHocHienTai() + " của học sinh: " + HocSinh.HoDem + " " + HocSinh.Ten;                    
                    string NoiDungGuiEmail = "";
                    string NoiDungGuiSMS = "";
                    //NoiDungGui += "<html><body>";
                    NoiDungGuiEmail += "<font face='verdana' color='#800000'><b>" + "Trường TH, THCS, THPT Chu Văn An kính gửi tới quý phụ huynh kết quả học tập của học sinh trong tháng " + thangHienTai + "</b></font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Họ và tên:  <b>" + HocSinh.HoDem + " " + HocSinh.Ten + "</b>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Mã học sinh:<b>" + HocSinh.MaHocSinh + "</b>" + "</font><br>";

                    //Thêm tiêu đề cho SMS
                    NoiDungGuiSMS += "Diem cap nhat thang " + thangHienTai + " cua hoc sinh: " + UTL.Ultils.ConvertToUnSign(HocSinh.HoDem + " " + HocSinh.Ten).Replace("-"," ").Trim();

                    //NoiDungGui += "<meta content=\"text/html; charset=UTF-8\">" +
                                        
                    NoiDungGuiEmail += "<table style=" + td + "><tr><th style=" + tgor59 + " rowspan=\"2\"><br>Loại điểm<br><br><br>Tên môn</th>";
                    foreach (DSLoaiDiem LoaiDiem in LoaiDiems)                    
                        if (LoaiDiem.SoDiemToiDa > 1)
                            NoiDungGuiEmail += "<th style=" + tgug4v + " colspan=\"" + LoaiDiem.SoDiemToiDa + "\">" + LoaiDiem.TenLoaiDiem + "</th>";
                        else
                            NoiDungGuiEmail += "<th style=" + tgor59 + " rowspan=\"2\">" + LoaiDiem.TenLoaiDiem + "</th>";
                    NoiDungGuiEmail += "</tr><tr>";
                    foreach (DSLoaiDiem LoaiDiem in LoaiDiems)
                        if (LoaiDiem.SoDiemToiDa > 1)
                            for (byte i = 1; i <= LoaiDiem.SoDiemToiDa; i++)
                                NoiDungGuiEmail += "<td style=" + tgor59 + ">" + LoaiDiem.HienThi + i.ToString() + "</td>";                        
                    NoiDungGuiEmail += "</tr>";
                    List<DSDiem> Diems = DSDiemBLL.LayDiemTheoHocSinhKy(HocSinh.MaHocSinh, maHocky);
                    byte Dong = 0;
                    foreach (DSMonHoc MonHoc in MonHocs)
                    {
                        bool coCapNhat = false;
                        NoiDungGuiEmail += "<tr>";
                        string classCSS = "";
                        if (Dong % 2 == 0)
                            classCSS = tgdongle + ">";
                        else
                            classCSS = tgdongchan + ">";                        

                        NoiDungGuiEmail += "<td style=" + classCSS + MonHoc.TenMonHoc + "</td>";


                        //Kiểm tra xem môn học đó có tính điểm không để in ra cách hiển thị khác nhau
                        if (MonHoc.DSHinhThucDanhGia.TinhDiem == true)
                        {
                            foreach (DSLoaiDiem LoaiDiem in LoaiDiems)
                            {
                                List<DSDiem> DiemTheoMon = Diems.Where(q => q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == LoaiDiem.MaLoaiDiem).ToList();
                                foreach (DSDiem Diem in DiemTheoMon)
                                    if (Diem.Diem == -1)
                                        NoiDungGuiEmail += "<td style=" + classCSS + "</td>";
                                    else
                                    {
                                        DateTime ngayCapNhat = (DateTime)Diem.NgayCapNhat;
                                        if (ngayCapNhat.Month == thang.STTThang)
                                        {
                                            NoiDungGuiEmail += "<td style=" + classCSS + "<span style = \"color:#FF0000;\">" + Diem.Diem + "</span></td>";
                                            //Kiểm tra xem biến coCapNhat đã được cập nhật chưa
                                            if (coCapNhat == false)
                                            {
                                                NoiDungGuiSMS += "\r\n" + UTL.Ultils.ConvertToUnSign(MonHoc.HienThi).Replace("-", " ").Trim() + ":";                                                
                                                coCapNhat = true;
                                                coMonThayDoi = true;
                                            }
                                            if (LoaiDiem.TinhToan == true)
                                                NoiDungGuiSMS += " " + Diem.Diem + "(" + LoaiDiem.HeSo + ")";
                                        }                                            
                                        else
                                            NoiDungGuiEmail += "<td style=" + classCSS + Diem.Diem + "</td>";
                                    }                                        
                            }
                        }else
                        {
                            foreach (DSLoaiDiem LoaiDiem in LoaiDiems)
                            {
                                List<DSDiem> DiemTheoMon = Diems.Where(q => q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == LoaiDiem.MaLoaiDiem).ToList();
                                foreach (DSDiem Diem in DiemTheoMon)
                                    if (Diem.Diem == -1)
                                        NoiDungGuiEmail += "<td style=" + classCSS + " </td>";
                                    else
                                    {
                                        DateTime ngayCapNhat = (DateTime)Diem.NgayCapNhat;
                                        if (Diem.Diem == -2)
                                            if (ngayCapNhat.Month == thang.STTThang)
                                                NoiDungGuiEmail += "<td style=" + classCSS + "<span style = \"color:#FF0000;\">Đ</span></td>";
                                            else
                                                NoiDungGuiEmail += "<td style=" + classCSS + "Đ</td>";
                                        else
                                             if (ngayCapNhat.Month == thang.STTThang)
                                            NoiDungGuiEmail += "<td style=" + classCSS + "<span style = \"color:#FF0000;\">CĐ</span></td>";
                                        else
                                            NoiDungGuiEmail += "<td style=" + classCSS + "CĐ</td>";
                                    }                                        
                            }
                        }
                        NoiDungGuiEmail += "</tr>";                                           
                        Dong++;                      
                    }
                    NoiDungGuiEmail += "</table>";
                    NoiDungGuiEmail += "<br><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>Quy ước: </b><span style = \"color:#FF0000;\">Điểm màu đỏ</span>" + "<span style = \"color:#000000;\"> là điểm học sinh được nhận trong tháng.</span>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\">Quý phụ huynh vui lòng không trả lời thư này vì đây là hệ thống thư tự động.</span>" + "</font><br><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><span style = \"color:#000000;\"><b>Nhà trường xin kính báo!</b></span>" + "</font>";
                    //NoiDungGui += "</body></html>";
                    if (coMonThayDoi == false)
                        NoiDungGuiSMS += "\r\nHoc sinh khong co diem moi trong thang nay.";
                    NoiDungGuiSMS += "\r\nTruy cap http://cva.utb.edu.vn/daotao/ de xem diem day du.";
                    ThemEmailGui(HocSinh.MaHocSinh, HocSinh.EmailPhuHuynh, thang.MaThang, TieuDeEmail, NoiDungGuiEmail, NoiDungGuiSMS);
                }
            }
            #endregion 
        }
        

        private static void ThemEmailGui(string maHocSinh, string diaChiNhan, string maThang, string tieuDe, string noiDungEmail, string noiDungSMS)
        {
            DSEmailGui EmailGui = new DSEmailGui();
            EmailGui.MaHocSinh = maHocSinh;
            EmailGui.DiaChiNhan = diaChiNhan;
            EmailGui.MaThang = maThang;
            EmailGui.TieuDe = tieuDe;
            EmailGui.NoiDungEmail = noiDungEmail;
            EmailGui.DaGuiEmail = false;
            EmailGui.NoiDungSMS = noiDungSMS;
            EmailGui.DaGuiSMS = false;
            DB.DSEmailGuis.InsertOnSubmit(EmailGui);
            DB.SubmitChanges();
        }

        public static void SendMail(string tieuDe, string noiDung)
        {            
            NetworkCredential cred = new NetworkCredential("accountforgames1702@gmail.com", "trungdung1617");
            MailMessage msg = new MailMessage();
            msg.To.Add("giangthanhtrung@gmail.com");
            msg.Subject = tieuDe;
            msg.IsBodyHtml = true;
            msg.Body = noiDung;
            msg.From = new MailAddress("accountforgames1702@gmail.com"); // Your Email Id
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //SmtpClient client1 = new SmtpClient("smtp.mail.yahoo.com", 465);
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(msg);            
        }

        //public static void SendMail(string tieuDe, string noiDung)
        //{            
        //    SmtpMail oMail = new SmtpMail("TryIt");
        //    EASendMail.SmtpClient oSmtp = new EASendMail.SmtpClient();

        //    try
        //    {
        //        SmtpServer oServer = new SmtpServer("smtp.gmail.com", 587);

        //        oServer.SocksProxyServer = "proxy1.utb.edu.vn";
        //        oServer.SocksProxyPort = 8080;
        //        // if your proxy doesn't requires user authentication, please don't assign any value to 
        //        // SocksProxyUser and SocksProxyPassword properties 
        //        oServer.ProxyProtocol = SocksProxyProtocol.Socks5;


        //        //set user authentication
        //        oServer.User = "accountforgames1702@gmail.com";
        //        oServer.Password = "trungdung1617";

        //        //specifies the authentication mechanism.
        //        //oSmtp.AuthType = SmtpAuthType.AuthAuto;

        //        //set SSL connection
        //        //oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

        //        //set smtp server port
        //        //oServer.Port = 465;

        //        //set helo domain
        //        //oServer.HeloDomain = "mymachine.com";

        //        //set delivery-report address
        //        //oServer.MailFrom = "report@adminsystem.com";
        //        oMail.From = new EASendMail.MailAddress("accountforgames1702@gmail.com");
        //        oMail.To.Add(new EASendMail.MailAddress("giangthanhtrung@gmail.com"));
        //        oMail.Subject = tieuDe;
        //        oMail.TextBody = noiDung;

        //        oSmtp.SendMail(oServer, oMail);
        //        Console.WriteLine("message was sent");
        //    }
        //    catch (SmtpTerminatedException exp)
        //    {
        //        Console.WriteLine(exp.Message);
        //    }
        //    catch (SmtpServerException exp)
        //    {
        //        Console.WriteLine("Exception: Server Respond: {0}", exp.ErrorMessage);
        //    }
        //    catch (System.Net.Sockets.SocketException exp)
        //    {
        //        Console.WriteLine("Exception: Networking Error: {0} {1}", exp.ErrorCode, exp.Message);
        //    }
        //    catch (System.ComponentModel.Win32Exception exp)
        //    {
        //        Console.WriteLine("Exception: System Error: {0} {1}", exp.ErrorCode, exp.Message);
        //    }
        //    catch (System.Exception exp)
        //    {
        //        Console.WriteLine("Exception: Common: {0}", exp.Message);
        //    }
        //}

        public static void SendListMail()
        {
            List<DSEmailGui> Emails = DB.DSEmailGuis.Where(q => q.MaHocSinh == "HS00153").ToList();
            foreach (DSEmailGui Email in Emails)
            {
                SendMail(Email.TieuDe, Email.NoiDungEmail);
                Thread.Sleep(1000);
            }
            Console.Write("Sent.");
        }

        public static List<DSEmailGui> LayDSMail()
        {
            return DB.DSEmailGuis.ToList();
        }

        public static void ThemEmailSMS(string noiDungEmail, string noiDungSMS)
        {
            List<DSHocSinh> HocSinhs = DSHocSinhBLL.LoadAll();
            foreach (DSHocSinh HocSinh in HocSinhs)
            {
                DSEmailSMSGuiToanBo EmailSMS = new DSEmailSMSGuiToanBo();
                EmailSMS.MaHocSinh = HocSinh.MaHocSinh;
                EmailSMS.EmailPhuHuynh = HocSinh.EmailPhuHuynh;
                EmailSMS.SoDienThoaiPhuHuynh = HocSinh.SoDienThoaiPhuHuynh;
                string NDSMS = noiDungSMS.Replace("{MaHocSinh}", HocSinh.MaHocSinh);
                NDSMS = NDSMS.Replace("{NgaySinh}", UTL.Ultils.Decrypt(HocSinh.MatKhau, "CVA"));
                EmailSMS.NoiDungSMS = NDSMS.Trim();
                EmailSMS.DaGuiEmail = EmailSMS.DaGuiSMS = false;
                DB.DSEmailSMSGuiToanBos.InsertOnSubmit(EmailSMS);
            }
            DB.SubmitChanges();
        }

        public static void GuiSMS(ref ProgressBarControl bar)
        {            
            List<DSEmailSMSGuiToanBo> EmailSMSes = DB.DSEmailSMSGuiToanBos.ToList();
            int i = 0;            
            Connect("COM4", 9600, 8, 400, 300);
            bar.Properties.Maximum = EmailSMSes.Count;
            bar.Properties.PercentView = true;
            bar.Properties.Step = 1;            
            foreach (DSEmailSMSGuiToanBo EmailSMS in EmailSMSes)
            {                
                //try
                //{
                if ((EmailSMS.SoDienThoaiPhuHuynh != null) && (EmailSMS.DaGuiSMS == false) && (EmailSMS.SoDienThoaiPhuHuynh != ""))
                {
                    string Message1 = EmailSMS.NoiDungSMS;
                    string Message2 = "";
                    int MessageLength = Message1.Length;
                    if (MessageLength > 160)
                    {
                        int ViTri = 159;
                        while (Message1[ViTri] != ' ')
                            ViTri--;
                        Message2 = Message1.Substring(ViTri, MessageLength - ViTri);
                        Message1 = Message1.Substring(0, ViTri);
                    }
                    objclsSMS.SendMsg(port, EmailSMS.SoDienThoaiPhuHuynh, Message1);
                    if (MessageLength > 160)
                    {
                        Thread.Sleep(5000);
                        objclsSMS.SendMsg(port, EmailSMS.SoDienThoaiPhuHuynh, Message2);
                    }
                    EmailSMS.DaGuiSMS = true;
                    DB.SubmitChanges();                   
                    Thread.Sleep(5000);
                    i++;
                    //if (i > 2)
                    //    return;

                    if ((i == 250))
                    {
                        objclsSMS.SendMsg(port, "0982527337", Message1);
                        Thread.Sleep(5000);
                        objclsSMS.SendMsg(port, "0982527337", Message2);
                        Thread.Sleep(5000);
                    }
                }
                bar.PerformStep();
                bar.Update();
                //}
                //catch (Exception ex)
                //{
                //    UTL.Ultils.ThongBao("Lỗi: " + ex.ToString(), MessageBoxIcon.Error);
                //}finally
                //{
                //    try
                //    {
                //        objclsSMS.ClosePort(port);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message.ToString());
                //    }
                //}
            }
            try
            {
                objclsSMS.ClosePort(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private static void Connect(string comPort, int baudRate, int dataBit, int readTimeout, int writeTimeout)
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
                    UTL.Ultils.ThongBao("Thiết lập cổng chưa đúng.", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UTL.Ultils.ThongBao("Chưa kết nối được đến Modem GSM.\r\nLỗi: " + ex.ToString(), MessageBoxIcon.Error);
            }
        }

        public static void CapNhatSDTEmail()
        {
            List<DSEmailSMSGuiToanBo> EmailSMSes = DB.DSEmailSMSGuiToanBos.ToList();
            foreach (DSEmailSMSGuiToanBo EmailSMS in EmailSMSes)
            {                
                DSHocSinh HS = DB.DSHocSinhs.Where(q => q.MaHocSinh == EmailSMS.MaHocSinh).FirstOrDefault();
                string TieuDe = "Trường TH, THCS, THPT Chu Văn An kính gửi phụ huynh em " + HS.HoDem + " " + HS.Ten + " - Lớp: " + DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HS.MaHocSinh);
                string NoiDung = "";
                NoiDung += "<p>Kính gửi phụ huynh em <b>" + HS.HoDem + " " + HS.Ten + "</b> - Sinh ngày: " + ((DateTime)HS.NgaySinh).ToShortDateString() + " - Lớp: " + DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HS.MaHocSinh) + "</p>";
                NoiDung += "<p>- Để chuẩn bị cho hệ thống Sổ liên lạc điện tử đi vào hoạt động chính thức, Nhà trường gửi tới phụ huynh Email này để kiểm tra tính chính xác của địa chỉ Email đã đăng ký.</p>";
                NoiDung += "<p>- Nếu quý phụ huynh thấy thông tin của học sinh gửi trong Email chưa chính xác, vui lòng liên hệ qua số điện thoại: <b>0982527337 (Thầy Trung)</b> để chỉnh sửa.</p>";
                NoiDung += "<p>- Quý phụ huynh vui lòng không trả lời Email này vì đây là hệ thống tự động.</p>";
                NoiDung += "<p><i>Xin trân trọng cảm ơn!</i></p>";
                EmailSMS.TieuDeEmail = TieuDe;
                EmailSMS.NoiDungEmail = NoiDung;                
                DB.SubmitChanges();
            }
        }

        public static void NoiDungEmail()
        {
            List<DSEmailSMSGuiToanBo> EmailSMSes = DB.DSEmailSMSGuiToanBos.ToList();
            foreach (DSEmailSMSGuiToanBo EmailSMS in EmailSMSes)
            {                
                DSHocSinh HS = DB.DSHocSinhs.Where(q => q.MaHocSinh == EmailSMS.MaHocSinh).FirstOrDefault();
                string tieuDe = "Trường TH, THCS, THPT Chu Văn An kính gửi phụ huynh em: " + HS.HoDem + " " + HS.Ten + " - Lớp: " + DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HS.MaHocSinh);
                string noiDung = "";
                noiDung += "Kính ";
                EmailSMS.SoDienThoaiPhuHuynh = HS.SoDienThoaiPhuHuynh;
                EmailSMS.EmailPhuHuynh = HS.EmailPhuHuynh;
                DB.SubmitChanges();
            }
        }
    }
}
