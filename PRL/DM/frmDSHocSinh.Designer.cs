namespace PRL
{
    partial class frmDSHocSinh
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXuatDL = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcHocSinh = new DevExpress.XtraGrid.GridControl();
            this.gvDSHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclMaHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHoDem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anh = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnXuatDL,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuatDL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "&Thêm";
            this.btnThem.Glyph = global::PRL.Properties.Resources.Add;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "&Sửa";
            this.btnSua.Glyph = global::PRL.Properties.Resources.Edit;
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "&Xóa";
            this.btnXoa.Glyph = global::PRL.Properties.Resources.Delete;
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnXuatDL
            // 
            this.btnXuatDL.Caption = "&Xuất Dữ liệu";
            this.btnXuatDL.Glyph = global::PRL.Properties.Resources.Export;
            this.btnXuatDL.Id = 3;
            this.btnXuatDL.Name = "btnXuatDL";
            this.btnXuatDL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatDL_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "T&hoát";
            this.btnThoat.Glyph = global::PRL.Properties.Resources.Exit;
            this.btnThoat.Id = 4;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(735, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 327);
            this.barDockControlBottom.Size = new System.Drawing.Size(735, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 253);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(735, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 253);
            // 
            // gcHocSinh
            // 
            this.gcHocSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinh.Location = new System.Drawing.Point(0, 74);
            this.gcHocSinh.MainView = this.gvDSHocSinh;
            this.gcHocSinh.MenuManager = this.barManager1;
            this.gcHocSinh.Name = "gcHocSinh";
            this.gcHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Anh});
            this.gcHocSinh.Size = new System.Drawing.Size(735, 253);
            this.gcHocSinh.TabIndex = 4;
            this.gcHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSHocSinh,
            this.gridView2});
            this.gcHocSinh.DoubleClick += new System.EventHandler(this.gcHocSinh_DoubleClick);
            // 
            // gvDSHocSinh
            // 
            this.gvDSHocSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTT,
            this.gclMaHocSinh,
            this.gclHoDem,
            this.gclTen,
            this.gclNgaySinh,
            this.gclGioiTinh,
            this.gclAnh,
            this.gclTenLop});
            this.gvDSHocSinh.GridControl = this.gcHocSinh;
            this.gvDSHocSinh.GroupCount = 1;
            this.gvDSHocSinh.Name = "gvDSHocSinh";
            this.gvDSHocSinh.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gclTenLop, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gclSTT, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gclSTT
            // 
            this.gclSTT.AppearanceCell.Options.UseTextOptions = true;
            this.gclSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclSTT.AppearanceHeader.Options.UseFont = true;
            this.gclSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSTT.Caption = "STT";
            this.gclSTT.FieldName = "STT";
            this.gclSTT.MaxWidth = 75;
            this.gclSTT.Name = "gclSTT";
            this.gclSTT.Visible = true;
            this.gclSTT.VisibleIndex = 0;
            // 
            // gclMaHocSinh
            // 
            this.gclMaHocSinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclMaHocSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHocSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclMaHocSinh.AppearanceHeader.Options.UseFont = true;
            this.gclMaHocSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaHocSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHocSinh.Caption = "Mã học sinh";
            this.gclMaHocSinh.FieldName = "MaHocSinh";
            this.gclMaHocSinh.Name = "gclMaHocSinh";
            this.gclMaHocSinh.OptionsColumn.AllowEdit = false;
            this.gclMaHocSinh.Visible = true;
            this.gclMaHocSinh.VisibleIndex = 1;
            this.gclMaHocSinh.Width = 76;
            // 
            // gclHoDem
            // 
            this.gclHoDem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclHoDem.AppearanceHeader.Options.UseFont = true;
            this.gclHoDem.AppearanceHeader.Options.UseTextOptions = true;
            this.gclHoDem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHoDem.Caption = "Họ đệm";
            this.gclHoDem.FieldName = "HoDem";
            this.gclHoDem.Name = "gclHoDem";
            this.gclHoDem.OptionsColumn.AllowEdit = false;
            this.gclHoDem.Visible = true;
            this.gclHoDem.VisibleIndex = 2;
            this.gclHoDem.Width = 141;
            // 
            // gclTen
            // 
            this.gclTen.AppearanceCell.Options.UseTextOptions = true;
            this.gclTen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTen.AppearanceHeader.Options.UseFont = true;
            this.gclTen.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTen.Caption = "Tên";
            this.gclTen.FieldName = "Ten";
            this.gclTen.Name = "gclTen";
            this.gclTen.OptionsColumn.AllowEdit = false;
            this.gclTen.Visible = true;
            this.gclTen.VisibleIndex = 3;
            this.gclTen.Width = 69;
            // 
            // gclNgaySinh
            // 
            this.gclNgaySinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclNgaySinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNgaySinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclNgaySinh.AppearanceHeader.Options.UseFont = true;
            this.gclNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNgaySinh.Caption = "Ngày sinh";
            this.gclNgaySinh.FieldName = "NgaySinh";
            this.gclNgaySinh.Name = "gclNgaySinh";
            this.gclNgaySinh.OptionsColumn.AllowEdit = false;
            this.gclNgaySinh.Visible = true;
            this.gclNgaySinh.VisibleIndex = 4;
            this.gclNgaySinh.Width = 141;
            // 
            // gclGioiTinh
            // 
            this.gclGioiTinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclGioiTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclGioiTinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclGioiTinh.AppearanceHeader.Options.UseFont = true;
            this.gclGioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclGioiTinh.Caption = "Giới tính";
            this.gclGioiTinh.FieldName = "GioiTinh";
            this.gclGioiTinh.Name = "gclGioiTinh";
            this.gclGioiTinh.OptionsColumn.AllowEdit = false;
            this.gclGioiTinh.Visible = true;
            this.gclGioiTinh.VisibleIndex = 5;
            this.gclGioiTinh.Width = 73;
            // 
            // gclAnh
            // 
            this.gclAnh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclAnh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclAnh.Caption = "Ảnh";
            this.gclAnh.FieldName = "Anh";
            this.gclAnh.Name = "gclAnh";
            this.gclAnh.OptionsColumn.AllowEdit = false;
            // 
            // gclTenLop
            // 
            this.gclTenLop.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTenLop.AppearanceHeader.Options.UseFont = true;
            this.gclTenLop.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenLop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenLop.Caption = "Lớp";
            this.gclTenLop.FieldName = "TenLop";
            this.gclTenLop.Name = "gclTenLop";
            this.gclTenLop.OptionsColumn.AllowEdit = false;
            this.gclTenLop.Visible = true;
            this.gclTenLop.VisibleIndex = 5;
            this.gclTenLop.Width = 217;
            // 
            // Anh
            // 
            this.Anh.AutoHeight = false;
            this.Anh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Anh.Name = "Anh";
            // 
            // gridView2
            // 
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6});
            this.gridView2.GridControl = this.gcHocSinh;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã giáo viên";
            this.gridColumn1.FieldName = "MaHocSinh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ đệm";
            this.gridColumn2.FieldName = "HoDem";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên";
            this.gridColumn3.FieldName = "Ten";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày sinh";
            this.gridColumn4.FieldName = "NgaySinh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giới tính";
            this.gridColumn5.FieldName = "GioiTinh";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Chức vụ";
            this.gridColumn7.FieldName = "TenChucVu";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ảnh";
            this.gridColumn6.ColumnEdit = this.Anh;
            this.gridColumn6.FieldName = "Anh";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // frmDSHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 350);
            this.Controls.Add(this.gcHocSinh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Học sinh";
            this.Load += new System.EventHandler(this.frmDSHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarLargeButtonItem btnThem;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnXuatDL;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraGrid.GridControl gcHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclHoDem;
        private DevExpress.XtraGrid.Columns.GridColumn gclTen;
        private DevExpress.XtraGrid.Columns.GridColumn gclNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclAnh;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit Anh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTT;
    }
}