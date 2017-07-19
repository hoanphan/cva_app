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
    public partial class rptPhanMemCuaBoM1 : DevExpress.XtraReports.UI.XtraReport
    {        
        public rptPhanMemCuaBoM1(string maHocKy, bool laTHCS)
        {
            InitializeComponent();            
            TaoTable(laTHCS);
            this.DataSource = ThongKeBLL.ThongKeTheoDanToc(maHocKy, laTHCS);
            if (maHocKy == "K1")
            {
                lbHocKy.Text = "I";
            }else
            {
                if (maHocKy == "K2")
                    lbHocKy.Text = "II";
                else
                {
                    lbChuHocKy.Text = "CẢ NĂM";
                    lbHocKy.Text = "";
                }
            }
            if (laTHCS == true)
                lbDonViQuanLy.Text = "PHÒNG GD&ĐT THÀNH PHỐ SƠN LA";
            else
                lbDonViQuanLy.Text = "SỞ GD&ĐT TỈNH SƠN LA";
            lbNamHoc.Text = DSNamHocBLL.LayTenNamHocHienTai();

                          
        }

        private void TaoTable(bool laTHCS)
        {
            List<DSKhoi> Khois;
            if (laTHCS == true)
                Khois = DSKhoiBLL.LayKhoiTheoMaCap("CTHCS");
            else
                Khois = DSKhoiBLL.LayKhoiTheoMaCap("CTHPT");
            //Thêm dòng tiêu đề            
            tableCellHeaderDanToc.Weight = 4.5D;
            tableCellHeaderDanTocTrong1.Weight = 4.5D;
            tableCellHeaderDanTocTrong2.Weight = 4.5D;
            XRTableCell cellHeaderTongSo = new XRTableCell();            
            cellHeaderTongSo.Weight = 1.5D;
            cellHeaderTongSo.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left |
                                    DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader1.Cells.Add(cellHeaderTongSo);
            XRTableCell cellHeaderTongSoTrong1 = new XRTableCell();
            cellHeaderTongSoTrong1.Text = "Tổng số";
            cellHeaderTongSoTrong1.Weight = 1.5D;
            cellHeaderTongSoTrong1.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader2.Cells.Add(cellHeaderTongSoTrong1);
            XRTableCell cellHeaderTongSoTrong2 = new XRTableCell();            
            cellHeaderTongSoTrong2.Weight = 1.5D;
            cellHeaderTongSoTrong2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left |
                                    DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader3.Cells.Add(cellHeaderTongSoTrong2);

            XRTableCell cellHeaderNu = new XRTableCell();            
            cellHeaderNu.Weight = 1.5D;
            cellHeaderNu.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left |
                                    DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader1.Cells.Add(cellHeaderNu);
            XRTableCell cellHeaderNuTrong1 = new XRTableCell();
            cellHeaderNuTrong1.Text = "Nữ";
            cellHeaderNuTrong1.Weight = 1.5D;
            cellHeaderNuTrong1.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader2.Cells.Add(cellHeaderNuTrong1);
            XRTableCell cellHeaderNuTrong2 = new XRTableCell();            
            cellHeaderNuTrong2.Weight = 1.5D;
            cellHeaderNuTrong2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left |
                                    DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader3.Cells.Add(cellHeaderNuTrong2);

            XRTableCell cellHeaderChiaRa = new XRTableCell();
            cellHeaderChiaRa.Text = "Chia ra";
            if (laTHCS == true)
                cellHeaderChiaRa.Weight = 8D;
            else
                cellHeaderChiaRa.Weight = 6D;
            tableRowHeader1.Cells.Add(cellHeaderChiaRa);
            foreach (DSKhoi Khoi in Khois)
            {
                XRTableCell cellHeaderKhoi = new XRTableCell();
                cellHeaderKhoi.Text = "Lớp " + Khoi.TenKhoi;
                cellHeaderKhoi.Weight = 2D;
                tableRowHeader2.Cells.Add(cellHeaderKhoi);
                XRTableCell cellHeaderKhoiTS = new XRTableCell();
                cellHeaderKhoiTS.Text = "TS";
                cellHeaderKhoiTS.Weight = 1D;
                tableRowHeader3.Cells.Add(cellHeaderKhoiTS);
                XRTableCell cellHeaderKhoiNu = new XRTableCell();
                cellHeaderKhoiNu.Text = "Nữ";
                cellHeaderKhoiNu.Weight = 1D;
                tableRowHeader3.Cells.Add(cellHeaderKhoiNu);
            }


            foreach (XRTableCell cell in tableRowContent)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
            }

            //Thêm dòng nội dung     
            tableCellDanToc.DataBindings.Add("Text", null, "DanToc");
            tableCellDanToc.Weight = 4.5D;
            XRTableCell cellTongSo = new XRTableCell();
            cellTongSo.DataBindings.AddRange(new XRBinding[] {new XRBinding("Text", null, "TongSo")});
            cellTongSo.Weight = 1.5D;
            cellTongSo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            tableRowContent.Cells.Add(cellTongSo);
            XRTableCell cellNu = new XRTableCell();
            cellNu.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "Nu") });
            cellNu.Weight = 1.5D;
            cellNu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            tableRowContent.Cells.Add(cellNu);
            foreach (DSKhoi Khoi in Khois)
            {
                XRTableCell cellKhoiTS = new XRTableCell();
                cellKhoiTS.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "TS" + Khoi.TenKhoi) });
                cellKhoiTS.Weight = 1D;
                cellKhoiTS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowContent.Cells.Add(cellKhoiTS);
                XRTableCell cellKhoiNu = new XRTableCell();
                cellKhoiNu.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "Nu" + Khoi.TenKhoi) });
                cellKhoiNu.Weight = 1D;
                cellKhoiNu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowContent.Cells.Add(cellKhoiNu);
            }

            foreach(XRTableCell cell in tableRowContent)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
            }
        }

        private void rptPhanMemCuaBoM1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormattingRule ruleNen = new FormattingRule();
            this.FormattingRuleSheet.Add(ruleNen);

            // Specify the rule's properties.
            ruleNen.DataSource = this.DataSource;
            ruleNen.DataMember = this.DataMember;           
            ruleNen.Condition = "Contains([DanToc], \'Tổng số\')";
            ruleNen.Formatting.Font = new Font("Arial", 12, FontStyle.Bold);
            ruleNen.Formatting.BackColor = Color.LightGray;
            //rule.Formatting.Font = new Font(this.Font, FontStyle.Bold);           
            // Apply this rule to the detail band.
            this.Detail.FormattingRules.Add(ruleNen);
        }
    }
}
