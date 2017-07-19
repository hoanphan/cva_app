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
    public partial class rptTongKetCacKy : DevExpress.XtraReports.UI.XtraReport
    {        
        public rptTongKetCacKy(string maLop, string maKhoi, bool tongHopTheoKhoi)
        {
            InitializeComponent();
            TaoTable(maLop, maKhoi);                                 
            if (tongHopTheoKhoi == true)
            {
                //lbTitle.Text = "BẢNG ĐIỂM TỔNG KẾT THEO KHỐI";
                lbNhanLopKhoi.Text = "Khối: ";
                lbLopKhoi.Text = DSKhoiBLL.LayTenKhoiTheoMaKhoi(maKhoi);
                lbNhanGVCN.Text = "Hiệu trưởng";
                lbGVCN.Text = "ThS. Nguyễn Thanh Tùng";
                lbNamHoc.Text = DSNamHocBLL.LayTenNamHocHienTai();
            }else
            {                
                lbLopKhoi.Text = DSLopBLL.LayTenLopTheoMaLop(maLop);
                lbGVCN.Text = DSGiaoVienBLL.LayTenGVCN(maLop);
            }            
            int SLDanhHieu = DMDanhHieuBLL.SoDanhHieuKhenThuong();
            string[] TenDanhHieu = new string[SLDanhHieu];
            int[] SoLuongDanhHieu = new int[SLDanhHieu];
            double[] PhanTramDanhHieu = new double[SLDanhHieu];

            int SLHocLuc = DMHocLucBLL.SoLuongHocLuc();
            string[] TenHocLuc = new string[SLHocLuc];
            int[] SoLuongHocLuc = new int[SLHocLuc];
            double[] PhanTramHocLuc = new double[SLHocLuc];

            int SLHanhKiem = DMHanhKiemBLL.SoLuongHanhKiem();
            string[] TenHanhKiem = new string[SLHanhKiem];
            int[] SoLuongHanhKiem = new int[SLHanhKiem];
            double[] PhanTramHanhKiem = new double[SLHanhKiem];

            this.DataSource = DSTongKetTheoKyBLL.LayDuLieuTongKetCacKy(maLop, maKhoi);

            DSTongKetTheoKyBLL.ThongKeSoLieuTheoKy(maLop, "K3", maKhoi, ref TenDanhHieu, ref SoLuongDanhHieu, ref PhanTramDanhHieu, ref TenHocLuc,
                ref SoLuongHocLuc, ref PhanTramHocLuc, ref TenHanhKiem, ref SoLuongHanhKiem, ref PhanTramHanhKiem);
            for(byte i = 0; i < TenDanhHieu.Count(); i++)
            {
                XRTableCell cellHeaderTenDanhHieu = new XRTableCell();
                cellHeaderTenDanhHieu.Text = TenDanhHieu[i];
                cellHeaderTenDanhHieu.Weight = 1.5D;
                tableRowHeaderDanhHieu.Cells.Add(cellHeaderTenDanhHieu);
                XRTableCell cellSoLuongDanhHieu = new XRTableCell();
                if (maKhoi == null)
                    cellSoLuongDanhHieu.Text = SoLuongDanhHieu[i].ToString() + "/" + DSLopBLL.LaySiSoTheoLop(maLop);
                else
                    cellSoLuongDanhHieu.Text = SoLuongDanhHieu[i].ToString() + "/" + DSKhoiBLL.LaySiSoTheoKhoi(maKhoi);
                cellSoLuongDanhHieu.Weight = 1.5D;
                tableRowSoLuongDanhHieu.Cells.Add(cellSoLuongDanhHieu);
                XRTableCell cellPhanTramDanhHieu = new XRTableCell();
                cellPhanTramDanhHieu.Text = PhanTramDanhHieu[i].ToString();
                cellPhanTramDanhHieu.Weight = 1.5D;
                tableRowPhanTramDanhHieu.Cells.Add(cellPhanTramDanhHieu);
            }
            for (byte i = 0; i < TenHocLuc.Count(); i++)
            {
                XRTableCell cellHeaderTenHocLuc = new XRTableCell();
                cellHeaderTenHocLuc.Text = TenHocLuc[i];
                cellHeaderTenHocLuc.Weight = 1.5D;
                tableRowHeaderHocLuc.Cells.Add(cellHeaderTenHocLuc);
                XRTableCell cellSoLuongHocLuc = new XRTableCell();
                if (maKhoi == null)
                    cellSoLuongHocLuc.Text = SoLuongHocLuc[i].ToString() + "/" + DSLopBLL.LaySiSoTheoLop(maLop);
                else
                    cellSoLuongHocLuc.Text = SoLuongHocLuc[i].ToString() + "/" + DSKhoiBLL.LaySiSoTheoKhoi(maKhoi);
                cellSoLuongHocLuc.Weight = 1.5D;
                tableRowSoLuongHocLuc.Cells.Add(cellSoLuongHocLuc);
                XRTableCell cellPhanTramHocLuc = new XRTableCell();
                cellPhanTramHocLuc.Text = PhanTramHocLuc[i].ToString();
                cellPhanTramHocLuc.Weight = 1.5D;
                tableRowPhanTramHocLuc.Cells.Add(cellPhanTramHocLuc);
            }
            for (byte i = 0; i < TenHanhKiem.Count(); i++)
            {
                XRTableCell cellHeaderTenHanhKiem = new XRTableCell();
                cellHeaderTenHanhKiem.Text = TenHanhKiem[i];
                cellHeaderTenHanhKiem.Weight = 1.5D;
                tableRowHeaderHanhKiem.Cells.Add(cellHeaderTenHanhKiem);
                XRTableCell cellSoLuongHanhKiem = new XRTableCell();
                if (maKhoi == null)
                    cellSoLuongHanhKiem.Text = SoLuongHanhKiem[i].ToString() + "/" + DSLopBLL.LaySiSoTheoLop(maLop);
                else
                    cellSoLuongHanhKiem.Text = SoLuongHanhKiem[i].ToString() + "/" + DSKhoiBLL.LaySiSoTheoKhoi(maKhoi);
                cellSoLuongHanhKiem.Weight = 1.5D;
                tableRowSoLuongHanhKiem.Cells.Add(cellSoLuongHanhKiem);
                XRTableCell cellPhanTramHanhKiem = new XRTableCell();
                cellPhanTramHanhKiem.Text = PhanTramHanhKiem[i].ToString();
                cellPhanTramHanhKiem.Weight = 1.5D;
                tableRowPhanTramHanhKiem.Cells.Add(cellPhanTramHanhKiem);
            } 
        }

        private void TaoTable(string maLop, string maKhoi)
        {
            //Add Tiêu đề
            XRTableCell cellHeaderMaHocSinh = new XRTableCell();
            cellHeaderMaHocSinh.Text = "Mã HS";
            cellHeaderMaHocSinh.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderMaHocSinh);
            XRTableCell cellHeaderHoVaTen = new XRTableCell();
            cellHeaderHoVaTen.Text = "Họ và tên";
            cellHeaderHoVaTen.Weight = 3D;
            tableRowHeader.Cells.Add(cellHeaderHoVaTen);
            XRTableCell cellHeaderNgaySinh = new XRTableCell();
            cellHeaderNgaySinh.Text = "Ngày sinh";
            cellHeaderNgaySinh.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderNgaySinh);

            if (maKhoi != null)
            {
                XRTableCell cellHeaderLop = new XRTableCell();
                cellHeaderLop.Text = "Lớp";
                cellHeaderLop.Weight = 1D;
                tableRowHeader.Cells.Add(cellHeaderLop);
            }

            //Add nội dung các cột
            XRTableCell cellMaHocSinh = new XRTableCell();
            cellMaHocSinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MaHocSinh")});
            cellMaHocSinh.Weight = 1.5D;
            this.tableRowContent.Cells.Add(cellMaHocSinh);
            XRTableCell cellHoVaTen = new XRTableCell();
            cellHoVaTen.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "HoVaTen")});
            cellHoVaTen.Weight = 3D;
            this.tableRowContent.Cells.Add(cellHoVaTen);
            XRTableCell cellNgaySinh = new XRTableCell();
            cellNgaySinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NgaySinh")});
            cellNgaySinh.Weight = 1.5D;
            this.tableRowContent.Cells.Add(cellNgaySinh);

            if (maKhoi != null)
            {
                XRTableCell cellLop = new XRTableCell();
                cellLop.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Lop")});
                cellLop.Weight = 1D;
                this.tableRowContent.Cells.Add(cellLop);
            }

            //Add nội dung cột Trung bình kỳ 1
            XRTableCell cellTrungBinhKy1 = new XRTableCell();
            cellTrungBinhKy1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TBCK1")});
            cellTrungBinhKy1.Weight = 1D;
            cellTrungBinhKy1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableRowContent.Cells.Add(cellTrungBinhKy1);

            //Add Tiêu đề cột Trung bình kỳ 1
            XRTableCell cellHeaderTrungBinhKy1 = new XRTableCell();
            cellHeaderTrungBinhKy1.Text = "TBC Kỳ 1";
            cellHeaderTrungBinhKy1.Weight = 1D;
            tableRowHeader.Cells.Add(cellHeaderTrungBinhKy1);

            //Add nội dung cột Trung bình kỳ 1
            XRTableCell cellTrungBinhKy2 = new XRTableCell();
            cellTrungBinhKy2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TBCK2")});
            cellTrungBinhKy2.Weight = 1D;
            cellTrungBinhKy2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableRowContent.Cells.Add(cellTrungBinhKy2);

            //Add Tiêu đề cột Trung bình kỳ 1
            XRTableCell cellHeaderTrungBinhKy2 = new XRTableCell();
            cellHeaderTrungBinhKy2.Text = "TBC Kỳ 2";
            cellHeaderTrungBinhKy2.Weight = 1D;
            tableRowHeader.Cells.Add(cellHeaderTrungBinhKy2);
            
            XRTableCell cellTrungBinh = new XRTableCell();
            cellTrungBinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TBCCaNam")});
            cellTrungBinh.Weight = 1D;            
            cellTrungBinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);            
            this.tableRowContent.Cells.Add(cellTrungBinh);

            //Add Tiêu đề cột Trung bình cộng
            XRTableCell cellHeaderTrungBinh = new XRTableCell();
            cellHeaderTrungBinh.Text = "TBC cả năm";
            cellHeaderTrungBinh.Weight = 1D;
            tableRowHeader.Cells.Add(cellHeaderTrungBinh);

            //Add nội dung cột Học lực
            XRTableCell cellHocLuc = new XRTableCell();
            cellHocLuc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "HocLuc")});
            cellHocLuc.Weight = 1.5D;
            cellHocLuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableRowContent.Cells.Add(cellHocLuc);

            //Add Tiêu đề cột Học lực
            XRTableCell cellHeaderHocLuc = new XRTableCell();
            cellHeaderHocLuc.Text = "Học lực";
            cellHeaderHocLuc.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderHocLuc);

            //Add nội dung cột Hạnh kiểm
            XRTableCell cellHanhKiem = new XRTableCell();
            cellHanhKiem.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "HanhKiem")});
            cellHanhKiem.Weight = 1.5D;                                  
            this.tableRowContent.Cells.Add(cellHanhKiem);

            //Add Tiêu đề cột Hạnh kiểm
            XRTableCell cellHeaderHanhKiem = new XRTableCell();
            cellHeaderHanhKiem.Text = "Hạnh kiểm";
            cellHeaderHanhKiem.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderHanhKiem);

            //Add nội dung cột Danh hiệu
            XRTableCell cellDanhHieu = new XRTableCell();
            cellDanhHieu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DanhHieu")});
            cellDanhHieu.Weight = 1.5D;
            this.tableRowContent.Cells.Add(cellDanhHieu);

            //Add Tiêu đề cột Danh hiệu
            XRTableCell cellHeaderDanhHieu = new XRTableCell();
            cellHeaderDanhHieu.Text = "Danh hiệu";
            cellHeaderDanhHieu.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderDanhHieu);

            for (byte i = 0; i < tableRowContent.Cells.Count; i++)
            {
                tableRowContent.Cells[i].BorderWidth = 1;
                tableRowHeader.Cells[i].BorderWidth = 1;
                tableRowHeader.Cells[i].Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                tableRowContent.Cells[i].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowHeader.Cells[i].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowContent.Cells[i].Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            }
            //tableTongKet.InsertColumnToRight(cellMaHocSinh);
        }

    }
}
