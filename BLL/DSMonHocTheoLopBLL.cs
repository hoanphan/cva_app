using DAL;
using UTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DSMonHocTheoLopBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DSMonHoc> LoadMHCanPhanLop(string maLop, string maHocKy)
        {            
            string[] dsMonHocDuocPhanLop = (from ds in DB.GetTable<DSMonHocTheoLop>()
                                                 where ds.MaLop == maLop && ds.MaHocKy == maHocKy
                                                 select ds.MaMonHoc).ToArray();
            return DB.DSMonHocs.Where(q => !dsMonHocDuocPhanLop.Contains(q.MaMonHoc)).ToList();
        }

        public static List<DSMonHoc> LoadMHDuocPhanLop(string maLop, string maHocKy)
        {
            string[] dsMonHocDuocPhanLop = (from ds in DB.GetTable<DSMonHocTheoLop>()
                                                 where ds.MaLop == maLop && ds.MaHocKy == maHocKy
                                                 select ds.MaMonHoc).ToArray();
            return DB.DSMonHocs.Where(q => dsMonHocDuocPhanLop.Contains(q.MaMonHoc)).ToList();
        }

        public static void ThemMonHocTheoLop(string maMonHoc, string maLop, string maHocKy)
        {
            string maNamHoc = DSLopBLL.LayNamHoc(maLop);
            DSMonHocTheoLop MonHocTheoLop = new DSMonHocTheoLop
            {
                MaMonHoc = maMonHoc,
                MaLop = maLop,
                MaNamHoc = maNamHoc,
                MaHocKy = maHocKy
            };
            DB.DSMonHocTheoLops.InsertOnSubmit(MonHocTheoLop);
            DB.SubmitChanges();
        }

        public static DSMonHocTheoLop TruyVanTheoMa(string maMonHoc, string maLop, string maHocKy)
        {
            return DB.DSMonHocTheoLops.Where(q => q.MaMonHoc == maMonHoc && q.MaLop == maLop && q.MaHocKy == maHocKy).FirstOrDefault();
        }

        public static void XoaMonHocTheoMa(string maMonHoc, string maLop, string maHocKy)
        {
            DSMonHocTheoLop MonHocTheoLop = TruyVanTheoMa(maMonHoc, maLop, maHocKy);
            DB.DSMonHocTheoLops.DeleteOnSubmit(MonHocTheoLop);
            DB.SubmitChanges();
        }

        public static string[] LayMaMonHocTheoLopHocKy(string maLop, string maHocKy)
        {
            return DB.DSMonHocTheoLops.Where(q => q.MaLop == maLop && q.MaHocKy == maHocKy).OrderBy(q=>q.MaMonHoc).Select(q => q.MaMonHoc).ToArray();
        }

        public static string[] LayMaMonHocTheoLopKyTongHop(string maLop)
        {
            return DB.DSMonHocTheoLops.Where(q => q.MaLop == maLop).OrderBy(q => q.MaMonHoc).Select(q => q.MaMonHoc).Distinct().ToArray();
        }

        public static string[] LayMaMonHocTheoLop(string maLop)
        {
            return DB.DSMonHocTheoLops.Where(q => q.MaLop == maLop).OrderBy(q => q.MaMonHoc).Select(q => q.MaMonHoc).ToArray();
        }

        public static string[] LayHienThiMonHocTheoLopHocKy(string maLop, string maHocKy)
        {
            return DB.DSMonHocTheoLops.Where(q => q.MaLop == maLop && q.MaHocKy == maHocKy).OrderBy(q => q.MaMonHoc).Select(q => q.DSMonHoc.HienThi).ToArray();
        }

        public static string[] LayHienThiMonHocTheoLopKyTongHop(string maLop)
        {
            string[] maMonHocs = LayMaMonHocTheoLopKyTongHop(maLop);
            string[] strHienThi = new string[maMonHocs.Count()];
            byte i = 0;
            foreach(string maMonHoc in maMonHocs)
            {
                strHienThi[i] = DSMonHocBLL.LayHienThiMonHocTheoMa(maMonHoc);
                i++;
            }
            return strHienThi;
        }
        
        public static List<DSMonHoc> LayMonHocTheoLopKy(string maLop, string maHocKy)
        {
            string[] dsMaMonHocTheoLopKy = LayMaMonHocTheoLopHocKy(maLop, maHocKy);
            return DB.DSMonHocs.Where(q => dsMaMonHocTheoLopKy.Contains(q.MaMonHoc)).ToList();
        }

        public static List<DSMonHoc> LayMonHocTheoLop(string maLop)
        {
            string[] dsMaMonHocTheoLop = LayMaMonHocTheoLop(maLop);
            return DB.DSMonHocs.Where(q => dsMaMonHocTheoLop.Contains(q.MaMonHoc)).ToList();
        }

    }
}
