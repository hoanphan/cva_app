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
    public class DSHocSinhThoiHocBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        
        public static DataTable LoadHocSinhThoiHoc(bool buocThoiHoc)
        {
            var DSHocSinh = DB.DSHocSinhThoiHocs.Where(q => q.BuocThoiHoc == buocThoiHoc).Select(q => new { q.MaHocSinh, q.DSHocSinh.HoDem, q.DSHocSinh.Ten, q.DSHocSinh.NgaySinh, q.LiDo }).ToList();
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
            DataColumn clLiDo = new DataColumn();
            clLiDo.ColumnName = "LiDo";

            tableHocSinh.Columns.Add(clSTT);
            tableHocSinh.Columns.Add(clMaHocSinh);
            tableHocSinh.Columns.Add(clHoDem);
            tableHocSinh.Columns.Add(clTen);
            tableHocSinh.Columns.Add(clNgaySinh);
            tableHocSinh.Columns.Add(clLiDo);

            byte i = 1;
            foreach (var HocSinh in DSHocSinh)
            {
                DataRow row = tableHocSinh.NewRow();
                row["STT"] = i++;
                row["MaHocSinh"] = HocSinh.MaHocSinh;
                row["HoDem"] = HocSinh.HoDem;
                row["Ten"] = HocSinh.Ten;
                row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                row["LiDo"] = HocSinh.LiDo;
                //UTL.Ultils.ThongBao(HocSinh.DangKyDichVu.ToString(), System.Windows.Forms.MessageBoxIcon.Information);
                tableHocSinh.Rows.Add(row);
            }
            return tableHocSinh;
        }

        /// <summary>
        /// Lấy mã học sinh thôi học theo học kỳ
        /// </summary>
        /// <param name="loaiThoiHoc">
        /// = 0 - Tự thôi học
        /// = 1 - Buộc thôi học
        /// = 2 - Tất cả</param>
        /// <param name="maHocKy">
        /// = maHocKy - Theo mã học kỳ
        /// = "" - Tất cả</param>
        /// <returns></returns>
        public static string[] LayMaHocSinhThoiHocTheoKy(byte loaiThoiHoc, string maHocKy)
        {
            string maNamHienTai = DSNamHocBLL.LayMaNamHocHienTai();
            List<DSHocSinhThoiHoc> HocSinhThoiHocs;                   
            switch (loaiThoiHoc)
            {
                case 0:
                    HocSinhThoiHocs = DB.DSHocSinhThoiHocs.Where(q => q.MaNamHoc == maNamHienTai && q.BuocThoiHoc == false).ToList();
                    break;
                case 1:
                    HocSinhThoiHocs = DB.DSHocSinhThoiHocs.Where(q => q.MaNamHoc == maNamHienTai && q.BuocThoiHoc == true).ToList();
                    break;
                case 2:
                    HocSinhThoiHocs = DB.DSHocSinhThoiHocs.Where(q => q.MaNamHoc == maNamHienTai).ToList();
                    break;
                default:
                    HocSinhThoiHocs = null;
                    break;              
            }
            if (HocSinhThoiHocs != null)
                if (maHocKy == "")
                    return HocSinhThoiHocs.Select(q => q.MaHocSinh).ToArray();
                else
                    return HocSinhThoiHocs.Where(q => q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
            return null;           
        }

        /// <summary>
        /// Lấy ds mã học sinh chuyển trường trong kỳ 2
        /// Dùng trong trường hợp HS chuyển đến kỳ 2 thì sẽ không lấy để xuất hiện trong kỳ 1
        /// </summary>
        /// <param name="chuyenDi">=1: Chuyển đi; =0: Chuyển đến</param>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public static string[] LayMaHocSinhThoiHocLechKy()
        {
            return DB.DSHocSinhThoiHocs.Where(q => q.BuocThoiHoc == false && q.MaHocKy == "K2").Select(q => q.MaHocSinh).ToArray();
        }

        public static void ThemHocSinhThoiHoc(bool buocThoiHoc, string maHocSinh, string maHocKy, string liDo, bool heVNEN)
        {
            string maNamHienTai = DSNamHocBLL.LayMaNamHocHienTai();
            int demTonTai = DB.DSHocSinhThoiHocs.Where(q => q.MaHocSinh == maHocSinh && q.BuocThoiHoc == buocThoiHoc).Count();
            if (demTonTai > 0)
            {
                UTL.Ultils.ThongBao("Học sinh này đã thôi học tại trường. " +
                    "Không thể thêm vào danh mục học sinh Thôi học", System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            else
            {
                DSHocSinhThoiHoc hsThoiHoc = new DSHocSinhThoiHoc();
                hsThoiHoc.BuocThoiHoc = buocThoiHoc;
                hsThoiHoc.MaNamHoc = maNamHienTai;
                hsThoiHoc.MaHocKy = maHocKy;
                hsThoiHoc.MaHocSinh = maHocSinh;
                hsThoiHoc.LiDo = liDo;                
                DB.DSHocSinhThoiHocs.InsertOnSubmit(hsThoiHoc);
                DB.SubmitChanges();
            }
        }

        /// <summary>
        /// Lấy ra danh sách mã sinh viên chuyển trường theo năm học hiện tại
        /// </summary>
        /// <param name="loaiThoi"> = 1 - Buộc thôi học
        ///                           = 0 - Tự thôi học
        ///                           = 2 - Tất cả</param>
        /// <param name="maHocKy"> = HK1 - Mã học kỳ        
        ///                           = "" - Tất cả</param>
        /// <returns>
        /// Mảng các chuỗi, mỗi chuỗi là một mã sinh viên chuyển trường theo loaiChuyen
        /// </returns>
        public static string[] LayMaHSThoiHoc(byte loaiThoi, string maHocKy)
        {
            string maNamHienTai = DSNamHocBLL.LayMaNamHocHienTai();            
            switch (loaiThoi)
            {
                case 0:
                    if (maHocKy == "")
                        return DB.DSHocSinhThoiHocs.Where(q => q.BuocThoiHoc == false).Select(q => q.MaHocSinh).ToArray();                    
                    else
                        return DB.DSHocSinhThoiHocs.Where(q => q.BuocThoiHoc == false && q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
                case 1:
                    if (maHocKy == "")
                        return DB.DSHocSinhThoiHocs.Where(q => q.BuocThoiHoc == true).Select(q => q.MaHocSinh).ToArray();                    
                    else
                        return DB.DSHocSinhThoiHocs.Where(q => q.BuocThoiHoc == true && q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();
                case 2:
                    if (maHocKy == "")
                        return DB.DSHocSinhThoiHocs.Select(q => q.MaHocSinh).ToArray();
                    else
                        return DB.DSHocSinhThoiHocs.Where(q => q.MaHocKy == maHocKy).Select(q => q.MaHocSinh).ToArray();                  
                default:
                    return null;
            }                
        }
    }
}
