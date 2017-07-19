using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Collections;

namespace BLL
{
    public class DMQuanHuyenBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMQuanHuyen> LoadAll()
        {
            return DB.DMQuanHuyens.ToList();
        }

        public static DMQuanHuyen TruyVanTheoMa(int maQuanHuyen)
        {
            return DB.DMQuanHuyens.Where(q => q.MaQuanHuyen == maQuanHuyen).FirstOrDefault();
        }

        public static IList LayDuLieu()
        {
            return (from ds in DB.DMQuanHuyens select new { MaQuanHuyen = ds.MaQuanHuyen, TenTinhThanh = ds.DMTinhThanh.TenTinhThanh, TenQuanHuyen = ds.TenQuanHuyen }).ToList();
        }

        public static void ThemQuanHuyen(string tenQuanHuyen, short maTinhThanh)
        {
            DMQuanHuyen QuanHuyen = new DMQuanHuyen
            {
                TenQuanHuyen = tenQuanHuyen,
                MaTinhThanh = maTinhThanh
            };
            DB.DMQuanHuyens.InsertOnSubmit(QuanHuyen);
            DB.SubmitChanges();
        }

        public static void CapNhatQuanHuyen(DMQuanHuyen quanHuyen)
        {
            DMQuanHuyen QuanHuyen = TruyVanTheoMa(quanHuyen.MaQuanHuyen);
            QuanHuyen = quanHuyen;
            DB.SubmitChanges();
        }

        public static void XoaQuanHuyen(int maQuanHuyen)
        {
            DMQuanHuyen QuanHuyen = TruyVanTheoMa(maQuanHuyen);
            DB.DMQuanHuyens.DeleteOnSubmit(QuanHuyen);
            DB.SubmitChanges();
        }
    }
}
