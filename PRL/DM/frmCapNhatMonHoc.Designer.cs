namespace PRL
{
    partial class frmCapNhatMonHoc
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
            this.nudHeSo = new System.Windows.Forms.NumericUpDown();
            this.btnTinhThanh = new DevExpress.XtraEditors.SimpleButton();
            this.lkuHinhThucDanhGia = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclMaHinhThucDanhGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenHinhThucDanhGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTinhThanh = new DevExpress.XtraEditors.LabelControl();
            this.lbHeSo = new DevExpress.XtraEditors.LabelControl();
            this.lbTenMonHoc = new DevExpress.XtraEditors.LabelControl();
            this.lbMaMonHoc = new DevExpress.XtraEditors.LabelControl();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuHinhThucDanhGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(313, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 228);
            this.barDockControlBottom.Size = new System.Drawing.Size(313, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 154);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(313, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 154);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nudHeSo);
            this.groupControl1.Controls.Add(this.btnTinhThanh);
            this.groupControl1.Controls.Add(this.lkuHinhThucDanhGia);
            this.groupControl1.Controls.Add(this.lbTinhThanh);
            this.groupControl1.Controls.Add(this.lbHeSo);
            this.groupControl1.Controls.Add(this.lbTenMonHoc);
            this.groupControl1.Controls.Add(this.lbMaMonHoc);
            this.groupControl1.Controls.Add(this.txtTenMonHoc);
            this.groupControl1.Controls.Add(this.txtMaMonHoc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(313, 154);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin môn học:";
            // 
            // nudHeSo
            // 
            this.nudHeSo.Location = new System.Drawing.Point(113, 88);
            this.nudHeSo.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHeSo.Name = "nudHeSo";
            this.nudHeSo.Size = new System.Drawing.Size(52, 21);
            this.nudHeSo.TabIndex = 2;
            this.nudHeSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeSo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.Location = new System.Drawing.Point(270, 119);
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.Size = new System.Drawing.Size(23, 19);
            this.btnTinhThanh.TabIndex = 4;
            this.btnTinhThanh.Text = "...";
            this.btnTinhThanh.Click += new System.EventHandler(this.btnTinhThanh_Click);
            // 
            // lkuHinhThucDanhGia
            // 
            this.lkuHinhThucDanhGia.EditValue = "[Chọn hình thức đánh giá]";
            this.lkuHinhThucDanhGia.Location = new System.Drawing.Point(113, 118);
            this.lkuHinhThucDanhGia.MenuManager = this.barManager1;
            this.lkuHinhThucDanhGia.Name = "lkuHinhThucDanhGia";
            this.lkuHinhThucDanhGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuHinhThucDanhGia.Properties.DisplayMember = "TenHinhThucDanhGia";
            this.lkuHinhThucDanhGia.Properties.NullText = "[Chọn hình thức đánh giá]";
            this.lkuHinhThucDanhGia.Properties.ValueMember = "MaHinhThucDanhGia";
            this.lkuHinhThucDanhGia.Properties.View = this.gridLookUpEdit1View;
            this.lkuHinhThucDanhGia.Size = new System.Drawing.Size(151, 20);
            this.lkuHinhThucDanhGia.TabIndex = 3;
            this.lkuHinhThucDanhGia.Leave += new System.EventHandler(this.lkuHinhThucDanhGia_Leave);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.OddRow.BackColor = System.Drawing.Color.LightGray;
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseBackColor = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclMaHinhThucDanhGia,
            this.gclTenHinhThucDanhGia});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gclMaHinhThucDanhGia
            // 
            this.gclMaHinhThucDanhGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaHinhThucDanhGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHinhThucDanhGia.Caption = "Mã hình thức đánh giá";
            this.gclMaHinhThucDanhGia.FieldName = "MaHinhThucDanhGia";
            this.gclMaHinhThucDanhGia.Name = "gclMaHinhThucDanhGia";
            // 
            // gclTenHinhThucDanhGia
            // 
            this.gclTenHinhThucDanhGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenHinhThucDanhGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenHinhThucDanhGia.Caption = "Tên hình thức đánh giá";
            this.gclTenHinhThucDanhGia.FieldName = "TenHinhThucDanhGia";
            this.gclTenHinhThucDanhGia.Name = "gclTenHinhThucDanhGia";
            this.gclTenHinhThucDanhGia.Visible = true;
            this.gclTenHinhThucDanhGia.VisibleIndex = 0;
            // 
            // lbTinhThanh
            // 
            this.lbTinhThanh.Location = new System.Drawing.Point(16, 119);
            this.lbTinhThanh.Name = "lbTinhThanh";
            this.lbTinhThanh.Size = new System.Drawing.Size(94, 13);
            this.lbTinhThanh.TabIndex = 1;
            this.lbTinhThanh.Text = "Hình thức đánh giá:";
            // 
            // lbHeSo
            // 
            this.lbHeSo.Location = new System.Drawing.Point(16, 92);
            this.lbHeSo.Name = "lbHeSo";
            this.lbHeSo.Size = new System.Drawing.Size(31, 13);
            this.lbHeSo.TabIndex = 1;
            this.lbHeSo.Text = "Hệ số:";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.Location = new System.Drawing.Point(16, 64);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(65, 13);
            this.lbTenMonHoc.TabIndex = 1;
            this.lbTenMonHoc.Text = "Tên môn học:";
            // 
            // lbMaMonHoc
            // 
            this.lbMaMonHoc.Location = new System.Drawing.Point(16, 38);
            this.lbMaMonHoc.Name = "lbMaMonHoc";
            this.lbMaMonHoc.Size = new System.Drawing.Size(61, 13);
            this.lbMaMonHoc.TabIndex = 1;
            this.lbMaMonHoc.Text = "Mã môn học:";
            // 
            // txtTenMonHoc
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenMonHoc, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenMonHoc.Location = new System.Drawing.Point(113, 61);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(180, 20);
            this.txtTenMonHoc.TabIndex = 1;
            this.txtTenMonHoc.Leave += new System.EventHandler(this.txtTenMonHoc_Leave);
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Enabled = false;
            this.txtMaMonHoc.Location = new System.Drawing.Point(113, 35);
            this.txtMaMonHoc.MenuManager = this.barManager1;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(127, 20);
            this.txtMaMonHoc.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 228);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatMonHoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatMonHoc";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuHinhThucDanhGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbTenMonHoc;
        private DevExpress.XtraEditors.LabelControl lbMaMonHoc;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private DevExpress.XtraEditors.TextEdit txtMaMonHoc;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl lbTinhThanh;
        private DevExpress.XtraEditors.GridLookUpEdit lkuHinhThucDanhGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHinhThucDanhGia;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenHinhThucDanhGia;
        private DevExpress.XtraEditors.SimpleButton btnTinhThanh;
        private System.Windows.Forms.NumericUpDown nudHeSo;
        private DevExpress.XtraEditors.LabelControl lbHeSo;
    }
}