using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DSThangBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        /// <summary>
        /// Lấy tháng theo STT của tháng
        /// </summary>
        /// <param name="thang"></param>
        /// <returns></returns>
        public static DSThang LayThang(int thang)
        {
            return DB.DSThangs.Where(q => q.STTThang == thang).FirstOrDefault();
        }

        public static DSThang LayThangTheoMa(string maThang)
        {
            return DB.DSThangs.Where(q => q.MaThang == maThang).FirstOrDefault();
        }

        public static string LayTenThangTheoMaThang(string maThang)
        {
            return DB.DSThangs.Where(q => q.MaThang == maThang).FirstOrDefault().TenThang;
        }

        public static DSThang LayThangHienTai()
        {
            DateTime date = DateTime.Now;
            return DB.DSThangs.Where(q => q.ThoiGianGui.Value.Month == date.Month && q.ThoiGianGui.Value.Year == date.Year).FirstOrDefault();
        }

        public static List<DSThang> LayTatCaThang()
        {
            return DB.DSThangs.OrderBy(q => q.STTThang).OrderBy(q => q.MaHocKy).ToList();
        }
    }
}
