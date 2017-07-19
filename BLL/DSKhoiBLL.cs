using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class DSKhoiBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DSKhoi> LoadAll()
        {
            return DB.DSKhois.OrderBy(q=>q.TenKhoi).ToList();
        }

        public static List<DSKhoi> LayKhoiTheoMaCap(string maCap)
        {
            return DB.DSKhois.OrderBy(q => q.TenKhoi).Where(q => q.MaCap == maCap).ToList();
        }

        public static int LaySiSoTheoKhoi(string maKhoi)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.DSLop.MaKhoi == maKhoi).Count();
        }

        public static int LaySiSoTheoKhoiKy(string maKhoi, string maHocKy)
        {
            string[] maDSHSChuyenDenKy2 = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongLechKy();
            string[] maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            string[] maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            if (maHocKy == "K2" || maHocKy == "K3")
            {
                Array.Clear(maDSHSChuyenDenKy2, 0, maDSHSChuyenDenKy2.Length);
                maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");
                maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            }
            return DB.DSHocSinhTheoLops.Where(q => q.DSLop.MaKhoi == maKhoi
                            && !maDSHSChuyenDenKy2.Contains(q.MaHocSinh)
                            && !maDSHSChuyenDi.Contains(q.MaHocSinh)
                            && !maDSHSThoiHocKy2.Contains(q.MaHocSinh)).Count();
        }

        public static string TruyVanTenKhoiTheoMaLop(string maLop)
        {
            DSLop Lop = DB.DSLops.Where(q => q.MaLop == maLop).First();
            return Lop.DSKhoi.TenKhoi;    
        }

        public static string LayTenKhoiTheoMaKhoi(string maKhoi)
        {
            return DB.DSKhois.Where(q => q.MaKhoi == maKhoi).Select(q => q.TenKhoi).FirstOrDefault();
        }
    }
}
