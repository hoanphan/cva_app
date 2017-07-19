using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DSNamHocBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DSNamHoc> LoadAll()
        {
            return DB.DSNamHocs.ToList();
        }

        public static DSNamHoc TruyVanTheoMa(string maNamHoc)
        {
            return DB.DSNamHocs.Where(q => q.MaNamHoc == maNamHoc).FirstOrDefault();
        }

        public static string LayMaNamHocHienTai()
        {
            return DB.DSNamHocs.Where(q => q.NamHienTai == true).FirstOrDefault().MaNamHoc;
        }

        public static void CapNhatNamHoc(DSNamHoc namHoc)
        {
            DSNamHoc NamHoc = TruyVanTheoMa(namHoc.MaNamHoc);
            NamHoc = namHoc;
            DB.SubmitChanges();
        }

        public static void XoaNamHoc(string maNamHoc)
        {
            DSNamHoc NamHoc = TruyVanTheoMa(maNamHoc);
            DB.DSNamHocs.DeleteOnSubmit(NamHoc);
            DB.SubmitChanges();
        }

        public static void ThemNamHoc(DSNamHoc namHoc)
        {
            DB.DSNamHocs.InsertOnSubmit(namHoc);
            DB.SubmitChanges();
        }

        public static string TruyVanNamHocHienTai()
        {
            return (from ds in DB.GetTable<DSNamHoc>()
                    where ds.NamHienTai == true
                    select ds.MaNamHoc).FirstOrDefault();
        }

        public static string SinhMaNamHoc()
        {
            DSNamHoc NamHoc = DB.DSNamHocs.ToList().LastOrDefault();
            int NuaDau = int.Parse(NamHoc.MaNamHoc.Substring(0, 4));
            int NuaSau = int.Parse(NamHoc.MaNamHoc.Substring(4, 4));                            
            return (NuaDau + 1).ToString() + (NuaSau + 1).ToString(); 
        }

        public static string SinhTenNamHoc()
        {
            DSNamHoc NamHoc = DB.DSNamHocs.ToList().LastOrDefault();
            int NuaDau = int.Parse(NamHoc.MaNamHoc.Substring(0, 4));
            int NuaSau = int.Parse(NamHoc.MaNamHoc.Substring(4, 4));
            return (NuaDau + 1).ToString() + " - " + (NuaSau + 1).ToString();
        }

        public static void BoNamHienTai()
        {
            List<DSNamHoc> NamHocs = LoadAll();
            foreach (DSNamHoc NamHoc in NamHocs)
                NamHoc.NamHienTai = false;
            DB.SubmitChanges();
        }

        public static string LayTenNamHocHienTai()
        {
            return DB.DSNamHocs.Where(q => q.NamHienTai == true).Select(q => q.TenNamHoc).FirstOrDefault();
        }
    }
}
