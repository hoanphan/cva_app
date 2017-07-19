namespace PRL
{
    partial class frmCapNhatQuanHuyen
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
            this.lkuTinhThanh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTinhThanh = new DevExpress.XtraEditors.LabelControl();
            this.lbTenQuanHuyen = new DevExpress.XtraEditors.LabelControl();
            this.lbMaQuanHuyen = new DevExpress.XtraEditors.LabelControl();
            this.txtTenQuanHuyen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaQuanHuyen = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuTinhThanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenQuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuanHuyen.Properties)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 204);
            this.barDockControlBottom.Size = new System.Drawing.Size(330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 130);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(330, 74);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 130);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTinhThanh);
            this.groupControl1.Controls.Add(this.lkuTinhThanh);
            this.groupControl1.Controls.Add(this.lbTinhThanh);
            this.groupControl1.Controls.Add(this.lbTenQuanHuyen);
            this.groupControl1.Controls.Add(this.lbMaQuanHuyen);
            this.groupControl1.Controls.Add(this.txtTenQuanHuyen);
            this.groupControl1.Controls.Add(this.txtMaQuanHuyen);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(330, 130);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin quận, huyện:";
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.Location = new System.Drawing.Point(281, 72);
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.Size = new System.Drawing.Size(23, 19);
            this.btnTinhThanh.TabIndex = 3;
            this.btnTinhThanh.Text = "...";
            this.btnTinhThanh.Click += new System.EventHandler(this.btnTinhThanh_Click);
            // 
            // lkuTinhThanh
            // 
            this.lkuTinhThanh.EditValue = "[Chọn tỉnh thành]";
            this.lkuTinhThanh.Location = new System.Drawing.Point(111, 72);
            this.lkuTinhThanh.MenuManager = this.barManager1;
            this.lkuTinhThanh.Name = "lkuTinhThanh";
            this.lkuTinhThanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuTinhThanh.Properties.DisplayMember = "TenTinhThanh";
            this.lkuTinhThanh.Properties.NullText = "[Chọn tỉnh thành]";
            this.lkuTinhThanh.Properties.ValueMember = "MaTinhThanh";
            this.lkuTinhThanh.Properties.View = this.gridLookUpEdit1View;
            this.lkuTinhThanh.Size = new System.Drawing.Size(164, 20);
            this.lkuTinhThanh.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.OddRow.BackColor = System.Drawing.Color.LightGray;
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseBackColor = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaTinhThanh,
            this.gcTenTinhThanh});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcMaTinhThanh
            // 
            this.gcMaTinhThanh.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaTinhThanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaTinhThanh.Caption = "Mã tỉnh thành";
            this.gcMaTinhThanh.FieldName = "MaTinhThanh";
            this.gcMaTinhThanh.Name = "gcMaTinhThanh";
            // 
            // gcTenTinhThanh
            // 
            this.gcTenTinhThanh.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenTinhThanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenTinhThanh.Caption = "Tên tỉnh thành";
            this.gcTenTinhThanh.FieldName = "TenTinhThanh";
            this.gcTenTinhThanh.Name = "gcTenTinhThanh";
            this.gcTenTinhThanh.Visible = true;
            this.gcTenTinhThanh.VisibleIndex = 0;
            // 
            // lbTinhThanh
            // 
            this.lbTinhThanh.Location = new System.Drawing.Point(19, 73);
            this.lbTinhThanh.Name = "lbTinhThanh";
            this.lbTinhThanh.Size = new System.Drawing.Size(80, 13);
            this.lbTinhThanh.TabIndex = 1;
            this.lbTinhThanh.Text = "Tỉnh, thành phố:";
            // 
            // lbTenQuanHuyen
            // 
            this.lbTenQuanHuyen.Location = new System.Drawing.Point(19, 101);
            this.lbTenQuanHuyen.Name = "lbTenQuanHuyen";
            this.lbTenQuanHuyen.Size = new System.Drawing.Size(86, 13);
            this.lbTenQuanHuyen.TabIndex = 1;
            this.lbTenQuanHuyen.Text = "Tên quận, huyện:";
            // 
            // lbMaQuanHuyen
            // 
            this.lbMaQuanHuyen.Location = new System.Drawing.Point(19, 44);
            this.lbMaQuanHuyen.Name = "lbMaQuanHuyen";
            this.lbMaQuanHuyen.Size = new System.Drawing.Size(82, 13);
            this.lbMaQuanHuyen.TabIndex = 1;
            this.lbMaQuanHuyen.Text = "Mã quận, huyện:";
            // 
            // txtTenQuanHuyen
            // 
            this.dxErrorProvider.SetIconAlignment(this.txtTenQuanHuyen, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTenQuanHuyen.Location = new System.Drawing.Point(111, 98);
            this.txtTenQuanHuyen.Name = "txtTenQuanHuyen";
            this.txtTenQuanHuyen.Size = new System.Drawing.Size(193, 20);
            this.txtTenQuanHuyen.TabIndex = 0;
            this.txtTenQuanHuyen.Leave += new System.EventHandler(this.txtTenQuanHuyen_Leave);
            // 
            // txtMaQuanHuyen
            // 
            this.txtMaQuanHuyen.Enabled = false;
            this.txtMaQuanHuyen.Location = new System.Drawing.Point(111, 41);
            this.txtMaQuanHuyen.MenuManager = this.barManager1;
            this.txtMaQuanHuyen.Name = "txtMaQuanHuyen";
            this.txtMaQuanHuyen.Size = new System.Drawing.Size(127, 20);
            this.txtMaQuanHuyen.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmCapNhatQuanHuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 204);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatQuanHuyen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatQuanHuyen";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuTinhThanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenQuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuanHuyen.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbTenQuanHuyen;
        private DevExpress.XtraEditors.LabelControl lbMaQuanHuyen;
        private DevExpress.XtraEditors.TextEdit txtTenQuanHuyen;
        private DevExpress.XtraEditors.TextEdit txtMaQuanHuyen;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl lbTinhThanh;
        private DevExpress.XtraEditors.GridLookUpEdit lkuTinhThanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaTinhThanh;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenTinhThanh;
        private DevExpress.XtraEditors.SimpleButton btnTinhThanh;
    }
}