using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMChucVuBLL
    {       
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMChucVu> LoadAll()
        {
            return DB.DMChucVus.ToList();
        }

        public static DMChucVu TruyVanTheoMa(short maChucVu)
        {
            return DB.DMChucVus.Where(q => q.MaChucVu == maChucVu).FirstOrDefault();
        }

        public static void ThemChucVu(string tenChucVu)
        {
            DMChucVu ChucVu = new DMChucVu
            {
                TenChucVu = tenChucVu
            };
            DB.DMChucVus.InsertOnSubmit(ChucVu);
            DB.SubmitChanges();
        }

        public static void CapNhatChucVu(DMChucVu danToc)
        {
            DMChucVu ChucVu = TruyVanTheoMa(danToc.MaChucVu);
            ChucVu = danToc;
            DB.SubmitChanges();
        }

        public static void XoaChucVu(short maChucVu)
        {
            DMChucVu ChucVu = TruyVanTheoMa(maChucVu);
            DB.DMChucVus.DeleteOnSubmit(ChucVu);
            DB.SubmitChanges();
        }
    }
}
