namespace PRL
{
    partial class frmCapNhatHinhThucDanhGia
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
            this.lbTenHinhThucDanhGia = new DevExpress.XtraEditors.LabelControl();
            this.lbMaHinhThucDanhGia = new DevExpress.XtraEditors.LabelControl();
            this.txtTenHinhThucDanhGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHinhThucDanhGia = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbTinhDiem = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHinhThucDanhGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHinhThucDanhGia.Properties)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(426, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 216);
            this.barDockControlBottom.Size = new System.Drawing.Size(426, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 142);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(426, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 142);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbTinhDiem);
            this.groupControl1.Controls.Add(this.lbTenHinhThucDanhGia);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lbMaHinhThucDanhGia);
            this.groupControl1.Controls.Add(this.txtTenHinhThucDanhGia);
            this.groupControl1.Controls.Add(this.txtMaHinhThucDanhGia);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 142);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin hình thức đánh giá:";
            // 
            // lbTenHinhThucDanhGia
            // 
            this.lbTenHinhThucDanhGia.Location = new System.Drawing.Point(19, 81);
            this.lbTenHinhThucDanhGia.Name = "lbTenHinhThucDanhGia";
            this.lbTenHinhThucDanhGia.Size = new System.Drawing.Size(114, 13);
            this.lbTenHinhThucDanhGia.TabIndex = 1;
            this.lbTenHinhThucDanhGia.Text = "Tên hình thức đánh giá:";
            // 
            // lbMaHinhThucDanhGia
            // 
            this.lbMaHinhThucDanhGia.Location = new System.Drawing.Point(19, 44);
            this.lbMaHinhThucDanhGia.Name = "lbMaHinhThucDanhGia";
            this.lbMaHinhThucDanhGia.Size = new System.Drawing.Size(110, 13);
            this.lbMaHinhThucDanhGia.TabIndex = 1;
            this.lbMaHinhThucDanhGia.Text = "Mã hình thức đánh giá:";
            // 
            // txtTenHinhThucDanhGia
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenHinhThucDanhGia, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenHinhThucDanhGia.Location = new System.Drawing.Point(137, 78);
            this.txtTenHinhThucDanhGia.Name = "txtTenHinhThucDanhGia";
            this.txtTenHinhThucDanhGia.Size = new System.Drawing.Size(193, 20);
            this.txtTenHinhThucDanhGia.TabIndex = 0;
            this.txtTenHinhThucDanhGia.Leave += new System.EventHandler(this.txtTenHinhThucDanhGia_Leave);
            // 
            // txtMaHinhThucDanhGia
            // 
            this.txtMaHinhThucDanhGia.Enabled = false;
            this.txtMaHinhThucDanhGia.Location = new System.Drawing.Point(137, 41);
            this.txtMaHinhThucDanhGia.MenuManager = this.barManager1;
            this.txtMaHinhThucDanhGia.Name = "txtMaHinhThucDanhGia";
            this.txtMaHinhThucDanhGia.Size = new System.Drawing.Size(127, 20);
            this.txtMaHinhThucDanhGia.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tính điểm:";
            // 
            // cbTinhDiem
            // 
            this.cbTinhDiem.AutoSize = true;
            this.cbTinhDiem.Location = new System.Drawing.Point(137, 116);
            this.cbTinhDiem.Name = "cbTinhDiem";
            this.cbTinhDiem.Size = new System.Drawing.Size(15, 14);
            this.cbTinhDiem.TabIndex = 2;
            this.cbTinhDiem.UseVisualStyleBackColor = true;
            // 
            // frmCapNhatHinhThucDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 216);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatHinhThucDanhGia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatHinhThucDanhGia";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHinhThucDanhGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHinhThucDanhGia.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbTenHinhThucDanhGia;
        private DevExpress.XtraEditors.LabelControl lbMaHinhThucDanhGia;
        private DevExpress.XtraEditors.TextEdit txtTenHinhThucDanhGia;
        private DevExpress.XtraEditors.TextEdit txtMaHinhThucDanhGia;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private System.Windows.Forms.CheckBox cbTinhDiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}