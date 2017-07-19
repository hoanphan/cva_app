using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;

namespace BLL
{
    public class DSDiemBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext();

        public static void KhoiTaoDuLieuDiem()
        {
            List<DSHocSinh> HocSinhs = DB.DSHocSinhs.ToList();
            List<DSLop> Lops = DB.DSLops.ToList();
            List<DSMonHocTheoLop> MonHocTheoLops = DB.DSMonHocTheoLops.ToList();
            List<DSHocSinhTheoLop> HocSinhTheoLops = DB.DSHocSinhTheoLops.ToList();
            DSNamHoc NamHoc = DB.DSNamHocs.Where(q => q.NamHienTai == true).FirstOrDefault();
            List<DSHocKy> HocKies = DB.DSHocKies.ToList();
            List<DSLoaiDiem> LoaiDiems = DB.DSLoaiDiems.ToList();            

            foreach(DSLop Lop in Lops)
            {
                foreach(DSHocSinhTheoLop HocSinhTheoLop in Lop.DSHocSinhTheoLops)
                {
                    foreach(DSMonHocTheoLop MonHocTheoLop in Lop.DSMonHocTheoLops)
                    {
                        foreach(DSLoaiDiem LoaiDiem in LoaiDiems)
                        {                            
                            foreach(DSHocKy HocKy in HocKies)
                            {
                                for (short i = 1; i < LoaiDiem.SoDiemToiDa + 1; i++)
                                {
                                    DSDiem Diem = new DSDiem();
                                    Diem.MaHocSinh = HocSinhTheoLop.MaHocSinh;
                                    Diem.MaHocKy = HocKy.MaHocKy;
                                    Diem.MaLoaiDiem = LoaiDiem.MaLoaiDiem;
                                    Diem.MaMonHoc = MonHocTheoLop.MaMonHoc;
                                    Diem.MaNamHoc = NamHoc.MaNamHoc;
                                    Diem.STTDiem = i;
                                    Diem.Diem = -1;
                                    Diem.ChoPhepDang = false;
                                    DB.DSDiems.InsertOnSubmit(Diem);                                    
                                }
                            }
                        }
                    }
                }
            }
            DB.SubmitChanges();            
        }

        private static DataTable TaoBangDiem()
        {
            DataTable temp = new DataTable();
            DataColumn clMaHocSinh = new DataColumn();
            clMaHocSinh.ColumnName = "MaHocSinh";            
            DataColumn clHoVaTen = new DataColumn();
            clHoVaTen.ColumnName = "HoVaTen";
            DataColumn clNgaySinh = new DataColumn();
            clNgaySinh.ColumnName = "NgaySinh";
            
            temp.Columns.Add(clMaHocSinh);
            temp.Columns.Add(clHoVaTen);
            temp.Columns.Add(clNgaySinh);

            string[] MaLoaiDiem = DSLoaiDiemBLL.LoadAllMaLoaiDiem();
            string[] TenLoaiDiem = DSLoaiDiemBLL.LoadAllTenLoaiDiem();
            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();
            for (byte i = 0; i < TenLoaiDiem.Count(); i++)
                if ((short)SoDiemToiDa.GetValue(i) > 1)
                {
                    for (byte j = 0; j < (short)SoDiemToiDa.GetValue(i); j++)
                    {
                        DataColumn cl = new DataColumn();
                        cl.ColumnName = MaLoaiDiem.GetValue(i).ToString() + "_" + (j + 1).ToString();
                        temp.Columns.Add(cl);
                    }
                }
            for (byte i = 0; i < TenLoaiDiem.Count(); i++)
                if ((short)SoDiemToiDa.GetValue(i) == 1)
                {
                        DataColumn cl = new DataColumn();
                        cl.ColumnName = MaLoaiDiem.GetValue(i).ToString() + "_" + (1).ToString();
                        temp.Columns.Add(cl);

                }
            //DataColumn clHocKy = new DataColumn();
            //clHocKy.ColumnName = "HK";
            //DataColumn clTrungBinh = new DataColumn();
            //clTrungBinh.ColumnName = "TB";
            //temp.Columns.Add(clHocKy);
            //temp.Columns.Add(clTrungBinh);
            return temp;
        }

