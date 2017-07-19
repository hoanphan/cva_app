using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DSHinhThucDanhGiaBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DSHinhThucDanhGia> LoadAll()
        {
            return DB.DSHinhThucDanhGias.ToList();
        }

        public static DSHinhThucDanhGia TruyVanTheoMa(short maHinhThucDanhGia)
        {
            return DB.DSHinhThucDanhGias.Where(q => q.MaHinhThucDanhGia == maHinhThucDanhGia).FirstOrDefault();
        }

        public static void ThemHinhThucDanhGia(string tenHinhThucDanhGia, bool tinhDiem)
        {
            DSHinhThucDanhGia HinhThucDanhGia = new DSHinhThucDanhGia
            {
                TenHinhThucDanhGia = tenHinhThucDanhGia,
                TinhDiem = tinhDiem
            };
            DB.DSHinhThucDanhGias.InsertOnSubmit(HinhThucDanhGia);
            DB.SubmitChanges();
        }

        public static void CapNhatHinhThucDanhGia(DSHinhThucDanhGia hinhThucDanhGia)
        {
            DSHinhThucDanhGia HinhThucDanhGia = TruyVanTheoMa(hinhThucDanhGia.MaHinhThucDanhGia);
            HinhThucDanhGia = hinhThucDanhGia;
            DB.SubmitChanges();
        }

        public static void XoaHinhThucDanhGia(short maHinhThucDanhGia)
        {
            DSHinhThucDanhGia HinhThucDanhGia = TruyVanTheoMa(maHinhThucDanhGia);
            DB.DSHinhThucDanhGias.DeleteOnSubmit(HinhThucDanhGia);
            DB.SubmitChanges();
        }
    }
}
