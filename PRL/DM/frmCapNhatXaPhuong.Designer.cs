namespace PRL
{
    partial class frmCapNhatXaPhuong
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
            this.btnLuu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTinhThanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuanHuyen = new DevExpress.XtraEditors.SimpleButton();
            this.lkuTinhThanh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkuQuanHuyen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbQuanHuyen = new DevExpress.XtraEditors.LabelControl();
            this.lbTenXaPhuong = new DevExpress.XtraEditors.LabelControl();
            this.lbMaXaPhuong = new DevExpress.XtraEditors.LabelControl();
            this.txtTenXaPhuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaXaPhuong = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuTinhThanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuQuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXaPhuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXaPhuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLuu,
            this.btnNapLai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNapLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "&Lưu và đóng";
            this.btnLuu.Id = 0;
            this.btnLuu.LargeGlyph = global::PRL.Properties.Resources.Save;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "&Nạp lại";
            this.btnNapLai.Id = 1;
            this.btnNapLai.LargeGlyph = global::PRL.Properties.Resources.Refresh;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "&Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.LargeGlyph = global::PRL.Properties.Resources.Exit;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(330, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 267);
            this.barDockControlBottom.Size = new System.Drawing.Size(330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 193);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(330, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 193);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTinhThanh);
            this.groupControl1.Controls.Add(this.btnQuanHuyen);
            this.groupControl1.Controls.Add(this.lkuTinhThanh);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lkuQuanHuyen);
            this.groupControl1.Controls.Add(this.lbQuanHuyen);
            this.groupControl1.Controls.Add(this.lbTenXaPhuong);
            this.groupControl1.Controls.Add(this.lbMaXaPhuong);
            this.groupControl1.Controls.Add(this.txtTenXaPhuong);
            this.groupControl1.Controls.Add(this.txtMaXaPhuong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(330, 193);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin xã,phường:";
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.Location = new System.Drawing.Point(281, 77);
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.Size = new System.Drawing.Size(23, 19);
            this.btnTinhThanh.TabIndex = 3;
            this.btnTinhThanh.Text = "...";
            this.btnTinhThanh.Click += new System.EventHandler(this.btnTinhThanh_Click);
            // 
            // btnQuanHuyen
            // 
            this.btnQuanHuyen.Location = new System.Drawing.Point(281, 112);
            this.btnQuanHuyen.Name = "btnQuanHuyen";
            this.btnQuanHuyen.Size = new System.Drawing.Size(23, 19);
            this.btnQuanHuyen.TabIndex = 3;
            this.btnQuanHuyen.Text = "...";
            this.btnQuanHuyen.Click += new System.EventHandler(this.btnQuanHuyen_Click);
            // 
            // lkuTinhThanh
            // 
            this.lkuTinhThanh.EditValue = "MaTinhThanh";
            this.lkuTinhThanh.Location = new System.Drawing.Point(111, 77);
            this.lkuTinhThanh.Name = "lkuTinhThanh";
            this.lkuTinhThanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuTinhThanh.Properties.DisplayMember = "TenTinhThanh";
            this.lkuTinhThanh.Properties.NullText = "[Chọn Tỉnh thành]";
            this.lkuTinhThanh.Properties.ValueMember = "MaTinhThanh";
            this.lkuTinhThanh.Properties.View = this.gridView1;
            this.lkuTinhThanh.Size = new System.Drawing.Size(164, 20);
            this.lkuTinhThanh.TabIndex = 1;
            this.lkuTinhThanh.EditValueChanged += new System.EventHandler(this.lkuTinhThanh_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaTinhThanh,
            this.gcTenTinhThanh});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gcMaTinhThanh
            // 
            this.gcMaTinhThanh.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaTinhThanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaTinhThanh.Caption = "Mã Tỉnh thành";
            this.gcMaTinhThanh.FieldName = "MaTinhThanh";
            this.gcMaTinhThanh.Name = "gcMaTinhThanh";
            // 
            // gcTenTinhThanh
            // 
            this.gcTenTinhThanh.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenTinhThanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenTinhThanh.Caption = "Tên Tỉnh thành";
            this.gcTenTinhThanh.FieldName = "TenTinhThanh";
            this.gcTenTinhThanh.Name = "gcTenTinhThanh";
            this.gcTenTinhThanh.Visible = true;
            this.gcTenTinhThanh.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tỉnh thành";
            // 
            // lkuQuanHuyen
            // 
            this.lkuQuanHuyen.EditValue = "MaQuanHuyen";
            this.lkuQuanHuyen.Location = new System.Drawing.Point(111, 112);
            this.lkuQuanHuyen.MenuManager = this.barManager1;
            this.lkuQuanHuyen.Name = "lkuQuanHuyen";
            this.lkuQuanHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuQuanHuyen.Properties.DisplayMember = "TenQuanHuyen";
            this.lkuQuanHuyen.Properties.NullText = "[Chọn Quận huyện]";
            this.lkuQuanHuyen.Properties.ValueMember = "MaQuanHuyen";
            this.lkuQuanHuyen.Properties.View = this.gridLookUpEdit1View;
            this.lkuQuanHuyen.Size = new System.Drawing.Size(164, 20);
            this.lkuQuanHuyen.TabIndex = 2;
            this.lkuQuanHuyen.EditValueChanged += new System.EventHandler(this.lkuTinhThanh_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.OddRow.BackColor = System.Drawing.Color.LightGray;
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseBackColor = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaQuanHuyen,
            this.gcTenQuanHuyen});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcMaQuanHuyen
            // 
            this.gcMaQuanHuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaQuanHuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaQuanHuyen.Caption = "Mã Quận ,Huyện";
            this.gcMaQuanHuyen.FieldName = "MaQuanHuyen";
            this.gcMaQuanHuyen.Name = "gcMaQuanHuyen";
            // 
            // gcTenQuanHuyen
            // 
            this.gcTenQuanHuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenQuanHuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenQuanHuyen.Caption = "Tên quận, huyện";
            this.gcTenQuanHuyen.FieldName = "TenQuanHuyen";
            this.gcTenQuanHuyen.Name = "gcTenQuanHuyen";
            this.gcTenQuanHuyen.Visible = true;
            this.gcTenQuanHuyen.VisibleIndex = 0;
            // 
            // lbQuanHuyen
            // 
            this.lbQuanHuyen.Location = new System.Drawing.Point(19, 115);
            this.lbQuanHuyen.Name = "lbQuanHuyen";
            this.lbQuanHuyen.Size = new System.Drawing.Size(68, 13);
            this.lbQuanHuyen.TabIndex = 1;
            this.lbQuanHuyen.Text = "Quận, Huyện:";
            // 
            // lbTenXaPhuong
            // 
            this.lbTenXaPhuong.Location = new System.Drawing.Point(19, 143);
            this.lbTenXaPhuong.Name = "lbTenXaPhuong";
            this.lbTenXaPhuong.Size = new System.Drawing.Size(81, 13);
            this.lbTenXaPhuong.TabIndex = 1;
            this.lbTenXaPhuong.Text = "Tên Xã, Phường:";
            // 
            // lbMaXaPhuong
            // 
            this.lbMaXaPhuong.Location = new System.Drawing.Point(19, 44);
            this.lbMaXaPhuong.Name = "lbMaXaPhuong";
            this.lbMaXaPhuong.Size = new System.Drawing.Size(77, 13);
            this.lbMaXaPhuong.TabIndex = 1;
            this.lbMaXaPhuong.Text = "Mã xã, phường:";
            // 
            // txtTenXaPhuong
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenXaPhuong, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenXaPhuong.Location = new System.Drawing.Point(111, 140);
            this.txtTenXaPhuong.Name = "txtTenXaPhuong";
            this.txtTenXaPhuong.Size = new System.Drawing.Size(193, 20);
            this.txtTenXaPhuong.TabIndex = 0;
            this.txtTenXaPhuong.Leave += new System.EventHandler(this.txtTenQuanHuyen_Leave);
            // 
            // txtMaXaPhuong
            // 
            this.txtMaXaPhuong.Enabled = false;
            this.txtMaXaPhuong.Location = new System.Drawing.Point(111, 41);
            this.txtMaXaPhuong.MenuManager = this.barManager1;
            this.txtMaXaPhuong.Name = "txtMaXaPhuong";
            this.txtMaXaPhuong.Size = new System.Drawing.Size(127, 20);
            this.txtMaXaPhuong.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatXaPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 267);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatXaPhuong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatQuanHuyen";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuTinhThanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuQuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXaPhuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXaPhuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnLuu;
        private DevExpress.XtraBars.BarLargeButtonItem btnNapLai;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbTenXaPhuong;
        private DevExpress.XtraEditors.LabelControl lbMaXaPhuong;
        private DevExpress.XtraEditors.TextEdit txtTenXaPhuong;
        private DevExpress.XtraEditors.TextEdit txtMaXaPhuong;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl lbQuanHuyen;
        private DevExpress.XtraEditors.GridLookUpEdit lkuQuanHuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaQuanHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenQuanHuyen;
        private DevExpress.XtraEditors.SimpleButton btnQuanHuyen;
        private DevExpress.XtraEditors.SimpleButton btnTinhThanh;
        private DevExpress.XtraEditors.GridLookUpEdit lkuTinhThanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaTinhThanh;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenTinhThanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}