using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DAL;
using BLL;
using System.Collections.Generic;

namespace PRL
{
    public partial class rptThongKeTHCSMau04 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeTHCSMau04(string maHocKy, bool theoDanToc, bool laTHCS)
        {
            InitializeComponent();
            if (theoDanToc)
                lbTitle.Text = "THỐNG KÊ KẾT QUẢ XẾP LOẠI HỌC LỰC, HẠNH KIỂM HỌC SINH DÂN TỘC HỌC KỲ";
            else
                lbTitle.Text = "THỐNG KÊ KẾT QUẢ XẾP LOẠI HỌC LỰC, HẠNH KIỂM HỌC SINH HỌC KỲ";
            lbNamHoc.Text = DSNamHocBLL.LayTenNamHocHienTai();
            generateTable();
            if (maHocKy == "K1")
                lbHocKy.Text = "I";
            else
            {
                if (maHocKy == "K2")
                    lbHocKy.Text = "II";
                else
                    lbHocKy.Text = "CẢ NĂM";
            }
            lbDonViQuanLy.Text = "PHÒNG GD & ĐT TP SƠN LA";
            if (laTHCS == false)
                lbDonViQuanLy.Text = "SỞ GD & ĐT TỈNH SƠN LA";
            this.DataSource = DSTongKetTheoKyBLL.ThongKeXepLoaiTheoHocLucHanhKiem(maHocKy, theoDanToc, laTHCS); 
        }

