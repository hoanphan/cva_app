using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BLL
{
    public class DSTongKetTheoKyBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static List<DSTongKetTheoKy> LoadAll(string maHocKy)
        {
            return DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy).ToList();
        }

        public static List<DSTongKetTheoKy> TongKetTheoKyTheoLop(string maHocKy, string tenDangNhap)
        {
            string[] dsMaHSChuyenTruong;
            if (maHocKy == "K1")
                dsMaHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            else
                dsMaHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, "");
            string[] dsMaHSThoiHoc;
            if (maHocKy == "K1")
                dsMaHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            else
                dsMaHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, "");
            string maLop = DSLopBLL.LaGVCN(tenDangNhap);
            if (maLop != null)
            {
                string[] dsMaHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLopKy(maLop, maHocKy);
                return DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && dsMaHocSinhTheoLop.Contains(q.MaHocSinh) && !dsMaHSChuyenTruong.Contains(q.MaHocSinh) && !dsMaHSThoiHoc.Contains(q.MaHocSinh)).ToList();
            }
            else
                return DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && !dsMaHSChuyenTruong.Contains(q.MaHocSinh) && !dsMaHSThoiHoc.Contains(q.MaHocSinh)).ToList();
        }

        public static void ThemMoi(string maNamHoc, string maHocKy, string maHocSinh)
        {            
            DB.SubmitChanges();
        }

        public static void TaoDuLieu(string maHocKy, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            List<DSHocKy> HocKies = DB.DSHocKies.Where(q=>q.MaHocKy == maHocKy).ToList();
            List<DSHocSinh> HocSinhs = DSHocSinhBLL.LayHocSinhDangHoc();
            pgbTienTrinh.Properties.Minimum = 0;
            if (maHocKy == "K2")
                pgbTienTrinh.Properties.Maximum = HocSinhs.Count * 2;
            else
                pgbTienTrinh.Properties.Maximum = HocSinhs.Count;
            pgbTienTrinh.Properties.PercentView = true;
            pgbTienTrinh.Properties.Step = 1;
            foreach (DSHocKy HocKy in HocKies)
            {
                foreach (DSHocSinh HocSinh in HocSinhs)
                {
                    DSTongKetTheoKy ds = new DSTongKetTheoKy();
                    ds.MaNamHoc = maNamHoc;
                    ds.MaHocKy = HocKy.MaHocKy;
                    ds.MaHocSinh = HocSinh.MaHocSinh;
                    if (TimKhoaTrung(ds.MaHocKy, ds.MaHocSinh))
                        DB.DSTongKetTheoKies.InsertOnSubmit(ds);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();
                }
            }
            if (maHocKy == "K2")
            {
                foreach (DSHocSinh HocSinh in HocSinhs)
                {
                    DSTongKetTheoKy ds = new DSTongKetTheoKy();
                    ds.MaNamHoc = maNamHoc;
                    ds.MaHocKy = "K3";
                    ds.MaHocSinh = HocSinh.MaHocSinh;
                    if (TimKhoaTrung(ds.MaHocKy, ds.MaHocSinh))
                        DB.DSTongKetTheoKies.InsertOnSubmit(ds);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();
                }
            }
            DB.SubmitChanges();
        }

        public static bool TimKhoaTrung(string maHocKy, string maHocSinh)
        {
            if (DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && q.MaHocSinh == maHocSinh).Count() > 0)
                return false;
            else
                return true;
        }

        public static void TinhDiemTBC(string maHocKy, string tenDangNhap)
        {      
            //if (DSHocKyBLL.LaTongHop(maHocKy) == true)
            //{
            //    string[] dsMaHSChuyenTruongVNEN = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruongVNEN();

            //    string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            //    string maDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
            //    List<DSHocKy> HocKies = DSHocKyBLL.LayHocKyHocTap();
            //    string[] maHocKyHocTap = HocKies.Select(q => q.MaHocKy).ToArray();
            //    List<DSLop> Lops;
            //    if (DSLopBLL.LaGVCN(tenDangNhap) != null)
            //        Lops = DSLopBLL.LayLopTheoGVCN(tenDangNhap);
            //    else
            //        Lops = DSLopBLL.LoadAll();
            //    foreach (DSLop Lop in Lops)
            //    {
            //        string[] MaHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(Lop.MaLop);
            //        string[] MaMonHocTheoLop = DSMonHocTheoLopBLL.LayMaMonHocTheoLop(Lop.MaLop);
            //        foreach (string maHocSinh in MaHocSinhTheoLop)
            //        {
            //            foreach (string maMonHoc in MaMonHocTheoLop)
            //            {
            //                List<DSDiem> Diems;
            //                if (dsMaHSChuyenTruongVNEN.Contains(maHocSinh))
            //                {
            //                    Diems = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && maHocKy == "K2").ToList();
            //                }
            //                else
            //                {
            //                    Diems = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && maHocKyHocTap.Contains(q.MaHocKy)).ToList();
            //                }
            //                double? tongDiem = 0, tongHeSo = 0, trungBinh;
            //                foreach (DSDiem Diem in Diems)
            //                {
            //                    double? heSo = HocKies.Where(q => q.MaHocKy == Diem.MaHocKy).Select(q => q.HeSo).FirstOrDefault();
            //                    tongDiem += Diem.Diem * heSo;
            //                    tongHeSo += heSo;
            //                }
            //                DSDiem DiemTongHop = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && q.MaHocKy == maHocKy).FirstOrDefault();
            //                trungBinh = tongDiem / tongHeSo;
            //                trungBinh = Math.Round((double)trungBinh, 1, MidpointRounding.AwayFromZero);
            //                if (DSMonHocBLL.LaChoDiem(maMonHoc) == false)
            //                    trungBinh = Math.Round((double)trungBinh, 0);
            //                DiemTongHop.Diem = trungBinh;
            //            }
            //        }
            //    }
            //}

            //DB.SubmitChanges();

            List<DSMonHoc> MonHocs = DSMonHocBLL.LoadAll();
            List<DSHocSinh> HocSinhs;
            string maLop = DSLopBLL.LaGVCN(tenDangNhap);
            if (maLop != null)
                HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).Select(q => q.DSHocSinh).ToList();
            else
                HocSinhs = DSHocSinhBLL.LoadAll();                        
            foreach (DSHocSinh HocSinh in HocSinhs)
            {
                double? TongDiemTB = 0;
                int? TongHeSo = 0;
                List<DSDiem> DSDiemTB = DSDiemBLL.TruyVanDiemTongHop(maHocKy, HocSinh.MaHocSinh);
                foreach (DSDiem DiemTB in DSDiemTB)
                {
                    TongDiemTB += DiemTB.Diem * DiemTB.DSMonHoc.HeSo;
                    TongHeSo += (byte?)DiemTB.DSMonHoc.HeSo;
                }
                //double tb = (double)TongDiemTB/(int)TongHeSo+0.00000001;
                //double trungBinh = Math.Round(tb, 1, MidpointRounding.AwayFromZero);
                //UTL.Ultils.ThongBao(trungBinh.ToString(), System.Windows.Forms.MessageBoxIcon.Exclamation);
                DSTongKetTheoKyBLL.CapNhatDiemTBCTheoKy(maHocKy, HocSinh.MaHocSinh, Math.Round((double)(TongDiemTB / TongHeSo)+0.0000000000001, 1, MidpointRounding.AwayFromZero));
            }
            DB.SubmitChanges();
        }

        public static void TinhDiemTBCTheoDSLop(string maHocKy, string[] tenLops)
        {
            string[] maLops = DB.DSLops.Where(q => tenLops.Contains(q.TenLop)).Select(q => q.MaLop).ToArray();
            foreach(string maLop in maLops)
            {
                string maGVCN = DB.DSLops.Where(q => q.MaLop == maLop).Select(q => q.MaGVCN).FirstOrDefault();
                TinhDiemTBC(maHocKy, maGVCN);
            }
        }

        public static void TinhDiemTBTheoMon(string maHocKy, string maLop, string maMonHoc)
        {
            if (DSHocKyBLL.LaTongHop(maHocKy) == true)
            {
                string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
                string maDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                List<DSHocKy> HocKies = DSHocKyBLL.LayHocKyHocTap();
                string[] maHocKyHocTap = HocKies.Select(q => q.MaHocKy).ToArray();
                //List<DSLop> Lops = DSLopBLL.LoadAll();
                string[] MaHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(maLop);                
                foreach (string maHocSinh in MaHocSinhTheoLop)
                {                    
                    List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && maHocKyHocTap.Contains(q.MaHocKy)).ToList();
                    double? tongDiem = 0, tongHeSo = 0, trungBinh;
                    foreach (DSDiem Diem in Diems)
                    {
                        double? heSo = HocKies.Where(q => q.MaHocKy == Diem.MaHocKy).Select(q => q.HeSo).FirstOrDefault();
                        tongDiem += Diem.Diem * heSo;
                        tongHeSo += heSo;
                    }
                    DSDiem DiemTongHop = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && q.MaHocKy == maHocKy).FirstOrDefault();
                    trungBinh = tongDiem / tongHeSo;
                    trungBinh = Math.Round((double)trungBinh, 1, MidpointRounding.AwayFromZero);
                    DiemTongHop.Diem = trungBinh;
                }
            }
            DB.SubmitChanges();
        }

        public static void CapNhatDiemTBCTheoKy(string maHocKy, string maHocSinh, double trungBinhChung)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            DSTongKetTheoKy TKTK = DB.DSTongKetTheoKies.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaHocSinh == maHocSinh).FirstOrDefault();
            TKTK.TrungBinhChung = trungBinhChung;            

        }

        private static DataTable TaoBangDiem(string maLop, string maHocKy)
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

            temp.Columns.Add(clSTT);
            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);
            string[] MaMonHocTheoLopKy;
            if (DSHocKyBLL.LaTongHop(maHocKy) == true)
                MaMonHocTheoLopKy = DSMonHocTheoLopBLL.LayMaMonHocTheoLopKyTongHop(maLop);            
            else
                MaMonHocTheoLopKy = DSMonHocTheoLopBLL.LayMaMonHocTheoLopHocKy(maLop, maHocKy);            
            for (byte i = 0; i < MaMonHocTheoLopKy.Count(); i++)               
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = MaMonHocTheoLopKy.GetValue(i).ToString();
                temp.Columns.Add(cl);
            }

            DataColumn clTBC = new DataColumn();
            clNgaySinh.ColumnName = "TBC";
            temp.Columns.Add(clTBC);

            //DataColumn clHocKy = new DataColumn();
            //clHocKy.ColumnName = "HK";
            //DataColumn clTrungBinh = new DataColumn();
            //clTrungBinh.ColumnName = "TB";
            //temp.Columns.Add(clHocKy);
            //temp.Columns.Add(clTrungBinh);
            return temp;
        }

        private static DataTable TaoBangDiemTongKet(string maLop, string maHocKy, string maKhoi)
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
            DataColumn clLop = new DataColumn();
            clLop.ColumnName = "Lop";
            
            temp.Columns.Add(clSTT);
            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);
            if (maKhoi != null)
            {
                temp.Columns.Add(clLop);
            }
            

            string[] MaMonHocTheoLopKy;
            if (DSHocKyBLL.LaTongHop(maHocKy) == true)
                MaMonHocTheoLopKy = DSMonHocTheoLopBLL.LayMaMonHocTheoLopKyTongHop(maLop);
            else
                MaMonHocTheoLopKy = DSMonHocTheoLopBLL.LayMaMonHocTheoLopHocKy(maLop, maHocKy);
            
            for (byte i = 0; i < MaMonHocTheoLopKy.Count(); i++)
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = MaMonHocTheoLopKy.GetValue(i).ToString();
                temp.Columns.Add(cl);
            }

            DataColumn clTBC = new DataColumn();
            clTBC.ColumnName = "TBC";
            temp.Columns.Add(clTBC);

            DataColumn clHocLuc = new DataColumn();
            clHocLuc.ColumnName = "HocLuc";
            temp.Columns.Add(clHocLuc);

            DataColumn clHanhKiem = new DataColumn();
            clHanhKiem.ColumnName = "HanhKiem";
            temp.Columns.Add(clHanhKiem);

            DataColumn clDanhHieu = new DataColumn();
            clDanhHieu.ColumnName = "DanhHieu";
            temp.Columns.Add(clDanhHieu);

            //DataColumn clHocKy = new DataColumn();
            //clHocKy.ColumnName = "HK";
            //DataColumn clTrungBinh = new DataColumn();
            //clTrungBinh.ColumnName = "TB";
            //temp.Columns.Add(clHocKy);
            //temp.Columns.Add(clTrungBinh);
            return temp;
        }

        private static DataTable TaoBangDiemTongKetCacKy(string maLop, string maKhoi)
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
            DataColumn clLop = new DataColumn();
            clLop.ColumnName = "Lop";

            temp.Columns.Add(clSTT);
            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);
            if (maKhoi != null)
            {
                temp.Columns.Add(clLop);
            }

            DataColumn clTBCK1 = new DataColumn();
            clTBCK1.ColumnName = "TBCK1";
            temp.Columns.Add(clTBCK1);

            DataColumn clTBCK2 = new DataColumn();
            clTBCK2.ColumnName = "TBCK2";
            temp.Columns.Add(clTBCK2);

            DataColumn clTBCaNam = new DataColumn();
            clTBCaNam.ColumnName = "TBCCaNam";
            temp.Columns.Add(clTBCaNam);

            DataColumn clHocLuc = new DataColumn();
            clHocLuc.ColumnName = "HocLuc";
            temp.Columns.Add(clHocLuc);

            DataColumn clHanhKiem = new DataColumn();
            clHanhKiem.ColumnName = "HanhKiem";
            temp.Columns.Add(clHanhKiem);

            DataColumn clDanhHieu = new DataColumn();
            clDanhHieu.ColumnName = "DanhHieu";
            temp.Columns.Add(clDanhHieu);

            //DataColumn clHocKy = new DataColumn();
            //clHocKy.ColumnName = "HK";
            //DataColumn clTrungBinh = new DataColumn();
            //clTrungBinh.ColumnName = "TB";
            //temp.Columns.Add(clHocKy);
            //temp.Columns.Add(clTrungBinh);
            return temp;
        }

        public static DataTable LayDuLieuTBTatCaCacMon(string maLop, string maHocKy)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                                           where ds.MaLop == maLop
                                           select ds.MaHocSinh).ToArray();
            List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
            List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && q.DSHocSinh.DSHocSinhTheoLop.MaLop == maLop).OrderBy(q => q.MaHocSinh).ToList();
            DataTable BangDiem = TaoBangDiem(maLop, maHocKy);

            byte stt = 1;
            foreach (DSHocSinh HocSinh in HocSinhTheoLops)
            {                
                DataRow row = BangDiem.NewRow();
                row[0] = stt++;
                row[1] = HocSinh.MaHocSinh;
                row[2] = HocSinh.HoDem + " " + HocSinh.Ten;
                row[3] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                string maLoaiDiemTB = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                List<DSDiem> dsDiemTBCacMon = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaHocSinh == HocSinh.MaHocSinh && q.MaLoaiDiem == maLoaiDiemTB).OrderBy(q => q.MaHocSinh).OrderBy(q => q.MaMonHoc).ToList();

                for (byte i = 0; i < dsDiemTBCacMon.Count; i++)
                {
                    if (dsDiemTBCacMon[i].Diem == -2)
                        row[i + 4] = "Đ";
                    else
                        if (dsDiemTBCacMon[i].Diem == -3)
                            row[i + 4] = "CĐ";
                        else
                            row[i + 4] = dsDiemTBCacMon[i].Diem;                    

                }
                row["TBC"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.TrungBinhChung).FirstOrDefault();
                BangDiem.Rows.Add(row);
            }                     
            return BangDiem;
        }


        /// <summary>
        /// Trả về dữ liệu tổng kết theo từng kỳ học của một lớp hoặc một khối
        /// </summary>
        /// <param name="maLop"></param>
        /// <param name="maHocKy"></param>
        /// <param name="maKhoi"></param>
        /// <returns></returns>
        public static DataTable LayDuLieuTongKetTheoKy(string maLop, string maHocKy, string maKhoi)
        {
            string[] maDSHSChuyenDenKy2 = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongLechKy();            
            string[] maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            string[] maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            if (maHocKy == "K2" || maHocKy == "K3")
            {
                Array.Clear(maDSHSChuyenDenKy2, 0, maDSHSChuyenDenKy2.Length);
                maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");
                maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            }                

            if ((maLop != "") && (maHocKy != ""))
            {
                string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
                //string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                //                               where ds.MaLop == maLop
                //                               select ds.MaHocSinh).ToArray();
                //List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
                List<DSHocSinh> HocSinhs;
                List<DSTongKetTheoKy> TongKetTheoKies;
                if (maKhoi == null)
                {
                    HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop &&
                                                        !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                        !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                        !maDSHSChuyenDi.Contains(q.MaHocSinh)).OrderBy(q => q.STT).Select(q => q.DSHocSinh).ToList();
                    TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && q.DSHocSinh.DSHocSinhTheoLop.MaLop == maLop).OrderBy(q => q.MaHocSinh).ToList();
                }                    
                else
                {                    
                    string[] DSMaLopTheoKhoi = DSLopBLL.LayMaLopTheoMaKhoi(maKhoi);
                    string[] DSMaHocSinhTheoKhoi = DB.DSHocSinhTheoLops.Where(q => DSMaLopTheoKhoi.Contains(q.MaLop) &&
                                                        !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                        !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                        !maDSHSChuyenDi.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();                    
                    HocSinhs = DB.DSTongKetTheoKies.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && DSMaHocSinhTheoKhoi.Contains(q.MaHocSinh)).OrderByDescending(q => q.TrungBinhChung).OrderBy(q => q.DMDanhHieu.MucUuTien).Select(q => q.DSHocSinh).ToList();
                    TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && DSMaHocSinhTheoKhoi.Contains(q.MaHocSinh)).OrderBy(q => q.MaHocSinh).ToList();
                }                                   
                DataTable BangDiem = TaoBangDiemTongKet(maLop, maHocKy, maKhoi);
               
                byte stt = 1;
                foreach (DSHocSinh HocSinh in HocSinhs)
                {
                    DataRow row = BangDiem.NewRow();
                    row[0] = stt;
                    row[1] = HocSinh.MaHocSinh;
                    row[2] = HocSinh.HoDem + " " + HocSinh.Ten;
                    row[3] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                    if (maKhoi != null)
                    {
                        row[4] = DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HocSinh.MaHocSinh);
                        string maLoaiDiemTB = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                        List<DSDiem> dsDiemTBCacMon = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaHocSinh == HocSinh.MaHocSinh && q.MaLoaiDiem == maLoaiDiemTB).OrderBy(q => q.MaMonHoc).ToList();

                        for (byte i = 0; i < dsDiemTBCacMon.Count; i++)
                        {
                            if (dsDiemTBCacMon[i].Diem == -2)
                                row[i + 5] = "Đ";
                            else
                                if (dsDiemTBCacMon[i].Diem == -3)
                                    row[i + 5] = "CĐ";
                                else
                                    row[i + 5] = dsDiemTBCacMon[i].Diem;

                        }
                    }
                    else
                    {
                        string maLoaiDiemTB = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                        List<DSDiem> dsDiemTBCacMon = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaHocSinh == HocSinh.MaHocSinh && q.MaLoaiDiem == maLoaiDiemTB).OrderBy(q => q.MaMonHoc).ToList();

                        for (byte i = 0; i < dsDiemTBCacMon.Count; i++)
                        {
                            if (dsDiemTBCacMon[i].Diem == -2)
                                row[i + 4] = "Đ";
                            else
                                if (dsDiemTBCacMon[i].Diem == -3)
                                    row[i + 4] = "CĐ";
                                else
                                    row[i + 4] = dsDiemTBCacMon[i].Diem;

                        }
                    }
                    
                    row["TBC"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.TrungBinhChung).FirstOrDefault();
                    if (TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.DMHocLuc).FirstOrDefault() == null)
                        row["HocLuc"] = "";
                    else
                        row["HocLuc"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.DMHocLuc.TenHocLuc).FirstOrDefault();
                    if (TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.DMHanhKiem).FirstOrDefault() == null)
                        row["HanhKiem"] = "";
                    else
                        row["HanhKiem"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.DMHanhKiem.TenHanhKiem).FirstOrDefault();
                    string danhHieu;
                    try
                    {
                        danhHieu = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.DMDanhHieu.TenDanhHieu).FirstOrDefault();
                    }
                    catch (NullReferenceException ex)
                    {
                        danhHieu = null;
                    }

                    if (danhHieu == null)
                        row["DanhHieu"] = "";
                    else
                        row["DanhHieu"] = danhHieu;
                    BangDiem.Rows.Add(row);
                    stt++;
                }               
                
                if (maKhoi != null)
                {
                    for (int i = 0; i < BangDiem.Rows.Count - 1; i++)
                        for (int j = i + 1; j < BangDiem.Rows.Count; j++)                                                   
                            if (float.Parse(BangDiem.Rows[i]["TBC"].ToString()) < float.Parse(BangDiem.Rows[j]["TBC"].ToString()))
                            {
                                DataRow row = BangDiem.NewRow();
                                for (byte col = 1; col < BangDiem.Columns.Count; col++)
                                {
                                    row[col] = BangDiem.Rows[i][col];
                                    BangDiem.Rows[i][col] = BangDiem.Rows[j][col];
                                    BangDiem.Rows[j][col] = row[col];
                                    //UTL.Ultils.ThongBao(row[col].ToString(), System.Windows.Forms.MessageBoxIcon.Error);
                                }
                            }                        
                }

                return BangDiem;
            }else
            {
                return null;
            }
            
        }

        public static DataTable LayDuLieuTongKetCacKy(string maLop, string maKhoi)
        {
            if ((maLop != ""))
            {
                string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
                //string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                //                               where ds.MaLop == maLop
                //                               select ds.MaHocSinh).ToArray();
                //List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
                List<DSHocSinh> HocSinhs;
                List<DSTongKetTheoKy> TongKetTheoKies;
                if (maKhoi == null)
                {
                    HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop).OrderBy(q => q.STT).Select(q => q.DSHocSinh).ToList();
                    TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.DSHocSinh.DSHocSinhTheoLop.MaLop == maLop).OrderBy(q => q.MaHocSinh).ToList();
                }
                else
                {
                    string[] DSMaLopTheoKhoi = DSLopBLL.LayMaLopTheoMaKhoi(maKhoi);
                    string[] DSMaHocSinhTheoKhoi = DB.DSHocSinhTheoLops.Where(q => DSMaLopTheoKhoi.Contains(q.MaLop)).Select(q => q.MaHocSinh).ToArray();
                    HocSinhs = DB.DSTongKetTheoKies.Where(q => q.MaNamHoc == maNamHoc && DSMaHocSinhTheoKhoi.Contains(q.MaHocSinh) && q.MaHocKy == "K3").OrderByDescending(q => q.TrungBinhChung).Select(q => q.DSHocSinh).ToList();
                    TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => DSMaHocSinhTheoKhoi.Contains(q.MaHocSinh)).OrderBy(q => q.MaHocSinh).ToList();
                }
                DataTable BangDiem = TaoBangDiemTongKetCacKy(maLop, maKhoi);

                byte stt = 1;
                foreach (DSHocSinh HocSinh in HocSinhs)
                {
                    DataRow row = BangDiem.NewRow();
                    row[0] = stt;
                    row[1] = HocSinh.MaHocSinh;
                    row[2] = HocSinh.HoDem + " " + HocSinh.Ten;
                    row[3] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                    if (maKhoi != null)
                    {
                        row[4] = DSHocSinhTheoLopBLL.LayTenLopTheoMaHocSinh(HocSinh.MaHocSinh);                        
                    }

                    string MaDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();

                    row["TBCK1"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K1").Select(q => q.TrungBinhChung).FirstOrDefault();
                    row["TBCK2"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K2").Select(q => q.TrungBinhChung).FirstOrDefault();

                    row["TBCCaNam"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K3").Select(q => q.TrungBinhChung).FirstOrDefault();
                    if (TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).Select(q => q.DMHocLuc).FirstOrDefault() == null)
                        row["HocLuc"] = "";
                    else
                        row["HocLuc"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K3").Select(q => q.DMHocLuc.TenHocLuc).FirstOrDefault();
                    if (TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K3").Select(q => q.DMHanhKiem).FirstOrDefault() == null)
                        row["HanhKiem"] = "";
                    else
                        row["HanhKiem"] = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K3").Select(q => q.DMHanhKiem.TenHanhKiem).FirstOrDefault();
                    string danhHieu;
                    try
                    {
                        danhHieu = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == "K3").Select(q => q.DMDanhHieu.TenDanhHieu).FirstOrDefault();
                    }
                    catch (NullReferenceException ex)
                    {
                        danhHieu = null;
                    }

                    if (danhHieu == null)
                        row["DanhHieu"] = "";
                    else
                        row["DanhHieu"] = danhHieu;
                    BangDiem.Rows.Add(row);
                    stt++;
                }  
              
                //Sắp xếp dữ liệu Bảng điểm theo TBC Cả năm, TBC Kỳ 2, TBC Kỳ 1                
                for (int i = 0; i < BangDiem.Rows.Count - 1; i++)
                    for (int j = i + 1; j < BangDiem.Rows.Count; j++)
                    {
                        if (float.Parse(BangDiem.Rows[i]["TBCCaNam"].ToString()) == float.Parse(BangDiem.Rows[j]["TBCCaNam"].ToString()))
                            if (float.Parse(BangDiem.Rows[i]["TBCK2"].ToString()) < float.Parse(BangDiem.Rows[j]["TBCK2"].ToString()))
                            {
                                DataRow row = BangDiem.NewRow();                                    
                                for (byte col = 1; col < BangDiem.Columns.Count; col++)
                                {
                                    row[col] = BangDiem.Rows[i][col];
                                    BangDiem.Rows[i][col] = BangDiem.Rows[j][col];
                                    BangDiem.Rows[j][col] = row[col];
                                    //UTL.Ultils.ThongBao(row[col].ToString(), System.Windows.Forms.MessageBoxIcon.Error);
                                }
                            }
                    }
                for (int i = 0; i < BangDiem.Rows.Count - 1; i++)
                    for (int j = i + 1; j < BangDiem.Rows.Count; j++)
                    {
                        if (float.Parse(BangDiem.Rows[i]["TBCCaNam"].ToString()) == float.Parse(BangDiem.Rows[j]["TBCCaNam"].ToString()))
                            if (float.Parse(BangDiem.Rows[i]["TBCK2"].ToString()) == float.Parse(BangDiem.Rows[j]["TBCK2"].ToString()))
                                if (float.Parse(BangDiem.Rows[i]["TBCK1"].ToString()) < float.Parse(BangDiem.Rows[j]["TBCK1"].ToString()))
                                {
                                    DataRow row = BangDiem.NewRow();                                    
                                    for (byte col = 1; col < BangDiem.Columns.Count; col++)
                                    {
                                        row[col] = BangDiem.Rows[i][col];
                                        BangDiem.Rows[i][col] = BangDiem.Rows[j][col];
                                        BangDiem.Rows[j][col] = row[col];
                                    }
                                }
                    }
                return BangDiem;
            }
            else
            {
                return null;
            }

        }

        public static void ThongKeSoLieuTheoKy(string maLop, string maHocKy, string maKhoi, ref string[] tenDanhHieu, ref int[] soLuongDanhHieu,
            ref double[] phanTramDanhHieu, ref string[] tenHocLuc, ref int[] soLuongHocLuc, ref double[] phanTramHocLuc, ref string[] tenHanhKiem, 
            ref int[] soLuongHanhKiem, ref double[] phanTramHanhKiem)
        {
            string[] maDSHSChuyenDenKy2 = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongLechKy();
            string[] maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            string[] maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            if (maHocKy == "K2" || maHocKy == "K3")
            {
                Array.Clear(maDSHSChuyenDenKy2, 0, maDSHSChuyenDenKy2.Length);
                maDSHSThoiHocKy2 = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");
                maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            }

            if ((maLop != "") && (maHocKy != ""))
            {
                string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
                //string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                //                               where ds.MaLop == maLop
                //                               select ds.MaHocSinh).ToArray();
                //List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
                List<DSHocSinh> HocSinhs;
                List<DSTongKetTheoKy> TongKetTheoKies;
                if (maKhoi == null)
                {
                    HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop &&
                                                !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDi.Contains(q.MaHocSinh)).OrderBy(q => q.STT).Select(q => q.DSHocSinh).ToList();
                    TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && q.DSHocSinh.DSHocSinhTheoLop.MaLop == maLop &&
                                                !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDi.Contains(q.MaHocSinh)).OrderBy(q => q.MaHocSinh).ToList();
                }
                else
                {
                    string[] DSMaLopTheoKhoi = DSLopBLL.LayMaLopTheoMaKhoi(maKhoi);
                    string[] DSMaHocSinhTheoKhoi = DB.DSHocSinhTheoLops.Where(q => DSMaLopTheoKhoi.Contains(q.MaLop) &&
                                                !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDi.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();
                    HocSinhs = DB.DSTongKetTheoKies.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && DSMaHocSinhTheoKhoi.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDi.Contains(q.MaHocSinh)).OrderByDescending(q => q.TrungBinhChung).Select(q => q.DSHocSinh).ToList();
                    TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && DSMaHocSinhTheoKhoi.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDenKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSThoiHocKy2.Contains(q.MaHocSinh) &&
                                                !maDSHSChuyenDi.Contains(q.MaHocSinh)).OrderBy(q => q.MaHocSinh).ToList();
                }
                List<DMDanhHieu> DanhHieus = DB.DMDanhHieus.Where(q => q.InGiayKhen == true).ToList();
                byte dem = 0;
                foreach(DMDanhHieu DanhHieu in DanhHieus)
                {
                    tenDanhHieu[dem] = DanhHieu.TenDanhHieu;
                    soLuongDanhHieu[dem] = TongKetTheoKies.Where(q => q.MaDanhHieu == DanhHieu.MaDanhHieu).Count();
                    phanTramDanhHieu[dem] = Math.Round((double)soLuongDanhHieu[dem] / TongKetTheoKies.Count()*100, 1);
                    dem++;
                }
                List<DMHanhKiem> HanhKiems = DB.DMHanhKiems.ToList();
                dem = 0;
                foreach (DMHanhKiem HanhKiem in HanhKiems)
                {
                    tenHanhKiem[dem] = HanhKiem.TenHanhKiem;
                    soLuongHanhKiem[dem] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem).Count();
                    phanTramHanhKiem[dem] = Math.Round((double)soLuongHanhKiem[dem] / TongKetTheoKies.Count() * 100, 1);
                    dem++;
                }
                List<DMHocLuc> HocLucs = DB.DMHocLucs.ToList();
                dem = 0;
                foreach (DMHocLuc HocLuc in HocLucs)
                {
                    tenHocLuc[dem] = HocLuc.TenHocLuc;
                    soLuongHocLuc[dem] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc).Count();
                    phanTramHocLuc[dem] = Math.Round((double)soLuongHocLuc[dem] / TongKetTheoKies.Count() * 100, 1);
                    dem++;
                }
            }
        }

        public static DataTable LayDuLieuHanhKiem(string maLop, string maHocKy)
        {
            DataTable temp = new DataTable();
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";
            DataColumn clHoVaTen = new DataColumn();
            clHoVaTen.ColumnName = "HoVaTen";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            DataColumn clHanhKiem = new DataColumn();
            clHanhKiem.ColumnName = "HanhKiem";

            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);
            temp.Columns.Add(clHanhKiem);

            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                                           where ds.MaLop == maLop
                                           select ds.MaHocSinh).ToArray();
            List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
            List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && q.DSHocSinh.DSHocSinhTheoLop.MaLop == maLop).OrderBy(q => q.MaHocSinh).ToList();

            foreach(DSHocSinh HocSinh in HocSinhTheoLops)
            {
                DataRow row = temp.NewRow();
                row[0] = HocSinh.MaHocSinh;
                row[1] = HocSinh.HoDem + " " + HocSinh.Ten;
                row[2] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                string maHanhKiem = TongKetTheoKies.Where(q => q.MaHocSinh == HocSinh.MaHocSinh && q.MaHocKy == maHocKy).Select(q => q.MaHanhKiem).FirstOrDefault();                
                if (maHanhKiem == null)
                    row[3] = "-";
                else
                    row[3] = DMHanhKiemBLL.LayTenHanhKiemTheoMa(maHanhKiem);
                temp.Rows.Add(row);
            }

            return temp;
        }

        public static void XetHocLuc(string maHocKy, string tenDangNhap)
        {            
            List<DSLop> Lops;
            if (DSLopBLL.LaGVCN(tenDangNhap) != null)
                Lops = DSLopBLL.LayLopTheoGVCN(tenDangNhap);
            else
                Lops = DSLopBLL.LoadAll();
            string maLoaiDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
            List<DSTongKetTheoKy> TongKetTheoKies = LayTongKetTheoKy(maHocKy);
            foreach(DSLop Lop in Lops)
            {
                List<DSMonHoc> MonHocTheoLops = DSMonHocTheoLopBLL.LayMonHocTheoLopKy(Lop.MaLop, maHocKy);
                string[] maHocSinhTheoLops = DSHocSinhTheoLopBLL.MaHocSinhTheoLopChuaChuyenTruongThoiHoc(maHocKy, Lop.MaLop);
                foreach (string maHocSinh in maHocSinhTheoLops)
                {
                    List<DSDiem> DiemTBs = DSDiemBLL.LayDiemTB(maHocSinh, maHocKy, maLoaiDiemTongHop);
                    float TBC = (float)Math.Round((decimal)TongKetTheoKies.Where(q => q.MaHocSinh == maHocSinh).Select(q => q.TrungBinhChung).FirstOrDefault(),1,MidpointRounding.AwayFromZero);
                    bool ToanVan80 = false, ToanVan65 = false, ToanVan50 = false;
                    byte duoi65 = 0, duoi50 = 0, duoi35 = 0, duoi20 = 0;
                    byte monKhongDat = 0;
                    foreach(DSDiem DiemTB in DiemTBs)
                    {                                      
                        if (DiemTB.Diem == -3)
                            monKhongDat++;
                        if ((DiemTB.Diem < 2) && (DiemTB.Diem > 0))
                        {
                            duoi20++;
                            duoi35++;
                            duoi50++;
                            duoi65++;
                        }                            
                        if ((DiemTB.Diem < 3.5) && (DiemTB.Diem > 0))
                        {
                            duoi35++;
                            duoi50++;
                            duoi65++;
                        }                            
                        if ((DiemTB.Diem < 5) && (DiemTB.Diem > 0))
                        {
                            duoi50++;
                            duoi65++;
                        }                            
                        if ((DiemTB.Diem < 6.5) && (DiemTB.Diem > 0))
                        {
                            duoi65++;
                        }                            
                        if ((DiemTB.DSMonHoc.XetHocLuc == true) && (DiemTB.Diem >= 5))
                        {
                            ToanVan50 = true;
                        }
                        if ((DiemTB.DSMonHoc.XetHocLuc == true) && (DiemTB.Diem >= 6.5))
                        {
                            ToanVan65 = true;
                        }
                        if ((DiemTB.DSMonHoc.XetHocLuc == true) && (DiemTB.Diem >= 8))
                        {
                            ToanVan80 = true;
                        }
                    }                    
                    byte DatHocLuc = 0;
                    if ((ToanVan80 == true) && (duoi65 == 0) && (monKhongDat == 0) && (TBC >= 8))
                        DatHocLuc = 1;
                    if ((ToanVan65 == true) && (duoi50 == 0) && (monKhongDat == 0) && (TBC >= 6.5) && (DatHocLuc == 0))
                        DatHocLuc = 2;
                    if ((ToanVan50 == true) && (duoi35 == 0) && (monKhongDat == 0) && (TBC >= 5) && (DatHocLuc == 0))
                        DatHocLuc = 3;
                    if ((duoi20 == 0) && (TBC >= 3.5) && (DatHocLuc == 0))
                        DatHocLuc = 4;
                    if (DatHocLuc == 0)
                        DatHocLuc = 5;
                    int i;
                    //if (maHocSinh == "HS00217")
                    //    i = 0;
                    //Xử lý trường hợp chỉ có 1 môn làm ảnh hưởng đến học lực tổng
                    //Xử lý trường hợp với các môn tính điểm
                    if (monKhongDat == 0)
                    {
                        if ((TBC >= 8) && (duoi50 == 1) && (DatHocLuc == 3))
                            DatHocLuc = 2;
                        if ((TBC >= 8) && (duoi35 == 1) && (DatHocLuc == 4))
                            DatHocLuc = 3;
                        if ((TBC >= 6.5) && (duoi35 == 1) && (DatHocLuc == 4))
                            DatHocLuc = 3;
                        if ((TBC >= 6.5) && (duoi20 == 1) && (DatHocLuc == 5))
                            DatHocLuc = 4;
                    }
                    else
                    {
                        if (monKhongDat == 1)
                        {
                            if ((TBC >= 8) && (duoi50 == 0) && (DatHocLuc == 3))
                                DatHocLuc = 2;
                            if ((TBC >= 8) && (duoi35 == 0) && (DatHocLuc == 4))
                                DatHocLuc = 3;
                            if ((TBC >= 6.5) && (duoi35 == 0) && (DatHocLuc == 4))
                                DatHocLuc = 3;
                            if ((TBC >= 6.5) && (duoi20 == 0) && (DatHocLuc == 5))
                                DatHocLuc = 4;
                        }
                    }
                    //Xử lý trường hợp với các môn đánh giá xếp loại
                    

                    DSTongKetTheoKy TongKetTheoKy = DB.DSTongKetTheoKies.Where(q => q.MaHocSinh == maHocSinh && q.MaHocKy == maHocKy).FirstOrDefault();
                    TongKetTheoKy.MaHocLuc = DB.DMHocLucs.Where(q => q.MucUuTien == DatHocLuc).Select(q => q.MaHocLuc).FirstOrDefault();                    
                }                
            }
            DB.SubmitChanges();
        }

        public static void XetHocLucTheoDSLop(string maHocKy, string[] tenLops)
        {
            string[] maLops = DB.DSLops.Where(q => tenLops.Contains(q.TenLop)).Select(q => q.MaLop).ToArray();
            foreach (string maLop in maLops)
            {
                string maGVCN = DB.DSLops.Where(q => q.MaLop == maLop).Select(q => q.MaGVCN).FirstOrDefault();
                string danhSachMonChuaNhapDiemHocKy = "";
                if (DSDiemBLL.KiemTraNhapDiemHocKyCacMonHoc(maHocKy, maGVCN, ref danhSachMonChuaNhapDiemHocKy) == true)
                {                    
                    XetHocLuc(maHocKy, maGVCN);                 
                }
                else
                {
                    UTL.Ultils.ThongBao("Chưa cập nhật điểm học kỳ ở các môn: " + danhSachMonChuaNhapDiemHocKy
                        + "\r\nVui lòng nhập đầy đủ trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
                }
            }
        }

        public static List<DSTongKetTheoKy> LayTongKetTheoKy(string maHocKy)
        {
            return DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy).ToList();
        }

        public static void CapNhatHanhKiem(GridControl gcHanhKiem, string maLop, string maHocKy)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            GridView gvHanhKiem = (GridView)gcHanhKiem.ViewCollection[0];
            for(byte i = 0; i < gvHanhKiem.RowCount; i++)
            {
                string maHocSinh = gvHanhKiem.GetRowCellValue(i, gvHanhKiem.Columns[1]).ToString();
                string tenHanhKiem = gvHanhKiem.GetRowCellValue(i, gvHanhKiem.Columns[4]).ToString();
                DSTongKetTheoKy TongKetTheoKy = DB.DSTongKetTheoKies.Where(q => q.MaNamHoc == maNamHoc && q.MaHocSinh == maHocSinh && q.MaHocKy == maHocKy).FirstOrDefault();
                string maHanhKiem = DMHanhKiemBLL.LayMaHanhKiemTheoTen(tenHanhKiem);
                TongKetTheoKy.MaHanhKiem = maHanhKiem;
            }
            DB.SubmitChanges();
        }

        public static void XetDanhHieu(string maHocKy, string tenDangNhap)
        {
            List<DSTongKetTheoKy> TongKetTheoKies = DSTongKetTheoKyBLL.TongKetTheoKyTheoLop(maHocKy, tenDangNhap);
            List<TieuChuanDanhHieu> TieuChuanDanhHieus = TieuChuanDanhHieuBLL.LoadAll();
            bool kiemTraDieuKienXetDanhHieu = true;
            foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
            {
                if ((TongKetTheoKy.MaHocLuc == null) || (TongKetTheoKy.MaHanhKiem == null))
                    kiemTraDieuKienXetDanhHieu = false;
            }
            if (kiemTraDieuKienXetDanhHieu == true)
            {
                foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                {
                    TongKetTheoKy.MaDanhHieu = TieuChuanDanhHieuBLL.LayMaDanhHieu(TongKetTheoKy.MaHocLuc, TongKetTheoKy.MaHanhKiem);
                }
                DB.SubmitChanges();
            }else
            {
                UTL.Ultils.ThongBao("Vui lòng nhập đầy đủ thông tin Hạnh kiểm trước khi thực hiện chức năng này.", System.Windows.Forms.MessageBoxIcon.Error);
            }                
        }

        public static void XetDanhHieuTheoDSLop(string maHocKy, string[] tenLops)
        {
            string[] maLops = DB.DSLops.Where(q => tenLops.Contains(q.TenLop)).Select(q => q.MaLop).ToArray();
            foreach (string maLop in maLops)
            {
                string maGVCN = DB.DSLops.Where(q => q.MaLop == maLop).Select(q => q.MaGVCN).FirstOrDefault();
                XetDanhHieu(maHocKy, maGVCN);
            }
        }

        public static bool KiemTraDuLieu(string maLop, string maHocKy)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string maDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
            string[] maHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(maLop);
            List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && maHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
            foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                if ((TongKetTheoKy.TrungBinhChung == null) || (TongKetTheoKy.MaHanhKiem == null) || (TongKetTheoKy.MaHocLuc == null))
                    return false;
            return true;
        }

        public static void XetLenLop()
        {
            String maHocKy = DSHocKyBLL.MaHocKyTongHop();
            bool kiemTraDieuKienXetLenLop = true;
            string[] MaHocSinhChuyenDi = DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == true).Select(q => q.MaHocSinh).ToArray();
            string[] MaHocSinhThoiHoc = DB.DSHocSinhThoiHocs.Select(q => q.MaHocSinh).ToArray();
            List<DSTongKetTheoKy> TongKetTheoKies = DSTongKetTheoKyBLL.LoadAll(maHocKy).Where(q=>!MaHocSinhThoiHoc.Contains(q.MaHocSinh) && !MaHocSinhChuyenDi.Contains(q.MaHocSinh)).ToList();          
            foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
            {
                if ((TongKetTheoKy.MaHanhKiem == null) || (TongKetTheoKy.MaHocLuc == null))
                {
                    kiemTraDieuKienXetLenLop = false;
                    break;
                }                    
            }
            if (kiemTraDieuKienXetLenLop == true)
            {
                List<DMLenLop> LenLops = DB.DMLenLops.ToList();
                //UTL.Ultils.ThongBao(TongKetTheoKies.Count.ToString(), System.Windows.Forms.MessageBoxIcon.Asterisk);
                foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                {
                    foreach (DMLenLop LenLop in LenLops)
                    {
                        if ((TongKetTheoKy.DMHanhKiem.MucUuTien <= LenLop.DMHanhKiem.MucUuTien)
                            && (TongKetTheoKy.SoBuoiNghi >= LenLop.SoBuoiNghiNhoNhat)
                            && (TongKetTheoKy.SoBuoiNghi <= LenLop.SoBuoiNghiLonNhat)
                            && (TongKetTheoKy.DMHocLuc.MucUuTien <= LenLop.DMHocLuc.MucUuTien))
                        {
                            TongKetTheoKy.MaLenLop = LenLop.MaLenLop;
                            //UTL.Ultils.ThongBao("Gán", System.Windows.Forms.MessageBoxIcon.Asterisk);
                            break;
                        }
                    }
                    //UTL.Ultils.ThongBao(TongKetTheoKy.MaHocSinh, System.Windows.Forms.MessageBoxIcon.Asterisk);                
                }
                DB.SubmitChanges();

                //Tăng trường DaQuaLop cho học sinh đủ điều kiện lên lớp
                foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                {
                    if (TongKetTheoKy.DMLenLop.DuocLenLop == true)
                    {
                        TongKetTheoKy.DSHocSinh.DaQuaLop = (short)(DSHocSinhTheoLopBLL.LayKhoiTheoMaHocSinh(TongKetTheoKy.MaHocSinh));
                    }
                }
                DB.SubmitChanges();
            }else
            {
                UTL.Ultils.ThongBao("Vui lòng nhập thực hiện chức năng Xét danh hiệu trước khi thực hiện chức năng này.", System.Windows.Forms.MessageBoxIcon.Error);
            }                        
        }        

        /// <summary>
        /// Dùng để trả kết quả về cho rptThongKeTHCSMau04
        /// </summary>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public static DataTable ThongKeXepLoaiTheoHocLucHanhKiem(string maHocKy, bool theoDanToc, bool laTHCS)
        {
            DataTable table = new DataTable();
            List<DMHanhKiem> HanhKiems = DMHanhKiemBLL.LayTatCaHanhKiem();
            List<DMHocLuc> HocLucs = DMHocLucBLL.LayTatCaHocLuc();

            DataColumn clLop = new DataColumn();
            clLop.ColumnName = "TenLop";
            DataColumn clTSHS = new DataColumn();
            clTSHS.ColumnName = "TSHS";

            table.Columns.Add(clLop);
            table.Columns.Add(clTSHS);            


            foreach (DMHanhKiem HanhKiem in HanhKiems)
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = HanhKiem.MaHanhKiem + "SL";
                table.Columns.Add(cl);
                cl = new DataColumn();
                cl.ColumnName = HanhKiem.MaHanhKiem + "PT";
                table.Columns.Add(cl);
            }

            foreach (DMHocLuc HocLuc in HocLucs)
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = HocLuc.MaHocLuc + "SL";
                table.Columns.Add(cl);
                cl = new DataColumn();
                cl.ColumnName = HocLuc.MaHocLuc + "PT";
                table.Columns.Add(cl);
            }

            DataColumn clGhiChu = new DataColumn();
            clGhiChu.ColumnName = "GhiChu";
            table.Columns.Add(clGhiChu);

            short maDanToc = DMDanTocBLL.LayMaDanTocKhongThongKe();
            List<DSKhoi> Khois;
            if (laTHCS == true)
                Khois = DB.DSKhois.Where(q => q.MaCap == "CTHCS").ToList();
            else
                Khois = DB.DSKhois.Where(q => q.MaCap == "CTHPT").ToList();
            int[] TongSoHanhKiem = new int[DMHanhKiemBLL.SoLuongHanhKiem() + 1];
            double[] TongPhanTramHanhKiem = new double[TongSoHanhKiem.Length];
            int[] TongSoHocLuc = new int[DMHocLucBLL.SoLuongHocLuc() + 1];
            double[] TongPhanTramHocLuc = new double[TongSoHocLuc.Length];
            int TongSoHocSinh = 0;

            for (int i = 0; i < TongSoHanhKiem.Length; i++)
            {
                TongSoHanhKiem[i] = 0;
                TongPhanTramHanhKiem[i] = 0;
            }
            for (int i = 0; i < TongSoHocLuc.Length; i++)
            {
                TongSoHocLuc[i] = 0;
                TongPhanTramHocLuc[i] = 0;
            }

            //Lấy mã danh sách học sinh không thống kê
            string[] maDSHSKhongThongKe = DSHocSinhChuyenTruongBLL.LayMaHSKhongXet(maHocKy);

            foreach (DSKhoi Khoi in Khois)
            {
                int[] SoLuongHanhKiem = new int[DMHanhKiemBLL.SoLuongHanhKiem()+1];
                double[] PhanTramHanhKiem = new double[SoLuongHanhKiem.Length];
                int[] SoLuongHocLuc = new int[DMHocLucBLL.SoLuongHocLuc() + 1];
                double[] PhanTramHocLuc = new double[SoLuongHocLuc.Length];
                for(int i = 0; i < SoLuongHanhKiem.Length; i++)
                {
                    SoLuongHanhKiem[i] = 0;
                    PhanTramHanhKiem[i] = 0;
                }
                for (int i = 0; i < SoLuongHocLuc.Length; i++)
                {
                    SoLuongHocLuc[i] = 0;
                    PhanTramHocLuc[i] = 0;
                }
                int KhongXepLoaiHanhKiem = 0;
                int KhongXepLoaiHocLuc = 0;
                DataRow row = table.NewRow();
                row[0] = "Lớp " + Khoi.TenKhoi;
                int SLHS = 0;
                List<DSLop> Lops = Khoi.DSLops.ToList();                

                foreach (DSLop Lop in Lops)
                {
                    string[] maHocSinhs;
                    if (theoDanToc)
                        maHocSinhs = Lop.DSHocSinhTheoLops.Where(q => q.DSHocSinh.MaDanToc != maDanToc &&
                                                                !maDSHSKhongThongKe.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();
                    else
                       maHocSinhs = Lop.DSHocSinhTheoLops.Where(q => !maDSHSKhongThongKe.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();
                    List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && maHocSinhs.Contains(q.MaHocSinh)).ToList();
                    foreach(DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                    {
                        if (TongKetTheoKy.MaHanhKiem != null)
                            SoLuongHanhKiem[(int)TongKetTheoKy.DMHanhKiem.MucUuTien]++;
                        else
                            KhongXepLoaiHanhKiem++;
                        if (TongKetTheoKy.MaHocLuc != null)
                            SoLuongHocLuc[(int)TongKetTheoKy.DMHocLuc.MucUuTien]++;
                        else
                            KhongXepLoaiHocLuc++;
                    }
                    SLHS += maHocSinhs.Length;
                }                                

                row[1] = SLHS;
                if (SLHS != 0)
                {
                    for (byte i = 0; i < SoLuongHanhKiem.Length; i++)
                    {
                        PhanTramHanhKiem[i] = Math.Round(((double)SoLuongHanhKiem[i] / SLHS) * 100, 1);
                    }
                    for (int i = SoLuongHanhKiem.Length - 1; i >= 0; i--)
                        if (PhanTramHanhKiem[i] != 0)
                        {
                            PhanTramHanhKiem[i] = 100;
                            for (byte j = 1; j < i; j++)
                                PhanTramHanhKiem[i] -= PhanTramHanhKiem[j];
                            PhanTramHanhKiem[i] = Math.Round(PhanTramHanhKiem[i], 1);
                            break;
                        }

                    for (int i = 0; i < SoLuongHocLuc.Length; i++)
                    {
                        PhanTramHocLuc[i] = Math.Round(((double)SoLuongHocLuc[i] / SLHS) * 100, 1);
                    }
                    for (int i = SoLuongHocLuc.Length - 1; i >= 0; i--)
                        if (PhanTramHocLuc[i] != 0)
                        {
                            PhanTramHocLuc[i] = 100;
                            for (byte j = 1; j < i; j++)
                                PhanTramHocLuc[i] -= PhanTramHocLuc[j];
                            PhanTramHocLuc[i] = Math.Round(PhanTramHocLuc[i], 1);
                            break;
                        }                    

                    for (byte i = 0; i < SoLuongHanhKiem.Length - 1; i++)
                    {
                        row[(i + 1) * 2] = SoLuongHanhKiem[i + 1];
                        row[(i + 1) * 2 + 1] = PhanTramHanhKiem[i + 1];
                    }
                    for (byte i = 0; i < SoLuongHocLuc.Length - 1; i++)
                    {
                        row[(i + 6) * 2] = SoLuongHocLuc[i + 1];
                        row[(i + 6) * 2 + 1] = PhanTramHocLuc[i + 1];
                    }
                    row[22] = "Không xếp loại Hạnh kiểm: " + KhongXepLoaiHanhKiem
                                + " --- Không xếp loại Học lực: " + KhongXepLoaiHocLuc;
                }
                for (byte i = 0; i < SoLuongHanhKiem.Length; i++)
                {
                    TongSoHanhKiem[i] += SoLuongHanhKiem[i];                    
                }
                for (byte i = 0; i < SoLuongHocLuc.Length; i++)
                {
                    TongSoHocLuc[i] += SoLuongHocLuc[i];                    
                }
                TongSoHocSinh += SLHS;
                table.Rows.Add(row);
            }

            //Tính tổng số phần trăm Hạnh kiểm và học lực
            for (byte i = 0; i < TongSoHanhKiem.Length; i++)
            {
                TongPhanTramHanhKiem[i] += Math.Round(((double)TongSoHanhKiem[i]/TongSoHocSinh)*100,1);
            }
            for (byte i = 0; i < TongSoHocLuc.Length; i++)
            {
                TongPhanTramHocLuc[i] += Math.Round(((double)TongSoHocLuc[i] / TongSoHocSinh) * 100, 1);
            }

            //Thêm dòng Tổng số
            DataRow rowTS = table.NewRow();
            rowTS[0] = "Tổng số";
            rowTS[1] = TongSoHocSinh;
            for (byte i = 0; i < DMHanhKiemBLL.SoLuongHanhKiem(); i++)
            {
                rowTS[(i + 1) * 2] = TongSoHanhKiem[i + 1];
                rowTS[(i + 1) * 2 + 1] = TongPhanTramHanhKiem[i + 1];
            }
            for (byte i = 0; i < DMHocLucBLL.SoLuongHocLuc(); i++)
            {
                rowTS[(i + 6) * 2] = TongSoHocLuc[i + 1];
                rowTS[(i + 6) * 2 + 1] = TongPhanTramHocLuc[i + 1];
            }
            table.Rows.Add(rowTS);

            return table;         
        }

        public static DSTongKetTheoKy LayTongKetTheoKyCuaMotHocSinh(string maHocKy, string maHocSinh)
        {
            return DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy && q.MaHocSinh == maHocSinh).FirstOrDefault();
        }
    }
}
