using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMHeDaoTaoBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMHeDaoTao> LoadAll()
        {
            return DB.DMHeDaoTaos.ToList();
        }

        public static DMHeDaoTao TruyVanTheoMa(short maHeDaoTao)
        {
            return DB.DMHeDaoTaos.Where(q => q.MaHeDaoTao == maHeDaoTao).FirstOrDefault();
        }

        public static void ThemHeDaoTao(string tenHeDaoTao)
        {
            DMHeDaoTao HeDaoTao = new DMHeDaoTao
            {
                TenHeDaoTao = tenHeDaoTao
            };
            DB.DMHeDaoTaos.InsertOnSubmit(HeDaoTao);
            DB.SubmitChanges();
        }

        public static void CapNhatHeDaoTao(DMHeDaoTao danToc)
        {
            DMHeDaoTao HeDaoTao = TruyVanTheoMa(danToc.MaHeDaoTao);
            HeDaoTao = danToc;
            DB.SubmitChanges();
        }

        public static void XoaHeDaoTao(short maHeDaoTao)
        {
            DMHeDaoTao HeDaoTao = TruyVanTheoMa(maHeDaoTao);
            DB.DMHeDaoTaos.DeleteOnSubmit(HeDaoTao);
            DB.SubmitChanges();
        }
    }
}
