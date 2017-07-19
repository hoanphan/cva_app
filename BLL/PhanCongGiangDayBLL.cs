using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DevExpress.XtraGrid.Views.Grid;

namespace BLL
{
    public class PhanCongGiangDayBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void KhoiTaoDuLieu(string maHocKy, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            string NamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            List<DSHocKy> HocKies = DB.DSHocKies.Where(q => q.MaHocKy == maHocKy).ToList();
            List<DSMonHoc> MonHocs = DB.DSMonHocs.ToList();
            List<DSLop> Lops = DB.DSLops.ToList();

            int SoMonTheoLop = 0;
            foreach(DSLop Lop in Lops)
            {
                SoMonTheoLop += DSMonHocTheoLopBLL.LayMonHocTheoLopKy(Lop.MaLop, maHocKy).Count;
            }
            pgbTienTrinh.Properties.Minimum = 0;
            pgbTienTrinh.Properties.Maximum = SoMonTheoLop;
            pgbTienTrinh.Properties.Step = 1;
            pgbTienTrinh.Properties.PercentView = true;

            foreach (DSHocKy HocKy in HocKies)
                if (HocKy.TongHop == false)
                {
                    foreach (DSLop Lop in Lops)
                    {
                        string[] maMonHocTheoLop = DSMonHocTheoLopBLL.LayMaMonHocTheoLopHocKy(Lop.MaLop, HocKy.MaHocKy);
                        foreach (DSMonHoc MonHoc in MonHocs)
                        {
                            if (maMonHocTheoLop.Contains(MonHoc.MaMonHoc))
                            {
                                PhanCongGiangDay phanCong = new PhanCongGiangDay();
                                phanCong.MaNamHoc = NamHoc;
                                phanCong.MaHocKy = HocKy.MaHocKy;
                                phanCong.MaMonHoc = MonHoc.MaMonHoc;
                                phanCong.MaLop = Lop.MaLop;
                                phanCong.MaGiaoVien = null;
                                if (TimKhoaTrung(phanCong.MaNamHoc, phanCong.MaHocKy, phanCong.MaMonHoc, phanCong.MaLop))
                                    DB.PhanCongGiangDays.InsertOnSubmit(phanCong);
                                pgbTienTrinh.PerformStep();
                                pgbTienTrinh.Update();                               
                            }
                        }
                    }
                }
            DB.SubmitChanges();
        }

        private static bool TimKhoaTrung(string maNamHoc, string maHocKy, string maMonHoc, string maLop)
        {
            if (DB.PhanCongGiangDays.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLop == maLop).Count() > 0)
                return false;
            else
                return true;
        }

        private static DataTable TaoBangPhanCongGiangDay()
        {
            DataTable temp = new DataTable();
            DataColumn clTenLop = new DataColumn();
            clTenLop.ColumnName = "TenLop";
            DataColumn clMaLop = new DataColumn();
            clMaLop.ColumnName = "MaLop";
            DataColumn clTenKhoi = new DataColumn();
            clTenKhoi.ColumnName = "TenKhoi";
            temp.Columns.Add(clTenLop);
            temp.Columns.Add(clMaLop);
            temp.Columns.Add(clTenKhoi);

            string[] maTatCaMonHoc = DSMonHocBLL.LayMaTatCaMonHoc();
            string[] tenTatCaMonHoc = DSMonHocBLL.LayTenTatCaMonHoc();
            for (byte i = 0; i < maTatCaMonHoc.Count(); i++)
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = maTatCaMonHoc[i];
                temp.Columns.Add(cl);
            }

            return temp;
        }

        public static DataTable TruyVanPhanCongGiangDay(string maHocKy, string maKhoi)
        {
            DataTable BangPCGD = TaoBangPhanCongGiangDay();
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string[] tenTatCaCacLop = DSLopBLL.TenTatCaCacLopTheoKhoi(maKhoi);
            string[] maTatCaCacLop = DSLopBLL.MaTatCaCacLopTheoKhoi(maKhoi);

            for (byte i = 0; i < tenTatCaCacLop.Count(); i++)
            {
                DataRow row = BangPCGD.NewRow();
                row["TenLop"] = tenTatCaCacLop.GetValue(i);
                row["MaLop"] = maTatCaCacLop.GetValue(i);
                row["TenKhoi"] = DSKhoiBLL.TruyVanTenKhoiTheoMaLop(maTatCaCacLop.GetValue(i).ToString());
                List<PhanCongGiangDay> PhanCongs = PhanCongGiangDayBLL.TruyVanTheoMaLopKyNamHoc(maNamHoc, maHocKy, maTatCaCacLop.GetValue(i).ToString());
                foreach(PhanCongGiangDay PhanCong in PhanCongs)
                {
                    if (PhanCong.MaGiaoVien == null)
                        row[PhanCong.MaMonHoc] = "-";
                    else
                        row[PhanCong.MaMonHoc] = PhanCong.MaGiaoVien;
                }
                for (byte j = 0; j < BangPCGD.Columns.Count; j++)
                    if (row[j] == null)
                        row[j] = "-";
                BangPCGD.Rows.Add(row);
            }

            return BangPCGD;
        }

        public static List<PhanCongGiangDay> TruyVanTheoMaLopKyNamHoc(string maNamHoc, string maHocKy, string maLop)
        {
            return DB.PhanCongGiangDays.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaLop == maLop).ToList();
        }

        public static PhanCongGiangDay TruyVanTheoMaLopKyNamHocMaMonHoc(string maNamHoc, string maHocKy, string maLop, string maMonHoc)
        {
            return DB.PhanCongGiangDays.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaLop == maLop && q.MaMonHoc == maMonHoc).FirstOrDefault();
        }

        public static void CapNhatPhanCongGiangDay(string maHocKy, DevExpress.XtraGrid.GridControl gcPCGD)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            GridView gvPCGD = (GridView)gcPCGD.ViewCollection[0];
            //UTL.Ultils.ThongBao(gvPCGD.RowCount.ToString());
            for (byte i = 0; i < gvPCGD.RowCount; i++)
            {                
                string maLop = gvPCGD.GetRowCellValue(i, gvPCGD.Columns[2]).ToString();                   
                for (byte j = 5; j < gvPCGD.Columns.Count; j++)
                {
                    string maMonHoc = gvPCGD.Columns[j].Name;
                    string maGiaoVien = gvPCGD.GetRowCellValue(i, gvPCGD.Columns[j]).ToString();                    
                    if (maGiaoVien != "-")
                    {
                        PhanCongGiangDay PCGD = TruyVanTheoMaLopKyNamHocMaMonHoc(maNamHoc, maHocKy, maLop, maMonHoc);
                        if (PCGD != null)
                        {                                
                            PCGD.MaGiaoVien = maGiaoVien;                            
                        }
                    }
                }                
            }
            DB.SubmitChanges();
        }

        public static string TenGiaoVienTheoMon(string maHocKy, string maLop, string maMonHoc)
        {
            string maNamHoc = DB.DSNamHocs.Where(q => q.NamHienTai == true).Select(q => q.MaNamHoc).FirstOrDefault();
            string ten = DB.PhanCongGiangDays.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLop == maLop).Select(q => q.DSGiaoVien.HoDem).FirstOrDefault();
            ten += " " + DB.PhanCongGiangDays.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLop == maLop).Select(q => q.DSGiaoVien.Ten).FirstOrDefault();
            return ten;
        }
    }
}
