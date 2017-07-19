using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Net;
using System.Net.Mail;
using System.Threading;
using UTL;
using System.IO.Ports;
using System.IO;
using System.Data;
//using EASendMail;

namespace BLL
{
    struct CapNhatGuiSMS
    {
        public string SDT;
        public string MaThang;
        public string NoiDung;
    }

    public class DSEmailGuiBLL
    {
        static List<CapNhatGuiSMS> daGuiSMS = new List<CapNhatGuiSMS>();
        static List<bool> delivered = new List<bool>();
        static mCore.SMS objSMS = new mCore.SMS();
        static SerialPort port = new SerialPort();
        static SMSClass objclsSMS = new SMSClass();
        static ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        static string maHocSinh, maThang = DSThangBLL.LayThangHienTai().MaThang;

        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void TaoMailDeGui(ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh, string maThang)
        {
            DateTime now = DateTime.Now;
            int thangHienTai = now.Month;                        
            DSThang thang = DSThangBLL.LayThangTheoMa(maThang);
            string maHocky = thang.MaHocKy;

            pgbTienTrinh.Properties.Maximum = 0;
            pgbTienTrinh.Properties.Maximum = DSHocSinhBLL.LaySoLuongHocSinhDangKyDichVu();            
            pgbTienTrinh.Properties.Step = 1;

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
                List<DSHocSinh> HocSinhs = DSHocSinhBLL.LayDSHocSinhDangKyDichVuTheoLop(Lop.MaLop, true);                
                List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocTheoLopKy(Lop.MaLop, maHocky);
                List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
                foreach (DSHocSinh HocSinh in HocSinhs)
                {
                    bool coMonThayDoi = false;
                    string TieuDeEmail = "Kết quả học tập tháng " + thang.STTThang + " - Năm học: " + DSNamHocBLL.LayTenNamHocHienTai() + " của học sinh: " + HocSinh.HoDem + " " + HocSinh.Ten;                    
                    string NoiDungGuiEmail = "";
                    string NoiDungGuiSMS = "";
                    //NoiDungGui += "<html><body>";
                    NoiDungGuiEmail += "<font face='verdana' color='#800000'><b>" + "Trường TH, THCS, THPT Chu Văn An kính gửi tới quý phụ huynh kết quả học tập của học sinh trong tháng " + thangHienTai + "</b></font><br><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Mã học sinh:<b>" + HocSinh.MaHocSinh + "</b>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Họ và tên:  <b>" + HocSinh.HoDem + " " + HocSinh.Ten + "</b>" + "</font><br>";                    
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Lớp:        <b>" + DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HocSinh.MaHocSinh) + "</b>" + "</font><br><br>";

                    //Thêm tiêu đề cho SMS
                    NoiDungGuiSMS += "Diem cap nhat thang " + thang.STTThang + " cua hoc sinh: " + UTL.Ultils.ConvertToUnSign(HocSinh.HoDem + " " + HocSinh.Ten).Replace("-"," ").Trim();

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
                                            if ((coCapNhat == false) && (LoaiDiem.TinhToan == true))
                                            {
                                                NoiDungGuiSMS += "\r\n" + MonHoc.HienThiSMS.Trim() + ":";                                                
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
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>Quy ước: <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#FF0000;\">Điểm màu đỏ</span>" + "<span style = \"color:#000000;\"> là điểm học sinh được nhận trong tháng.</span>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\">Quý phụ huynh vui lòng không trả lời thư này vì đây là hệ thống thư tự động.</span>" + "</font>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\"></span>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\">Để xem thông tin chi tiết vui lòng truy cập website: <a href=\"http://cva.utb.edu.vn/daotao\">http://cva.utb.edu.vn/daotao</a></span>" + "</font><br><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><span style = \"color:#000000;\"><b>Nhà trường xin kính báo!</b></span>" + "</font>";
                    NoiDungGuiEmail += "</body></html>";
                    if (coMonThayDoi == false)
                        NoiDungGuiSMS += "\r\nHoc sinh khong co diem moi trong thang nay.";
                    else
                        NoiDungGuiSMS += "\r\n(Phan noi dung trong ngoac don la he so cua diem)";
                    NoiDungGuiSMS += "\r\nTruy cap http://cva.utb.edu.vn/daotao/ de xem diem day du.";
                    ThemEmailGui(HocSinh.MaHocSinh, HocSinh.EmailPhuHuynh, HocSinh.SoDienThoaiPhuHuynh, thang.MaThang, TieuDeEmail, NoiDungGuiEmail, NoiDungGuiSMS);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();
                }
            }
            #endregion 
        }

