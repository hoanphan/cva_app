using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DMTrinhDoQLGDBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTrinhDoQLGD>LoadAll()
        {
            return DB.DMTrinhDoQLGDs.ToList();
        }
        public static DMTrinhDoQLGD TruyVanTheoMa(short maTrinhDoQLGD)
        {
            return DB.DMTrinhDoQLGDs.Where(q => q.MaTrinhDoQLGD == maTrinhDoQLGD).FirstOrDefault();
        }

        public static void ThemQLGD(string tenTrinhDoQLGD)
        {
            DMTrinhDoQLGD QLGD = new DMTrinhDoQLGD
            {
                TenTrinhDoQLGD = tenTrinhDoQLGD
            };
            DB.DMTrinhDoQLGDs.InsertOnSubmit(QLGD);
            DB.SubmitChanges();
        }

        public static void CapNhatQLGD(DMTrinhDoQLGD TrinhDoQLGD)
        {
            DMTrinhDoQLGD QLGD = TruyVanTheoMa(TrinhDoQLGD.MaTrinhDoQLGD);
            QLGD = TrinhDoQLGD;
            DB.SubmitChanges();
        }

        public static void XoaQLGD(short maQLGD)
        {
            DMTrinhDoQLGD QLGD = TruyVanTheoMa(maQLGD);
            DB.DMTrinhDoQLGDs.DeleteOnSubmit(QLGD);
            DB.SubmitChanges();
        }

    }
}
