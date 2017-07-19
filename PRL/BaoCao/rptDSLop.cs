using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using BLL;

namespace PRL
{
    public partial class rptDSLop : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSLop(string maLop)
        {
            InitializeComponent();
            TaoTable();            
            lbLop.Text = DSLopBLL.LayTenLopTheoMaLop(maLop);
            lbGVCN.Text = DSGiaoVienBLL.LayTenGVCN(maLop);
            this.DataSource = DSHocSinhBLL.LayDSHocSinhTheoLop(maLop);
        }

        private void TaoTable()
        {
            //Add Tiêu đề
            XRTableCell cellHeaderMaHocSinh = new XRTableCell();
            cellHeaderMaHocSinh.Text = "Mã HS";
            cellHeaderMaHocSinh.Weight = 1D;
            tableRowHeader.Cells.Add(cellHeaderMaHocSinh);
            XRTableCell cellHeaderHoVaTen = new XRTableCell();
            cellHeaderHoVaTen.Text = "Họ và tên";
            cellHeaderHoVaTen.Weight = 2.5D;
            tableRowHeader.Cells.Add(cellHeaderHoVaTen);
            XRTableCell cellHeaderNgaySinh = new XRTableCell();
            cellHeaderNgaySinh.Text = "Ngày sinh";
            cellHeaderNgaySinh.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderNgaySinh);
            XRTableCell cellHeaderGioiTinh = new XRTableCell();
            cellHeaderGioiTinh.Text = "Giới tính";
            cellHeaderGioiTinh.Weight = 1.5D;
            tableRowHeader.Cells.Add(cellHeaderGioiTinh);



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
            XRTableCell cellGioiTinh = new XRTableCell();
            cellGioiTinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GioiTinh")});
            cellGioiTinh.Weight = 1.5D;
            this.tableRowContent.Cells.Add(cellGioiTinh);

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
