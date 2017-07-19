using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DAL;
using System.Data;

namespace BLL
{
    public class DSGiaoVienBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DSGiaoVien> LoadAll()
        {
            return DB.DSGiaoViens.ToList();
        }

        public static string VD()
        {
            DSGiaoVien GV = DB.DSGiaoViens.Where(q => q.MaGiaoVien == "GV040").FirstOrDefault();
            return UTL.Ultils.Decrypt(GV.MatKhau, "CVA");
        }

        public static IList SelectDataFill()
        {
            return (from ds in DB.DSGiaoViens select new { MaGiaoVien = ds.MaGiaoVien, HoDem = ds.HoDem, Ten = ds.Ten, NgaySinh = ds.NgaySinh, GioiTinh = ds.GioiTinh, TenChucVu = ds.DMChucVu.TenChucVu}).ToList();
        }

        public static DSGiaoVien LayGiaoVienTheoMa(string maGiaoVien)
        {
            return DB.DSGiaoViens.Where(q => q.MaGiaoVien == maGiaoVien).FirstOrDefault();
        }

        public static IList SelectGiaoVien()
        {
            return (from ds in DB.DSGiaoViens select new { MaGiaoVien = ds.MaGiaoVien, HoVaTen = ds.HoDem + " " + ds.Ten }).ToList();
        }

        public static DSGiaoVien TruyVanTheoMa(string maGiaoVien)
        {
            return DB.DSGiaoViens.Where(q => q.MaGiaoVien == maGiaoVien).FirstOrDefault();
        }

        public static void ThemGiaoVien(DSGiaoVien giaoVien)
        {                        
            DB.DSGiaoViens.InsertOnSubmit(giaoVien);
            DB.SubmitChanges();
            QuanLySoLuongBLL.TangSoLuongGiaoVien();          
        }

        public static void CapNhatGiaoVien(DSGiaoVien giaoVien)
        {
            DSGiaoVien GiaoVien = TruyVanTheoMa(giaoVien.MaGiaoVien);
            GiaoVien = giaoVien;
            DB.SubmitChanges();
        }

        public static void XoaGiaoVien(string maGiaoVien)
        {
            DSGiaoVien GiaoVien = TruyVanTheoMa(maGiaoVien);
            DB.DSGiaoViens.DeleteOnSubmit(GiaoVien);
            DB.SubmitChanges();
        }

        public static string SinhMaGiaoVien()
        {
            var temp = DB.QuanLySoLuongs.Select(x => x.SoLuongGiaoVien);
            int SLGV = (int)temp.First();
            if (SLGV < 10)
                return "GV00" + (SLGV).ToString();
            else
                if (SLGV < 100)
                    return "GV0" + (SLGV).ToString();
                else
                    return "GV" + (SLGV).ToString();            
        }

        public static IList TruyVanTheoMonGiangDay(string maMonHoc)
        {
            return (from ds in DB.DSGiaoViens select new { MaGiaoVien = ds.MaGiaoVien, HoVaTen = ds.HoDem+ " " + ds.Ten, MonGiangDay = ds.MonGiangDay}).Where(q => q.MonGiangDay.Contains(maMonHoc)).ToList();
            //return DB.DSGiaoViens.Where(q => q.MonGiangDay.Contains(maMonHoc)).Select(q.ToList();
        }

        public static string LayTenGVCN(string maLop)
        {
            string HoTen = DB.DSLops.Where(q => q.MaLop == maLop).Select(q => q.DSGiaoVien.HoDem).FirstOrDefault() 
                + " " + DB.DSLops.Where(q => q.MaLop == maLop).Select(q => q.DSGiaoVien.Ten).FirstOrDefault();
            return HoTen;
        }

        public static byte XacThuc(string maGiaoVien, string matKhau)
        {
            try
            {
                string strEncrypt = DB.DSGiaoViens.Where(q => q.MaGiaoVien == maGiaoVien).Select(q => q.MatKhau).FirstOrDefault();
                if (strEncrypt != null)
                {
                    if (UTL.Ultils.Decrypt(strEncrypt, "CVA") == matKhau)
                        return 1;
                    else
                        return 0;
                }
                else
                    return 0;
            }catch(System.Data.SqlClient.SqlException ex)
            {
                return 255;
            }            
        }
        
        public static bool LaGiaoVien(string userName)
        {
            if (DB.DSGiaoViens.Where(q => q.MaGiaoVien == userName).Count() > 0)
                return true;
            else
                return false;
        }

        public static bool LaGVCN(string userName)
        {
            if (DB.DSLops.Where(q => q.MaGVCN == userName).Count() > 0)
                return true;
            else
                return false;
        }

        public static void HienMatKhau()
        {
            List<DSGiaoVien> GiaoViens = DB.DSGiaoViens.ToList();
            foreach(DSGiaoVien GiaoVien in GiaoViens)
            {
                UTL.Ultils.ThongBao(GiaoVien.Ten + " " + UTL.Ultils.Decrypt(GiaoVien.MatKhau, "CVA"), System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