        private void generateTable()
        {
            List<DMHanhKiem> HanhKiems = DMHanhKiemBLL.LayTatCaHanhKiem();
            List<DMHocLuc> HocLucs = DMHocLucBLL.LayTatCaHocLuc();

            double rong = 0.5D;
            double rongTo = 1.2D;

            XRTableCell cellHeaderTS1 = new XRTableCell();
            cellHeaderTS1.Weight = rongTo;
            this.tableRowHeader1.Cells.Add(cellHeaderTS1);
            XRTableCell cellHeaderTS2 = new XRTableCell();
            cellHeaderTS2.Text = "Tổng số HS";
            cellHeaderTS2.Weight = rongTo;
            this.tableRowHeader2.Cells.Add(cellHeaderTS2);
            XRTableCell cellHeaderTS3 = new XRTableCell();
            cellHeaderTS3.Weight = rongTo;
            this.tableRowHeader3.Cells.Add(cellHeaderTS3);

            XRTableCell cellHeaderHanhKiem = new XRTableCell();
            cellHeaderHanhKiem.Text = "XẾP LOẠI HẠNH KIỂM";
            cellHeaderHanhKiem.Weight = 5D;
            this.tableRowHeader1.Cells.Add(cellHeaderHanhKiem);

            XRTableCell cellHeaderHocLuc = new XRTableCell();
            cellHeaderHocLuc.Text = "XẾP LOẠI HỌC LỰC";
            cellHeaderHocLuc.Weight = 5D;
            this.tableRowHeader1.Cells.Add(cellHeaderHocLuc);            

            cellHeaderLopTrong1.Weight = rongTo;
            cellHeaderLop.Weight = rongTo;
            cellHeaderLopTrong2.Weight = rongTo;

            tableCellLop.Weight = rongTo;            

            XRTableCell cellTSHS = new XRTableCell();
            cellTSHS.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "TSHS")});
            cellTSHS.Weight = rongTo;
            cellTSHS.Font = new Font(cellTSHS.Font, FontStyle.Bold);               
            this.tableRowContent.Cells.Add(cellTSHS);            
            

            foreach (DMHanhKiem HanhKiem in HanhKiems)
            {
                //Thêm dòng tiêu đề
                XRTableCell cellHeaderLoaiHanhKiem = new XRTableCell();
                cellHeaderLoaiHanhKiem.Text = HanhKiem.TenHanhKiem;
                cellHeaderLoaiHanhKiem.Weight = 2*rong;
                this.tableRowHeader2.Cells.Add(cellHeaderLoaiHanhKiem);

                XRTableCell cellHeaderTSHanhKiem = new XRTableCell();
                cellHeaderTSHanhKiem.Text = "TS";
                cellHeaderTSHanhKiem.Weight = rong;
                this.tableRowHeader3.Cells.Add(cellHeaderTSHanhKiem);

                XRTableCell cellHeaderPTHanhKiem = new XRTableCell();
                cellHeaderPTHanhKiem.Text = "%";
                cellHeaderPTHanhKiem.Weight = rong;
                this.tableRowHeader3.Cells.Add(cellHeaderPTHanhKiem);

                XRTableCell cellThongKe = new XRTableCell();
                cellThongKe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, HanhKiem.MaHanhKiem + "SL")});
                cellThongKe.Weight = rong;
                cellThongKe.Font = new Font(cellThongKe.Font, FontStyle.Bold);
                this.tableRowContent.Cells.Add(cellThongKe);

                cellThongKe = new XRTableCell();
                cellThongKe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, HanhKiem.MaHanhKiem + "PT")});
                cellThongKe.Weight = rong;
                this.tableRowContent.Cells.Add(cellThongKe);
            }

            foreach (DMHocLuc HocLuc in HocLucs)
            {
                XRTableCell cellHeaderLoaiHocLuc = new XRTableCell();
                cellHeaderLoaiHocLuc.Text = HocLuc.TenHocLuc;
                cellHeaderLoaiHocLuc.Weight = 1D;
                this.tableRowHeader2.Cells.Add(cellHeaderLoaiHocLuc);

                XRTableCell cellHeaderTSHocLuc = new XRTableCell();
                cellHeaderTSHocLuc.Text = "TS";
                cellHeaderTSHocLuc.Weight = rong;
                this.tableRowHeader3.Cells.Add(cellHeaderTSHocLuc);

                XRTableCell cellHeaderPTHocLuc = new XRTableCell();
                cellHeaderPTHocLuc.Text = "%";
                cellHeaderPTHocLuc.Weight = rong;
                this.tableRowHeader3.Cells.Add(cellHeaderPTHocLuc);

                XRTableCell cellThongKe = new XRTableCell();
                cellThongKe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, HocLuc.MaHocLuc + "SL")});
                cellThongKe.Weight = rong;
                cellThongKe.Font = new Font(cellThongKe.Font, FontStyle.Bold);
                this.tableRowContent.Cells.Add(cellThongKe);

                cellThongKe = new XRTableCell();
                cellThongKe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, HocLuc.MaHocLuc + "PT")});
                cellThongKe.Weight = rong;                
                this.tableRowContent.Cells.Add(cellThongKe);
            }

            XRTableCell cellHeaderGhiChu1 = new XRTableCell();
            cellHeaderGhiChu1.Weight = rongTo;
            this.tableRowHeader1.Cells.Add(cellHeaderGhiChu1);
            XRTableCell cellHeaderGhiChu2 = new XRTableCell();
            cellHeaderGhiChu2.Text = "Ghi chú";
            cellHeaderGhiChu2.Weight = rongTo;
            this.tableRowHeader2.Cells.Add(cellHeaderGhiChu2);
            XRTableCell cellHeaderGhiChu3 = new XRTableCell();
            cellHeaderGhiChu3.Weight = rongTo;
            this.tableRowHeader3.Cells.Add(cellHeaderGhiChu3);

            XRTableCell cellGhiChu = new XRTableCell();
            cellGhiChu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "GhiChu")});
            cellGhiChu.Weight = rongTo;
            //cellGhiChu.CanGrow = false;
            //cellGhiChu.CanShrink = false;
            cellGhiChu.WordWrap = true;           
            this.tableRowContent.Cells.Add(cellGhiChu);
                           
            foreach(XRTableRow row in tableHeader)
                foreach(XRTableCell cell in row)
                {
                    cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    cell.BackColor = Color.Transparent;
                    cell.Font = new Font(cell.Font, FontStyle.Bold);
                }       
            cellHeaderLopTrong1.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left
                                            | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderLop.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderLopTrong2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left
                                            | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderTS1.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left
                                            | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderTS2.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderTS3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left
                                            | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderGhiChu1.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left
                                            | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderGhiChu2.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderGhiChu3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left
                                            | DevExpress.XtraPrinting.BorderSide.Right;
        }

    }
}
