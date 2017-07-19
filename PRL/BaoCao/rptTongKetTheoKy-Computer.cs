using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using BLL;

namespace PRL
{
    public partial class rptTongKetTheoKy : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongKetTheoKy(string maLop, string maHocKy)
        {
            InitializeComponent();
            TaoTable(maLop, maHocKy);
            this.DataSource = DSTongKetTheoKyBLL.LayDuLieuTongKetTheoKy(maLop, maHocKy);
        }

        private void TaoTable(string maLop, string maHocKy)
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

            string[] maTatCaMonHoc = DSMonHocTheoLopBLL.LayMaMonHocTheoLopHocKy(maLop, maHocKy);
            string[] hienThiTatCaMonHoc = DSMonHocTheoLopBLL.LayHienThiMonHocTheoLopHocKy(maLop, maHocKy);
            for (byte i = 0; i < maTatCaMonHoc.Count(); i++)
            {
                XRTableCell cellDiemTBMon = new XRTableCell();
                cellDiemTBMon.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, maTatCaMonHoc[i])});
                cellDiemTBMon.Weight = 0.8D;
                this.tableRowContent.Cells.Add(cellDiemTBMon);

                //Add Tiêu đề các môn học
                XRTableCell cellHeaderDiemTBMon = new XRTableCell();
                cellHeaderDiemTBMon.Text = hienThiTatCaMonHoc[i];
                cellHeaderDiemTBMon.Weight = 0.8D;
                tableRowHeader.Cells.Add(cellHeaderDiemTBMon);
            }
            XRTableCell cellTrungBinh = new XRTableCell();
            cellTrungBinh.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TBC")});
            cellTrungBinh.Weight = 0.8D;            
            cellTrungBinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);            
            this.tableRowContent.Cells.Add(cellTrungBinh);

            //Add Tiêu đề cột Trung bình cộng
            XRTableCell cellHeaderTrungBinh = new XRTableCell();
            cellHeaderTrungBinh.Text = "TBC";
            cellHeaderTrungBinh.Weight = 0.8D;
            tableRowHeader.Cells.Add(cellHeaderTrungBinh);

            //Add nội dung cột Hạnh kiểm
            XRTableCell cellHanhKiem = new XRTableCell();
            cellHanhKiem.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "HanhKiem")});
            cellHanhKiem.Weight = 1D;                                  
            this.tableRowContent.Cells.Add(cellHanhKiem);

            //Add Tiêu đề cột Hạnh kiểm
            XRTableCell cellHeaderHanhKiem = new XRTableCell();
            cellHeaderHanhKiem.Text = "Hạnh kiểm";
            cellHeaderHanhKiem.Weight = 1D;
            tableRowHeader.Cells.Add(cellHeaderHanhKiem);

            //Add nội dung cột Danh hiệu
            XRTableCell cellDanhHieu = new XRTableCell();
            cellDanhHieu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DanhHieu")});
            cellDanhHieu.Weight = 1D;
            this.tableRowContent.Cells.Add(cellDanhHieu);

            //Add Tiêu đề cột Danh hiệu
            XRTableCell cellHeaderDanhHieu = new XRTableCell();
            cellHeaderDanhHieu.Text = "Danh hiệu";
            cellHeaderDanhHieu.Weight = 1D;
            tableRowHeader.Cells.Add(cellHeaderDanhHieu);

            for (byte i = 0; i < tableRowContent.Cells.Count; i++)
            {
                tableRowContent.Cells[i].BorderWidth = 1;
                tableRowHeader.Cells[i].BorderWidth = 1;
                tableRowHeader.Cells[i].Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
                tableRowContent.Cells[i].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableRowHeader.Cells[i].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
            //tableTongKet.InsertColumnToRight(cellMaHocSinh);
        }

    }
}
