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
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace BLL
{
    public class DSDiemBLL
    {
        static SerialPort port = new SerialPort();
        static SMSClass objclsSMS = new SMSClass();

        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void KhoiTaoDuLieuDiem(string maHocKy, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            List<DSHocSinh> HocSinhs = DB.DSHocSinhs.ToList();
            List<DSLop> Lops = DB.DSLops.ToList();            
            //List<DSHocSinhTheoLop> HocSinhTheoLops = DB.DSHocSinhTheoLops.ToList();
            DSNamHoc NamHoc = DB.DSNamHocs.Where(q => q.NamHienTai == true).FirstOrDefault();
            List<DSHocKy> HocKies = DB.DSHocKies.Where(q=>q.MaHocKy == maHocKy).ToList();
            List<DSLoaiDiem> LoaiDiems = DB.DSLoaiDiems.ToList();


            //Tính toán số Học sinh cần tạo dữ liệu
            int soHocSinh = 0;
            foreach(DSLop Lop in Lops)
            {
                soHocSinh += DB.DSHocSinhTheoLops.Where(q => q.MaLop == Lop.MaLop).Count();
            }
            pgbTienTrinh.EditValue = 0;
            pgbTienTrinh.Properties.Minimum = 0;
            pgbTienTrinh.Properties.Maximum = soHocSinh;
            pgbTienTrinh.Properties.Step = 1;
            pgbTienTrinh.Properties.PercentView = true;
            #region
            foreach (DSHocKy HocKy in HocKies)
            {                
                foreach(DSLop Lop in Lops)
                {
                    List<DSMonHocTheoLop> MonHocTheoLops = DB.DSMonHocTheoLops.Where(q => q.MaHocKy == HocKy.MaHocKy && q.MaLop == Lop.MaLop).ToList();
                    List<DSHocSinhTheoLop> HocSinhTheoLops = DB.DSHocSinhTheoLops.Where(q => q.MaLop == Lop.MaLop).ToList();
                    foreach(DSHocSinhTheoLop HocSinhTheoLop in HocSinhTheoLops)
                    {                        
                        foreach(DSMonHocTheoLop MonHocTheoLop in MonHocTheoLops)
                        {
                            foreach (DSLoaiDiem LoaiDiem in LoaiDiems)
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
                                    if (TimKhoaTrung(Diem.MaHocSinh, Diem.MaHocKy, Diem.MaMonHoc, Diem.MaLoaiDiem, Diem.STTDiem))
                                        DB.DSDiems.InsertOnSubmit(Diem);                                  
                                }
                            }
                        }                        
                        pgbTienTrinh.PerformStep();
                        pgbTienTrinh.Update();
                    }
                }
            }
            #endregion

            DB.SubmitChanges();

            if (maHocKy == "K2")
            {
                List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaHocKy == "K1" && q.MaLoaiDiem == "LD5").ToList();
                foreach (DSDiem DiemCon in Diems)
                {
                    DSDiem Diem = new DSDiem();
                    Diem.MaHocSinh = DiemCon.MaHocSinh;
                    Diem.MaHocKy = "K3";
                    Diem.MaLoaiDiem = DiemCon.MaLoaiDiem;
                    Diem.MaMonHoc = DiemCon.MaMonHoc;
                    Diem.MaNamHoc = DiemCon.MaNamHoc;
                    Diem.STTDiem = 1;
                    Diem.Diem = -1;
                    Diem.ChoPhepDang = false;
                    if (TimKhoaTrung(Diem.MaHocSinh, Diem.MaHocKy, Diem.MaMonHoc, Diem.MaLoaiDiem, Diem.STTDiem))
                        DB.DSDiems.InsertOnSubmit(Diem);
                    //DB.SubmitChanges();
                }
                DB.SubmitChanges();
            }            
        }

        /// <summary>
        /// Phương thức khóa sổ dữ liệu, không cho người dùng chỉnh sửa nữa
        /// Bằng cách thiết lập thuộc tính KhoaSo trong bảng DSDiem về True
        /// </summary>
        /// <param name="maHocKy"></param>
        /// <param name="pgbTienTrinh"></param>
        public static void KhoaSoDuLieu(string maHocKy)
        {
            //List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaHocKy == maHocKy).ToList();
            string command = "UPDATE DSDiem Set KhoaSo = 'True' WHERE MaHocKy = '" + maHocKy + "'";
            DB.ExecuteCommand(command);            
        }

        /// <summary>
        /// Phương thức Mở khóa sổ dữ liệu, cho phép người dùng tiếp tục chỉnh sửa
        /// Bằng cách thiết lập thuộc tính KhoaSo trong bảng DSDiem về False
        /// </summary>
        /// <param name="maHocKy"></param>
        /// <param name="pgbTienTrinh"></param>
        public static void MoKhoaSoDuLieu(string maHocKy)
        {
            //List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaHocKy == maHocKy).ToList();
            string command = "UPDATE DSDiem Set KhoaSo = 'False' WHERE MaHocKy = '" + maHocKy + "'";
            DB.ExecuteCommand(command);
        }

        /// <summary>
        /// Kiểm tra xem đã khóa sổ học kỳ đó chưa
        /// Nếu đã khóa sổ sẽ trả về True
        /// Nếu chưa khóa sổ sẽ trả về False
        /// </summary>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public static bool KiemTraKhoaSo(string maHocKy)
        {
            int dem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.KhoaSo == true).Count();
            if (dem > 0)
                return true;
            return false;
        }

        public static bool TimKhoaTrung(string maHocSinh, string maHocKy, string maMonHoc, string maLoaiDiem, short sttDiem)
        {
            if (DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiem && q.STTDiem == sttDiem).Count() > 0)
                return false;
            else
                return true;
        }

        private static DataTable TaoBangDiem(string maHocKy)
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
            if (maHocKy == "K2")
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = "TBCCaNam";
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

        private static DataTable TaoBangDiemTrungBinh(string maLop, string maHocKy)
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
            
            List<DSMonHoc> monHocTheoLopKy = DSMonHocTheoLopBLL.LayMonHocTheoLopKy(maLop, maHocKy);

            foreach(DSMonHoc monHoc in monHocTheoLopKy)
            {
                temp.Columns.Add(new DataColumn(monHoc.MaMonHoc));
            }

            DataColumn cl = new DataColumn();
            cl.ColumnName = "TBCCaKy";
            temp.Columns.Add(cl);
            
            temp.Columns.Add(new DataColumn("HocLuc"));
            temp.Columns.Add(new DataColumn("HanhKiem"));
            temp.Columns.Add(new DataColumn("DanhHieu"));

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
            string[] maDSHSChuyenDenKy2 = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongLechKy();
            if (maHocKy == "K2")
                Array.Clear(maDSHSChuyenDenKy2, 0, maDSHSChuyenDenKy2.Length);
            string[] maDSHSChuyenDi = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                                           where ds.MaLop == maLop && !maDSHSChuyenDenKy2.Contains(ds.MaHocSinh)
                                             select ds.MaHocSinh).ToArray();
            //List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
            List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && !maDSHSChuyenDenKy2.Contains(q.MaHocSinh)).OrderBy(q => q.STT).Select(q => q.DSHocSinh).ToList();
            List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
            //List<MauBangNhapDiem> BangDiem = new List<MauBangNhapDiem>();
            DataTable BangDiem = TaoBangDiem(maHocKy);

            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();

            byte TongSoDiemCon = 0;
            for(byte i = 0; i < SoDiemToiDa.Count(); i++)
            {
                TongSoDiemCon += (byte)(short)SoDiemToiDa.GetValue(i);
            }

            byte stt = 1;
            if (DSMonHocBLL.LaChoDiem(maMonHoc) == true)
            {
                foreach (DSHocSinh HocSinh in HocSinhTheoLops)
                {                    
                    DataRow row = BangDiem.NewRow();
                    row["STT"] = stt++;
                    row["MaHocSinh"] = HocSinh.MaHocSinh;
                    row["HoVaTen"] = HocSinh.HoDem + " " + HocSinh.Ten;                    
                    row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                    if (!maDSHSChuyenDi.Contains(HocSinh.MaHocSinh))
                    {
                        List<DSDiem> dsDiem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaHocSinh == HocSinh.MaHocSinh).OrderBy(q => q.MaLoaiDiem).ToList();
                        for (byte i = 0; i < TongSoDiemCon; i++)
                        {
                            row[i + 4] = ghepDiem(dsDiem, i);
                        }
                        if (maHocKy == "K2")
                        {
                            string maHocKyTongHop = DSHocKyBLL.MaHocKyTongHop();
                            DSDiem dsDiemTBCCN = DB.DSDiems.Where(q => q.MaHocKy == maHocKyTongHop && q.MaMonHoc == maMonHoc && q.MaHocSinh == HocSinh.MaHocSinh).FirstOrDefault();
                            if (dsDiemTBCCN == null)
                                row["TBCCaNam"] = "";
                            else
                                row["TBCCaNam"] = dsDiemTBCCN.Diem;
                        }
                    }                       
                    BangDiem.Rows.Add(row);
                }
            }else
            {
                foreach (DSHocSinh HocSinh in HocSinhTheoLops)
                {
                    DataRow row = BangDiem.NewRow();
                    row["STT"] = stt++;
                    row["MaHocSinh"] = HocSinh.MaHocSinh;
                    row["HoVaTen"] = HocSinh.HoDem + " " + HocSinh.Ten;
                    row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                    if (!maDSHSChuyenDi.Contains(HocSinh.MaHocSinh))
                    {
                        List<DSDiem> dsDiem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaHocSinh == HocSinh.MaHocSinh).OrderBy(q => q.MaLoaiDiem).ToList();
                        for (byte i = 0; i < TongSoDiemCon; i++)
                        {
                            row[i + 4] = ghepDiemNX(dsDiem, i);
                        }
                    }
                    BangDiem.Rows.Add(row);
                }
            }            
            //UTL.Ultils.ThongBao(BangDiem.Rows.Count.ToString());
            return BangDiem;
        }

        /// <summary>
        /// Lấy danh sách điểm Học kỳ của HS chuyển đến trường.
        /// </summary>
        /// <param name="maLop"></param>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public static DataTable TruyVanDSDiemHocKyHSChuyenTruong(string maLop, string maHocKy)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string[] maHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(0, "");
            string[] dsMaHocSinhTheoLop = (from ds in DB.GetTable<DSHocSinhTheoLop>()
                                           where ds.MaLop == maLop && maHSChuyenTruong.Contains(ds.MaHocSinh)
                                           select ds.MaHocSinh).ToArray();
            string maLoaiDiemTongHop = DSLoaiDiemBLL.LayLoaiDiemTongHop().MaLoaiDiem;
            //List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhs.Where(q => dsMaHocSinhTheoLop.Contains(q.MaHocSinh)).ToList();
            List<DSHocSinh> HocSinhTheoLops = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && maHSChuyenTruong.Contains(q.MaHocSinh)).OrderBy(q => q.STT).Select(q => q.DSHocSinh).ToList();
            DSLoaiDiem LoaiDiems = DSLoaiDiemBLL.LayLoaiDiemTongHop();            
            DataTable BangDiem = TaoBangDiemTrungBinh(maLop, maHocKy);

            List<DSMonHoc> monHocTheoLopKy = DSMonHocTheoLopBLL.LayMonHocTheoLopKy(maLop, maHocKy);            

            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();


            
            byte stt = 0;
            foreach (DSHocSinh HocSinh in HocSinhTheoLops)
            {
                DataRow row = BangDiem.NewRow();
                row["STT"] = ++stt;
                row["MaHocSinh"] = HocSinh.MaHocSinh;
                row["HoVaTen"] = HocSinh.HoDem + " " + HocSinh.Ten;
                row["NgaySinh"] = ((DateTime)HocSinh.NgaySinh).Date.ToLongDateString();
                List<DSDiem> dsDiem = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaLoaiDiem == maLoaiDiemTongHop && q.MaHocSinh == HocSinh.MaHocSinh).ToList();
                foreach (DSMonHoc monHoc in monHocTheoLopKy)
                {
                    double? diem = dsDiem.Where(q => q.MaMonHoc == monHoc.MaMonHoc).Select(q => q.Diem).FirstOrDefault();
                    if (diem == -1)
                            row[monHoc.MaMonHoc] = "-";
                    else
                        if (diem == -2)                        
                            row[monHoc.MaMonHoc] = "Đ";
                        else
                            if (diem == -3)                        
                                row[monHoc.MaMonHoc] = "CĐ";
                            else                        
                                row[monHoc.MaMonHoc] = diem.ToString();                                                                   
                }
                row["TBCCaKy"] = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, HocSinh.MaHocSinh).TrungBinhChung;
                row["HocLuc"] = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, HocSinh.MaHocSinh).MaHocLuc;
                row["HanhKiem"] = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, HocSinh.MaHocSinh).MaHanhKiem;
                row["DanhHieu"] = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, HocSinh.MaHocSinh).MaDanhHieu;
                BangDiem.Rows.Add(row);
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
                        
                        string maLoaiDiem = UTL.Ultils.CatMaLoaiDiem(gvDiem.Columns[j].Name);
                        byte STT = UTL.Ultils.CatSoTT(gvDiem.Columns[j].Name);
                        DSDiem Diem = DiemCon(maHocSinh, maNamHoc, maHocKy, maMonHoc, maLoaiDiem, STT);
                        float diemCon = -1;
                        if (cellValue == "-")
                            diemCon = -1;
                        else
                            if (float.TryParse(cellValue, out tt))
                                diemCon = float.Parse(cellValue);
                        if ((Diem.Diem == -1) && (diemCon != -1))
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


        public static void CapNhatDiemTrungBinhMon(GridControl gcDiem, string maHocKy)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string maLoaiDiemTongHop = DSLoaiDiemBLL.LoadMaDiemTongHop();
            GridView gvDiem = (GridView)gcDiem.ViewCollection[0];
            int tongSoCot = gvDiem.Columns.Count;
            for (byte i = 0; i < gvDiem.RowCount; i++)
            {
                string maHocSinh = gvDiem.GetRowCellValue(i, "MaHocSinh").ToString();
                List<DSDiem> dsDiemTrungBinh = DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocSinh == maHocSinh
                                                                && q.MaLoaiDiem == maLoaiDiemTongHop 
                                                                && q.MaHocKy == maHocKy).ToList();
                #region CapNhatDiemTrungBinhTungMon
                for (int j = 4; j < tongSoCot - 4; j++)
                {
                    DSDiem diemTrungBinh = dsDiemTrungBinh.Where(q => q.MaMonHoc == gvDiem.Columns[j].FieldName).FirstOrDefault();
                    if (diemTrungBinh != null)
                    {
                        string strDiem = gvDiem.GetRowCellValue(i, gvDiem.Columns[j]).ToString();
                        if (strDiem != "-")
                        {
                            double diem;
                            if (diemTrungBinh.Diem == -1)
                                diemTrungBinh.NgayCapNhat = DateTime.Now.Date;
                            if (strDiem == "Đ")
                                diem = -2;
                            else
                            {
                                if (strDiem == "CĐ")
                                    diem = -3;
                                else
                                    diem = Math.Round(double.Parse(strDiem),1);
                            }
                            if (diemTrungBinh.Diem != diem)
                            {
                                diemTrungBinh.NgayChinhSua = DateTime.Now.Date;
                                diemTrungBinh.Diem = diem;
                                DB.SubmitChanges();
                            }                            
                        }else
                        {
                            if (diemTrungBinh.Diem != -1)
                            {
                                diemTrungBinh.Diem = -1;
                                diemTrungBinh.NgayCapNhat = null;
                                diemTrungBinh.NgayChinhSua = null;
                                DB.SubmitChanges();
                            }
                        }
                    }
                }
                #endregion


                //DSTongKetTheoKy tongKetTheoKy = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, maHocSinh);
                DSTongKetTheoKy tongKetTheoKy = DB.DSTongKetTheoKies.Where(q => q.MaHocSinh == maHocSinh && q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy).FirstOrDefault();                
                if (tongKetTheoKy != null)
                {
                    var cellValue = gvDiem.GetRowCellValue(i, gvDiem.Columns[tongSoCot - 4]);
                    double diemTBC;
                    if (double.TryParse(cellValue.ToString(), out diemTBC))
                    {
                        tongKetTheoKy.TrungBinhChung = diemTBC;
                    }
                    string str = gvDiem.GetRowCellValue(i, gvDiem.Columns[tongSoCot - 3]).ToString();
                    if (str != "")
                    {
                        tongKetTheoKy.MaHocLuc = str;
                    }
                    str = gvDiem.GetRowCellValue(i, gvDiem.Columns[tongSoCot - 2]).ToString();
                    if (str != "")
                    {
                        tongKetTheoKy.MaHanhKiem = str;
                    }
                    str = gvDiem.GetRowCellValue(i, gvDiem.Columns[tongSoCot - 1]).ToString();
                    if (str != "")
                    {
                        tongKetTheoKy.MaDanhHieu = str;
                    }
                    DB.SubmitChanges();
                }
            }            
        }

        public static void TinhDiemTrungBinh(string maHocKy, string maLop, string maMonHoc)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            List<DSLoaiDiem> LoaiDiems = DSLoaiDiemBLL.LoadAll();
            string[] maHocSinhTheoLops = DSHocSinhTheoLopBLL.MaHocSinhTheoLopKy(maLop, maHocKy);
            if (DSMonHocBLL.LaChoDiem(maMonHoc)==true)
            {
                foreach (string maHocSinh in maHocSinhTheoLops)
                {
                    double? TongDiem = 0;
                    int? TongHeSo = 0;
                    foreach (DSLoaiDiem LoaiDiem in LoaiDiems)
                    {
                        if (LoaiDiem.TinhToan == true)
                        {
                            double?[] Diems = LoadDSDiem(maHocKy, maMonHoc, maHocSinh, LoaiDiem.MaLoaiDiem);
                            TongDiem += Diems.Sum() * LoaiDiem.HeSo;
                            TongHeSo += Diems.Count() * LoaiDiem.HeSo;
                        }
                    }                    
                    string maLoaiDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                    DSDiem Diem = DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiemTongHop && q.MaHocSinh == maHocSinh).FirstOrDefault();
                    if (TongHeSo == 0)
                        Diem.Diem = -1;
                    else
                    {
                        if (Diem.NgayCapNhat == null)
                            Diem.NgayCapNhat = DateTime.Today;
                        Diem.Diem = Math.Round((double)(TongDiem / TongHeSo), 1, MidpointRounding.AwayFromZero);
                        Diem.NgayChinhSua = DateTime.Today;
                    }                        
                }
            }else
            {
                foreach (string maHocSinh in maHocSinhTheoLops)
                {
                    int TongSoDat = 0;
                    int TongSoBaiKT = 0;
                    foreach (DSLoaiDiem LoaiDiem in LoaiDiems)
                    {
                        if (LoaiDiem.TinhToan == true)
                        {
                            double?[] Diems = LoadDSDiem(maHocKy, maMonHoc, maHocSinh, LoaiDiem.MaLoaiDiem);
                            foreach (double? diem in Diems)
                            {
                                if (diem == -2)
                                {
                                    TongSoDat++;
                                }
                            }
                            TongSoBaiKT += Diems.Count();
                        }
                    }                    
                    DSDiem DiemHK = DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.DSLoaiDiem.LaHocKy == true && q.MaHocSinh == maHocSinh).FirstOrDefault();
                    string maLoaiDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                    DSDiem Diem = DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiemTongHop && q.MaHocSinh == maHocSinh).FirstOrDefault();
                    if (TongSoBaiKT == 0)
                        Diem.Diem = -1;
                    else
                    {
                        if (Diem.NgayCapNhat == null)
                            Diem.NgayCapNhat = DateTime.Today;
                        if (((float)TongSoDat / TongSoBaiKT) >= (0.6666) && (DiemHK.Diem == -2))
                            Diem.Diem = -2;
                        else
                            Diem.Diem = -3;
                        Diem.NgayChinhSua = DateTime.Today;
                    }
                        
                }
            }
            
            DB.SubmitChanges();

            if (DSHocKyBLL.LaTongHop(maHocKy) == true)
            {
                string[] dsMaHSChuyenTruongVNEN = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruongVNEN();                
                string maDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
                List<DSHocKy> HocKies = DSHocKyBLL.LayHocKyHocTap();
                string[] maHocKyHocTap = HocKies.Select(q => q.MaHocKy).ToArray();
                //List<DSLop> Lops = DSLopBLL.LoadAll();
                string[] MaHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(maLop);
                foreach (string maHocSinh in MaHocSinhTheoLop)
                {
                    List<DSDiem> Diems;
                    if (dsMaHSChuyenTruongVNEN.Contains(maHocSinh))
                    {
                        Diems = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && q.MaHocKy == "K2").ToList();
                    }
                    else
                    {
                        Diems = DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maDiemTongHop && maHocKyHocTap.Contains(q.MaHocKy)).ToList();
                    }
                        
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
                    if (DSMonHocBLL.LaChoDiem(maMonHoc) == false)
                        trungBinh = Math.Round((double)trungBinh, 0);
                    DiemTongHop.Diem = trungBinh;
                }
                DB.SubmitChanges();
            }            
        }

        public static List<DSDiem> TruyVanDiemTongHop(string maHocKy, string maHocSinh)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string maDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
            return DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaLoaiDiem == maDiemTongHop && q.MaHocSinh == maHocSinh).ToList();
        }

        public static List<DSDiem> LayDiemTB(string maHocSinh, string maHocKy, string maLoaiDiem)
        {
            return DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaHocKy == maHocKy && q.MaLoaiDiem == maLoaiDiem).ToList();
        }

        public static bool KiemTraDuLieu(string maLop, string maHocKy, string maMonHoc)
        {
            string maNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
            string maDiemTongHop = DSLoaiDiemBLL.LoadMaLoaiDiemTongHop();
            string[] maHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(maLop);
            List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaNamHoc == maNamHoc && q.MaHocKy == maHocKy && q.MaLoaiDiem == maDiemTongHop && maHocSinhTheoLop.Contains(q.MaHocSinh) && q.MaMonHoc == maMonHoc).ToList();
            foreach (DSDiem Diem in Diems)
                if ((Diem.Diem == null))
                    return false;
            return true;
        }

        public static List<DSDiem> LayDiemTheoHocSinhKy(string maHocSinh, string maHocKy)
        {
            return DB.DSDiems.Where(q => q.MaHocSinh == maHocSinh && q.MaHocKy == maHocKy).ToList();
        }

        public static void KiemTraNhapDiemTheoThang(string noiDung, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            List<DSGiaoVien> GiaoVienChuaNhapDiem = new List<DSGiaoVien>();
            DSThang Thang = DSThangBLL.LayThangHienTai();
            if (Thang != null)
            {
                Connect("COM1", 9600, 8, 400, 300);
                List<DSGiaoVien> GiaoViens = DB.DSGiaoViens.ToList();
                pgbTienTrinh.Properties.Minimum = 0;
                pgbTienTrinh.Properties.Maximum = GiaoViens.Count;
                pgbTienTrinh.Properties.Step = 1;
                List<PhanCongGiangDay> PhanCongGiangDays = DB.PhanCongGiangDays.Where(q => q.MaHocKy == Thang.MaHocKy).ToList();
                List<DSDiem> Diems = DB.DSDiems.Where(q => q.NgayCapNhat.Value.Month == Thang.ThoiGianGui.Value.Month).ToList();                
                foreach (DSGiaoVien GiaoVien in GiaoViens)
                {
                    int dem = 0;
                    List<PhanCongGiangDay> PhanCongGiangDayTheoGV = PhanCongGiangDays.Where(q => q.MaGiaoVien == GiaoVien.MaGiaoVien).ToList();
                    foreach (PhanCongGiangDay PhanCongGiangDay in PhanCongGiangDayTheoGV)
                    {
                        string[] DSMaHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(PhanCongGiangDay.MaLop);
                        dem += Diems.Where(q => DSMaHocSinhTheoLop.Contains(q.MaHocSinh) && q.MaMonHoc == PhanCongGiangDay.MaMonHoc).Count();
                    }
                    if ((dem == 0) && (PhanCongGiangDayTheoGV.Count > 0))
                    {
                        if (GiaoVien.DienThoai.Trim().Length >= 10)
                        {
                            string HoVaTen = UTL.Ultils.ConvertToUnSign(GiaoVien.HoDem).Replace("-"," ") + " " + UTL.Ultils.ConvertToUnSign(GiaoVien.Ten).Replace("-","");                            
                            string NoiDungSMS = noiDung.Replace("{HoVaTen}", HoVaTen);
                            //UTL.Ultils.ThongBao(GiaoVien.HoDem + " " + GiaoVien.Ten, MessageBoxIcon.Asterisk);
                            //objclsSMS.SendMsg(port, GiaoVien.DienThoai.Trim(), NoiDungSMS);                        
                            //UTL.Ultils.ThongBao(NoiDungSMS + GiaoVien.DienThoai.Trim(), MessageBoxIcon.Error);
                            //Thread.Sleep(10000);
                        }                        
                    }
                    UTL.Ultils.ThongBao(GiaoVien.HoDem + GiaoVien.Ten + "-" + dem + "-" + GiaoVien.DienThoai.Trim(), MessageBoxIcon.Error);
                    pgbTienTrinh.PerformStep();
                    pgbTienTrinh.Update();                      
                }
                objclsSMS.SendMsg(port,"0982527337", "Done");
                try
                {
                    objclsSMS.ClosePort(port);
                }
                catch (Exception ex)
                {
                    UTL.Ultils.ThongBao(ex.Message.ToString(), System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }

        public static DataTable TaoSMSGiaoVienChuaNhapDiemTheoThang(string noiDung, string maNhaMang)
        {
            DMNhaMang nhaMang = DB.DMNhaMangs.Where(q => q.MaNhaMang == maNhaMang).FirstOrDefault();
            string[] dauSos = nhaMang.DauSo.Split('#');

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("STT", typeof(int)));
            dataTable.Columns.Add(new DataColumn("SoDienThoai", typeof(string)));
            dataTable.Columns.Add(new DataColumn("NoiDungSMS", typeof(string)));
            List<DSGiaoVien> GiaoVienChuaNhapDiem = new List<DSGiaoVien>();
            DSThang Thang = DSThangBLL.LayThangHienTai();
            if (Thang != null)
            {
                int stt = 0;   
                List<DSGiaoVien> GiaoViens = DB.DSGiaoViens.ToList();                
                List<PhanCongGiangDay> PhanCongGiangDays = DB.PhanCongGiangDays.Where(q => q.MaHocKy == Thang.MaHocKy).ToList();
                List<DSDiem> Diems = DB.DSDiems.Where(q => q.NgayCapNhat.Value.Month == Thang.ThoiGianGui.Value.Month).ToList();
                foreach (DSGiaoVien GiaoVien in GiaoViens)
                {
                    int dem = 0;
                    List<PhanCongGiangDay> PhanCongGiangDayTheoGV = PhanCongGiangDays.Where(q => q.MaGiaoVien == GiaoVien.MaGiaoVien).ToList();
                    foreach (PhanCongGiangDay PhanCongGiangDay in PhanCongGiangDayTheoGV)
                    {
                        string[] DSMaHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLop(PhanCongGiangDay.MaLop);
                        dem += Diems.Where(q => DSMaHocSinhTheoLop.Contains(q.MaHocSinh) && q.MaMonHoc == PhanCongGiangDay.MaMonHoc).Count();
                    }
                    if ((dem == 0) && (PhanCongGiangDayTheoGV.Count > 0))
                    {
                        if (GiaoVien.DienThoai.Trim().Length >= 10)
                        {
                            DataRow row = dataTable.NewRow();
                            row[0] = ++stt;
                            row[1] = "84" + GiaoVien.DienThoai.Substring(1, GiaoVien.DienThoai.Length - 1);
                            string HoVaTen = UTL.Ultils.ConvertToUnSign(GiaoVien.HoDem).Replace("-", " ") + " " + UTL.Ultils.ConvertToUnSign(GiaoVien.Ten).Replace("-", "");
                            row[2] = noiDung.Replace("{HoVaTen}", HoVaTen);   
                            if (nhaMang.TatCa != true)
                            {
                                bool thuocMang = false;
                                foreach (string dauSo in dauSos)
                                    if (row[1].ToString().StartsWith(dauSo))
                                    {
                                        thuocMang = true;
                                        break;
                                    }
                                if (thuocMang == true)
                                    dataTable.Rows.Add(row);
                            } else                                                                          
                                dataTable.Rows.Add(row);
                        }
                    }                    
                }               
            }            
            return dataTable;
        }

        private static void Connect(string comPort, int baudRate, int dataBit, int readTimeout, int writeTimeout)
        {
            try
            {
                //Open communication port 
                port = objclsSMS.OpenPort(comPort, baudRate, dataBit, readTimeout, writeTimeout);
                if (port != null)
                {
                    //UTL.Ultils.ThongBao("Kết nối thành công với modem ở cổng " + comPort + ".", MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Invalid port settings");
                    UTL.Ultils.ThongBao("Thiết lập cổng chưa đúng.", System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UTL.Ultils.ThongBao("Chưa kết nối được đến Modem GSM.\r\nLỗi: " + ex.ToString(), System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Dùng để kiểm tra việc nhập điểm Học kỳ của tất cả các môn học trong một lớp
        /// dựa trên Mã học kỳ và Tên đăng nhập (ứng với Giáo viên chủ nhiệm)
        /// </summary>
        /// <returns>
        /// Trả về True nếu tất cả các điểm học kỳ đã được nhập
        /// Trả về False nếu có một phần điểm chưa được nhập
        /// </returns>
        public static bool KiemTraNhapDiemHocKyCacMonHoc(string maHocKy, string tenDangNhap, ref string danhSachMon)
        {
            string[] dsMaHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
            string[] dsMaHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");
            bool co = true;
            string maLop = DSLopBLL.LaGVCN(tenDangNhap);
            string maLoaiDiem = DSLoaiDiemBLL.LoadMaDiemHocKy();
            List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocTheoLopKy(maLop, maHocKy);
            List<DSHocSinh> HocSinhs;
            if (maLop != null)
                HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && !dsMaHSChuyenTruong.Contains(q.MaHocSinh) && !dsMaHSThoiHoc.Contains(q.MaHocSinh)).Select(q => q.DSHocSinh).ToList();
            else
                HocSinhs = DB.DSHocSinhTheoLops.Where(q => !dsMaHSChuyenTruong.Contains(q.MaHocSinh) && !dsMaHSThoiHoc.Contains(q.MaHocSinh)).Select(q => q.DSHocSinh).ToList();
            string[] MaHocSinhs = HocSinhs.Select(q => q.MaHocSinh).ToArray();
            foreach(DSMonHoc MonHoc in MonHocs)
            {
                int soDiemChuaNhap = DB.DSDiems.Where(q => MaHocSinhs.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == maLoaiDiem && q.Diem == -1).Count();
                if ((soDiemChuaNhap > 0) && (MonHoc.MaMonHoc != "MH15"))
                {
                    danhSachMon += " " + MonHoc.TenMonHoc;
                    co = false;
                }
            }
            danhSachMon.Trim();
            return co;
        }

        public static bool KiemTraNhapDiemHocKyCacMonHocToanTruong(string maHocKy, string tenDangNhap, ref string danhSachMon)
        {
            bool co = true;            
            List<DSLop> Lops = DB.DSLops.ToList();
            string maLoaiDiem = DSLoaiDiemBLL.LoadMaDiemHocKy();
            foreach(DSLop Lop in Lops)
            {
                danhSachMon += "\r\n" + Lop.TenLop + ": ";
                List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocTheoLopKy(Lop.MaLop, maHocKy);
                List<DSHocSinh> HocSinhs;
                if (Lop.MaLop != null)
                    HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == Lop.MaLop).Select(q => q.DSHocSinh).ToList();
                else
                    HocSinhs = DSHocSinhBLL.LoadAll();
                string[] MaHocSinhs = HocSinhs.Select(q => q.MaHocSinh).ToArray();
                foreach (DSMonHoc MonHoc in MonHocs)
                {
                    int soDiemChuaNhap = DB.DSDiems.Where(q => MaHocSinhs.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == maLoaiDiem && q.Diem == -1).Count();
                    if ((soDiemChuaNhap > 0) && (MonHoc.MaMonHoc != "MH15"))
                    {
                        danhSachMon += " " + MonHoc.TenMonHoc;
                        co = false;
                    }
                }
            }            
            danhSachMon.Trim();
            return co;
        }

        /// <summary>
        /// Dùng để kiểm tra việc nhập điểm Học kỳ của các môn học được tính hệ số trong TBC trong một lớp
        /// dựa trên Mã học kỳ và Tên đăng nhập (ứng với Giáo viên chủ nhiệm)
        /// </summary>
        /// <returns>
        /// Trả về True nếu tất cả các điểm học kỳ đã được nhập
        /// Trả về False nếu có một phần điểm chưa được nhập
        /// </returns>
        public static bool KiemTraNhapDiemHocKyCacMonHocDuocTinhTBC(string maHocKy, string tenDangNhap, ref string danhSachMon)
        {
            string[] maDSHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHocSinhChuyenTruongTheoKy(true, maHocKy);
            string[] maDSHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHocSinhThoiHocTheoKy(2, maHocKy);
            bool co = true;
            string maLop = DSLopBLL.LaGVCN(tenDangNhap);
            string maLoaiDiem = DSLoaiDiemBLL.LoadMaDiemHocKy();
            List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocDuocTinhHeSoTheoLopKy(maLop, maHocKy);
            List<DSHocSinh> HocSinhs;
            if (maLop != null)
                HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == maLop && !maDSHSChuyenTruong.Contains(q.MaHocSinh) && !maDSHSThoiHoc.Contains(q.MaHocSinh)).Select(q => q.DSHocSinh).ToList();
            else
                HocSinhs = DB.DSHocSinhTheoLops.Where(q => !maDSHSChuyenTruong.Contains(q.MaHocSinh) && !maDSHSThoiHoc.Contains(q.MaHocSinh)).Select(q => q.DSHocSinh).ToList();
            string[] MaHocSinhs = HocSinhs.Select(q => q.MaHocSinh).ToArray();
            foreach (DSMonHoc MonHoc in MonHocs)
            {
                int soDiemChuaNhap = DB.DSDiems.Where(q => MaHocSinhs.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == maLoaiDiem && q.Diem == -1).Count();
                if (soDiemChuaNhap > 0)
                {
                    danhSachMon += " " + MonHoc.TenMonHoc;
                    co = false;
                }
            }
            danhSachMon.Trim();
            return co;
        }

        public static bool KiemTraNhapDiemHocKyCacMonHocDuocTinhTBCToanTruong(string maHocKy, string tenDangNhap, ref string danhSachMon)
        {
            bool co = true;
            List<DSLop> Lops = DB.DSLops.ToList();
            string maLoaiDiem = DSLoaiDiemBLL.LoadMaDiemHocKy();
            foreach(DSLop Lop in Lops)
            {
                danhSachMon += "\r\n" + Lop.TenLop + ": ";
                List<DSMonHoc> MonHocs = DSMonHocBLL.LayMonHocDuocTinhHeSoTheoLopKy(Lop.MaLop, maHocKy);
                List<DSHocSinh> HocSinhs;
                if (Lop.MaLop != null)
                    HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.MaLop == Lop.MaLop).Select(q => q.DSHocSinh).ToList();
                else
                    HocSinhs = DSHocSinhBLL.LoadAll();
                string[] MaHocSinhs = HocSinhs.Select(q => q.MaHocSinh).ToArray();
                foreach (DSMonHoc MonHoc in MonHocs)
                {
                    int soDiemChuaNhap = DB.DSDiems.Where(q => MaHocSinhs.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == maLoaiDiem && q.Diem == -1).Count();
                    if (soDiemChuaNhap > 0)
                    {
                        danhSachMon += " " + MonHoc.TenMonHoc;
                        co = false;
                    }
                }
                danhSachMon.Trim();
            }
            
            return co;
        }
    }
}
