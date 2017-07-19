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
    public partial class rptPhanMemCuaBo : DevExpress.XtraReports.UI.XtraReport
    {
        bool theoHKHL;
        public rptPhanMemCuaBo(string maHocKy, bool laTHCS, bool theoHKHL)
        {
            InitializeComponent();
            this.theoHKHL = theoHKHL;
            TaoTable(laTHCS, theoHKHL);                        
            if (theoHKHL == true)
            {
                this.DataSource = ThongKeBLL.ThongKeTheoHocLucHanhKiem(maHocKy, laTHCS);
                tableCellHeaderDanhGiaHocSinh.Text = "Đánh giá học sinh";                
                lbTieuDe.Text = "BIỂU THỐNG KÊ KẾT QUẢ HỌC TẬP RÈN LUYỆN THEO HẠNH KIỂM - HỌC LỰC";                
            }                
            else
            {
                this.DataSource = ThongKeBLL.ThongKeTheoMonHoc(maHocKy, laTHCS);
                tableCellHeaderDanhGiaHocSinh.Text = "Môn học";
                lbTieuDe.Text = "BIỂU THỐNG KÊ KẾT QUẢ HỌC TẬP RÈN LUYỆN THEO HỌC LỰC CỦA MÔN HỌC";
            } 
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

        private void TaoTable(bool laTHCS, bool theoHKHL)
        {
            List<DSKhoi> Khois;
            if (laTHCS == true)
                Khois = DSKhoiBLL.LayKhoiTheoMaCap("CTHCS");
            else
                Khois = DSKhoiBLL.LayKhoiTheoMaCap("CTHPT");
            //Thêm dòng tiêu đề            
            tableCellHeaderDanhGiaHocSinh.Weight = 4.5D;
            tableCellHeaderDanhGiaHocSinhTrong.Weight = 4.5D;
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
            if (theoHKHL == true)       
                tableCellDanhGiaHocSinh.DataBindings.Add("Text", null, "DanhGiaHocSinh");
            else
                tableCellDanhGiaHocSinh.DataBindings.Add("Text", null, "MonHoc");
            tableCellDanhGiaHocSinh.Weight = 4.5D;
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

        private void rptPhanMemCuaBo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormattingRule ruleNen = new FormattingRule();
            this.FormattingRuleSheet.Add(ruleNen);

            // Specify the rule's properties.
            ruleNen.DataSource = this.DataSource;
            ruleNen.DataMember = this.DataMember;
            if (theoHKHL == true)
            {                
                ruleNen.Condition = "Contains([DanhGiaHocSinh], \'học sinh\')";
            }
            else
            {
                ruleNen.Condition = "Contains([MonHoc], \'học sinh\')";
            }

            ruleNen.Formatting.Font = new Font("Arial", 12, FontStyle.Bold);
            ruleNen.Formatting.BackColor = Color.DarkGray;            
            //rule.Formatting.Font = new Font(this.Font, FontStyle.Bold);           
            // Apply this rule to the detail band.
            this.Detail.FormattingRules.Add(ruleNen);

            FormattingRule ruleDam = new FormattingRule();
            this.FormattingRuleSheet.Add(ruleDam);

            // Specify the rule's properties.
            ruleDam.DataSource = this.DataSource;
            ruleDam.DataMember = this.DataMember;
            if (theoHKHL == true)
            {
                string dieuKien = "";
                string[] tenTatCaHanhKiem = DMHanhKiemBLL.LayTenTatCaHanhKiem();
                string[] tenTatCaHocLuc = DMHocLucBLL.LayTenTatCaHocLuc();
                foreach (string tenHanhKiem in tenTatCaHanhKiem)
                {
                    dieuKien += "Contains([DanhGiaHocSinh], \'" + tenHanhKiem + "\')";                    
                }
                foreach (string tenHocLuc in tenTatCaHocLuc)
                {
                    if (dieuKien.Contains(tenHocLuc) == false) 
                        dieuKien += "Contains([DanhGiaHocSinh], \'" + tenHocLuc + "\')";
                }
                ruleDam.Condition = dieuKien.Replace(")Con", ") Or Con");
                
            }
            else
            {
                string dieuKien = "";
                string[] tenTatCaMonHoc = DSMonHocBLL.LayTenTatCaMonHoc();                
                foreach (string tenMonHoc in tenTatCaMonHoc)
                {
                    dieuKien += "Contains([MonHoc], \'" + tenMonHoc + "\')";
                }                
                ruleDam.Condition = dieuKien.Replace(")Con", ") Or Con");
            }

            ruleDam.Formatting.Font = new Font("Arial", 12, FontStyle.Bold);
            ruleDam.Formatting.BackColor = Color.LightGray;           
            //rule.Formatting.Font = new Font(this.Font, FontStyle.Bold);           
            // Apply this rule to the detail band.
            this.Detail.FormattingRules.Add(ruleDam);
        }
    }
}
