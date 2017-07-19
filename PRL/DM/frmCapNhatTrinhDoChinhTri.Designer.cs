namespace PRL
{
    partial class frmCapNhatTrinhDoChinhTri
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
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtTenTrinhDoChinhTri = new DevExpress.XtraEditors.TextEdit();
            this.lbTenTrinhDoChinhTri = new System.Windows.Forms.Label();
            this.txtMaTrinhDoChinhTri = new DevExpress.XtraEditors.TextEdit();
            this.lbMaTrinhDoChinhTri = new System.Windows.Forms.Label();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDoChinhTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDoChinhTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
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
            this.btnLuu,
            this.btnNapLai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "&Lưu và Đóng";
            this.btnLuu.Glyph = global::PRL.Properties.Resources.Save;
            this.btnLuu.Id = 0;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "&Nạp Lại";
            this.btnNapLai.Glyph = global::PRL.Properties.Resources.Refresh;
            this.btnNapLai.Id = 1;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "&Thoát";
            this.btnThoat.Glyph = global::PRL.Properties.Resources.Exit;
            this.btnThoat.Id = 2;
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
            this.barDockControlTop.Size = new System.Drawing.Size(337, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 212);
            this.barDockControlBottom.Size = new System.Drawing.Size(337, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 138);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(337, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 138);
            // 
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.txtTenTrinhDoChinhTri);
            this.gcThongTin.Controls.Add(this.lbTenTrinhDoChinhTri);
            this.gcThongTin.Controls.Add(this.txtMaTrinhDoChinhTri);
            this.gcThongTin.Controls.Add(this.lbMaTrinhDoChinhTri);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(0, 74);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(337, 138);
            this.gcThongTin.TabIndex = 4;
            this.gcThongTin.Text = "Thông trình độ chính trị:";
            // 
            // txtTenTrinhDoChinhTri
            // 
            this.txtTenTrinhDoChinhTri.Location = new System.Drawing.Point(131, 88);
            this.txtTenTrinhDoChinhTri.Name = "txtTenTrinhDoChinhTri";
            this.txtTenTrinhDoChinhTri.Size = new System.Drawing.Size(158, 20);
            this.txtTenTrinhDoChinhTri.TabIndex = 1;
            this.txtTenTrinhDoChinhTri.Leave += new System.EventHandler(this.txtTenTrinhDoChinhTri_Leave);
            // 
            // lbTenTrinhDoChinhTri
            // 
            this.lbTenTrinhDoChinhTri.AutoSize = true;
            this.lbTenTrinhDoChinhTri.Location = new System.Drawing.Point(12, 91);
            this.lbTenTrinhDoChinhTri.Name = "lbTenTrinhDoChinhTri";
            this.lbTenTrinhDoChinhTri.Size = new System.Drawing.Size(113, 13);
            this.lbTenTrinhDoChinhTri.TabIndex = 0;
            this.lbTenTrinhDoChinhTri.Text = "Tên trình độ chính trị :";
            // 
            // txtMaTrinhDoChinhTri
            // 
            this.txtMaTrinhDoChinhTri.Location = new System.Drawing.Point(131, 38);
            this.txtMaTrinhDoChinhTri.MenuManager = this.barManager1;
            this.txtMaTrinhDoChinhTri.Name = "txtMaTrinhDoChinhTri";
            this.txtMaTrinhDoChinhTri.Size = new System.Drawing.Size(128, 20);
            this.txtMaTrinhDoChinhTri.TabIndex = 1;
            // 
            // lbMaTrinhDoChinhTri
            // 
            this.lbMaTrinhDoChinhTri.AutoSize = true;
            this.lbMaTrinhDoChinhTri.Location = new System.Drawing.Point(12, 41);
            this.lbMaTrinhDoChinhTri.Name = "lbMaTrinhDoChinhTri";
            this.lbMaTrinhDoChinhTri.Size = new System.Drawing.Size(109, 13);
            this.lbMaTrinhDoChinhTri.TabIndex = 0;
            this.lbMaTrinhDoChinhTri.Text = "Mã trình độ chính trị :";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmCapNhatTrinhDoChinhTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 235);
            this.Controls.Add(this.gcThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatTrinhDoChinhTri";
            this.Text = "frmCapNhatTrinhDoChinhTri";
            this.Load += new System.EventHandler(this.frmCapNhatTrinhDoChinhTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            this.gcThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDoChinhTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDoChinhTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnLuu;
        private DevExpress.XtraBars.BarLargeButtonItem btnNapLai;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraEditors.TextEdit txtMaTrinhDoChinhTri;
        private System.Windows.Forms.Label lbMaTrinhDoChinhTri;
        private DevExpress.XtraEditors.TextEdit txtTenTrinhDoChinhTri;
        private System.Windows.Forms.Label lbTenTrinhDoChinhTri;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}