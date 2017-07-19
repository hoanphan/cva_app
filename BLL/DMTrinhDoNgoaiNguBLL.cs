using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMTrinhDoNgoaiNguBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTrinhDoNgoaiNgu> LoadAll()
        {
            return DB.DMTrinhDoNgoaiNgus.ToList();
        }

        public static DMTrinhDoNgoaiNgu TruyVanTheoMa(short maTrinhDoNgoaiNgu)
        {
            return DB.DMTrinhDoNgoaiNgus.Where(q => q.MaTrinhDoNgoaiNgu == maTrinhDoNgoaiNgu).FirstOrDefault();
        }

        public static void ThemTrinhDoNgoaiNgu(string tenTrinhDoNgoaiNgu)
        {
            DMTrinhDoNgoaiNgu TrinhDoNgoaiNgu = new DMTrinhDoNgoaiNgu
            {
                TenTrinhDoNgoaiNgu = tenTrinhDoNgoaiNgu
            };
            DB.DMTrinhDoNgoaiNgus.InsertOnSubmit(TrinhDoNgoaiNgu);
            DB.SubmitChanges();
        }

        public static void CapNhatTrinhDoNgoaiNgu(DMTrinhDoNgoaiNgu trinhDoNgoaiNgu)
        {
            DMTrinhDoNgoaiNgu TrinhDoNgoaiNgu = TruyVanTheoMa(trinhDoNgoaiNgu.MaTrinhDoNgoaiNgu);
            TrinhDoNgoaiNgu = trinhDoNgoaiNgu;
            DB.SubmitChanges();
        }

        public static void XoaTrinhDoNgoaiNgu(short maTrinhDoNgoaiNgu)
        {
            DMTrinhDoNgoaiNgu TrinhDoNgoaiNgu = TruyVanTheoMa(maTrinhDoNgoaiNgu);
            DB.DMTrinhDoNgoaiNgus.DeleteOnSubmit(TrinhDoNgoaiNgu);
            DB.SubmitChanges();
        }
    }
}
