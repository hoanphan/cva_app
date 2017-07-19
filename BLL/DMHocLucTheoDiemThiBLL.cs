using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMHocLucTheoDiemThiBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static int SoLuongHocLuc()
        {
            return DB.DMHocLucTheoDiemThis.Count();
        }

        public static string[] LayTatCaMaHocLucTheoDiemThi()
        {
            return DB.DMHocLucTheoDiemThis.Select(q => q.MaHocLuc).ToArray();
        }
    }
}
