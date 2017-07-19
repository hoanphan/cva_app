namespace PRL
{
    partial class frmDMTrinhDoChinhTri
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
            this.gcDMTrinhDoChinhTri = new DevExpress.XtraGrid.GridControl();
            this.gvDMTrinhDoChinhTri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaTrinhDoChinhTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenTrinhDoChinhTri = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDMTrinhDoChinhTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDMTrinhDoChinhTri)).BeginInit();
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
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(338, 140);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất";
            this.btnXuat.Glyph = global::PRL.Properties.Resources.Export;
            this.btnXuat.Id = 3;
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "&Thoát";
            this.btnThoat.Glyph = global::PRL.Properties.Resources.Exit;
            this.btnThoat.Id = 4;
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
            this.barDockControlTop.Size = new System.Drawing.Size(516, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 291);
            this.barDockControlBottom.Size = new System.Drawing.Size(516, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 217);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(516, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 217);
            // 
            // gcDMTrinhDoChinhTri
            // 
            this.gcDMTrinhDoChinhTri.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDMTrinhDoChinhTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDMTrinhDoChinhTri.Location = new System.Drawing.Point(0, 74);
            this.gcDMTrinhDoChinhTri.MainView = this.gvDMTrinhDoChinhTri;
            this.gcDMTrinhDoChinhTri.MenuManager = this.barManager1;
            this.gcDMTrinhDoChinhTri.Name = "gcDMTrinhDoChinhTri";
            this.gcDMTrinhDoChinhTri.Size = new System.Drawing.Size(516, 217);
            this.gcDMTrinhDoChinhTri.TabIndex = 4;
            this.gcDMTrinhDoChinhTri.UseDisabledStatePainter = false;
            this.gcDMTrinhDoChinhTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDMTrinhDoChinhTri});
            this.gcDMTrinhDoChinhTri.DoubleClick += new System.EventHandler(this.gcDMTrinhDoChinhTri_DoubleClick);
            // 
            // gvDMTrinhDoChinhTri
            // 
            this.gvDMTrinhDoChinhTri.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDMTrinhDoChinhTri.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDMTrinhDoChinhTri.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDMTrinhDoChinhTri.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDMTrinhDoChinhTri.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvDMTrinhDoChinhTri.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDMTrinhDoChinhTri.Appearance.Row.Options.UseTextOptions = true;
            this.gvDMTrinhDoChinhTri.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDMTrinhDoChinhTri.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvDMTrinhDoChinhTri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaTrinhDoChinhTri,
            this.gcTenTrinhDoChinhTri});
            this.gvDMTrinhDoChinhTri.GridControl = this.gcDMTrinhDoChinhTri;
            this.gvDMTrinhDoChinhTri.Name = "gvDMTrinhDoChinhTri";
            this.gvDMTrinhDoChinhTri.OptionsBehavior.Editable = false;
            this.gvDMTrinhDoChinhTri.OptionsView.EnableAppearanceOddRow = true;
            this.gvDMTrinhDoChinhTri.OptionsView.ShowAutoFilterRow = true;
            // 
            // gcMaTrinhDoChinhTri
            // 
            this.gcMaTrinhDoChinhTri.Caption = "Mã Trình Độ Chính Trị";
            this.gcMaTrinhDoChinhTri.FieldName = "MaTrinhDoChinhTri";
            this.gcMaTrinhDoChinhTri.Name = "gcMaTrinhDoChinhTri";
            this.gcMaTrinhDoChinhTri.OptionsColumn.AllowEdit = false;
            this.gcMaTrinhDoChinhTri.Visible = true;
            this.gcMaTrinhDoChinhTri.VisibleIndex = 0;
            // 
            // gcTenTrinhDoChinhTri
            // 
            this.gcTenTrinhDoChinhTri.Caption = "Tên Trình Độ Chính Trị";
            this.gcTenTrinhDoChinhTri.FieldName = "TenTrinhDoChinhTri";
            this.gcTenTrinhDoChinhTri.Name = "gcTenTrinhDoChinhTri";
            this.gcTenTrinhDoChinhTri.Visible = true;
            this.gcTenTrinhDoChinhTri.VisibleIndex = 1;
            // 
            // frmDMTrinhDoChinhTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 314);
            this.Controls.Add(this.gcDMTrinhDoChinhTri);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDMTrinhDoChinhTri";
            this.Text = "Danh mục trình độ Chính trị";
            this.Load += new System.EventHandler(this.frmDMTrinhDoChinhTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDMTrinhDoChinhTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDMTrinhDoChinhTri)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcDMTrinhDoChinhTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDMTrinhDoChinhTri;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaTrinhDoChinhTri;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenTrinhDoChinhTri;
        private DevExpress.XtraBars.BarLargeButtonItem btnThem;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnXuat;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
    }
}