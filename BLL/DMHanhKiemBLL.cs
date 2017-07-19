using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMHanhKiemBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static string[] LayTenTatCaHanhKiem()
        {
            return DB.DMHanhKiems.OrderBy(q=>q.MucUuTien).Select(q => q.TenHanhKiem).ToArray();
        }
        public static string LayTenHanhKiemTheoMa(string maHanhKiem)
        {
            return DB.DMHanhKiems.Where(q => q.MaHanhKiem == maHanhKiem).Select(q => q.TenHanhKiem).FirstOrDefault();
        }

        public static string LayMaHanhKiemTheoTen(string tenHanhKiem)
        {
            return DB.DMHanhKiems.Where(q => q.TenHanhKiem == tenHanhKiem).Select(q => q.MaHanhKiem).FirstOrDefault();
        }

        public static int SoLuongHanhKiem()
        {
            return DB.DMHanhKiems.Count();
        }

        public static List<DMHanhKiem> LayTatCaHanhKiem()
        {
            return DB.DMHanhKiems.ToList();
        }

    }
}
