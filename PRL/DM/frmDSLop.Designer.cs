namespace PRL
{
    partial class frmDSLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSLop));
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
            this.gcDSLop = new DevExpress.XtraGrid.GridControl();
            this.gvDSLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLop)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(448, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 264);
            this.barDockControlBottom.Size = new System.Drawing.Size(448, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 190);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(448, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 190);
            // 
            // gcDSLop
            // 
            this.gcDSLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDSLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSLop.Location = new System.Drawing.Point(0, 74);
            this.gcDSLop.MainView = this.gvDSLop;
            this.gcDSLop.MenuManager = this.barManager1;
            this.gcDSLop.Name = "gcDSLop";
            this.gcDSLop.Size = new System.Drawing.Size(448, 190);
            this.gcDSLop.TabIndex = 4;
            this.gcDSLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLop});
            this.gcDSLop.DoubleClick += new System.EventHandler(this.gcDSLop_DoubleClick);
            // 
            // gvDSLop
            // 
            this.gvDSLop.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gvDSLop.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDSLop.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvDSLop.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaLop,
            this.gcTenLop,
            this.gcTenKhoi});
            this.gvDSLop.GridControl = this.gcDSLop;
            this.gvDSLop.GroupCount = 1;
            this.gvDSLop.Name = "gvDSLop";
            this.gvDSLop.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSLop.OptionsView.ShowAutoFilterRow = true;
            this.gvDSLop.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcTenKhoi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gcMaLop
            // 
            this.gcMaLop.AppearanceCell.Options.UseTextOptions = true;
            this.gcMaLop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaLop.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcMaLop.AppearanceHeader.Options.UseFont = true;
            this.gcMaLop.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaLop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaLop.Caption = "Mã Lớp";
            this.gcMaLop.FieldName = "MaLop";
            this.gcMaLop.Name = "gcMaLop";
            this.gcMaLop.OptionsColumn.AllowEdit = false;
            this.gcMaLop.Visible = true;
            this.gcMaLop.VisibleIndex = 0;
            this.gcMaLop.Width = 100;
            // 
            // gcTenLop
            // 
            this.gcTenLop.AppearanceCell.Options.UseTextOptions = true;
            this.gcTenLop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenLop.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTenLop.AppearanceHeader.Options.UseFont = true;
            this.gcTenLop.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenLop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenLop.Caption = "Tên Lớp";
            this.gcTenLop.FieldName = "TenLop";
            this.gcTenLop.Name = "gcTenLop";
            this.gcTenLop.OptionsColumn.AllowEdit = false;
            this.gcTenLop.Visible = true;
            this.gcTenLop.VisibleIndex = 1;
            this.gcTenLop.Width = 300;
            // 
            // gcTenKhoi
            // 
            this.gcTenKhoi.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcTenKhoi.AppearanceHeader.Options.UseFont = true;
            this.gcTenKhoi.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenKhoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenKhoi.Caption = "Tên khối";
            this.gcTenKhoi.FieldName = "TenKhoi";
            this.gcTenKhoi.Name = "gcTenKhoi";
            this.gcTenKhoi.Visible = true;
            this.gcTenKhoi.VisibleIndex = 2;
            // 
            // frmDSLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 287);
            this.Controls.Add(this.gcDSLop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLop)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcDSLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLop;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenLop;       
        private DevExpress.XtraGrid.Columns.GridColumn gcTenKhoi;
    }
}