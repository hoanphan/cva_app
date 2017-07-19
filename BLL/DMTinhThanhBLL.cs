using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMTinhThanhBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTinhThanh> LoadAll()
        {
            return DB.DMTinhThanhs.ToList();
        }

        public static DMTinhThanh TruyVanTheoMa(short maTinhThanh)
        {
            return DB.DMTinhThanhs.Where(q => q.MaTinhThanh == maTinhThanh).FirstOrDefault();
        }

        public static void ThemTinhThanh(string tenTinhThanh)
        {
            DMTinhThanh TinhThanh = new DMTinhThanh
            {
                TenTinhThanh = tenTinhThanh
            };
            DB.DMTinhThanhs.InsertOnSubmit(TinhThanh);
            DB.SubmitChanges();
        }

        public static void CapNhatTinhThanh(DMTinhThanh tinhThanh)
        {
            DMTinhThanh TinhThanh = TruyVanTheoMa(tinhThanh.MaTinhThanh);
            TinhThanh = tinhThanh;
            DB.SubmitChanges();
        }

        public static void XoaTinhThanh(short maTinhThanh)
        {
            DMTinhThanh TinhThanh = TruyVanTheoMa(maTinhThanh);
            DB.DMTinhThanhs.DeleteOnSubmit(TinhThanh);
            DB.SubmitChanges();
        }
    }
}
