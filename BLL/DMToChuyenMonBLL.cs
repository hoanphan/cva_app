using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMToChuyenMonBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMToChuyenMon> LoadAll()
        {
            return DB.DMToChuyenMons.ToList();
        }

        public static DMToChuyenMon TruyVanTheoMa(short maToChuyenMon)
        {
            return DB.DMToChuyenMons.Where(q => q.MaToChuyenMon == maToChuyenMon).FirstOrDefault();
        }

        public static void ThemToChuyenMon(string tenToChuyenMon)
        {
            DMToChuyenMon ToChuyenMon = new DMToChuyenMon
            {
                TenToChuyenMon = tenToChuyenMon
            };
            DB.DMToChuyenMons.InsertOnSubmit(ToChuyenMon);
            DB.SubmitChanges();
        }

        public static void CapNhatToChuyenMon(DMToChuyenMon toChuyenMon)
        {
            DMToChuyenMon ToChuyenMon = TruyVanTheoMa(toChuyenMon.MaToChuyenMon);
            ToChuyenMon = toChuyenMon;
            DB.SubmitChanges();
        }

        public static void XoaToChuyenMon(short maToChuyenMon)
        {
            DMToChuyenMon ToChuyenMon = TruyVanTheoMa(maToChuyenMon);
            DB.DMToChuyenMons.DeleteOnSubmit(ToChuyenMon);
            DB.SubmitChanges();
        }
    }
}
