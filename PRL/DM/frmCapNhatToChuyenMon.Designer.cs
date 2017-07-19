namespace PRL
{
    partial class frmCapNhatToChuyenMon
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
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.lbTenToChuyenMon = new DevExpress.XtraEditors.LabelControl();
            this.lbMaToChuyenMon = new DevExpress.XtraEditors.LabelControl();
            this.txtTenToChuyenMon = new DevExpress.XtraEditors.TextEdit();
            this.txtMaToChuyenMon = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenToChuyenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaToChuyenMon.Properties)).BeginInit();
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
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.lbTenToChuyenMon);
            this.gcThongTin.Controls.Add(this.lbMaToChuyenMon);
            this.gcThongTin.Controls.Add(this.txtTenToChuyenMon);
            this.gcThongTin.Controls.Add(this.txtMaToChuyenMon);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(0, 74);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(330, 124);
            this.gcThongTin.TabIndex = 4;
            this.gcThongTin.Text = "Thông tin tổ chuyên môn:";
            // 
            // lbTenToChuyenMon
            // 
            this.lbTenToChuyenMon.Location = new System.Drawing.Point(19, 81);
            this.lbTenToChuyenMon.Name = "lbTenToChuyenMon";
            this.lbTenToChuyenMon.Size = new System.Drawing.Size(96, 13);
            this.lbTenToChuyenMon.TabIndex = 1;
            this.lbTenToChuyenMon.Text = "Tên tổ chuyên môn:";
            // 
            // lbMaToChuyenMon
            // 
            this.lbMaToChuyenMon.Location = new System.Drawing.Point(19, 44);
            this.lbMaToChuyenMon.Name = "lbMaToChuyenMon";
            this.lbMaToChuyenMon.Size = new System.Drawing.Size(92, 13);
            this.lbMaToChuyenMon.TabIndex = 1;
            this.lbMaToChuyenMon.Text = "Mã tổ chuyên môn:";
            // 
            // txtTenToChuyenMon
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenToChuyenMon, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenToChuyenMon.Location = new System.Drawing.Point(115, 78);
            this.txtTenToChuyenMon.Name = "txtTenToChuyenMon";
            this.txtTenToChuyenMon.Size = new System.Drawing.Size(193, 20);
            this.txtTenToChuyenMon.TabIndex = 0;
            this.txtTenToChuyenMon.Leave += new System.EventHandler(this.txtTenToChuyenMon_Leave);
            // 
            // txtMaToChuyenMon
            // 
            this.txtMaToChuyenMon.Enabled = false;
            this.txtMaToChuyenMon.Location = new System.Drawing.Point(115, 41);
            this.txtMaToChuyenMon.MenuManager = this.barManager1;
            this.txtMaToChuyenMon.Name = "txtMaToChuyenMon";
            this.txtMaToChuyenMon.Size = new System.Drawing.Size(127, 20);
            this.txtMaToChuyenMon.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatToChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 198);
            this.Controls.Add(this.gcThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatToChuyenMon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatToChuyenMon";
            this.Load += new System.EventHandler(this.frmCapNhatToChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            this.gcThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenToChuyenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaToChuyenMon.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraEditors.LabelControl lbTenToChuyenMon;
        private DevExpress.XtraEditors.LabelControl lbMaToChuyenMon;
        private DevExpress.XtraEditors.TextEdit txtTenToChuyenMon;
        private DevExpress.XtraEditors.TextEdit txtMaToChuyenMon;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}