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
    public partial class rptPhanMemCuaBoM2 : DevExpress.XtraReports.UI.XtraReport
    {
        
        public rptPhanMemCuaBoM2(string maHocKy, bool laTHCS)
        {
            InitializeComponent();
            TaoTable(laTHCS);                        
            this.DataSource = ThongKeBLL.ThongKeTheoDoTuoi(maHocKy, laTHCS);
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
            tableCellHeaderHocSinh.Weight = 4.5D;
            tableCellHeaderHocSinhTrong.Weight = 4.5D;
            XRTableCell cellHeaderTongSo = new XRTableCell();
            cellHeaderTongSo.Text = "Tổng số";
            cellHeaderTongSo.Weight = 1.5D;
            cellHeaderTongSo.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left |
                                    DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader1.Cells.Add(cellHeaderTongSo);
            XRTableCell cellHeaderTongSoTrong = new XRTableCell();
            cellHeaderTongSoTrong.Text = "";
            cellHeaderTongSoTrong.Weight = 1.5D;
            cellHeaderTongSoTrong.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left |
                                    DevExpress.XtraPrinting.BorderSide.Right;
            tableRowHeader2.Cells.Add(cellHeaderTongSoTrong);
            XRTableCell cellHeaderChiaRa = new XRTableCell();
            cellHeaderChiaRa.Text = "Chia ra";
            if (laTHCS == true)
                cellHeaderChiaRa.Weight = 6D;
            else
                cellHeaderChiaRa.Weight = 4.5D;
            tableRowHeader1.Cells.Add(cellHeaderChiaRa);
            foreach (DSKhoi Khoi in Khois)
            {
                XRTableCell cellHeaderKhoi = new XRTableCell();
                cellHeaderKhoi.Text = "Lớp " + Khoi.TenKhoi;
                cellHeaderKhoi.Weight = 1.5D;
                tableRowHeader2.Cells.Add(cellHeaderKhoi);
            }

            foreach (XRTableCell cell in tableRowContent)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
            }

            //Thêm dòng nội dung                 
            tableCellHocSinh.DataBindings.Add("Text", null, "HocSinh");
            tableCellHocSinh.Weight = 4.5D;
            XRTableCell cellTongSo = new XRTableCell();
            cellTongSo.DataBindings.AddRange(new XRBinding[] {new XRBinding("Text", null, "TongSo")});
            cellTongSo.Weight = 1.5D;
            cellTongSo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            tableRowContent.Cells.Add(cellTongSo);
            foreach(DSKhoi Khoi in Khois)
            {
                XRTableCell cellKhoi = new XRTableCell();
                cellKhoi.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, Khoi.TenKhoi) });
                cellKhoi.Weight = 1.5D;
                cellKhoi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowContent.Cells.Add(cellKhoi);
            }

            foreach(XRTableCell cell in tableRowContent)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
            }
        }

        private void rptPhanMemCuaBoM2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormattingRule ruleNen = new FormattingRule();
            this.FormattingRuleSheet.Add(ruleNen);

            // Specify the rule's properties.
            ruleNen.DataSource = this.DataSource;
            ruleNen.DataMember = this.DataMember;            
            ruleNen.Condition = "Contains([HocSinh], \'học sinh\')";
            
            ruleNen.Formatting.Font = new Font("Arial", 12, FontStyle.Bold);
            ruleNen.Formatting.BackColor = Color.LightGray;            
            //rule.Formatting.Font = new Font(this.Font, FontStyle.Bold);           
            // Apply this rule to the detail band.
            this.Detail.FormattingRules.Add(ruleNen);            
        }
    }
}
