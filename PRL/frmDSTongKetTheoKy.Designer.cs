namespace PRL
{
    partial class frmDSTongKetTheoKy
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
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnTaoDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDiemTrungBinhCong = new DevExpress.XtraGrid.GridControl();
            this.gvDiemTrungBinhCong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclMaHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkuVD = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lkuGiaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclMaGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PRL.frmWaiting), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiemTrungBinhCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemTrungBinhCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoDuLieu});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(856, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Size = new System.Drawing.Size(856, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(856, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
            // 
            // btnTaoDuLieu
            // 
            this.btnTaoDuLieu.Id = 3;
            this.btnTaoDuLieu.Name = "btnTaoDuLieu";
            // 
            // cbKhoi
            // 
            this.cbKhoi.DisplayMember = "TenKhoi";
            this.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(90, 12);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(58, 21);
            this.cbKhoi.TabIndex = 6;
            this.cbKhoi.ValueMember = "MaKhoi";
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "TenLop";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(210, 11);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(58, 21);
            this.cbLop.TabIndex = 6;
            this.cbLop.ValueMember = "MaLop";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(341, 12);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(74, 21);
            this.cbHocKy.TabIndex = 6;
            this.cbHocKy.ValueMember = "MaHocKy";
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khối:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Học kỳ:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbLop);
            this.panelControl1.Controls.Add(this.cbKhoi);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.cbHocKy);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(856, 43);
            this.panelControl1.TabIndex = 13;
            // 
            // gcDiemTrungBinhCong
            // 
            this.gcDiemTrungBinhCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDiemTrungBinhCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiemTrungBinhCong.Location = new System.Drawing.Point(0, 43);
            this.gcDiemTrungBinhCong.MainView = this.gvDiemTrungBinhCong;
            this.gcDiemTrungBinhCong.Name = "gcDiemTrungBinhCong";
            this.gcDiemTrungBinhCong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkuVD});
            this.gcDiemTrungBinhCong.Size = new System.Drawing.Size(856, 347);
            this.gcDiemTrungBinhCong.TabIndex = 18;
            this.gcDiemTrungBinhCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiemTrungBinhCong});
            // 
            // gvDiemTrungBinhCong
            // 
            this.gvDiemTrungBinhCong.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDiemTrungBinhCong.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDiemTrungBinhCong.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDiemTrungBinhCong.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDiemTrungBinhCong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTT,
            this.gclMaHocSinh,
            this.gclTenHocSinh,
            this.gclNgaySinh});
            this.gvDiemTrungBinhCong.GridControl = this.gcDiemTrungBinhCong;
            this.gvDiemTrungBinhCong.Name = "gvDiemTrungBinhCong";
            this.gvDiemTrungBinhCong.OptionsView.ColumnAutoWidth = false;
            this.gvDiemTrungBinhCong.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDiemTrungBinhCong.OptionsView.EnableAppearanceOddRow = true;
            this.gvDiemTrungBinhCong.OptionsView.ShowGroupPanel = false;
            // 
            // gclSTT
            // 
            this.gclSTT.AppearanceCell.Options.UseTextOptions = true;
            this.gclSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclSTT.AppearanceHeader.Options.UseFont = true;
            this.gclSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSTT.Caption = "STT";
            this.gclSTT.FieldName = "STT";
            this.gclSTT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gclSTT.Name = "gclSTT";
            this.gclSTT.OptionsColumn.AllowEdit = false;
            this.gclSTT.OptionsColumn.AllowSize = false;
            this.gclSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclSTT.Visible = true;
            this.gclSTT.VisibleIndex = 0;
            this.gclSTT.Width = 40;
            // 
            // gclMaHocSinh
            // 
            this.gclMaHocSinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclMaHocSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHocSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclMaHocSinh.AppearanceHeader.Options.UseFont = true;
            this.gclMaHocSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaHocSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHocSinh.Caption = "Mã HS";
            this.gclMaHocSinh.FieldName = "MaHocSinh";
            this.gclMaHocSinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gclMaHocSinh.Name = "gclMaHocSinh";
            this.gclMaHocSinh.OptionsColumn.AllowEdit = false;
            this.gclMaHocSinh.OptionsColumn.AllowSize = false;
            this.gclMaHocSinh.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclMaHocSinh.Visible = true;
            this.gclMaHocSinh.VisibleIndex = 1;
            this.gclMaHocSinh.Width = 50;
            // 
            // gclTenHocSinh
            // 
            this.gclTenHocSinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclTenHocSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenHocSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTenHocSinh.AppearanceHeader.Options.UseFont = true;
            this.gclTenHocSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenHocSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenHocSinh.Caption = "Họ và tên";
            this.gclTenHocSinh.FieldName = "HoVaTen";
            this.gclTenHocSinh.Name = "gclTenHocSinh";
            this.gclTenHocSinh.OptionsColumn.AllowEdit = false;
            this.gclTenHocSinh.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclTenHocSinh.Visible = true;
            this.gclTenHocSinh.VisibleIndex = 2;
            this.gclTenHocSinh.Width = 130;
            // 
            // gclNgaySinh
            // 
            this.gclNgaySinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclNgaySinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNgaySinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclNgaySinh.AppearanceHeader.Options.UseFont = true;
            this.gclNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNgaySinh.Caption = "Ngày sinh";
            this.gclNgaySinh.FieldName = "NgaySinh";
            this.gclNgaySinh.Name = "gclNgaySinh";
            this.gclNgaySinh.OptionsColumn.AllowEdit = false;
            this.gclNgaySinh.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclNgaySinh.Visible = true;
            this.gclNgaySinh.VisibleIndex = 3;
            // 
            // lkuVD
            // 
            this.lkuVD.AutoHeight = false;
            this.lkuVD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuVD.DisplayMember = "HoVaTen";
            this.lkuVD.Name = "lkuVD";
            this.lkuVD.ValueMember = "MaGiaoVien";
            this.lkuVD.View = this.lkuGiaoVien;
            // 
            // lkuGiaoVien
            // 
            this.lkuGiaoVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclMaGiaoVien,
            this.gclTenGiaoVien});
            this.lkuGiaoVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lkuGiaoVien.Name = "lkuGiaoVien";
            this.lkuGiaoVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lkuGiaoVien.OptionsView.ShowGroupPanel = false;
            // 
            // gclMaGiaoVien
            // 
            this.gclMaGiaoVien.AppearanceCell.Options.UseTextOptions = true;
            this.gclMaGiaoVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaGiaoVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclMaGiaoVien.AppearanceHeader.Options.UseFont = true;
            this.gclMaGiaoVien.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaGiaoVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaGiaoVien.Caption = "Mã giáo viên";
            this.gclMaGiaoVien.FieldName = "MaGiaoVien";
            this.gclMaGiaoVien.Name = "gclMaGiaoVien";
            this.gclMaGiaoVien.Visible = true;
            this.gclMaGiaoVien.VisibleIndex = 0;
            // 
            // gclTenGiaoVien
            // 
            this.gclTenGiaoVien.AppearanceCell.Options.UseTextOptions = true;
            this.gclTenGiaoVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenGiaoVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTenGiaoVien.AppearanceHeader.Options.UseFont = true;
            this.gclTenGiaoVien.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenGiaoVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenGiaoVien.Caption = "Tên giáo viên";
            this.gclTenGiaoVien.FieldName = "HoVaTen";
            this.gclTenGiaoVien.Name = "gclTenGiaoVien";
            this.gclTenGiaoVien.Visible = true;
            this.gclTenGiaoVien.VisibleIndex = 1;
            // 
            // frmDSTongKetTheoKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 413);
            this.Controls.Add(this.gcDiemTrungBinhCong);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSTongKetTheoKy";
            this.Text = "Tổng hợp theo học kỳ";
            this.Load += new System.EventHandler(this.frmDSTongKetTheoKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiemTrungBinhCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemTrungBinhCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnTaoDuLieu;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcDiemTrungBinhCong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiemTrungBinhCong;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclNgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lkuVD;
        private DevExpress.XtraGrid.Views.Grid.GridView lkuGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenGiaoVien;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}