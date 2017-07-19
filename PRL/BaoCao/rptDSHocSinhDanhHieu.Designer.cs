namespace PRL
{
    partial class rptDSHocSinhDanhHieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDSHocSinhDanhHieu));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tableTongKet = new DevExpress.XtraReports.UI.XRTable();
            this.tableRowContent = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.tableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.tableRowHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNamHoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lbHocKy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.pictureLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lbHieuTruong = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupLop = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tableGroup = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellLop = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupDanhHieu = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDanhHieu = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.tableTongKet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tableTongKet});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableTongKet
            // 
            this.tableTongKet.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tableTongKet.Name = "tableTongKet";
            this.tableTongKet.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRowContent});
            this.tableTongKet.SizeF = new System.Drawing.SizeF(793.4167F, 25F);
            // 
            // tableRowContent
            // 
            this.tableRowContent.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableRowContent.BorderWidth = 2F;
            this.tableRowContent.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellSTT});
            this.tableRowContent.Name = "tableRowContent";
            this.tableRowContent.StylePriority.UseBorders = false;
            this.tableRowContent.StylePriority.UseBorderWidth = false;
            this.tableRowContent.Weight = 1D;
            // 
            // cellSTT
            // 
            this.cellSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellSTT.BorderWidth = 1F;
            this.cellSTT.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.StylePriority.UseBorders = false;
            this.cellSTT.StylePriority.UseBorderWidth = false;
            this.cellSTT.StylePriority.UseFont = false;
            this.cellSTT.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.cellSTT.Summary = xrSummary1;
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellSTT.Weight = 1D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 28F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 29F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.LightGray;
            this.tableHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRowHeader});
            this.tableHeader.SizeF = new System.Drawing.SizeF(793.4165F, 25F);
            this.tableHeader.StylePriority.UseBackColor = false;
            // 
            // tableRowHeader
            // 
            this.tableRowHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableRowHeader.BorderWidth = 2F;
            this.tableRowHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.tableRowHeader.Name = "tableRowHeader";
            this.tableRowHeader.StylePriority.UseBorders = false;
            this.tableRowHeader.StylePriority.UseBorderWidth = false;
            this.tableRowHeader.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BorderWidth = 1F;
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorderWidth = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "STT";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 1D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tableHeader});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.lbNamHoc,
            this.lbHocKy,
            this.xrLabel2,
            this.pictureLogo,
            this.xrLabel1});
            this.ReportHeader.HeightF = 106.125F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(493.75F, 57.25001F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(62.5F, 23F);
            this.xrLabel5.Text = "Năm học:";
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNamHoc.LocationFloat = new DevExpress.Utils.PointFloat(556.25F, 57.25001F);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNamHoc.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbNamHoc.StylePriority.UseFont = false;
            this.lbNamHoc.Text = "xrLabel2";
            // 
            // lbHocKy
            // 
            this.lbHocKy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbHocKy.LocationFloat = new DevExpress.Utils.PointFloat(327.0834F, 57.25001F);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHocKy.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbHocKy.StylePriority.UseFont = false;
            this.lbHocKy.Text = "xrLabel2";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(272.9167F, 57.25001F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(54.1667F, 23F);
            this.xrLabel2.Text = "Học kỳ:";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 3.125008F);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.SizeF = new System.Drawing.SizeF(99.99999F, 100F);
            this.pictureLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(189.0834F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(551.0416F, 30.29166F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "DANH SÁCH HỌC SINH ĐẠT DANH HIỆU";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHieuTruong,
            this.xrLabel3});
            this.ReportFooter.HeightF = 108F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lbHieuTruong
            // 
            this.lbHieuTruong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbHieuTruong.LocationFloat = new DevExpress.Utils.PointFloat(467.7083F, 84.99998F);
            this.lbHieuTruong.Name = "lbHieuTruong";
            this.lbHieuTruong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHieuTruong.SizeF = new System.Drawing.SizeF(300.5418F, 23F);
            this.lbHieuTruong.StylePriority.UseFont = false;
            this.lbHieuTruong.StylePriority.UseTextAlignment = false;
            this.lbHieuTruong.Text = "lbHieuTruong";
            this.lbHieuTruong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(523.2292F, 10.29167F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(181.2499F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Hiệu trưởng";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupLop
            // 
            this.GroupLop.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tableGroup});
            this.GroupLop.HeightF = 25F;
            this.GroupLop.Name = "GroupLop";
            // 
            // tableGroup
            // 
            this.tableGroup.LocationFloat = new DevExpress.Utils.PointFloat(0.0001907349F, 0F);
            this.tableGroup.Name = "tableGroup";
            this.tableGroup.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.tableGroup.SizeF = new System.Drawing.SizeF(793.4165F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow1.BorderWidth = 2F;
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.cellLop});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseBorders = false;
            this.xrTableRow1.StylePriority.UseBorderWidth = false;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.BorderWidth = 1F;
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseBorderWidth = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Lớp:";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 0.108759478176424D;
            // 
            // cellLop
            // 
            this.cellLop.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellLop.BorderWidth = 1F;
            this.cellLop.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Lop")});
            this.cellLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cellLop.Name = "cellLop";
            this.cellLop.StylePriority.UseBorders = false;
            this.cellLop.StylePriority.UseBorderWidth = false;
            this.cellLop.StylePriority.UseFont = false;
            this.cellLop.StylePriority.UseTextAlignment = false;
            this.cellLop.Text = "Lop";
            this.cellLop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellLop.Weight = 0.891240521823576D;
            // 
            // GroupDanhHieu
            // 
            this.GroupDanhHieu.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupDanhHieu.HeightF = 25F;
            this.GroupDanhHieu.Level = 1;
            this.GroupDanhHieu.Name = "GroupDanhHieu";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(793.4165F, 25F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow2.BorderWidth = 2F;
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.cellDanhHieu});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseBorders = false;
            this.xrTableRow2.StylePriority.UseBorderWidth = false;
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.BorderWidth = 1F;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseBorderWidth = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Danh hiệu:";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 0.108759478176424D;
            // 
            // cellDanhHieu
            // 
            this.cellDanhHieu.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellDanhHieu.BorderWidth = 1F;
            this.cellDanhHieu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DanhHieu")});
            this.cellDanhHieu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cellDanhHieu.Name = "cellDanhHieu";
            this.cellDanhHieu.StylePriority.UseBorders = false;
            this.cellDanhHieu.StylePriority.UseBorderWidth = false;
            this.cellDanhHieu.StylePriority.UseFont = false;
            this.cellDanhHieu.StylePriority.UseTextAlignment = false;
            this.cellDanhHieu.Text = "DanhHieu";
            this.cellDanhHieu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellDanhHieu.Weight = 0.891240521823576D;
            // 
            // rptDSHocSinhDanhHieu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportHeader,
            this.ReportFooter,
            this.GroupLop,
            this.GroupDanhHieu});
            this.Margins = new System.Drawing.Printing.Margins(23, 11, 28, 29);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.tableTongKet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable tableTongKet;
        private DevExpress.XtraReports.UI.XRTableRow tableRowContent;
        private DevExpress.XtraReports.UI.XRTableCell cellSTT;
        private DevExpress.XtraReports.UI.XRTable tableHeader;
        private DevExpress.XtraReports.UI.XRTableRow tableRowHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox pictureLogo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel lbHieuTruong;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupLop;
        private DevExpress.XtraReports.UI.XRTable tableGroup;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell cellLop;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupDanhHieu;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell cellDanhHieu;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel lbNamHoc;
        private DevExpress.XtraReports.UI.XRLabel lbHocKy;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
