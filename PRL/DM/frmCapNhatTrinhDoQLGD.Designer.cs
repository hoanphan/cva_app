namespace PRL
{
    partial class frmCapNhatTrinhDoQLGD
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
            this.lbTenTrinhDoQLGD = new DevExpress.XtraEditors.LabelControl();
            this.lbMaTrinhDoQLGD = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTrinhDoQLGD = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTrinhDoQLGD = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDoQLGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDoQLGD.Properties)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(391, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 198);
            this.barDockControlBottom.Size = new System.Drawing.Size(391, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(391, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 124);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTenTrinhDoQLGD);
            this.groupControl1.Controls.Add(this.lbMaTrinhDoQLGD);
            this.groupControl1.Controls.Add(this.txtTenTrinhDoQLGD);
            this.groupControl1.Controls.Add(this.txtMaTrinhDoQLGD);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(391, 124);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin trình độ quản lí giáo dục:";
            // 
            // lbTenTrinhDoQLGD
            // 
            this.lbTenTrinhDoQLGD.Location = new System.Drawing.Point(19, 81);
            this.lbTenTrinhDoQLGD.Name = "lbTenTrinhDoQLGD";
            this.lbTenTrinhDoQLGD.Size = new System.Drawing.Size(139, 13);
            this.lbTenTrinhDoQLGD.TabIndex = 1;
            this.lbTenTrinhDoQLGD.Text = "Tên trình độ quản lí giáo dục:";
            // 
            // lbMaTrinhDoQLGD
            // 
            this.lbMaTrinhDoQLGD.Location = new System.Drawing.Point(19, 44);
            this.lbMaTrinhDoQLGD.Name = "lbMaTrinhDoQLGD";
            this.lbMaTrinhDoQLGD.Size = new System.Drawing.Size(135, 13);
            this.lbMaTrinhDoQLGD.TabIndex = 1;
            this.lbMaTrinhDoQLGD.Text = "Mã trình độ quản lí giáo dục:";
            // 
            // txtTenTrinhDoQLGD
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenTrinhDoQLGD, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenTrinhDoQLGD.Location = new System.Drawing.Point(165, 78);
            this.txtTenTrinhDoQLGD.Name = "txtTenTrinhDoQLGD";
            this.txtTenTrinhDoQLGD.Size = new System.Drawing.Size(193, 20);
            this.txtTenTrinhDoQLGD.TabIndex = 0;
            this.txtTenTrinhDoQLGD.Leave += new System.EventHandler(this.txtTenTinhThanh_Leave);
            // 
            // txtMaTrinhDoQLGD
            // 
            this.txtMaTrinhDoQLGD.Enabled = false;
            this.txtMaTrinhDoQLGD.Location = new System.Drawing.Point(165, 41);
            this.txtMaTrinhDoQLGD.MenuManager = this.barManager1;
            this.txtMaTrinhDoQLGD.Name = "txtMaTrinhDoQLGD";
            this.txtMaTrinhDoQLGD.Size = new System.Drawing.Size(127, 20);
            this.txtMaTrinhDoQLGD.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatTrinhDoQLGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 198);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatTrinhDoQLGD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatTrinhDoQLGD";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDoQLGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDoQLGD.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbTenTrinhDoQLGD;
        private DevExpress.XtraEditors.LabelControl lbMaTrinhDoQLGD;
        private DevExpress.XtraEditors.TextEdit txtTenTrinhDoQLGD;
        private DevExpress.XtraEditors.TextEdit txtMaTrinhDoQLGD;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}