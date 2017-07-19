using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class DSLopBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DSLop> LoadAll()
        {
            return DB.DSLops.ToList();
        }

        public static int LaySiSoTheoLop(string maLop)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Count();
        }

        public static int LaySiSoTheoLopKy(string maLop, string maHocKy)
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
            return DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop 
                            && !maDSHSChuyenDenKy2.Contains(q.MaHocSinh)
                            && !maDSHSChuyenDi.Contains(q.MaHocSinh)
                            && !maDSHSThoiHocKy2.Contains(q.MaHocSinh)).Count();
        }

        public static List<DSLop> LayLopTheoGVCN(string maGiaoVien)
        {
            return DB.DSLops.Where(q => q.MaGVCN == maGiaoVien).ToList();
        }

        public static List<DSLop> TruyVanTheoMaKhoi(string maKhoi)
        {
            return DB.DSLops.Where(q => q.MaKhoi == maKhoi).ToList();
        }

        public static List<DSLop> TruyVanTheoMaKhoiMaGVCN(string maKhoi, string maGVCN)
        {
            return DB.DSLops.Where(q => q.MaKhoi == maKhoi && q.MaGVCN == maGVCN).ToList();
        }

        public static string LayNamHoc(string maLop)
        {
            DSLop Lop = DB.DSLops.Where(q => q.MaLop == maLop).First();
            return (string)Lop.MaNamHoc;
        }

        public static string[] LayMaLopTheoMaKhoi(string maKhoi)
        {
            return DB.DSLops.Where(q => q.MaKhoi == maKhoi).Select(q => q.MaLop).ToArray();
        }

        public static string[] TenTatCaCacLopTheoKhoi(string maKhoi)
        {
            return DB.DSLops.Where(q => q.MaKhoi == maKhoi).Select(q => q.TenLop).ToArray();
        }

        public static string[] MaTatCaCacLopTheoKhoi(string maKhoi)
        {
            return DB.DSLops.Where(q => q.MaKhoi == maKhoi).Select(q => q.MaLop).ToArray();
        }

        public static string LayTenLopTheoMaLop(string maLop)
        {
            return DB.DSLops.Where(q => q.MaLop == maLop).Select(q => q.TenLop).FirstOrDefault();
        }

        public static DSLop TruyVanTheoMa(string maLop)
        {
            return DB.DSLops.Where(q => q.MaLop == maLop).FirstOrDefault();
        }

        public static void ThemLop(DSLop lop)
        {
            DB.DSLops.InsertOnSubmit(lop);
            DB.SubmitChanges();
        }

        public static void CapNhatLop(DSLop lop)
        {
            DSLop Lop = DB.DSLops.Where(q => q.MaLop == lop.MaLop).FirstOrDefault();
            Lop = lop;
            DB.SubmitChanges();
        }

        public static void XoaLop(string maLop)
        {
            DSLop Lop = TruyVanTheoMa(maLop);
            DB.DSLops.DeleteOnSubmit(Lop);
            DB.SubmitChanges();
        }

        public static System.Collections.IList LayDuLieu()
        {
            return (from ds in DB.DSLops select new { MaLop = ds.MaLop, TenKhoi = ds.DSKhoi.TenKhoi, TenLop = ds.TenLop }).ToList();
        }

        public static string SinhMaLop()
        {
            var temp = DB.QuanLySoLuongs.Select(x => x.SoLuongLop);
            int SLL = (int)temp.First();
            if (SLL < 10)
                return "L00" + (SLL).ToString();
            else
                if (SLL < 100)
                    return "L0" + (SLL).ToString();
                else
                    return "L" + (SLL).ToString();
        }

        public static string LaGVCN(string maNguoiDung)
        {
            return DB.DSLops.Where(q => q.MaGVCN == maNguoiDung).Select(q => q.MaLop).FirstOrDefault();
        }

        public static string[] LayMaTatCaCacLop()
        {
            return DB.DSLops.OrderBy(q => q.TenLop).OrderBy(q => q.DSKhoi.TenKhoi).Select(q => q.TenLop).ToArray();
        }

        public static List<DSLop> LayLopTheoMaKhoi(string maKhoi)
        {
            return DB.DSLops.Where(q => q.MaKhoi == maKhoi).OrderBy(q=> q.TenLop).ToList();
        }
        
    }
}
