using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class QuanLySoLuongBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void TangSoLuongMonHoc()
        {
            QuanLySoLuong QLSL = DB.QuanLySoLuongs.First();
            QLSL.SoLuongMonHoc = (short)(QLSL.SoLuongMonHoc + 1);
            DB.SubmitChanges();
        }

        public static void TangSoLuongLop()
        {
            QuanLySoLuong QLSL = DB.QuanLySoLuongs.First();
            QLSL.SoLuongLop = (short)(QLSL.SoLuongLop + 1);
            DB.SubmitChanges();
        }

        public static void TangSoLuongHocSinh()
        {
            QuanLySoLuong QLSL = DB.QuanLySoLuongs.First();
            QLSL.SoLuongHocSinh = (int)(QLSL.SoLuongHocSinh + 1);
            DB.SubmitChanges();
        }

        public static void TangSoLuongGiaoVien()
        {
            QuanLySoLuong QLSL = DB.QuanLySoLuongs.First();
            QLSL.SoLuongGiaoVien = (byte)(QLSL.SoLuongGiaoVien + 1);
            DB.SubmitChanges();
        }
    }
}
