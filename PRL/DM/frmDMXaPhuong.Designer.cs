namespace PRL
{
    partial class frmDMXaPhuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMXaPhuong));
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
            this.gcDMQuanHuyen = new DevExpress.XtraGrid.GridControl();
            this.gvDMXaPhuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaXaPhuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenXaPhuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDMQuanHuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDMXaPhuong)).BeginInit();
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
            // gcDMQuanHuyen
            // 
            this.gcDMQuanHuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDMQuanHuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDMQuanHuyen.Location = new System.Drawing.Point(0, 74);
            this.gcDMQuanHuyen.MainView = this.gvDMXaPhuong;
            this.gcDMQuanHuyen.MenuManager = this.barManager1;
            this.gcDMQuanHuyen.Name = "gcDMQuanHuyen";
            this.gcDMQuanHuyen.Size = new System.Drawing.Size(448, 190);
            this.gcDMQuanHuyen.TabIndex = 4;
            this.gcDMQuanHuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDMXaPhuong});
            this.gcDMQuanHuyen.DoubleClick += new System.EventHandler(this.gcDMQuanHuyen_DoubleClick);
            // 
            // gvDMXaPhuong
            // 
            this.gvDMXaPhuong.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gvDMXaPhuong.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDMXaPhuong.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvDMXaPhuong.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDMXaPhuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaXaPhuong,
            this.gcTenXaPhuong,
            this.gcTenQuanHuyen,
            this.gcTenTinhThanh});
            this.gvDMXaPhuong.GridControl = this.gcDMQuanHuyen;
            this.gvDMXaPhuong.GroupCount = 2;
            this.gvDMXaPhuong.Name = "gvDMXaPhuong";
            this.gvDMXaPhuong.OptionsView.EnableAppearanceOddRow = true;
            this.gvDMXaPhuong.OptionsView.ShowAutoFilterRow = true;
            this.gvDMXaPhuong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcTenTinhThanh, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcTenQuanHuyen, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gcMaXaPhuong
            // 
            this.gcMaXaPhuong.AppearanceCell.Options.UseTextOptions = true;
            this.gcMaXaPhuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaXaPhuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcMaXaPhuong.AppearanceHeader.Options.UseFont = true;
            this.gcMaXaPhuong.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaXaPhuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaXaPhuong.Caption = "Mã xã phường";
            this.gcMaXaPhuong.FieldName = "MaXaPhuong";
            this.gcMaXaPhuong.Name = "gcMaXaPhuong";
            this.gcMaXaPhuong.OptionsColumn.AllowEdit = false;
            this.gcMaXaPhuong.Visible = true;
            this.gcMaXaPhuong.VisibleIndex = 0;
            this.gcMaXaPhuong.Width = 100;
            // 
            // gcTenXaPhuong
            // 
            this.gcTenXaPhuong.AppearanceCell.Options.UseTextOptions = true;
            this.gcTenXaPhuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenXaPhuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTenXaPhuong.AppearanceHeader.Options.UseFont = true;
            this.gcTenXaPhuong.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenXaPhuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenXaPhuong.Caption = "Tên Xã Phường";
            this.gcTenXaPhuong.FieldName = "TenXaPhuong";
            this.gcTenXaPhuong.Name = "gcTenXaPhuong";
            this.gcTenXaPhuong.OptionsColumn.AllowEdit = false;
            this.gcTenXaPhuong.Visible = true;
            this.gcTenXaPhuong.VisibleIndex = 1;
            this.gcTenXaPhuong.Width = 300;
            // 
            // gcTenQuanHuyen
            // 
            this.gcTenQuanHuyen.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gcTenQuanHuyen.AppearanceHeader.Options.UseFont = true;
            this.gcTenQuanHuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenQuanHuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenQuanHuyen.Caption = "Tên Quận huyện";
            this.gcTenQuanHuyen.FieldName = "TenQuanHuyen";
            this.gcTenQuanHuyen.Name = "gcTenQuanHuyen";
            this.gcTenQuanHuyen.Visible = true;
            this.gcTenQuanHuyen.VisibleIndex = 2;
            // 
            // gcTenTinhThanh
            // 
            this.gcTenTinhThanh.AppearanceHeader.Options.UseFont = true;
            this.gcTenTinhThanh.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenTinhThanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenTinhThanh.Caption = "Tên Tỉnh thành";
            this.gcTenTinhThanh.FieldName = "TenTinhThanh";
            this.gcTenTinhThanh.Name = "gcTenTinhThanh";
            this.gcTenTinhThanh.Visible = true;
            this.gcTenTinhThanh.VisibleIndex = 2;
            // 
            // frmDMXaPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 287);
            this.Controls.Add(this.gcDMQuanHuyen);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDMXaPhuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Xã, phường";
            this.Load += new System.EventHandler(this.frmDMXaPhuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDMQuanHuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDMXaPhuong)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcDMQuanHuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDMXaPhuong;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaXaPhuong;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenXaPhuong;       
        private DevExpress.XtraGrid.Columns.GridColumn gcTenQuanHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenTinhThanh;
    }
}