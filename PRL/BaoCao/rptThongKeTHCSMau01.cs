using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BLL;

namespace PRL
{
    public partial class rptThongKeTHCSMau01 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeTHCSMau01(string maHocKy)
        {
            InitializeComponent();
            generateTable();
            if (maHocKy == "K1")
                lbHocKy.Text = "I";
            else
            {
                if (maHocKy == "K2")
                    lbHocKy.Text = "II";
                else
                {
                    lbChuHocKy.Text = "CẢ NĂM";
                    lbHocKy.Text = "";
                }                
            }
                
            lbNamHoc.Text = DSNamHocBLL.LayTenNamHocHienTai();
            this.DataSource = ThongKeBLL.ThongKeDiemHocKyTHCS(maHocKy, true);
        }

        private void generateTable()
        {
            tableCellContentMon.DataBindings.Add("Text", null, "TenMon");

            //Thêm dòng nội dung Tổng số học sinh
            XRTableCell cellContentTongSo = new XRTableCell();
            cellContentTongSo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "TongSo")});
            cellContentTongSo.Weight = 1D;
            this.tableRowContent.Cells.Add(cellContentTongSo);

            //Thêm dòng tiêu đề            
            tableCellContentMon.Weight = 1D;
            tableCellMonTrong.Weight = 1D;
            XRTableCell cellHeaderTongSoRow1 = new XRTableCell();
            cellHeaderTongSoRow1.Text = "Tổng";            
            cellHeaderTongSoRow1.Weight = 1D;
            this.tableRowHanhKiem.Cells.Add(cellHeaderTongSoRow1);
            XRTableCell cellHeaderTongSoRow2 = new XRTableCell();
            cellHeaderTongSoRow2.Text = "số";            
            cellHeaderTongSoRow2.Weight = 1D;
            this.tableRowTSPhanTram.Cells.Add(cellHeaderTongSoRow2);
            string[] TenHocLucs = DMHocLucBLL.LayTenTatCaHocLuc();
            string[] MaHocLucs = DMHocLucBLL.LayMaTatCaHocLuc();
            for(byte i = 0; i < TenHocLucs.Length; i++)
            {
                XRTableCell cellTenHocLuc = new XRTableCell();
                cellTenHocLuc.Text = TenHocLucs[i];                
                cellTenHocLuc.Weight = 1D;
                this.tableRowHanhKiem.Cells.Add(cellTenHocLuc);
                XRTableCell cellTS = new XRTableCell();
                cellTS.Text = "TS";                
                cellTS.Weight = 0.5D;
                this.tableRowTSPhanTram.Cells.Add(cellTS);
                XRTableCell cellPT = new XRTableCell();
                cellPT.Text = "%";                
                cellPT.Weight = 0.5D;
                this.tableRowTSPhanTram.Cells.Add(cellPT);                
                //Thêm dòng nội dung TSTheoTungLoai
                XRTableCell cellContentTS = new XRTableCell();
                cellContentTS.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, MaHocLucs[i]+"TS")});
                cellContentTS.Weight = 0.5D;
                cellContentTS.Font = new Font(cellContentTS.Font, FontStyle.Bold);
                this.tableRowContent.Cells.Add(cellContentTS);
                //Thêm dòng nội dung %TheoTungLoai
                XRTableCell cellContentPT = new XRTableCell();
                cellContentPT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, MaHocLucs[i]+"PT")});
                cellContentPT.Weight = 0.5D;
                this.tableRowContent.Cells.Add(cellContentPT);
            }
            //Tô đường biên cho dòng tiêu đề
            foreach(XRTableRow row in tableHeader.Rows)
            {
                foreach (XRTableCell cell in row.Cells)
                {
                    cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    cell.Font = new Font(cell.Font, FontStyle.Bold);
                }
            }            
            cellHeaderTongSoRow1.Borders = tableCellHeaderMon.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top |
                                            DevExpress.XtraPrinting.BorderSide.Right;
            cellHeaderTongSoRow2.Borders = tableCellMonTrong.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom |
                                            DevExpress.XtraPrinting.BorderSide.Right;
            //Tô đường biên cho dòng nội dung
            foreach(XRTableCell cell in tableRowContent)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
        }

    }
}
