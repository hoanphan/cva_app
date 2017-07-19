using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMHocLucBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static int SoLuongHocLuc()
        {
            return DB.DMHocLucs.Count();
        }

        public static List<DMHocLuc> LayTatCaHocLuc()
        {
            return DB.DMHocLucs.ToList();
        }

        public static string[] LayTenTatCaHocLuc()
        {
            return DB.DMHocLucs.OrderBy(q => q.MucUuTien).Select(q => q.TenHocLuc).ToArray();
        }

        public static string[] LayMaTatCaHocLuc()
        {
            return DB.DMHocLucs.OrderBy(q => q.MucUuTien).Select(q => q.MaHocLuc).ToArray();
        }
    }
}
