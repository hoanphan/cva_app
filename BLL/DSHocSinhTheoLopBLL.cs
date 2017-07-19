using DAL;
using UTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace BLL
{
    public class DSHocSinhTheoLopBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static string[] LayMaTatCaHSTrongCacLop()
        {
            return DB.DSHocSinhTheoLops.Select(q => q.MaHocSinh).ToArray();
        }

        public static List<DSHocSinh> LoadHSCanPhanLop(string maKhoi)
        {
            byte Khoi = (byte)(UTL.Ultils.CatKhoi(maKhoi) - 1);
            return DB.DSHocSinhs.Where(q => q.DaQuaLop == Khoi && !(from ds in DB.GetTable<DSHocSinhTheoLop>()
                                                                   select ds.MaHocSinh).ToArray().Contains(q.MaHocSinh)).ToList();
        }

        public static List<DSHocSinh> LoadHSDuocPhanLop(string maLop)
        {
            string[] dsHocSinhDuocPhanLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                                                 where ds.MaLop == maLop
                                                 select ds.MaHocSinh).ToArray();           
            return DB.DSHocSinhs.Where(q => dsHocSinhDuocPhanLop.Contains(q.MaHocSinh)).ToList();
        }

        public static DataTable LoadHocSinhTheoLop(string maLop)
        {
            var DSHocSinh = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => new { q.MaLop, q.MaHocSinh, q.DSHocSinh.HoDem, q.DSHocSinh.Ten, q.DSHocSinh.NgaySinh, q.STT }).ToList();
            DataTable tableHocSinh = new DataTable();
            DataColumn clSTT = new DataColumn();
            clSTT.ColumnName = "STT";
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";
            DataColumn clHoDem = new DataColumn();
            clHoDem.ColumnName = "HoDem";
            DataColumn clTen = new DataColumn();
            clTen.ColumnName = "Ten";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            DataColumn clThuTu = new DataColumn();
            clThuTu.ColumnName = "ThuTu";

            tableHocSinh.Columns.Add(clSTT);
            tableHocSinh.Columns.Add(clMaHocSinh);
            tableHocSinh.Columns.Add(clHoDem);
            tableHocSinh.Columns.Add(clTen);
            tableHocSinh.Columns.Add(clNgaySinh);
            tableHocSinh.Columns.Add(clThuTu);

            byte i = 1;
            foreach(var HocSinh in DSHocSinh)
            {
                DataRow row = tableHocSinh.NewRow();
                row["STT"] = i++;
                row["MaHocSinh"] = HocSinh.MaHocSinh;
                row["HoDem"] = HocSinh.HoDem;
                row["Ten"] = HocSinh.Ten;
                row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                row["ThuTu"] = HocSinh.STT;
                tableHocSinh.Rows.Add(row);
            }
            return tableHocSinh;
        }

        public static DataTable LoadHocSinhTheoLopDangKyDichVu(string maLop)
        {
            var DSHocSinh = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => new { q.MaLop, q.MaHocSinh, q.DSHocSinh.HoDem, q.DSHocSinh.Ten, q.DSHocSinh.NgaySinh, q.STT, q.DSHocSinh.DangKyDichVu }).OrderBy(q => q.STT).ToList();
            DataTable tableHocSinh = new DataTable();
            DataColumn clSTT = new DataColumn();
            clSTT.ColumnName = "STT";
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";
            DataColumn clHoDem = new DataColumn();
            clHoDem.ColumnName = "HoDem";
            DataColumn clTen = new DataColumn();
            clTen.ColumnName = "Ten";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            DataColumn clDangKyDichVu = new DataColumn();
            clDangKyDichVu.ColumnName = "DangKyDichVu";

            tableHocSinh.Columns.Add(clSTT);
            tableHocSinh.Columns.Add(clMaHocSinh);
            tableHocSinh.Columns.Add(clHoDem);
            tableHocSinh.Columns.Add(clTen);
            tableHocSinh.Columns.Add(clNgaySinh);
            tableHocSinh.Columns.Add(clDangKyDichVu);

            byte i = 1;
            foreach (var HocSinh in DSHocSinh)
            {
                DataRow row = tableHocSinh.NewRow();
                row["STT"] = i++;
                row["MaHocSinh"] = HocSinh.MaHocSinh;
                row["HoDem"] = HocSinh.HoDem;
                row["Ten"] = HocSinh.Ten;
                row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                row["DangKyDichVu"] = HocSinh.DangKyDichVu;
                //UTL.Ultils.ThongBao(HocSinh.DangKyDichVu.ToString(), System.Windows.Forms.MessageBoxIcon.Information);
                tableHocSinh.Rows.Add(row);
            }
            return tableHocSinh;
        }

        public static void ThemHocSinhTheoLop(string maHocSinh, string maLop)
        {
            string MaNamHienTai = DSNamHocBLL.LayMaNamHocHienTai();
            DSHocSinhTheoLop HocSinhTheoLop = new DSHocSinhTheoLop
            {
                MaNamHoc = MaNamHienTai,
                MaHocSinh = maHocSinh,
                MaLop = maLop
            };
            DB.DSHocSinhTheoLops.InsertOnSubmit(HocSinhTheoLop);
            DB.SubmitChanges();
        }

        public static DSHocSinhTheoLop TruyVanTheoMa(string maHocSinh)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == maHocSinh).FirstOrDefault();
        }

        public static void XoaHocSinhTheoMa(string maHocSinh)
        {
            DSHocSinhTheoLop HocSinhTheoLop = TruyVanTheoMa(maHocSinh);
            DB.DSHocSinhTheoLops.DeleteOnSubmit(HocSinhTheoLop);
            DB.SubmitChanges();
        }

        public static string[] MaHocSinhTheoLop(string maLop)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.MaHocSinh).ToArray();
        }        

        public static string[] MaHocSinhTheoLopChuaChuyenTruongThoiHoc(string maHocKy, string maLop)
        {
            string[] dsMaHSChuyenTruong;
            if (maHocKy == "HK1")
                dsMaHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            else
                dsMaHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            string[] dsMaHSThoiHoc;
            if (maHocKy == "HK1")
                dsMaHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            else
                dsMaHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");
            return DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && !dsMaHSChuyenTruong.Contains(q.MaHocSinh) && !dsMaHSThoiHoc.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();
        }

        public static string[] MaHocSinhTheoLopKy(string maLop, string maHocKy)
        {
            string[] maDSHSChuyenDenKy2 = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongLechKy();
            string[] maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            string[] maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, maHocKy);
            if (maHocKy == "K2" || maHocKy == "K3")
            {
                Array.Clear(maDSHSChuyenDenKy2, 0, maDSHSChuyenDenKy2.Length);
                maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, "");
                maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            }                                        
            return DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && !maDSHSChuyenDi.Contains(q.MaHocSinh) &&
                                                    !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                    !maDSHSThoiHocKy2.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();
        }

        public static string TenLopTheoMaHocSinh(string maHocSinh)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == maHocSinh).Select(q => q.DSLop.TenLop).FirstOrDefault();
        }

        public static void CapNhatThuTuHocSinhTrongLop(string maLop, GridControl gcHocSinh)
        {
            GridView gvHocSinh = (GridView)gcHocSinh.ViewCollection[0];
            for (byte i = 0; i < gvHocSinh.RowCount; i++)
            {
                string maHocSinh = gvHocSinh.GetRowCellValue(i, gvHocSinh.Columns[1]).ToString();
                string thuTu = gvHocSinh.GetRowCellValue(i, gvHocSinh.Columns[5]).ToString();
                DSHocSinhTheoLop HocSinhTheoLop = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && q.MaHocSinh == maHocSinh).FirstOrDefault();
                byte STT;
                if (byte.TryParse(thuTu, out STT))
                    HocSinhTheoLop.STT = STT;
            }
            DB.SubmitChanges();
        }

        public static string LayTenLopTheoMaHocSinh(string maHocSinh)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == maHocSinh).Select(q => q.DSLop.TenLop).FirstOrDefault();
        }

        public static short LayKhoiTheoMaHocSinh(string maHocSinh)
        {
            string temp = DB.DSHocSinhTheoLops.Where(q => q.MaHocSinh == maHocSinh).Select(q => q.DSLop.DSKhoi.TenKhoi).FirstOrDefault();
            return short.Parse(temp);
        }

        /// <summary>
        /// Trả về danh sách học sinh dựa trên mã lớp
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public static List<DSHocSinh> LayDSHocSinhTheoLop(string maLop)
        {
            return DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.DSHocSinh).ToList();
        }
    }
}
