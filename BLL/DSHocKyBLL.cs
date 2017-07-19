using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DSHocKyBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DSHocKy> LoadAll()
        {
            return DB.DSHocKies.ToList();
        }

        public static List<DSHocKy> LoadHocKyHoc()
        {
            return DB.DSHocKies.Where(q => q.HeSo > 0).ToList();
        }

        public static string LayTenHocKyTheoMa(string maHocKy)
        {
            return DB.DSHocKies.Where(q => q.MaHocKy == maHocKy).Select(q => q.TenHocKy).FirstOrDefault();
        }

        public static bool? LaTongHop(string maHocKy)
        {
            return DB.DSHocKies.Where(q => q.MaHocKy == maHocKy).Select(q => q.TongHop).FirstOrDefault();
        }

        public static List<DSHocKy> LayHocKyHocTap()
        {
            return DB.DSHocKies.Where(q => q.TongHop == false).ToList();
        }

        public static string MaHocKyTongHop()
        {
            return DB.DSHocKies.Where(q => q.TongHop == true).Select(q => q.MaHocKy).FirstOrDefault();
        }
    }
}
