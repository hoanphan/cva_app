using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using BLL;
using System.Data;

namespace PRL
{
    public partial class rptBangDiemTheoMon : DevExpress.XtraReports.UI.XtraReport
    {
        int SLHocLuc = DMHocLucTheoDiemThiBLL.SoLuongHocLuc();
        string[] TenHocLuc;
        int[] SoLuongHocLuc;
        double[] PhanTramHocLuc;

        public rptBangDiemTheoMon(string maLop, string maHocKy, string maMonHoc)
        {
            InitializeComponent();
            TaoTable(maLop, maHocKy);
            lbHocKy.Text = DSHocKyBLL.LayTenHocKyTheoMa(maHocKy);
            lbLop.Text = DSLopBLL.LayTenLopTheoMaLop(maLop);
            lbGiaoVienBoMon.Text = PhanCongGiangDayBLL.TenGiaoVienTheoMon(maHocKy, maLop, maMonHoc);
            lbNamHoc.Text = DSNamHocBLL.LayTenNamHocHienTai();
            lbMonHoc.Text = DSMonHocBLL.TenMonHocTheoMa(maMonHoc);
            this.DataSource = DSDiemBLL.TruyVanDSDiem(maLop, maHocKy, maMonHoc);
            //this.DataSource = DSTongKetTheoKyBLL.LayDuLieuTongKetTheoKy(maLop, maHocKy);  

            //Thống kê theo điểm học kỳ
            TenHocLuc = new string[SLHocLuc];
            SoLuongHocLuc = new int[SLHocLuc];
            PhanTramHocLuc = new double[SLHocLuc];
            int TongSo = 0;
            ThongKeBLL.ThongKeTheoDiemThiTungMon(maLop, maHocKy, maMonHoc, ref TenHocLuc, ref SoLuongHocLuc, ref PhanTramHocLuc, ref TongSo, true);

            for (byte i = 0; i < TenHocLuc.Count(); i++)
            {
                XRTableCell cellHeaderTenHocLuc = new XRTableCell();
                cellHeaderTenHocLuc.Text = TenHocLuc[i];
                cellHeaderTenHocLuc.Weight = 1.5D;
                tableRowHeaderHocLuc.Cells.Add(cellHeaderTenHocLuc);
                XRTableCell cellSoLuongHocLuc = new XRTableCell();
                cellSoLuongHocLuc.Text = SoLuongHocLuc[i].ToString() + "/" + TongSo.ToString();               
                cellSoLuongHocLuc.Weight = 1.5D;
                tableRowSoLuongHocLuc.Cells.Add(cellSoLuongHocLuc);
                XRTableCell cellPhanTramHocLuc = new XRTableCell();
                cellPhanTramHocLuc.Text = PhanTramHocLuc[i].ToString();
                cellPhanTramHocLuc.Weight = 1.5D;
                tableRowPhanTramHocLuc.Cells.Add(cellPhanTramHocLuc);
            }

            TenHocLuc = new string[SLHocLuc];
            SoLuongHocLuc = new int[SLHocLuc];
            PhanTramHocLuc = new double[SLHocLuc];
            TongSo = 0;
            ThongKeBLL.ThongKeTheoDiemThiTungMon(maLop, maHocKy, maMonHoc, ref TenHocLuc, ref SoLuongHocLuc, ref PhanTramHocLuc, ref TongSo, false);

            for (byte i = 0; i < TenHocLuc.Count(); i++)
            {
                XRTableCell cellHeaderTenHocLucTBC = new XRTableCell();
                cellHeaderTenHocLucTBC.Text = TenHocLuc[i];
                cellHeaderTenHocLucTBC.Weight = 1.5D;
                tableRowHeaderHocLucTBC.Cells.Add(cellHeaderTenHocLucTBC);
                XRTableCell cellSoLuongHocLucTBC = new XRTableCell();
                cellSoLuongHocLucTBC.Text = SoLuongHocLuc[i].ToString() + "/" + TongSo.ToString();
                cellSoLuongHocLucTBC.Weight = 1.5D;
                tableRowSoLuongHocLucTBC.Cells.Add(cellSoLuongHocLucTBC);
                XRTableCell cellPhanTramHocLucTBC = new XRTableCell();
                cellPhanTramHocLucTBC.Text = PhanTramHocLuc[i].ToString();
                cellPhanTramHocLucTBC.Weight = 1.5D;
                tableRowPhanTramHocLucTBC.Cells.Add(cellPhanTramHocLucTBC);
            }
        }

