using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DMNhaMangBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DMNhaMang> LayTatCaNhaMang()
        {
            return DB.DMNhaMangs.OrderBy(q => q.MaNhaMang).ToList();
        }
    }
}
