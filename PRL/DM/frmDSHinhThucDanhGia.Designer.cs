namespace PRL
{
    partial class frmDSHinhThucDanhGia
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSHinhThucDanhGia));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcDSHinhThucDanhGia = new DevExpress.XtraGrid.GridControl();
            this.gvDSHinhThucDanhGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaHinhThucDanhGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenHinhThucDanhGia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHinhThucDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHinhThucDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnXuat,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "&Thêm";
            this.btnThem.Id = 1;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "&Sửa";
            this.btnSua.Id = 2;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "&Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất &Excel";
            this.btnXuat.Id = 4;
            this.btnXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.LargeGlyph")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "T&hoát";
            this.btnThoat.Id = 5;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(584, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 338);
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 264);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 264);
            // 
            // gcDSHinhThucDanhGia
            // 
            this.gcDSHinhThucDanhGia.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDSHinhThucDanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSHinhThucDanhGia.Location = new System.Drawing.Point(0, 74);
            this.gcDSHinhThucDanhGia.MainView = this.gvDSHinhThucDanhGia;
            this.gcDSHinhThucDanhGia.MenuManager = this.barManager1;
            this.gcDSHinhThucDanhGia.Name = "gcDSHinhThucDanhGia";
            this.gcDSHinhThucDanhGia.Size = new System.Drawing.Size(584, 264);
            this.gcDSHinhThucDanhGia.TabIndex = 4;
            this.gcDSHinhThucDanhGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSHinhThucDanhGia});
            this.gcDSHinhThucDanhGia.DoubleClick += new System.EventHandler(this.gcDSHinhThucDanhGia_DoubleClick);
            // 
            // gvDSHinhThucDanhGia
            // 
            this.gvDSHinhThucDanhGia.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gvDSHinhThucDanhGia.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDSHinhThucDanhGia.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvDSHinhThucDanhGia.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSHinhThucDanhGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaHinhThucDanhGia,
            this.gcTenHinhThucDanhGia});
            this.gvDSHinhThucDanhGia.GridControl = this.gcDSHinhThucDanhGia;
            this.gvDSHinhThucDanhGia.Name = "gvDSHinhThucDanhGia";
            this.gvDSHinhThucDanhGia.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSHinhThucDanhGia.OptionsView.ShowAutoFilterRow = true;
            // 
            // gcMaHinhThucDanhGia
            // 
            this.gcMaHinhThucDanhGia.AppearanceCell.Options.UseTextOptions = true;
            this.gcMaHinhThucDanhGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaHinhThucDanhGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcMaHinhThucDanhGia.AppearanceHeader.Options.UseFont = true;
            this.gcMaHinhThucDanhGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaHinhThucDanhGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaHinhThucDanhGia.Caption = "Mã hình thức đánh giá";
            this.gcMaHinhThucDanhGia.FieldName = "MaHinhThucDanhGia";
            this.gcMaHinhThucDanhGia.Name = "gcMaHinhThucDanhGia";
            this.gcMaHinhThucDanhGia.OptionsColumn.AllowEdit = false;
            this.gcMaHinhThucDanhGia.Visible = true;
            this.gcMaHinhThucDanhGia.VisibleIndex = 0;
            this.gcMaHinhThucDanhGia.Width = 100;
            // 
            // gcTenHinhThucDanhGia
            // 
            this.gcTenHinhThucDanhGia.AppearanceCell.Options.UseTextOptions = true;
            this.gcTenHinhThucDanhGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenHinhThucDanhGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTenHinhThucDanhGia.AppearanceHeader.Options.UseFont = true;
            this.gcTenHinhThucDanhGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenHinhThucDanhGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenHinhThucDanhGia.Caption = "Tên hình thức đánh giá";
            this.gcTenHinhThucDanhGia.FieldName = "TenHinhThucDanhGia";
            this.gcTenHinhThucDanhGia.Name = "gcTenHinhThucDanhGia";
            this.gcTenHinhThucDanhGia.OptionsColumn.AllowEdit = false;
            this.gcTenHinhThucDanhGia.Visible = true;
            this.gcTenHinhThucDanhGia.VisibleIndex = 1;
            this.gcTenHinhThucDanhGia.Width = 300;
            // 
            // frmDSHinhThucDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gcDSHinhThucDanhGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmDSHinhThucDanhGia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Hình thức đánh giá";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHinhThucDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHinhThucDanhGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnThem;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnXuat;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraGrid.GridControl gcDSHinhThucDanhGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSHinhThucDanhGia;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaHinhThucDanhGia;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenHinhThucDanhGia;
    }
}