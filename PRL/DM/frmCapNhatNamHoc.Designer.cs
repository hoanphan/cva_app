namespace PRL
{
    partial class frmCapNhatNamHoc
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.lbTenNamHoc = new DevExpress.XtraEditors.LabelControl();
            this.lbMaNamHoc = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNamHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNamHoc = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkNamHienTai = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNamHienTai.Properties)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 198);
            this.barDockControlBottom.Size = new System.Drawing.Size(330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 124);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(330, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 124);
            // 
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.chkNamHienTai);
            this.gcThongTin.Controls.Add(this.labelControl1);
            this.gcThongTin.Controls.Add(this.lbTenNamHoc);
            this.gcThongTin.Controls.Add(this.lbMaNamHoc);
            this.gcThongTin.Controls.Add(this.txtTenNamHoc);
            this.gcThongTin.Controls.Add(this.txtMaNamHoc);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(0, 74);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(330, 124);
            this.gcThongTin.TabIndex = 4;
            this.gcThongTin.Text = "Thông tin năm học:";
            // 
            // lbTenNamHoc
            // 
            this.lbTenNamHoc.Location = new System.Drawing.Point(31, 60);
            this.lbTenNamHoc.Name = "lbTenNamHoc";
            this.lbTenNamHoc.Size = new System.Drawing.Size(65, 13);
            this.lbTenNamHoc.TabIndex = 1;
            this.lbTenNamHoc.Text = "Tên năm học:";
            // 
            // lbMaNamHoc
            // 
            this.lbMaNamHoc.Location = new System.Drawing.Point(31, 34);
            this.lbMaNamHoc.Name = "lbMaNamHoc";
            this.lbMaNamHoc.Size = new System.Drawing.Size(61, 13);
            this.lbMaNamHoc.TabIndex = 1;
            this.lbMaNamHoc.Text = "Mã năm học:";
            // 
            // txtTenNamHoc
            // 
            this.txtTenNamHoc.EditValue = "";
            this.dxErrorProvider.SetIconAlignment(this.txtTenNamHoc, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenNamHoc.Location = new System.Drawing.Point(111, 57);
            this.txtTenNamHoc.Name = "txtTenNamHoc";
            this.txtTenNamHoc.Size = new System.Drawing.Size(193, 20);
            this.txtTenNamHoc.TabIndex = 0;
            this.txtTenNamHoc.Leave += new System.EventHandler(this.txtTenNamHoc_Leave);
            // 
            // txtMaNamHoc
            // 
            this.txtMaNamHoc.Enabled = false;
            this.txtMaNamHoc.Location = new System.Drawing.Point(111, 31);
            this.txtMaNamHoc.MenuManager = this.barManager1;
            this.txtMaNamHoc.Name = "txtMaNamHoc";
            this.txtMaNamHoc.Size = new System.Drawing.Size(127, 20);
            this.txtMaNamHoc.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Năm hiện tại:";
            // 
            // chkNamHienTai
            // 
            this.chkNamHienTai.Location = new System.Drawing.Point(111, 86);
            this.chkNamHienTai.MenuManager = this.barManager1;
            this.chkNamHienTai.Name = "chkNamHienTai";
            this.chkNamHienTai.Properties.Caption = "";
            this.chkNamHienTai.Size = new System.Drawing.Size(24, 19);
            this.chkNamHienTai.TabIndex = 2;
            // 
            // frmCapNhatNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 198);
            this.Controls.Add(this.gcThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatNamHoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatNamHoc";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            this.gcThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNamHienTai.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraEditors.LabelControl lbTenNamHoc;
        private DevExpress.XtraEditors.LabelControl lbMaNamHoc;
        private DevExpress.XtraEditors.TextEdit txtTenNamHoc;
        private DevExpress.XtraEditors.TextEdit txtMaNamHoc;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.CheckEdit chkNamHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}