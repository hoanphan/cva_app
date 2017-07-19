using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMTonGiaoBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTonGiao> LoadAll()
        {
            return DB.DMTonGiaos.ToList();
        }

        public static DMTonGiao TruyVanTheoMa(short maTonGiao)
        {
            return DB.DMTonGiaos.Where(q => q.MaTonGiao == maTonGiao).FirstOrDefault();
        }

        public static void ThemTonGiao(string tenTonGiao)
        {
            DMTonGiao TonGiao = new DMTonGiao
            {
                TenTonGiao = tenTonGiao
            };
            DB.DMTonGiaos.InsertOnSubmit(TonGiao);
            DB.SubmitChanges();
        }

        public static void CapNhatTonGiao(DMTonGiao tonGiao)
        {
            DMTonGiao TonGiao = TruyVanTheoMa(tonGiao.MaTonGiao);
            TonGiao = tonGiao;
            DB.SubmitChanges();
        }

        public static void XoaTonGiao(short maTonGiao)
        {
            DMTonGiao TonGiao = TruyVanTheoMa(maTonGiao);
            DB.DMTonGiaos.DeleteOnSubmit(TonGiao);
            DB.SubmitChanges();
        }
    }
}
