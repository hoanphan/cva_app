using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DSHocKyBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext();

        public static List<DSHocKy> LoadAll()
        {
            return DB.DSHocKies.ToList();
        }
    }
}
