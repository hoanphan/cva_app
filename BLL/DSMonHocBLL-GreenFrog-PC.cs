using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Collections;

namespace BLL
{
    public class DSMonHocBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext();
        public static List<DSMonHoc> LoadAll()
        {
            return DB.DSMonHocs.ToList();
        }

        public static DSMonHoc TruyVanTheoMa(string maMonHoc)
        {
            return DB.DSMonHocs.Where(q => q.MaMonHoc == maMonHoc).FirstOrDefault();
        }

        public static List<DSMonHoc> TruyVanMonHocTheoLop(string maLop)
        {
            string[] dsMonHocTheoLop = (from ds in DB.GetTable<DSMonHocTheoLop>()
                                             where ds.MaLop == maLop
                                             select ds.MaMonHoc).ToArray();            
            return DB.DSMonHocs.Where(q => dsMonHocTheoLop.Contains(q.MaMonHoc)).ToList();
        }

        public static IList LayDuLieu()
        {
            return (from ds in DB.DSMonHocs select new { MaMonHoc = ds.MaMonHoc, HinhThucDanhGia = ds.DSHinhThucDanhGia.TenHinhThucDanhGia, TenMonHoc = ds.TenMonHoc, HeSo = ds.HeSo }).ToList();
        }

        public static void ThemMonHoc(string maMonHoc, string tenMonHoc, short maHinhThucDanhGia, short heSo)
        {
            DSMonHoc MonHoc = new DSMonHoc
            {
                MaMonHoc = maMonHoc,
                TenMonHoc = tenMonHoc,
                MaHinhThucDanhGia = maHinhThucDanhGia,
                HeSo = heSo
            };
            DB.DSMonHocs.InsertOnSubmit(MonHoc);
            DB.SubmitChanges();
            QuanLySoLuongBLL.TangSoLuongMonHoc();
        }

        public static void CapNhatMonHoc(DSMonHoc monHoc)
        {
            DSMonHoc MonHoc = TruyVanTheoMa(monHoc.MaMonHoc);
            MonHoc = monHoc;
            DB.SubmitChanges();
        }

        public static void XoaMonHoc(string maMonHoc)
        {
            DSMonHoc MonHoc = TruyVanTheoMa(maMonHoc);
            DB.DSMonHocs.DeleteOnSubmit(MonHoc);
            DB.SubmitChanges();
        }

        public static string SinhMaMonHoc()
        {
            var temp = DB.QuanLySoLuongs.Select(x => x.SoLuongMonHoc);
            int SLMH = (int)temp.First();
            if (SLMH < 10)
                return "MH0" + SLMH.ToString();
            else
                return "MH" + SLMH.ToString();
        }

        public static string[] LayMaTatCaMonHoc()
        {
            return DB.DSMonHocs.Select(q => q.MaMonHoc).ToArray();
        }

        public static string[] LayTenTatCaMonHoc()
        {
            return DB.DSMonHocs.Select(q => q.TenMonHoc).ToArray();
        }

        public static bool? LaChoDiem(string maMonHoc)
        {
            return DB.DSMonHocs.Where(q => q.MaMonHoc == maMonHoc).Select(q => q.DSHinhThucDanhGia.TinhDiem).First();
        }
        
    }
}
