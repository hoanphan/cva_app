namespace PRL
{
    partial class frmHocSinhThoiHoc
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gcHocSinhTheoLop = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinhTheoLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclMaHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHoDem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkDangKyDichVu = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbThamSo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.rightRight = new System.Windows.Forms.Panel();
            this.gbDanhSachThoiHoc = new System.Windows.Forms.GroupBox();
            this.gcHocSinhThoiHoc = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinhThoiHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTTCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclMaHSCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHoDemCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNoiChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbThamSoChuyen = new System.Windows.Forms.GroupBox();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.checkBuocThoiHoc = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.leftPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhTheoLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhTheoLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDangKyDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbThamSo.SuspendLayout();
            this.rightRight.SuspendLayout();
            this.gbDanhSachThoiHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhThoiHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhThoiHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.gbThamSoChuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.gbThamSo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(450, 545);
            this.leftPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcHocSinhTheoLop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 472);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh:";
            // 
            // gcHocSinhTheoLop
            // 
            this.gcHocSinhTheoLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcHocSinhTheoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinhTheoLop.Location = new System.Drawing.Point(3, 17);
            this.gcHocSinhTheoLop.MainView = this.gvHocSinhTheoLop;
            this.gcHocSinhTheoLop.Name = "gcHocSinhTheoLop";
            this.gcHocSinhTheoLop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkDangKyDichVu,
            this.repositoryItemCheckEdit1});
            this.gcHocSinhTheoLop.Size = new System.Drawing.Size(444, 452);
            this.gcHocSinhTheoLop.TabIndex = 5;
            this.gcHocSinhTheoLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocSinhTheoLop,
            this.gridView1});
            // 
            // gvHocSinhTheoLop
            // 
            this.gvHocSinhTheoLop.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gvHocSinhTheoLop.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvHocSinhTheoLop.Appearance.FocusedRow.BackColor = System.Drawing.Color.Red;
            this.gvHocSinhTheoLop.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvHocSinhTheoLop.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvHocSinhTheoLop.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvHocSinhTheoLop.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gvHocSinhTheoLop.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gvHocSinhTheoLop.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvHocSinhTheoLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTT,
            this.gclMaHocSinh,
            this.gclHoDem,
            this.gclTen,
            this.gclNgaySinh});
            this.gvHocSinhTheoLop.GridControl = this.gcHocSinhTheoLop;
            this.gvHocSinhTheoLop.Name = "gvHocSinhTheoLop";
            this.gvHocSinhTheoLop.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHocSinhTheoLop.OptionsView.EnableAppearanceOddRow = true;
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
            this.gclSTT.Name = "gclSTT";
            this.gclSTT.OptionsColumn.AllowEdit = false;
            this.gclSTT.OptionsColumn.AllowFocus = false;
            this.gclSTT.Visible = true;
            this.gclSTT.VisibleIndex = 0;
            this.gclSTT.Width = 62;
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
            this.gclMaHocSinh.Name = "gclMaHocSinh";
            this.gclMaHocSinh.OptionsColumn.AllowEdit = false;
            this.gclMaHocSinh.OptionsColumn.AllowFocus = false;
            this.gclMaHocSinh.Visible = true;
            this.gclMaHocSinh.VisibleIndex = 1;
            this.gclMaHocSinh.Width = 80;
            // 
            // gclHoDem
            // 
            this.gclHoDem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclHoDem.AppearanceHeader.Options.UseFont = true;
            this.gclHoDem.AppearanceHeader.Options.UseTextOptions = true;
            this.gclHoDem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHoDem.Caption = "Họ đệm";
            this.gclHoDem.FieldName = "HoDem";
            this.gclHoDem.Name = "gclHoDem";
            this.gclHoDem.OptionsColumn.AllowEdit = false;
            this.gclHoDem.OptionsColumn.AllowFocus = false;
            this.gclHoDem.Visible = true;
            this.gclHoDem.VisibleIndex = 2;
            this.gclHoDem.Width = 122;
            // 
            // gclTen
            // 
            this.gclTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTen.AppearanceHeader.Options.UseFont = true;
            this.gclTen.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTen.Caption = "Tên";
            this.gclTen.FieldName = "Ten";
            this.gclTen.Name = "gclTen";
            this.gclTen.OptionsColumn.AllowEdit = false;
            this.gclTen.OptionsColumn.AllowFocus = false;
            this.gclTen.Visible = true;
            this.gclTen.VisibleIndex = 3;
            this.gclTen.Width = 65;
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
            this.gclNgaySinh.OptionsColumn.AllowFocus = false;
            this.gclNgaySinh.Visible = true;
            this.gclNgaySinh.VisibleIndex = 4;
            this.gclNgaySinh.Width = 92;
            // 
            // checkDangKyDichVu
            // 
            this.checkDangKyDichVu.AutoHeight = false;
            this.checkDangKyDichVu.Name = "checkDangKyDichVu";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcHocSinhTheoLop;
            this.gridView1.Name = "gridView1";
            // 
            // gbThamSo
            // 
            this.gbThamSo.Controls.Add(this.label2);
            this.gbThamSo.Controls.Add(this.label1);
            this.gbThamSo.Controls.Add(this.cbLop);
            this.gbThamSo.Controls.Add(this.cbKhoi);
            this.gbThamSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThamSo.Location = new System.Drawing.Point(0, 0);
            this.gbThamSo.Name = "gbThamSo";
            this.gbThamSo.Size = new System.Drawing.Size(450, 73);
            this.gbThamSo.TabIndex = 0;
            this.gbThamSo.TabStop = false;
            this.gbThamSo.Text = "Tham số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối:";
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "TenLop";
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(300, 21);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(81, 21);
            this.cbLop.TabIndex = 0;
            this.cbLop.ValueMember = "MaLop";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbKhoi
            // 
            this.cbKhoi.DisplayMember = "TenKhoi";
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(155, 21);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(81, 21);
            this.cbKhoi.TabIndex = 0;
            this.cbKhoi.ValueMember = "MaKhoi";
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(454, 44);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(92, 23);
            this.btnChuyen.TabIndex = 2;
            this.btnChuyen.Text = "&Chuyển trường";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // rightRight
            // 
            this.rightRight.Controls.Add(this.gbDanhSachThoiHoc);
            this.rightRight.Controls.Add(this.gbThamSoChuyen);
            this.rightRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightRight.Location = new System.Drawing.Point(450, 0);
            this.rightRight.Name = "rightRight";
            this.rightRight.Size = new System.Drawing.Size(558, 545);
            this.rightRight.TabIndex = 1;
            // 
            // gbDanhSachThoiHoc
            // 
            this.gbDanhSachThoiHoc.Controls.Add(this.gcHocSinhThoiHoc);
            this.gbDanhSachThoiHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachThoiHoc.Location = new System.Drawing.Point(0, 73);
            this.gbDanhSachThoiHoc.Name = "gbDanhSachThoiHoc";
            this.gbDanhSachThoiHoc.Size = new System.Drawing.Size(558, 472);
            this.gbDanhSachThoiHoc.TabIndex = 1;
            this.gbDanhSachThoiHoc.TabStop = false;
            this.gbDanhSachThoiHoc.Text = "Danh sách thôi học:";
            // 
            // gcHocSinhThoiHoc
            // 
            this.gcHocSinhThoiHoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcHocSinhThoiHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinhThoiHoc.Location = new System.Drawing.Point(3, 17);
            this.gcHocSinhThoiHoc.MainView = this.gvHocSinhThoiHoc;
            this.gcHocSinhThoiHoc.Name = "gcHocSinhThoiHoc";
            this.gcHocSinhThoiHoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.gcHocSinhThoiHoc.Size = new System.Drawing.Size(552, 452);
            this.gcHocSinhThoiHoc.TabIndex = 6;
            this.gcHocSinhThoiHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocSinhThoiHoc,
            this.gridView3});
            // 
            // gvHocSinhThoiHoc
            // 
            this.gvHocSinhThoiHoc.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvHocSinhThoiHoc.Appearance.OddRow.Options.UseBackColor = true;
            this.gvHocSinhThoiHoc.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gvHocSinhThoiHoc.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvHocSinhThoiHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTTCT,
            this.gclMaHSCT,
            this.gclHoDemCT,
            this.gclTenCT,
            this.gclNoiChuyen});
            this.gvHocSinhThoiHoc.GridControl = this.gcHocSinhThoiHoc;
            this.gvHocSinhThoiHoc.Name = "gvHocSinhThoiHoc";
            // 
            // gclSTTCT
            // 
            this.gclSTTCT.AppearanceCell.Options.UseTextOptions = true;
            this.gclSTTCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSTTCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclSTTCT.AppearanceHeader.Options.UseFont = true;
            this.gclSTTCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclSTTCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSTTCT.Caption = "STT";
            this.gclSTTCT.FieldName = "STT";
            this.gclSTTCT.Name = "gclSTTCT";
            this.gclSTTCT.OptionsColumn.AllowEdit = false;
            this.gclSTTCT.OptionsColumn.AllowFocus = false;
            this.gclSTTCT.Visible = true;
            this.gclSTTCT.VisibleIndex = 0;
            this.gclSTTCT.Width = 46;
            // 
            // gclMaHSCT
            // 
            this.gclMaHSCT.AppearanceCell.Options.UseTextOptions = true;
            this.gclMaHSCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHSCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclMaHSCT.AppearanceHeader.Options.UseFont = true;
            this.gclMaHSCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaHSCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHSCT.Caption = "Mã HS";
            this.gclMaHSCT.FieldName = "MaHocSinh";
            this.gclMaHSCT.Name = "gclMaHSCT";
            this.gclMaHSCT.OptionsColumn.AllowEdit = false;
            this.gclMaHSCT.OptionsColumn.AllowFocus = false;
            this.gclMaHSCT.Visible = true;
            this.gclMaHSCT.VisibleIndex = 1;
            this.gclMaHSCT.Width = 80;
            // 
            // gclHoDemCT
            // 
            this.gclHoDemCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclHoDemCT.AppearanceHeader.Options.UseFont = true;
            this.gclHoDemCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclHoDemCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHoDemCT.Caption = "Họ đệm";
            this.gclHoDemCT.FieldName = "HoDem";
            this.gclHoDemCT.Name = "gclHoDemCT";
            this.gclHoDemCT.OptionsColumn.AllowEdit = false;
            this.gclHoDemCT.OptionsColumn.AllowFocus = false;
            this.gclHoDemCT.Visible = true;
            this.gclHoDemCT.VisibleIndex = 2;
            this.gclHoDemCT.Width = 153;
            // 
            // gclTenCT
            // 
            this.gclTenCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTenCT.AppearanceHeader.Options.UseFont = true;
            this.gclTenCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenCT.Caption = "Tên";
            this.gclTenCT.FieldName = "Ten";
            this.gclTenCT.Name = "gclTenCT";
            this.gclTenCT.OptionsColumn.AllowEdit = false;
            this.gclTenCT.OptionsColumn.AllowFocus = false;
            this.gclTenCT.Visible = true;
            this.gclTenCT.VisibleIndex = 3;
            this.gclTenCT.Width = 88;
            // 
            // gclNoiChuyen
            // 
            this.gclNoiChuyen.AppearanceCell.Options.UseTextOptions = true;
            this.gclNoiChuyen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNoiChuyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclNoiChuyen.AppearanceHeader.Options.UseFont = true;
            this.gclNoiChuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.gclNoiChuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNoiChuyen.Caption = "Nơi chuyển";
            this.gclNoiChuyen.FieldName = "NoiChuyen";
            this.gclNoiChuyen.Name = "gclNoiChuyen";
            this.gclNoiChuyen.OptionsColumn.AllowEdit = false;
            this.gclNoiChuyen.OptionsColumn.AllowFocus = false;
            this.gclNoiChuyen.Visible = true;
            this.gclNoiChuyen.VisibleIndex = 4;
            this.gclNoiChuyen.Width = 190;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcHocSinhThoiHoc;
            this.gridView3.Name = "gridView3";
            // 
            // gbThamSoChuyen
            // 
            this.gbThamSoChuyen.Controls.Add(this.txtLiDo);
            this.gbThamSoChuyen.Controls.Add(this.checkBuocThoiHoc);
            this.gbThamSoChuyen.Controls.Add(this.btnChuyen);
            this.gbThamSoChuyen.Controls.Add(this.label4);
            this.gbThamSoChuyen.Controls.Add(this.label3);
            this.gbThamSoChuyen.Controls.Add(this.cbHocKy);
            this.gbThamSoChuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThamSoChuyen.Location = new System.Drawing.Point(0, 0);
            this.gbThamSoChuyen.Name = "gbThamSoChuyen";
            this.gbThamSoChuyen.Size = new System.Drawing.Size(558, 73);
            this.gbThamSoChuyen.TabIndex = 0;
            this.gbThamSoChuyen.TabStop = false;
            this.gbThamSoChuyen.Text = "Tham số:";
            // 
            // txtLiDo
            // 
            this.txtLiDo.Location = new System.Drawing.Point(97, 46);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(333, 21);
            this.txtLiDo.TabIndex = 4;
            // 
            // checkBuocThoiHoc
            // 
            this.checkBuocThoiHoc.AutoSize = true;
            this.checkBuocThoiHoc.Location = new System.Drawing.Point(30, 23);
            this.checkBuocThoiHoc.Name = "checkBuocThoiHoc";
            this.checkBuocThoiHoc.Size = new System.Drawing.Size(90, 17);
            this.checkBuocThoiHoc.TabIndex = 3;
            this.checkBuocThoiHoc.Text = "Buộc thôi học";
            this.checkBuocThoiHoc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lí do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học kỳ:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(349, 21);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(81, 21);
            this.cbHocKy.TabIndex = 0;
            this.cbHocKy.ValueMember = "MaHocKy";
            // 
            // frmHocSinhThoiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 545);
            this.Controls.Add(this.rightRight);
            this.Controls.Add(this.leftPanel);
            this.Name = "frmHocSinhThoiHoc";
            this.Text = "Danh sách học sinh thôi học";
            this.Load += new System.EventHandler(this.frmHocSinhThoiHoc_Load);
            this.leftPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhTheoLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhTheoLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDangKyDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbThamSo.ResumeLayout(false);
            this.gbThamSo.PerformLayout();
            this.rightRight.ResumeLayout(false);
            this.gbDanhSachThoiHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhThoiHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhThoiHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.gbThamSoChuyen.ResumeLayout(false);
            this.gbThamSoChuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbThamSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private DevExpress.XtraGrid.GridControl gcHocSinhTheoLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinhTheoLop;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclHoDem;
        private DevExpress.XtraGrid.Columns.GridColumn gclTen;
        private DevExpress.XtraGrid.Columns.GridColumn gclNgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkDangKyDichVu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbDanhSachThoiHoc;
        private System.Windows.Forms.GroupBox gbThamSoChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Button btnChuyen;
        private DevExpress.XtraGrid.GridControl gcHocSinhThoiHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinhThoiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTTCT;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHSCT;
        private DevExpress.XtraGrid.Columns.GridColumn gclHoDemCT;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenCT;
        private DevExpress.XtraGrid.Columns.GridColumn gclNoiChuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.CheckBox checkBuocThoiHoc;
        private System.Windows.Forms.TextBox txtLiDo;
        private System.Windows.Forms.Label label4;
    }
}