        /// <summary>
        /// Tạo mail gửi kết quả tổng kết cả học kỳ cho phụ huynh
        /// </summary>
        /// <param name="pgbTienTrinh"></param>
        public static void TaoMailKetQuaCaHocKyDeGui(string maHocKy, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            DateTime now = DateTime.Now;
            int thangHienTai = now.Month;
            DSThang thang = DSThangBLL.LayThang(thangHienTai);
            string tenHocKy = DSHocKyBLL.LayTenHocKyTheoMa(maHocKy);

            pgbTienTrinh.Properties.Maximum = DSHocSinhBLL.LaySoLuongHocSinhDangKyDichVu();
            pgbTienTrinh.Properties.PercentView = true;
            pgbTienTrinh.Properties.Step = 1;
            
            string td = "\"font-family:Arial, sans-serif; font-size:14px; padding: 10px 5px; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px; overflow: hidden; word-break:normal; width: 800px;\"";            
            string tgor59 = "\"font-weight:bold; background-color:#cbcefb; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";
            string tgug4v = "\"font-weight:bold; background-color:#cbcefb;text-align:center; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";
            string tgdongchan = "\"background-color:#cbcefb;text-align:center; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";
            string tgdongle = "\"background-color:#ffffff;text-align:center; border-collapse:collapse; border-spacing:0; border-style:solid; border-width:1px\"";

            #region ChenNoiDungGui
            List<DSLop> Lops = DSLopBLL.LoadAll();
            foreach (DSLop Lop in Lops)
            {
                List<DSHocSinh> HocSinhs = DSHocSinhBLL.LayDSHocSinhDangKyDichVuTheoLop(Lop.MaLop, true);
                List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocTheoLopKy(Lop.MaLop, maHocKy);
                List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
                foreach (DSHocSinh HocSinh in HocSinhs)
                {                    
                    string TieuDeEmail = "Kết quả học tập Học " + tenHocKy + " - Năm học: " + DSNamHocBLL.LayTenNamHocHienTai() + " của học sinh: " + HocSinh.HoDem + " " + HocSinh.Ten;
                    string NoiDungGuiEmail = "";                    
                    //NoiDungGui += "<html><body>";
                    NoiDungGuiEmail += "<font face='verdana' color='#800000'><b>" + "Trường TH, THCS, THPT Chu Văn An kính gửi tới quý phụ huynh kết quả học tập của học sinh trong Học " + tenHocKy + "</b></font><br><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Mã học sinh: <b>" + HocSinh.MaHocSinh + "</b>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Họ và tên:  <b>" + HocSinh.HoDem + " " + HocSinh.Ten + "</b>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Lớp:        <b>" + DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HocSinh.MaHocSinh) + "</b>" + "</font><br><br>";                                        

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
                    List<DSDiem> Diems = DSDiemBLL.LayDiemTheoHocSinhKy(HocSinh.MaHocSinh, maHocKy);
                    byte Dong = 0;
                    foreach (DSMonHoc MonHoc in MonHocs)
                    {                        
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
                                        if (Diem.Diem < 5)
                                        {
                                            NoiDungGuiEmail += "<td style=" + classCSS + "<span style = \"color:#FF0000;\">" + Diem.Diem + "</span></td>";                                            
                                        }
                                        else
                                            NoiDungGuiEmail += "<td style=" + classCSS + Diem.Diem + "</td>";
                                    }
                            }
                        }
                        else
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
                                            NoiDungGuiEmail += "<td style=" + classCSS + "Đ</td>";
                                        else                                            
                                            NoiDungGuiEmail += "<td style=" + classCSS + "<span style = \"color:#FF0000;\">CĐ</span></td>";                                        
                                    }
                            }
                        }
                        NoiDungGuiEmail += "</tr>";
                        Dong++;
                    }
                    DSTongKetTheoKy TongKetTheoKy = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, HocSinh.MaHocSinh);
                    NoiDungGuiEmail += "</table>";
                    NoiDungGuiEmail += "<br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'>Trung bình các môn: &nbsp;&nbsp;<b><span style = \"color:#1804f4;\">" + TongKetTheoKy.TrungBinhChung + "</span></b>" + "</font><br>";
                    if (TongKetTheoKy.MaHocLuc != null)
                        NoiDungGuiEmail += "<font face='verdana' color='#000000'>Học lực: &nbsp;&nbsp;<b><span style = \"color:#1804f4;\">" + TongKetTheoKy.DMHocLuc.TenHocLuc + "</span></b>" + "</font><br>";
                    if (TongKetTheoKy.MaHanhKiem != null)
                        NoiDungGuiEmail += "<font face='verdana' color='#000000'>Hạnh kiểm: <b><span style = \"color:#1804f4;\">" + TongKetTheoKy.DMHanhKiem.TenHanhKiem + "</span></b>" + "</font><br>";
                    if (TongKetTheoKy.MaDanhHieu != null)
                        NoiDungGuiEmail += "<font face='verdana' color='#000000'>Danh hiệu: <b><span style = \"color:#1804f4;\">" + TongKetTheoKy.DMDanhHieu.TenDanhHieu + "</span></b>" + "</font><br>";
                    else
                        NoiDungGuiEmail += "<font face='verdana' color='#000000'>Danh hiệu: <b><span style = \"color:#1804f4;\">Không</span></b>" + "</font><br>";
                    NoiDungGuiEmail += "<br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>Quy ước: <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#FF0000;\">Điểm màu đỏ</span>" + "<span style = \"color:#000000;\"> là điểm dưới trung bình.</span>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\">Quý phụ huynh vui lòng không trả lời thư này vì đây là hệ thống thư tự động.</span>" + "</font>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\"></span>" + "</font><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><span style = \"color:#000000;\">Để xem thông tin chi tiết vui lòng truy cập website: <a href=\"http://cva.utb.edu.vn/daotao\">http://cva.utb.edu.vn/daotao</a></span>" + "</font><br><br>";
                    NoiDungGuiEmail += "<font face='verdana' color='#000000'><span style = \"color:#000000;\"><b>Nhà trường xin kính báo!</b></span>" + "</font>";
                    NoiDungGuiEmail += "</body></html>";                    
                    ThemEmailGui(HocSinh.MaHocSinh, HocSinh.EmailPhuHuynh, HocSinh.SoDienThoaiPhuHuynh, thang.MaThang, TieuDeEmail, NoiDungGuiEmail, null);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();
                }
            }
            #endregion 
        }

        private static void ThemEmailGui(string maHocSinh, string diaChiNhan, string soDienThoai, string maThang, string tieuDe, string noiDungEmail, string noiDungSMS)
        {
            DSEmailGui EmailGui = new DSEmailGui();
            EmailGui.MaHocSinh = maHocSinh;
            EmailGui.DiaChiNhan = diaChiNhan;            
            EmailGui.SoDienThoai = ThemTienToSDT(soDienThoai);
            EmailGui.MaThang = maThang;
            EmailGui.TieuDe = tieuDe;
            EmailGui.NoiDungEmail = noiDungEmail;
            EmailGui.DaGuiEmail = false;
            EmailGui.NoiDungSMS = noiDungSMS;
            EmailGui.DaGuiSMS = false;
            DB.DSEmailGuis.InsertOnSubmit(EmailGui);
            DB.SubmitChanges();
        }

        private static string ThemTienToSDT(string soDienThoai)
        {
            string soDienThoaiMoi = "";
            if (soDienThoai != null)
            {
                if (soDienThoai.Length > 3)
                {
                    soDienThoaiMoi = "84" + soDienThoai.Substring(1, soDienThoai.Length - 1);
                    return soDienThoaiMoi;
                }                    
            }
            return soDienThoai;
                

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
        //        oServer.ProxyProtocol = SocksProxyProtocol.Http;


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

        public static void SendListMailToanBo()
        {
            //List<DSEmailGui> Emails = DB.DSEmailGuis.Where(q => q.MaHocSinh == "HS00153").ToList();
            List<DSEmailSMSGuiToanBo> Emails = DB.DSEmailSMSGuiToanBos.ToList();
            foreach (DSEmailSMSGuiToanBo Email in Emails)
            {
                if ((Email.EmailPhuHuynh != "") && (Email.EmailPhuHuynh != null) && (Email.DaGuiEmail == false))
                {
                    //string mail1 = Email.EmailPhuHuynh, mail2 = "";
                    //if (Email.EmailPhuHuynh.Contains(','))
                    //{
                    //    mail1 = Email.EmailPhuHuynh.Substring(0, Email.EmailPhuHuynh.IndexOf(','));
                    //    mail2 = Email.EmailPhuHuynh.Substring(Email.EmailPhuHuynh.IndexOf(',') + 1, Email.EmailPhuHuynh.Length - Email.EmailPhuHuynh.IndexOf(',') - 1);
                    //    //UTL.Ultils.ThongBao(mail1 + "==" + mail2, System.Windows.Forms.MessageBoxIcon.Error);
                    //}
                    //UTL.Ultils.ThongBao(Email.EmailPhuHuynh, System.Windows.Forms.MessageBoxIcon.Error);
                    Ultils.SendMail(Email.EmailPhuHuynh, Email.TieuDeEmail, Email.NoiDungEmail);
                    Email.DaGuiEmail = true;
                    DB.SubmitChanges();
                    Thread.Sleep(10000);
                }
            }            
        }

        public static void SendListMailHangThang(ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            //List<DSEmailGui> Emails = DB.DSEmailGuis.Where(q => q.MaHocSinh == "HS00153").ToList();
            DSThang Thang = DSThangBLL.LayThangHienTai();            
            List<DSEmailGui> Emails = DB.DSEmailGuis.Where(q => q.MaThang == Thang.MaThang).ToList();
            pgbTienTrinh.Properties.Maximum = Emails.Count;
            pgbTienTrinh.Properties.PercentView = true;
            pgbTienTrinh.Properties.Step = 1;            
            foreach (DSEmailGui Email in Emails)
            {
                if ((Email.DiaChiNhan != "") && (Email.DiaChiNhan != null) && (Email.DaGuiEmail == false))
                {
                    //string mail1 = Email.DiaChiNhan, mail2 = "";
                    //if (Email.DiaChiNhan.Contains(','))
                    //{
                    //    mail1 = Email.DiaChiNhan.Substring(0, Email.DiaChiNhan.IndexOf(','));
                    //    mail2 = Email.DiaChiNhan.Substring(Email.DiaChiNhan.IndexOf(',') + 1, Email.DiaChiNhan.Length - Email.DiaChiNhan.IndexOf(',') - 1);
                    //    //UTL.Ultils.ThongBao(mail1 + "==" + mail2, System.Windows.Forms.MessageBoxIcon.Error);
                    //}
                    //UTL.Ultils.ThongBao(Email.EmailPhuHuynh, System.Windows.Forms.MessageBoxIcon.Error);
                    Ultils.SendMail(Email.DiaChiNhan, Email.TieuDe, Email.NoiDungEmail);
                    Email.DaGuiEmail = true;
                    DB.SubmitChanges();
                    Thread.Sleep(10000);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();
                }
            }
        }

        public static List<DSEmailGui> LayDSMail()
        {
            return DB.DSEmailGuis.ToList();
        }

        public static void GuiSMS(ref DevExpress.XtraEditors.ProgressBarControl bar)
        {
            List<DSEmailGui> EmailSMSes = DB.DSEmailGuis.ToList();
            int i = 0;
            Connect("COM4", 9600, 8, 400, 300);
            bar.Properties.Maximum = EmailSMSes.Count;
            bar.Properties.PercentView = true;
            bar.Properties.Step = 1;
            foreach (DSEmailGui EmailSMS in EmailSMSes)
            {
                //try
                //{
                if ((EmailSMS.SoDienThoai != null) && (EmailSMS.DaGuiSMS == false) && (EmailSMS.SoDienThoai != ""))
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
                    objclsSMS.SendMsg(port, EmailSMS.SoDienThoai, Message1);
                    if (MessageLength > 160)
                    {
                        Thread.Sleep(5000);
                        objclsSMS.SendMsg(port, EmailSMS.SoDienThoai, Message2);
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
                UTL.Ultils.ThongBao(ex.Message.ToString(), System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Phương thức gửi SMS mới bằng thư viện mCore
        /// </summary>
        /// <param name="bar"></param>
        public static void GuiSMSThangNew(ref DevExpress.XtraEditors.ProgressBarControl bar)
        {
            objSMS.NewDeliveryReport += new mCore.SMS.NewDeliveryReportEventHandler(objSMS_NewDeliveryReport);


            DSThang Thang = DSThangBLL.LayThangHienTai();
            List<DSEmailGui> SMSes = DB.DSEmailGuis.Where(q => q.MaThang == Thang.MaThang && q.DaGuiSMS == false).OrderBy(q=>q.MaHocSinh).ToList();            
            int i = 0;
            string ComPort = "", Parity = "";
            int BaudRate = 0, DataBits = 0;
            float StopBit = 0.0f;
            if (BLL.ModemConfigBLL.LayThongTinModem(ref ComPort, ref BaudRate, ref DataBits, ref Parity, ref StopBit) == true)
            {
                SetCommParameters(ComPort, BaudRate, DataBits, 0, 0);
                if (objSMS.Connect())
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem thành công.", System.Windows.Forms.MessageBoxIcon.Information);
                }
            }

            //Connect("COM4", 9600, 8, 400, 300);
            bar.Properties.Maximum = SMSes.Count;
            //bar.Properties.PercentView = true;
            bar.Properties.Step = 1;
            foreach (DSEmailGui SMS in SMSes)
            {
                //try
                //{
                if ((SMS.SoDienThoai != null) && (SMS.DaGuiSMS == false) && (SMS.SoDienThoai != ""))
                {
                    //UTL.Ultils.ThongBao(SMS.NoiDungSMS, System.Windows.Forms.MessageBoxIcon.Information);
                    if ((SMS.DaGuiSMS == false) || (SMS.DeliveredSMS.Contains("false#")) || (SMS.DeliveredSMS == null))
                    {
                        objSMS.SendSMS(SMS.SoDienThoai, SMS.NoiDungSMS);
                        SMS.DaGuiSMS = true;
                        DB.SubmitChanges();
                        Thread.Sleep(10000);
                        i++;
                    }                    
                    //if (i > 2)
                    //    return;

                    //if ((i == 2))
                    //{
                    //    break;
                    //}
                }
                bar.PerformStep();
                bar.Update();                
            }
            try
            {
                objSMS.Disconnect();                
            }
            catch (mCore.GeneralException ex)
            {
                UTL.Ultils.ThongBao(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                UTL.Ultils.ThongBao(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void GuiLaiSMSThangNew(ref DevExpress.XtraEditors.ProgressBarControl bar)
        {
            delivered.Clear();

            objSMS.Queue().Enabled = true;            

            objSMS.NewDeliveryReport += new mCore.SMS.NewDeliveryReportEventHandler(objSMS_NewDeliveryReport);


            DSThang Thang = DSThangBLL.LayThangHienTai();
            maThang = "T03";
            List<DSEmailGui> SMSes = DB.DSEmailGuis.Where(q => q.MaThang == maThang && (q.DaGuiSMS == false || q.DeliveredSMS.Contains("false") || q.DeliveredSMS == null)).OrderBy(q => q.MaHocSinh).ToList();
            int i = 0;
            string ComPort = "", Parity = "";
            int BaudRate = 0, DataBits = 0;
            float StopBit = 0.0f;
            if (BLL.ModemConfigBLL.LayThongTinModem(ref ComPort, ref BaudRate, ref DataBits, ref Parity, ref StopBit) == true)
            {
                SetCommParameters(ComPort, BaudRate, DataBits, 0, 0);
                if (objSMS.Connect())
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem thành công.", System.Windows.Forms.MessageBoxIcon.Information);                    
                }else
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem thất bại.", System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
            }else
            {
                UTL.Ultils.ThongBao("Không thể lấy thông tin kết nối Modem.", System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            mCore.QueuePriority EnumPriority = mCore.QueuePriority.Normal;            

            //Connect("COM4", 9600, 8, 400, 300);
            bar.Properties.Minimum = 0;
            bar.EditValue = 0;
            bar.Properties.Maximum = SMSes.Count;
            //bar.Properties.PercentView = true;
            bar.Properties.Step = 1;
            int dem = 0;
            foreach (DSEmailGui SMS in SMSes)
            {
                //try
                //{
                if ((SMS.SoDienThoai != null) && (SMS.SoDienThoai != ""))
                {
                    //UTL.Ultils.ThongBao(SMS.NoiDungSMS, System.Windows.Forms.MessageBoxIcon.Information);
                    objSMS.SendSMSToQueue(SMS.SoDienThoai, SMS.NoiDungSMS, EnumPriority, false);

                    //objSMS.SendSMS(SMS.SoDienThoai, SMS.NoiDungSMS);
                    SMS.DaGuiSMS = true;
                    DB.SubmitChanges();
                    dem++;
                    if (checkDelivered())
                        if (dem % 5 == 0)
                            Thread.Sleep(240000);
                        else
                            Thread.Sleep(10000);
                    else
                    {
                        Thread.Sleep(300000);
                        break;
                    }                        

                    i++;                    
                    //if (i > 2)
                    //    return;

                    //if ((i == 2))
                    //{
                    //    break;
                    //}
                }
                bar.PerformStep();
                bar.Update();
            }
            CapNhatDeliveredSMS();
            try
            {
                objSMS.Disconnect();
            }
            catch (mCore.GeneralException ex)
            {
                UTL.Ultils.ThongBao(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                UTL.Ultils.ThongBao(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
            UTL.Ultils.ThongBao("Kết thúc gửi.", System.Windows.Forms.MessageBoxIcon.Information);
        }

        static private bool checkDelivered()
        {
            if (delivered.Count > 5)
            {
                bool co = false;
                for (int i = delivered.Count - 1; i >= delivered.Count - 6; i--)
                    if (delivered[i] == true)
                        co = true;
                return co;
            }
            else
                return true;
                

        }

        private static void objSMS_NewDeliveryReport(object sender, mCore.NewDeliveryReportEventArgs e)
        {
            string noiDung = "";
            if (e.Status)
            {
                delivered.Add(true);
                noiDung += "true#" + "MESSAGE DELIVERED" + "\r\n" + "TO: " + e.Phone + "\r\n" +
                                       "DELIVERY DATE/TIME: " + e.DeliveryTimeStamp.ToString() +
                                       "\r\n" + "[Message Ref.: " + e.MessageReference.ToString() + "]";
                //UTL.Ultils.ThongBao(noiDung, System.Windows.Forms.MessageBoxIcon.Information);                
            }
            else
            {
                delivered.Add(false);
                noiDung += "false#" + "MESSAGE DELIVERY FALED" + "\r\n" + "TO: " + e.Phone + "\r\n" +
                                       "DELIVERY DATE/TIME: " + e.DeliveryTimeStamp.ToString() +
                                       "\r\n" + "[Message Ref.: " + e.MessageReference.ToString() + "]";
                //UTL.Ultils.ThongBao(noiDung, System.Windows.Forms.MessageBoxIcon.Information);                
            }

            CapNhatGuiSMS cnsms = new CapNhatGuiSMS();
            cnsms.SDT = e.Phone;
            cnsms.MaThang = maThang;
            cnsms.NoiDung = noiDung;
            daGuiSMS.Add(cnsms);
            //DSEmailGuiBLL.CapNhatDeliveredSMS(e.Phone, maThang, noiDung);
            using (StreamWriter sw = File.AppendText(@"F:\SMSLog.txt"))
            {
                sw.WriteLine(noiDung + Environment.NewLine);
            }
        }


        private static void SetCommParameters(string comPort, int baudRate, int dataBits, int parity, int stopBit)
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
                    objSMS.StopBits = (mCore.StopBits)(stopBit + 1);
                    objSMS.FlowControl = 0;
                    objSMS.DisableCheckPIN = true;
                    objSMS.DeliveryReport = true;
                    objSMS.LogType = mCore.LogType.ErrorEventLog;
                    objSMS.LogFolderPath = @"F:\SMSLogs\";
                }
            }
            catch (mCore.GeneralException ex)
            {

            }
        }

        /// <summary>
        /// Chuyển SMS của tháng hiện tại sang hệ thống tự động gửi
        /// </summary>
        public static void ChuyenSMSSangBangTuDongGui()
        {
            DSThang Thang = DSThangBLL.LayThangHienTai();
            if (Thang != null)
            {
                List<DSEmailGui> EmailSMSes = DB.DSEmailGuis.Where(q => q.MaThang == Thang.MaThang).ToList();
                foreach (DSEmailGui EmailSMS in EmailSMSes)
                {
                    if ((EmailSMS.SoDienThoai != null) && (EmailSMS.DaGuiSMS == false) && (EmailSMS.SoDienThoai != ""))
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
                            DSSMSAutoSend SMS = new DSSMSAutoSend();
                            SMS.SoDienThoaiNhan = EmailSMS.SoDienThoai;
                            SMS.NoiDungSMS = Message1;
                            DB.DSSMSAutoSends.InsertOnSubmit(SMS);
                            DSSMSAutoSend SMS2 = new DSSMSAutoSend();
                            SMS2.SoDienThoaiNhan = EmailSMS.SoDienThoai;
                            SMS2.NoiDungSMS = Message2;
                            DB.DSSMSAutoSends.InsertOnSubmit(SMS2);
                        }else
                        {
                            DSSMSAutoSend SMS = new DSSMSAutoSend();
                            SMS.SoDienThoaiNhan = EmailSMS.SoDienThoai;
                            SMS.NoiDungSMS = Message1;
                            DB.DSSMSAutoSends.InsertOnSubmit(SMS);
                        }                        
                        EmailSMS.DaGuiSMS = true;
                        DB.SubmitChanges();
                    }                        
                }
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
                    UTL.Ultils.ThongBao("Thiết lập cổng chưa đúng.", System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UTL.Ultils.ThongBao("Chưa kết nối được đến Modem GSM.\r\nLỗi: " + ex.ToString(), System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật trạng thái Delivered cho SMS của học sinh đầu tiên có số điện thoại trùng
        /// </summary>
        /// <param name="soDienThoai"></param>
        /// <param name="maThang"></param>
        /// <param name="noiDung"></param>
        public static void CapNhatDeliveredSMS()
        {
            foreach(CapNhatGuiSMS cnsms in daGuiSMS)
            {
                string sdtCat = cnsms.SDT.Substring(3, cnsms.SDT.Length - 3);
                DSEmailGui email = DB.DSEmailGuis.Where(q => q.SoDienThoai.Contains(sdtCat) && q.MaThang == cnsms.MaThang && (q.DeliveredSMS.Contains("false#") || q.DeliveredSMS == null)).OrderBy(q => q.MaHocSinh).FirstOrDefault();
                if (email != null)
                {
                    email.DeliveredSMS = cnsms.NoiDung;
                    DB.SubmitChanges();
                }
            }                       
        }

        public static bool KiemTraEmailGuiDaTonTai(string maThang)
        {            
            int soBanGhi = DB.DSEmailGuis.Where(q => q.MaThang == maThang).Count();
            if (soBanGhi > 0)
                return true;
            else
            {
                return false;
            }
        }

        public static void XoaEmailSMSTheoThang(string maThang)
        {
            DB.DSEmailGuis.DeleteAllOnSubmit(DB.DSEmailGuis.Where(q => q.MaThang == maThang).ToList());
            DB.SubmitChanges();
        }

        public static DataTable LayDuLieuSMSDeXuatExcel(string maThang, string maNhaMang)
        {
            //Lấy thông tin về nhà mạng
            DMNhaMang nhaMang = DB.DMNhaMangs.Where(q => q.MaNhaMang == maNhaMang).FirstOrDefault();
            string[] dauSos = nhaMang.DauSo.Split('#');                        
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("SoDienThoai", typeof(string));
            dataTable.Columns.Add("NoiDungSMS", typeof(string));
            List<DSEmailGui> emailSMSes = DB.DSEmailGuis.Where(q=>q.MaThang == maThang).ToList();
            int dem = 0;
            if (nhaMang.TatCa == true)
                foreach(DSEmailGui emailSMS in emailSMSes)
                {
                    DataRow row = dataTable.NewRow();
                    row[0] = ++dem;
                    row[1] = emailSMS.SoDienThoai;
                    row[2] = emailSMS.NoiDungSMS;
                    dataTable.Rows.Add(row);
                }
            else
                foreach (DSEmailGui emailSMS in emailSMSes)
                {
                    bool thuocMang = false;
                    foreach (string dauSo in dauSos)
                        if (emailSMS.SoDienThoai.StartsWith(dauSo))
                        {
                            thuocMang = true;
                            break;
                        }
                    if (thuocMang == true)
                    {
                        DataRow row = dataTable.NewRow();
                        row[0] = ++dem;
                        row[1] = emailSMS.SoDienThoai;
                        row[2] = emailSMS.NoiDungSMS;
                        dataTable.Rows.Add(row);
                    }                    
                }
            return dataTable;
        }
    }
}
