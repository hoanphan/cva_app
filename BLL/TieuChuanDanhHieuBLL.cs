using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class TieuChuanDanhHieuBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<TieuChuanDanhHieu> LoadAll()
        {
            return DB.TieuChuanDanhHieus.ToList();
        }

        public static string LayMaDanhHieu(string maHocLuc, string maHanhKiem)
        {
            return DB.TieuChuanDanhHieus.Where(q => q.MaHocLuc == maHocLuc && q.MaHanhKiem == maHanhKiem).Select(q => q.MaDanhHieu).FirstOrDefault();
        }
    }
}
