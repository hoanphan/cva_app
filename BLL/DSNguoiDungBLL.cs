using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DSNguoiDungBLL
    {
        private static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static byte XacThuc(string tenDangNhap, string matKhau)
        {
            try
            {
                string strEncrypt = DB.DSNguoiDungs.Where(q => q.TenDangNhap == tenDangNhap).Select(q => q.MatKhau).FirstOrDefault();
                if (strEncrypt != null)
                {
                    if (UTL.Ultils.Decrypt(strEncrypt, "CVA") == matKhau)
                        return 1;
                    else
                        return 0;
                }
                else
                    return 0;  
            }catch (System.Data.SqlClient.SqlException ex)
            {
                return 255;
            }                                  
        }

        public static string LayTenNguoiDung(string tenDangNhap)
        {
            if (DB.DSNguoiDungs.Where(q => q.TenDangNhap == tenDangNhap).FirstOrDefault() == null)
                return (from ds in DB.DSGiaoViens select new { TenNguoiDung = ds.HoDem + " " + ds.Ten, TenDangNhap = ds.MaGiaoVien }).Where(q => q.TenDangNhap == tenDangNhap).Select(q => q.TenNguoiDung).FirstOrDefault();
            else
                return DB.DSNguoiDungs.Where(q => q.TenDangNhap == tenDangNhap).Select(q => q.TenNguoiDung).FirstOrDefault();
        }
    }
}
