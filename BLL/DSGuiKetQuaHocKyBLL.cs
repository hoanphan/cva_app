using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class DSGuiKetQuaHocKyBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static bool KiemTraGuiKetQuaHocKyDaTonTai(string maHocKy)
        {
            int soBanGhi = DB.DSGuiKetQuaHocKies.Where(q => q.MaHocKy == maHocKy).Count();
            if (soBanGhi > 0)
                return true;
            else
            {
                return false;

            }
        }

        public static void XoaEmailSMSTheoKy(string maHocKy)
        {
            DB.DSGuiKetQuaHocKies.DeleteAllOnSubmit(DB.DSGuiKetQuaHocKies.Where(q => q.MaHocKy == maHocKy).ToList());
            DB.SubmitChanges();
        }

        public static void TaoMailKetQuaCaHocKyDeGui(string maHocKy, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            DateTime now = DateTime.Now;
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
                    ThemEmailGui(HocSinh.MaHocSinh, maHocKy, HocSinh.EmailPhuHuynh, HocSinh.SoDienThoaiPhuHuynh, TieuDeEmail, NoiDungGuiEmail, null);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();
                }
            }
            #endregion 
        }

        private static void ThemEmailGui(string maHocSinh, string maHocKy, string diaChiEmail, string soDienThoai, string tieuDeEmail, string noiDungEmail, string noiDungSMS)
        {
            DSGuiKetQuaHocKy EmailGui = new DSGuiKetQuaHocKy();
            EmailGui.MaHocSinh = maHocSinh;
            EmailGui.MaHocKy = maHocKy;
            EmailGui.SoDienThoai = ThemTienToSDT(soDienThoai);
            EmailGui.DiaChiEmail = diaChiEmail;
            EmailGui.SoDienThoai = soDienThoai;
            EmailGui.TieuDeEmail = tieuDeEmail;
            EmailGui.NoiDungEmail = noiDungEmail;
            EmailGui.DaGuiEmail = false;
            EmailGui.NoiDungSMS = noiDungSMS;
            EmailGui.DaGuiSMS = false;
            EmailGui.DeliveredSMS = "";
            DB.DSGuiKetQuaHocKies.InsertOnSubmit(EmailGui);
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

        public static DataTable LayDuLieuSMSDeXuatExcel(string maHocKy, string maNhaMang)
        {
            //Lấy thông tin về nhà mạng
            DMNhaMang nhaMang = DB.DMNhaMangs.Where(q => q.MaNhaMang == maNhaMang).FirstOrDefault();
            string[] dauSos = nhaMang.DauSo.Split('#');
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("SoDienThoai", typeof(string));
            dataTable.Columns.Add("NoiDungSMS", typeof(string));
            List<DSGuiKetQuaHocKy> emailSMSes = DB.DSGuiKetQuaHocKies.Where(q => q.MaHocKy == maHocKy).ToList();
            int dem = 0;
            if (nhaMang.TatCa == true)
                foreach (DSGuiKetQuaHocKy emailSMS in emailSMSes)
                {
                    DataRow row = dataTable.NewRow();
                    row[0] = ++dem;
                    row[1] = emailSMS.SoDienThoai;
                    row[2] = emailSMS.NoiDungSMS;
                    dataTable.Rows.Add(row);
                }
            else
                foreach (DSGuiKetQuaHocKy emailSMS in emailSMSes)
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
