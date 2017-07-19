namespace PRL
{
    partial class frmCapNhatChung
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
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.lbTenChung = new DevExpress.XtraEditors.LabelControl();
            this.lbMaChung = new DevExpress.XtraEditors.LabelControl();
            this.txtTenChung = new DevExpress.XtraEditors.TextEdit();
            this.txtMaChung = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChung.Properties)).BeginInit();
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
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.lbTenChung);
            this.groupThongTin.Controls.Add(this.lbMaChung);
            this.groupThongTin.Controls.Add(this.txtTenChung);
            this.groupThongTin.Controls.Add(this.txtMaChung);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupThongTin.Location = new System.Drawing.Point(0, 74);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(330, 124);
            this.groupThongTin.TabIndex = 4;
            this.groupThongTin.Text = "Thông tin tôn giáo:";
            // 
            // lbTenChung
            // 
            this.lbTenChung.Location = new System.Drawing.Point(19, 81);
            this.lbTenChung.Name = "lbTenChung";
            this.lbTenChung.Size = new System.Drawing.Size(64, 13);
            this.lbTenChung.TabIndex = 1;
            this.lbTenChung.Text = "Tên tôn giáo:";
            // 
            // lbMaChung
            // 
            this.lbMaChung.Location = new System.Drawing.Point(19, 44);
            this.lbMaChung.Name = "lbMaChung";
            this.lbMaChung.Size = new System.Drawing.Size(60, 13);
            this.lbMaChung.TabIndex = 1;
            this.lbMaChung.Text = "Mã tôn giáo:";
            // 
            // txtTenChung
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenChung, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenChung.Location = new System.Drawing.Point(99, 78);
            this.txtTenChung.Name = "txtTenChung";
            this.txtTenChung.Size = new System.Drawing.Size(193, 20);
            this.txtTenChung.TabIndex = 0;
            this.txtTenChung.Leave += new System.EventHandler(this.txtTenChung_Leave);
            // 
            // txtMaChung
            // 
            this.txtMaChung.Enabled = false;
            this.txtMaChung.Location = new System.Drawing.Point(99, 41);
            this.txtMaChung.MenuManager = this.barManager1;
            this.txtMaChung.Name = "txtMaChung";
            this.txtMaChung.Size = new System.Drawing.Size(127, 20);
            this.txtMaChung.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 198);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatChung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatChung";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChung.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private DevExpress.XtraEditors.LabelControl lbTenChung;
        private DevExpress.XtraEditors.LabelControl lbMaChung;
        private DevExpress.XtraEditors.TextEdit txtTenChung;
        private DevExpress.XtraEditors.TextEdit txtMaChung;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}