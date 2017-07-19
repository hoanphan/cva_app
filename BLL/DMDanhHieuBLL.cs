using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMDanhHieuBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static int SoDanhHieuKhenThuong()
        {
            return DB.DMDanhHieus.Where(q => q.InGiayKhen == true).Count();
        }

        public static List<DMDanhHieu> LayTatCaDanhHieu()
        {
            return DB.DMDanhHieus.ToList();
        }
    }
}