        public static DataTable TruyVanDSDiem(string maLop, string maHocKy, string maMonHoc)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                                             where ds.MaLop == maLop
                                             select ds.MaHocSinh).ToArray();
            List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
            List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
            //List<MauBangNhapDiem> BangDiem = new List<MauBangNhapDiem>();
            DataTable BangDiem = TaoBangDiem();

            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();

            byte TongSoDiemCon = 0;
            for(byte i = 0; i < SoDiemToiDa.Count(); i++)
            {
                TongSoDiemCon += (byte)(short)SoDiemToiDa.GetValue(i);
            }

            if (DSMonHocBLL.LaChoDiem(maMonHoc) == true)
            {
                foreach (DSHocSinh HocSinh in HocSinhTheoLops)
                {
                    //MauBangNhapDiem diem = new MauBangNhapDiem();
                    //diem.MaHocSinh = HocSinh.MaHocSinh;
                    //diem.HoVaTen = HocSinh.HoDem + " " + HocSinh.Ten;
                    //diem.NgaySinh = HocSinh.NgaySinh;                        
                    //List<DSDiem> dsDiem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaHocSinh == HocSinh.MaHocSinh).OrderBy(q => q.MaLoaiDiem).ToList();
                    //diem.M1 = ghepDiem(dsDiem, 0); diem.M2 = ghepDiem(dsDiem, 1); diem.M3 = ghepDiem(dsDiem, 2);
                    //diem.M4 = ghepDiem(dsDiem, 3); diem.M5 = ghepDiem(dsDiem, 4);
                    //diem.P1 = ghepDiem(dsDiem, 5); diem.P2 = ghepDiem(dsDiem, 6); diem.P3 = ghepDiem(dsDiem, 7);
                    //diem.P4 = ghepDiem(dsDiem, 8); diem.P5 = ghepDiem(dsDiem,9);
                    //diem.V1 = ghepDiem(dsDiem, 10); diem.V2 = ghepDiem(dsDiem, 11); diem.V3 = ghepDiem(dsDiem, 12);
                    //diem.V4 = ghepDiem(dsDiem, 13); diem.V5 = ghepDiem(dsDiem, 14);
                    //diem.HK = ghepDiem(dsDiem,15);
                    //BangDiem.Add(diem);
                    DataRow row = BangDiem.NewRow();
                    row["MaHocSinh"] = HocSinh.MaHocSinh;
                    row["HoVaTen"] = HocSinh.HoDem + " " + HocSinh.Ten;
                    row["NgaySinh"] = HocSinh.NgaySinh;
                    List<DSDiem> dsDiem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaHocSinh == HocSinh.MaHocSinh).OrderBy(q => q.MaLoaiDiem).ToList();
                    for (byte i = 0; i < TongSoDiemCon; i++)
                    {
                        row[i + 3] = ghepDiem(dsDiem, i);
                    }
                    BangDiem.Rows.Add(row);
                }
            }else
            {
                foreach (DSHocSinh HocSinh in HocSinhTheoLops)
                {
                    DataRow row = BangDiem.NewRow();
                    row["MaHocSinh"] = HocSinh.MaHocSinh;
                    row["HoVaTen"] = HocSinh.HoDem + " " + HocSinh.Ten;
                    row["NgaySinh"] = HocSinh.NgaySinh;
                    List<DSDiem> dsDiem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaHocSinh == HocSinh.MaHocSinh).OrderBy(q => q.MaLoaiDiem).ToList();
                    for (byte i = 0; i < TongSoDiemCon; i++)
                    {
                        row[i + 3] = ghepDiemNX(dsDiem, i);
                    }
                    BangDiem.Rows.Add(row);
                }
            }            
            //UTL.Ultils.ThongBao(BangDiem.Rows.Count.ToString());
            return BangDiem;
        }

        public static double?[] LoadDSDiem(string maHocKy, string maMonHoc, string maHocSinh, string maLoaiDiem)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            return DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaHocSinh == maHocSinh && q.MaLoaiDiem == maLoaiDiem && q.Diem != -1 ).Select(q => q.Diem).ToArray();
        }

        private static string ghepDiem(List<DSDiem> dsDiem, byte index)
        {
            if (dsDiem[index].Diem == -1)
            {
                return "-";
            }else
            {
                return dsDiem[index].Diem.ToString();
            }
        }

        private static string ghepDiemNX(List<DSDiem> dsDiem, byte index)
        {
            if (dsDiem[index].Diem == -1)
            {
                return "-";
            }
            else
            {
                if (dsDiem[index].Diem == -2)
                    return "Đ";
                else
                    return "CĐ";
            }
        }     

        public static DSDiem DiemCon(string maHocSinh, string maNamHoc, string maHocKy, string maMonHoc, string maLoaiDiem, byte STT)
        {
            return DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiem && q.STTDiem == STT).FirstOrDefault();
        }

        public static void CapNhatDiem(GridControl gcDiem, string maLop, string maHocKy, string maMonHoc)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            GridView gvDiem = (GridView)gcDiem.ViewCollection[0];
            float tt;
            if (DSMonHocBLL.LaChoDiem(maMonHoc) == true)
            {
                for (int i = 0; i < gvDiem.RowCount; i++)
                {
                    string maHocSinh = gvDiem.GetRowCellValue(i, gvDiem.Columns[1]).ToString();
                    for (byte j = 4; j < gvDiem.Columns.Count; j++)
                    {
                        string cellValue = gvDiem.GetRowCellValue(i, gvDiem.Columns[j]).ToString();
                        if (float.TryParse(cellValue, out tt))
                        {
                            string maLoaiDiem = UTL.Ultils.CatMaLoaiDiem(gvDiem.Columns[j].Name);
                            byte STT = UTL.Ultils.CatSoTT(gvDiem.Columns[j].Name);
                            DSDiem Diem = DiemCon(maHocSinh, maNamHoc, maHocKy, maMonHoc, maLoaiDiem, STT);
                            float diemCon = float.Parse(cellValue);
                            if (Diem.Diem == -1)
                            {
                                Diem.NgayCapNhat = DateTime.Today;
                                //Diem.NgayChinhSua = DateTime.Today;
                            }
                            if (diemCon != Diem.Diem)
                            {
                                Diem.Diem = Math.Round(diemCon, 2);
                                Diem.NgayChinhSua = DateTime.Today;
                            }
                            DB.SubmitChanges();
                            //UTL.Ultils.ThongBao(Diem.MaHocSinh);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < gvDiem.RowCount; i++)
                {
                    string maHocSinh = gvDiem.GetRowCellValue(i, gvDiem.Columns[1]).ToString();
                    for (byte j = 4; j < gvDiem.Columns.Count; j++)
                    {
                        string cellValue = gvDiem.GetRowCellValue(i, gvDiem.Columns[j]).ToString();                        
                        float diemCon = -1;
                        if (cellValue == "Đ")
                            diemCon = -2;
                        if (cellValue == "CĐ")
                            diemCon = -3;
                        string maLoaiDiem = UTL.Ultils.CatMaLoaiDiem(gvDiem.Columns[j].Name);
                        byte STT = UTL.Ultils.CatSoTT(gvDiem.Columns[j].Name);
                        DSDiem Diem = DiemCon(maHocSinh, maNamHoc, maHocKy, maMonHoc, maLoaiDiem, STT);
                        
                        if (Diem.Diem == -1)
                        {
                            Diem.NgayCapNhat = DateTime.Today;
                            //Diem.NgayChinhSua = DateTime.Today;
                        }
                        if (diemCon != Diem.Diem)
                        {
                            Diem.Diem = diemCon;
                            Diem.NgayChinhSua = DateTime.Today;
                        }
                        DB.SubmitChanges();
                        //UTL.Ultils.ThongBao(Diem.MaHocSinh);                        
                    }
                }
            }
            
        }

        public static void TinhDiemTrungBinh(string maHocKy, string maLop, string maMonHoc)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
            string[] maHocSinhTheoLops = DSHocSinhTheoLopBLL.maHocSinhTheoLop(maLop);            
            foreach (string maHocSinh in maHocSinhTheoLops)
            {                
                double? TongDiem = 0;
                int? TongHeSo = 0;                
                foreach(DSLoaiDiem LoaiDiem in LoaiDiems)
                {
                    if (LoaiDiem.TinhToan == true)
                    {
                        double?[] Diems = LoadDSDiem(maHocKy, maMonHoc, maHocSinh, LoaiDiem.MaLoaiDiem);
                        TongDiem += Diems.Sum() * LoaiDiem.HeSo;
                        TongHeSo += Diems.Count() * LoaiDiem.HeSo;
                    }
                }
                UTL.Ultils.ThongBao(TongHeSo.ToString());
                string maLoaiDiemTongHop = DSLoaiDiemBLL.LoadLoaiDiemTongHop();
                DSDiem Diem = DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiemTongHop && q.MaHocSinh == maHocSinh).FirstOrDefault();                
                Diem.Diem = Math.Round((double)(TongDiem / TongHeSo), 1);                
            }
            DB.SubmitChanges();
        }
    }
}