        private void TaoTable(string maLop, string maHocKy)
        {
            //Add Tiêu đề
            XRTableCell cellHeaderMaHocSinh = new XRTableCell();
            cellHeaderMaHocSinh.Text = "Mã HS";
            cellHeaderMaHocSinh.Weight = 1D;            
            tableRowChiTiet.Cells.Add(cellHeaderMaHocSinh);            
            XRTableCell cellHeaderHoVaTen = new XRTableCell();
            cellHeaderHoVaTen.Text = "Họ và tên";
            cellHeaderHoVaTen.Weight = 2.5D;            
            tableRowChiTiet.Cells.Add(cellHeaderHoVaTen);
            XRTableCell cellHeaderNgaySinh = new XRTableCell();
            cellHeaderNgaySinh.Text = "Ngày sinh";
            cellHeaderNgaySinh.Weight = 1.5D;            
            tableRowChiTiet.Cells.Add(cellHeaderNgaySinh);

            //Add Tiêu đề trên
            XRTableCell cellHeaderMaHocSinhAbove = new XRTableCell();
            cellHeaderMaHocSinhAbove.BorderWidth = 1;
            cellHeaderMaHocSinhAbove.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cellHeaderMaHocSinhAbove.Weight = 1D;            
            tableRowHeader.Cells.Add(cellHeaderMaHocSinhAbove);

            XRTableCell cellHeaderHoVaTenAbove = new XRTableCell();
            cellHeaderHoVaTenAbove.BorderWidth = 1;
            cellHeaderHoVaTenAbove.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cellHeaderHoVaTenAbove.Weight = 2.5D;
            tableRowHeader.Cells.Add(cellHeaderHoVaTenAbove);

            XRTableCell cellHeaderNgaySinhAbove = new XRTableCell();
            cellHeaderNgaySinhAbove.BorderWidth = 1;
            cellHeaderNgaySinhAbove.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cellHeaderNgaySinhAbove.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderNgaySinhAbove);

