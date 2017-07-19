using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using DAL;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace BLL
{
    public class DSHocSinhBLL
    {

        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DSHocSinh> LoadAll()
        {
            return DB.DSHocSinhs.ToList();
        }

        public static IList SelectDataFill()
        {
            return (from ds in DB.DSHocSinhs select new { MaHocSinh = ds.MaHocSinh, HoDem = ds.HoDem, Ten = ds.Ten, NgaySinh = ds.NgaySinh, GioiTinh = ds.GioiTinh, TenLop = DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == ds.MaHocSinh).Select(q => q.DSLop.TenLop).FirstOrDefault(), STT = DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == ds.MaHocSinh).Select(q => q.STT).FirstOrDefault() }).ToList();
        }

        public static DSHocSinh TruyVanTheoMa(string maHocSinh)
        {
            return DB.DSHocSinhs.Where(q => q.MaHocSinh == maHocSinh).FirstOrDefault();
        }      

        public static void ThemHocSinh(DSHocSinh HocSinh)
        {            
            DB.DSHocSinhs.InsertOnSubmit(HocSinh);
            DB.SubmitChanges();
        }

        public static void CapNhatHocSinh(DSHocSinh hocSinh)
        {
            DSHocSinh HocSinh = TruyVanTheoMa(hocSinh.MaHocSinh);
            HocSinh = hocSinh;
            DB.SubmitChanges();
        }

        public static void XoaHocSinh(string maHocSinh)
        {
            DSHocSinh HocSinh = TruyVanTheoMa(maHocSinh);
            DB.DSHocSinhs.DeleteOnSubmit(HocSinh);
            DB.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Số lượng mã học sinh đã đánh để trả ra mã học sinh mới</returns>
        public static string SinhMaHocSinh()
        {
            var temp = DB.QuanLySoLuongs.Select(x => x.SoLuongHocSinh);
            int SLHS = (int)temp.First();
            if (SLHS < 10)
                return "HS0000" + SLHS.ToString();
            else
                if (SLHS < 100)
                    return "HS000" + SLHS.ToString();
                else
                    if (SLHS < 1000)
                        return "HS00" + SLHS.ToString();            
                    else
                        if (SLHS < 10000)
                            return "HS0" + SLHS.ToString();
                        else
                            return "HS" + SLHS.ToString();            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinh"></param>
        /// <returns>Lớp học sinh đã tốt nghiệp dựa vào mã học sinh</returns>
        public static byte DaQuaLop(string maHocSinh)
        {
            var temp = from a in DB.GetTable<DSHocSinh>()
                       where a.MaHocSinh == maHocSinh
                       select a.DaQuaLop;
            return (byte)temp.First();
        }

        private static DataTable TaoBangDSHocSinh()
        {
            DataTable temp = new DataTable();
            DataColumn clSTT = new DataColumn();
            clSTT.ColumnName = "STT";
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";
            DataColumn clHoVaTen = new DataColumn();
            clHoVaTen.ColumnName = "HoVaTen";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            DataColumn clGioiTinh = new DataColumn();
            clGioiTinh.ColumnName = "GioiTinh";
            DataColumn clEmail = new DataColumn();
            clEmail.ColumnName = "EmailPhuHuynh";
            DataColumn clSDT = new DataColumn();
            clSDT.ColumnName = "SoDienThoaiPhuHuynh";

            temp.Columns.Add(clSTT);
            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);
            temp.Columns.Add(clGioiTinh);
            temp.Columns.Add(clEmail);
            temp.Columns.Add(clSDT);

            //DataColumn clHocKy = new DataColumn();
            //clHocKy.ColumnName = "HK";
            //DataColumn clTrungBinh = new DataColumn();
            //clTrungBinh.ColumnName = "TB";
            //temp.Columns.Add(clHocKy);
            //temp.Columns.Add(clTrungBinh);
            return temp;
        }

        private static DataTable TaoBangDSHocSinhCoDanhHieu()
        {
            DataTable temp = new DataTable();
            DataColumn clSTT = new DataColumn();
            clSTT.ColumnName = "STT";
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";
            DataColumn clHoVaTen = new DataColumn();
            clHoVaTen.ColumnName = "HoVaTen";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            DataColumn clGioiTinh = new DataColumn();
            clGioiTinh.ColumnName = "GioiTinh";
            DataColumn clDiemTB = new DataColumn();
            clDiemTB.ColumnName = "DiemTB";
            DataColumn clHanhKiem = new DataColumn();
            clHanhKiem.ColumnName = "HanhKiem";
            DataColumn clDanhHieu = new DataColumn();
            clDanhHieu.ColumnName = "DanhHieu";
            DataColumn clLop = new DataColumn();
            clLop.ColumnName = "Lop";

            temp.Columns.Add(clSTT);
            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);
            temp.Columns.Add(clGioiTinh);
            temp.Columns.Add(clDiemTB);
            temp.Columns.Add(clHanhKiem);
            temp.Columns.Add(clDanhHieu);
            temp.Columns.Add(clLop);

            //DataColumn clHocKy = new DataColumn();
            //clHocKy.ColumnName = "HK";
            //DataColumn clTrungBinh = new DataColumn();
            //clTrungBinh.ColumnName = "TB";
            //temp.Columns.Add(clHocKy);
            //temp.Columns.Add(clTrungBinh);
            return temp;
        }

        public static DataTable LayDSHocSinhTheoLop(string maLop)
        {
            string[] DSMaHocSinhTheoLop = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.MaHocSinh).ToArray();
            DataTable BangDSHocSinh = TaoBangDSHocSinh();
            List<DSHocSinh> HocSinhs = DB.DSHocSinhs.Where(q => DSMaHocSinhTheoLop.Contains(q.MaHocSinh)).OrderBy(q => q.Ten).ToList();
            byte stt = 1;
            foreach(DSHocSinh HocSinh in HocSinhs)
            {
                DataRow row = BangDSHocSinh.NewRow();
                row[0] = stt++;
                row["MaHocSinh"] = HocSinh.MaHocSinh;
                row["HoVaTen"] = HocSinh.HoDem + " " + HocSinh.Ten;
                row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                if (HocSinh.GioiTinh == true)
                    row["GioiTinh"] = "Nam";
                else
                    row["GioiTinh"] = "Nữ";
                row["EmailPhuHuynh"] = HocSinh.EmailPhuHuynh;
                row["SoDienThoaiPhuHuynh"] = HocSinh.SoDienThoaiPhuHuynh;              
                BangDSHocSinh.Rows.Add(row);
            }
            return BangDSHocSinh;
        }

        public static DataTable LayDSHocSinhDatDanhHieu(string maHocKy)
        {
            //string[] DSMaHocSinhTheoLop = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.MaHocSinh).ToArray();
            List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.DMDanhHieu.InGiayKhen == true && q.MaHocKy == maHocKy).ToList();
            DataTable BangDSHocSinh = TaoBangDSHocSinhCoDanhHieu();
            byte stt = 1;
            foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
            {
                DataRow row = BangDSHocSinh.NewRow();
                row[0] = stt++;
                row["MaHocSinh"] = TongKetTheoKy.MaHocSinh;
                row["HoVaTen"] = TongKetTheoKy.DSHocSinh.HoDem + " " + TongKetTheoKy.DSHocSinh.Ten;
                row["NgaySinh"] = ((DateTime)TongKetTheoKy.DSHocSinh.NgaySinh).Date.ToLongDateString();
                if (TongKetTheoKy.DSHocSinh.GioiTinh == true)
                    row["GioiTinh"] = "Nam";
                else
                    row["GioiTinh"] = "Nữ";
                row["DiemTB"] = TongKetTheoKy.TrungBinhChung;
                row["HanhKiem"] = TongKetTheoKy.DMHanhKiem.TenHanhKiem;
                row["DanhHieu"] = TongKetTheoKy.DMDanhHieu.TenDanhHieu;
                row["Lop"] = DSHocSinhTheoLopBLL.TenLopTheoMaHocSinh(TongKetTheoKy.MaHocSinh);
                BangDSHocSinh.Rows.Add(row);
            }
            return BangDSHocSinh;
        }

        public static List<DSHocSinh> LayDSHocSinhTheoLop(string maLop, bool t)
        {
            string[] DSMaHocSinhTheoLop = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.MaHocSinh).ToArray();
            return DB.DSHocSinhs.Where(q => DSMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
        }

        public static List<DSHocSinh> LayDSHocSinhDangKyDichVuTheoLop(string maLop, bool t)
        {
            string[] DSMaHocSinhTheoLop = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.MaHocSinh).ToArray();
            return DB.DSHocSinhs.Where(q => DSMaHocSinhTheoLop.Contains(q.MaHocSinh) && q.DangKyDichVu == true).ToList();
        }

        public static string LayTenLopTheoMaHocSinh(string maHocSinh)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == maHocSinh).Select(q => q.DSLop.TenLop).FirstOrDefault();
        }

        public static void ResetTatCaMatKhauHocSinh()
        {
            List<DSHocSinh> HocSinhs = DB.DSHocSinhs.ToList();
            foreach (DSHocSinh HocSinh in HocSinhs)
            {
                string str = "";
                if (((DateTime)HocSinh.NgaySinh).Day.ToString().Length == 1)
                    str += "0" + ((DateTime)HocSinh.NgaySinh).Day.ToString();
                else
                    str += ((DateTime)HocSinh.NgaySinh).Day.ToString();
                if (((DateTime)HocSinh.NgaySinh).Month.ToString().Length == 1)
                    str += "0" + ((DateTime)HocSinh.NgaySinh).Month.ToString();
                else
                    str += ((DateTime)HocSinh.NgaySinh).Month.ToString();
                str +=  ((DateTime)HocSinh.NgaySinh).Year.ToString();
                HocSinh.MatKhau = UTL.Ultils.Encrypt(str, "CVA");
            }
            DB.SubmitChanges();
        }

        public static void CapNhatHocSinhDangKyDichVu(GridControl gcDangKyDichVu)
        {
            GridView gvDangKyDichVu = (GridView)gcDangKyDichVu.ViewCollection[0];
            for (byte i = 0; i < gvDangKyDichVu.RowCount; i++)
            {
                string maHocSinh = gvDangKyDichVu.GetRowCellValue(i, gvDangKyDichVu.Columns[1]).ToString();
                string dangKyDichVu = gvDangKyDichVu.GetRowCellValue(i, gvDangKyDichVu.Columns[5]).ToString();
                DSHocSinh HocSinh = DB.DSHocSinhs.Where(q => q.MaHocSinh == maHocSinh).FirstOrDefault();
                bool DKDV;
                if (bool.TryParse(dangKyDichVu, out DKDV))
                    HocSinh.DangKyDichVu = DKDV;
            }
            DB.SubmitChanges();
        }

        public static int LaySoLuongHocSinhDangKyDichVu()
        {
            return DB.DSHocSinhs.Where(q => q.DangKyDichVu == true).Count();
        }

        public static List<DSHocSinh> LayHocSinhDangHoc()
        {
            string[] maHocSinhTrongCacLop = DSHocSinhTheoLopBLL.LayMaTatCaHSTrongCacLop();
            return DB.DSHocSinhs.Where(q => maHocSinhTrongCacLop.Contains(q.MaHocSinh)).ToList();
        }

    }
}
