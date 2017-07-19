using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DSLoaiDiemBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DSLoaiDiem> LoadAll()
        {
            return DB.DSLoaiDiems.ToList();
        }

        public static string[] LoadAllTenLoaiDiem()
        {
            return DB.DSLoaiDiems.Select(q => q.TenLoaiDiem).ToArray();
        }

        public static string[] LoadAllMaLoaiDiem()
        {
            return DB.DSLoaiDiems.Select(q => q.MaLoaiDiem).ToArray();
        }

        public static string LoadMaDiemTongHop()
        {
            return DB.DSLoaiDiems.Where(q => q.TongHop == true).Select(q => q.MaLoaiDiem).FirstOrDefault();
        }

        public static string LoadMaDiemHocKy()
        {
            return DB.DSLoaiDiems.Where(q => q.LaHocKy == true).Select(q => q.MaLoaiDiem).FirstOrDefault();
        }

        public static string LoadMaDiemTrungBinh()
        {
            return DB.DSLoaiDiems.Where(q => q.TongHop == true).Select(q => q.MaLoaiDiem).FirstOrDefault();
        }

        public static string[] LoadAllHienThi()
        {
            return DB.DSLoaiDiems.Select(q => q.HienThi).ToArray();
        }

        public static short?[] LoadAllSoDiemToiDa()
        {
            return DB.DSLoaiDiems.Select(q => q.SoDiemToiDa).ToArray();
        }

        public static bool?[] LoadAllChinhSua()
        {
            return DB.DSLoaiDiems.Select(q => q.ChoPhepChinhSua).ToArray();
        }

        public static string LoadMaLoaiDiemTongHop()
        {
            return DB.DSLoaiDiems.Where(q => q.TinhToan == false).Select(q => q.MaLoaiDiem).FirstOrDefault().ToString();
        }

        public static DSLoaiDiem LayLoaiDiemTongHop()
        {
            return DB.DSLoaiDiems.Where(q => q.TinhToan == false).FirstOrDefault();
        }

    }
}
