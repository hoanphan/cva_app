using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTL;
using DAL;
using System.Data;

namespace BLL
{
    public class DSHocSinhChuyenTruongBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static DataTable LoadHocSinhChuyenTruong(bool chuyenDi)
        {
            var DSHocSinh = DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == chuyenDi).Select(q => new { q.MaHocSinh, q.DSHocSinh.HoDem, q.DSHocSinh.Ten, q.DSHocSinh.NgaySinh, q.NoiChuyen }).ToList();
            DataTable tableHocSinh = new DataTable();
            DataColumn clSTT = new DataColumn();
            clSTT.ColumnName = "STT";
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";
            DataColumn clHoDem = new DataColumn();
            clHoDem.ColumnName = "HoDem";
            DataColumn clTen = new DataColumn();
            clTen.ColumnName = "Ten";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            DataColumn clNoiChuyen = new DataColumn();
            clNoiChuyen.ColumnName = "NoiChuyen";

            tableHocSinh.Columns.Add(clSTT);
            tableHocSinh.Columns.Add(clMaHocSinh);
            tableHocSinh.Columns.Add(clHoDem);
            tableHocSinh.Columns.Add(clTen);
            tableHocSinh.Columns.Add(clNgaySinh);
            tableHocSinh.Columns.Add(clNoiChuyen);

            byte i = 1;
            foreach (var HocSinh in DSHocSinh)
            {
                DataRow row = tableHocSinh.NewRow();
                row["STT"] = i++;
                row["MaHocSinh"] = HocSinh.MaHocSinh;
                row["HoDem"] = HocSinh.HoDem;
                row["Ten"] = HocSinh.Ten;
                row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                row["NoiChuyen"] = HocSinh.NoiChuyen;
                //UTL.Ultils.ThongBao(HocSinh.DangKyDichVu.ToString(), System.Windows.Forms.MessageBoxIcon.Information);
                tableHocSinh.Rows.Add(row);
            }
            return tableHocSinh;
        }

        public static string[] LayMaHocSinhChuyenTruongTheoKy(bool chuyenDi, string maHocKy)
        {
            return DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == chuyenDi && q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
        }

        /// <summary>
        /// Lấy ds mã học sinh chuyển trường trong kỳ 2
        /// Dùng trong trường hợp HS chuyển đến kỳ 2 thì sẽ không lấy để xuất hiện trong kỳ 1
        /// </summary>
        /// <param name="chuyenDi">=1: Chuyển đi; =0: Chuyển đến</param>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public static string[] LayMaHocSinhChuyenTruongLechKy()
        {
            return DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == false && q.MaHocKy == "K2").Select(q => q.MaHocSinh).ToArray();
        }

        public static void ThemHocSinhChuyenTruong(bool chuyenDi, string maHocSinh, string maHocKy, string noiChuyen, bool heVNEN)
        {
            string maNamHienTai = DSNamHocBLL.LayMaNamHocHienTai();
            int demTonTai = DB.DSHocSinhChuyenTruongs.Where(q => q.MaHocSinh == maHocSinh && q.ChuyenDi == chuyenDi).Count();
            if (demTonTai > 0)
            {
                UTL.Ultils.ThongBao("Học sinh này đã được chuyển đi (hoặc đến) trường. " +
                    "Không thể thêm vào danh mục học sinh Chuyển trường", System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            else
            {
                DSHocSinhChuyenTruong hsChuyenTruong = new DSHocSinhChuyenTruong();
                hsChuyenTruong.ChuyenDi = chuyenDi;
                hsChuyenTruong.MaNamHoc = maNamHienTai;
                hsChuyenTruong.MaHocKy = maHocKy;
                hsChuyenTruong.MaHocSinh = maHocSinh;
                hsChuyenTruong.NoiChuyen = noiChuyen;
                hsChuyenTruong.HeVNEN = heVNEN;
                DB.DSHocSinhChuyenTruongs.InsertOnSubmit(hsChuyenTruong);
                DB.SubmitChanges();
            }
        }

        /// <summary>
        /// Lấy ra danh sách mã sinh viên chuyển trường theo năm học hiện tại
        /// </summary>
        /// <param name="loaiChuyen"> = 1 - Chuyển đi
        ///                           = 0 - Chuyển đến
        ///                           = 2 - Tất cả</param>
        /// <param name="maHocKy"> = maHocKy - Theo mã học kỳ        
        ///                           = "" - Tất cả</param>
        /// <returns>
        /// Mảng các chuỗi, mỗi chuỗi là một mã sinh viên chuyển trường theo loaiChuyen
        /// </returns>
        public static string[] LayMaHSChuyenTruong(byte loaiChuyen, string maHocKy)
        {
            string maNamHienTai = DSNamHocBLL.LayMaNamHocHienTai();            
            switch (loaiChuyen)
            {
                case 0:
                    if (maHocKy == "")
                        return DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == false).Select(q => q.MaHocSinh).ToArray();                    
                    else
                        return DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == false && q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
                case 1:
                    if (maHocKy == "")
                        return DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == true).Select(q => q.MaHocSinh).ToArray();                    
                    else
                        return DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == true && q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
                case 2:
                    if (maHocKy == "")
                        return DB.DSHocSinhChuyenTruongs.Select(q => q.MaHocSinh).ToArray();                    
                    else
                        return DB.DSHocSinhChuyenTruongs.Where(q => q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
                default:
                    return null;
            }                
        }

        public static string[] LayMaHSChuyenTruongVNEN()
        {
            string maNamHoc = DSNamHocBLL.LayMaNamHocHienTai();
            return DB.DSHocSinhChuyenTruongs.Where(q => q.HeVNEN == true && q.MaNamHoc == maNamHoc).Select(q => q.MaHocSinh).ToArray();
        }

        public static string[] LayMaHSKhongXet(string maHocKy)
        {
            //Lấy mã danh sách học sinh không thống kê bao gồm: chuyển trường, thôi học
            string[] maDSHSChuyenDenKy2 = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongLechKy();
            string[] maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            string[] maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            if (maHocKy == "K2" || maHocKy == "K3")
            {
                Array.Clear(maDSHSChuyenDenKy2, 0, maDSHSChuyenDenKy2.Length);
                maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");
                maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            }

            string[] maDSHSKhongThongKe = new string[maDSHSChuyenDenKy2.Length + maDSHSThoiHocKy2.Length + maDSHSChuyenDi.Length];
            maDSHSChuyenDenKy2.CopyTo(maDSHSKhongThongKe, 0);
            maDSHSThoiHocKy2.CopyTo(maDSHSKhongThongKe, maDSHSChuyenDenKy2.Length);
            maDSHSChuyenDi.CopyTo(maDSHSKhongThongKe, maDSHSChuyenDenKy2.Length + maDSHSThoiHocKy2.Length);
            return maDSHSKhongThongKe;
        }
    }
}