            //Add nội dung các cột
            XRTableCell cellMaHocSinh = new XRTableCell();
            cellMaHocSinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MaHocSinh")});
            cellMaHocSinh.Weight = 1D;
            this.tableRowContent.Cells.Add(cellMaHocSinh);
            XRTableCell cellHoVaTen = new XRTableCell();
            cellHoVaTen.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "HoVaTen")});
            cellHoVaTen.Weight = 2.5D;
            this.tableRowContent.Cells.Add(cellHoVaTen);
            XRTableCell cellNgaySinh = new XRTableCell();
            cellNgaySinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NgaySinh")});
            cellNgaySinh.Weight = 1.5D;
            this.tableRowContent.Cells.Add(cellNgaySinh);

            string[] MaLoaiDiem = DSLoaiDiemBLL.LoadAllMaLoaiDiem();
            string[] TenLoaiDiem = DSLoaiDiemBLL.LoadAllTenLoaiDiem();
            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();
            int colTemp = 4;

            for (byte i = 0; i < TenLoaiDiem.Count(); i++)
            {
                if ((short)SoDiemToiDa.GetValue(i) > 1)
                {                    
                    for (byte j = 0; j < (short)SoDiemToiDa.GetValue(i); j++)
                    {
                        XRTableCell cellDiemCon = new XRTableCell();
                        cellDiemCon.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                            new DevExpress.XtraReports.UI.XRBinding("Text", null, MaLoaiDiem[i] + "_" + (j + 1).ToString())});
                        cellDiemCon.Weight = 0.8D;
                        this.tableRowContent.Cells.Add(cellDiemCon);

                        //Add Tiêu đề các môn học
                        XRTableCell cellHeaderDiemCon = new XRTableCell();
                        cellHeaderDiemCon.Text = HienThi[i] + (j + 1).ToString();
                        cellHeaderDiemCon.Weight = 0.8D;
                        cellHeaderDiemCon.Borders = DevExpress.XtraPrinting.BorderSide.All;
                        tableRowChiTiet.Cells.Add(cellHeaderDiemCon);                        

                        colTemp++;
                    }                    
                }
                //Add Tiêu đề các môn học
                XRTableCell cellHeaderLoaiDiem = new XRTableCell();
                cellHeaderLoaiDiem.Text = TenLoaiDiem[i].ToString();
                cellHeaderLoaiDiem.Weight = 0.8D*(short)SoDiemToiDa.GetValue(i);
                cellHeaderLoaiDiem.Borders = DevExpress.XtraPrinting.BorderSide.All;
                cellHeaderLoaiDiem.BorderWidth = 1;
                cellHeaderLoaiDiem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cellHeaderLoaiDiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                tableRowHeader.Cells.Add(cellHeaderLoaiDiem);        
            }

            for (byte i = 0; i < TenLoaiDiem.Count(); i++)
            {
                if ((short)SoDiemToiDa.GetValue(i) == 1)
                {                    
                    XRTableCell cellDiemCon = new XRTableCell();
                    cellDiemCon.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, MaLoaiDiem[i] + "_" + (1).ToString())});
                    cellDiemCon.Weight = 0.8D;
                    cellDiemCon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                    this.tableRowContent.Cells.Add(cellDiemCon);

                    //Add Tiêu đề các môn học
                    XRTableCell cellHeaderDiemCon = new XRTableCell();
                    cellHeaderDiemCon.Text = HienThi[i];
                    cellHeaderDiemCon.Weight = 0.8D;
                    cellHeaderDiemCon.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    cellHeaderDiemCon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular);
                    tableRowChiTiet.Cells.Add(cellHeaderDiemCon);

                    colTemp++;                    
                }
            }            

            if (maHocKy == "K2")
            {
                //Add nội dung cột TBC Ca nam
                XRTableCell cellTBCCaNam = new XRTableCell();
                cellTBCCaNam.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "TBCCaNam")});
                cellTBCCaNam.Weight = 1D;
                cellTBCCaNam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                this.tableRowContent.Cells.Add(cellTBCCaNam);

                //Add Tiêu đề cột Hạnh kiểm
                XRTableCell cellHeaderTBCCaNam = new XRTableCell();
                cellHeaderTBCCaNam.Text = "TBC Cả năm";
                cellHeaderTBCCaNam.Weight = 1D;
                cellHeaderTBCCaNam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                tableRowChiTiet.Cells.Add(cellHeaderTBCCaNam);

                //Add Tiêu đề trên cột Hạnh kiểm
                XRTableCell cellHeaderTBCCaNamAbove = new XRTableCell();
                cellHeaderTBCCaNamAbove.Text = "";
                cellHeaderTBCCaNamAbove.Weight = 1D;
                tableRowHeader.Cells.Add(cellHeaderTBCCaNamAbove);
            }
                   
            for (byte i = 0; i < tableRowContent.Cells.Count; i++)
            {
                tableRowContent.Cells[i].BorderWidth = 1;
                tableRowChiTiet.Cells[i].BorderWidth = 1;
                tableRowChiTiet.Cells[i].Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                tableRowContent.Cells[i].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowChiTiet.Cells[i].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowContent.Cells[i].Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            }
            //tableTongKet.InsertColumnToRight(cellMaHocSinh);
        }

        private void ThongKe()
        {
            
        }

    }
}
