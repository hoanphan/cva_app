namespace PRL
{
    partial class frmCapNhatLop
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
            this.btnKhoi = new DevExpress.XtraEditors.SimpleButton();
            this.lkuGVCN = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkuKhoi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbKhoi = new DevExpress.XtraEditors.LabelControl();
            this.lbTenLop = new DevExpress.XtraEditors.LabelControl();
            this.lbMaLop = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGVCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuKhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 226);
            this.barDockControlBottom.Size = new System.Drawing.Size(330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 152);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(330, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 152);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKhoi);
            this.groupControl1.Controls.Add(this.lkuGVCN);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lkuKhoi);
            this.groupControl1.Controls.Add(this.lbKhoi);
            this.groupControl1.Controls.Add(this.lbTenLop);
            this.groupControl1.Controls.Add(this.lbMaLop);
            this.groupControl1.Controls.Add(this.txtTenLop);
            this.groupControl1.Controls.Add(this.txtMaLop);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(330, 152);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin lớp:";
            // 
            // btnKhoi
            // 
            this.btnKhoi.Location = new System.Drawing.Point(289, 72);
            this.btnKhoi.Name = "btnKhoi";
            this.btnKhoi.Size = new System.Drawing.Size(23, 19);
            this.btnKhoi.TabIndex = 3;
            this.btnKhoi.Text = "...";
            this.btnKhoi.Click += new System.EventHandler(this.btnKhoi_Click);
            // 
            // lkuGVCN
            // 
            this.lkuGVCN.EditValue = "[Chọn giáo viên chủ nhiệm]";
            this.lkuGVCN.Location = new System.Drawing.Point(119, 124);
            this.lkuGVCN.Name = "lkuGVCN";
            this.lkuGVCN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuGVCN.Properties.DisplayMember = "HoVaTen";
            this.lkuGVCN.Properties.NullText = "[Chọn Giáo viên chủ nhiệm]";
            this.lkuGVCN.Properties.ValueMember = "MaGiaoVien";
            this.lkuGVCN.Properties.View = this.gridView1;
            this.lkuGVCN.Size = new System.Drawing.Size(193, 20);
            this.lkuGVCN.TabIndex = 2;
            this.lkuGVCN.Leave += new System.EventHandler(this.lkuGVCN_Leave);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã giáo viên";
            this.gridColumn1.FieldName = "MaGiaoVien";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tên giáo viên";
            this.gridColumn2.FieldName = "HoVaTen";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Giáo viên chủ nhiệm:";
            // 
            // lkuKhoi
            // 
            this.lkuKhoi.EditValue = "[Chọn khối]";
            this.dxErrorProvider.SetIconAlignment(this.lkuKhoi, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.lkuKhoi.Location = new System.Drawing.Point(119, 72);
            this.lkuKhoi.MenuManager = this.barManager1;
            this.lkuKhoi.Name = "lkuKhoi";
            this.lkuKhoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuKhoi.Properties.DisplayMember = "TenKhoi";
            this.lkuKhoi.Properties.NullText = "[Chọn khối]";
            this.lkuKhoi.Properties.ValueMember = "MaKhoi";
            this.lkuKhoi.Properties.View = this.gridLookUpEdit1View;
            this.lkuKhoi.Size = new System.Drawing.Size(164, 20);
            this.lkuKhoi.TabIndex = 2;
            this.lkuKhoi.Leave += new System.EventHandler(this.lkuKhoi_Leave);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.OddRow.BackColor = System.Drawing.Color.LightGray;
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseBackColor = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaKhoi,
            this.gcTenKhoi});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcMaKhoi
            // 
            this.gcMaKhoi.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaKhoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaKhoi.Caption = "Mã khối";
            this.gcMaKhoi.FieldName = "MaKhoi";
            this.gcMaKhoi.Name = "gcMaKhoi";
            // 
            // gcTenKhoi
            // 
            this.gcTenKhoi.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenKhoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenKhoi.Caption = "Tên khối";
            this.gcTenKhoi.FieldName = "TenKhoi";
            this.gcTenKhoi.Name = "gcTenKhoi";
            this.gcTenKhoi.Visible = true;
            this.gcTenKhoi.VisibleIndex = 0;
            // 
            // lbKhoi
            // 
            this.lbKhoi.Location = new System.Drawing.Point(19, 73);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(24, 13);
            this.lbKhoi.TabIndex = 1;
            this.lbKhoi.Text = "Khối:";
            // 
            // lbTenLop
            // 
            this.lbTenLop.Location = new System.Drawing.Point(19, 101);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(39, 13);
            this.lbTenLop.TabIndex = 1;
            this.lbTenLop.Text = "Tên lớp:";
            // 
            // lbMaLop
            // 
            this.lbMaLop.Location = new System.Drawing.Point(19, 44);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(35, 13);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "Mã lớp:";
            // 
            // txtTenLop
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenLop, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenLop.Location = new System.Drawing.Point(119, 98);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(193, 20);
            this.txtTenLop.TabIndex = 0;
            this.txtTenLop.Leave += new System.EventHandler(this.txtTenLop_Leave);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(119, 41);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(127, 20);
            this.txtMaLop.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 226);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatLop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatLop";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGVCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuKhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbTenLop;
        private DevExpress.XtraEditors.LabelControl lbMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl lbKhoi;
        private DevExpress.XtraEditors.GridLookUpEdit lkuKhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenKhoi;
        private DevExpress.XtraEditors.SimpleButton btnKhoi;
        private DevExpress.XtraEditors.GridLookUpEdit lkuGVCN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}