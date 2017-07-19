namespace PRL
{
    partial class frmNhapDiemHSChuyenTruong
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
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gvDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclMaHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkuHocLuc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkuHanhKiem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkuDanhHieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PRL.frmWaiting), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuHocLuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuHanhKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuDanhHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.btnLuu);
            this.groupThongTin.Controls.Add(this.cbHocKy);
            this.groupThongTin.Controls.Add(this.cbLop);
            this.groupThongTin.Controls.Add(this.cbKhoi);
            this.groupThongTin.Controls.Add(this.label4);
            this.groupThongTin.Controls.Add(this.label2);
            this.groupThongTin.Controls.Add(this.label1);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(1008, 60);
            this.groupThongTin.TabIndex = 0;
            this.groupThongTin.Text = "Chọn thông tin Lớp học:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(738, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(579, 30);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(65, 21);
            this.cbHocKy.TabIndex = 11;
            this.cbHocKy.ValueMember = "MaHocKy";
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "TenLop";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(436, 30);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(65, 21);
            this.cbLop.TabIndex = 10;
            this.cbLop.ValueMember = "MaLop";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbKhoi
            // 
            this.cbKhoi.DisplayMember = "TenKhoi";
            this.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(302, 30);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(65, 21);
            this.cbKhoi.TabIndex = 9;
            this.cbKhoi.ValueMember = "MaKhoi";
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khối:";
            // 
            // gcDiem
            // 
            this.gcDiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiem.Location = new System.Drawing.Point(0, 60);
            this.gcDiem.MainView = this.gvDiem;
            this.gcDiem.Name = "gcDiem";
            this.gcDiem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkuHocLuc,
            this.lkuHanhKiem,
            this.lkuDanhHieu});
            this.gcDiem.Size = new System.Drawing.Size(1008, 371);
            this.gcDiem.TabIndex = 1;
            this.gcDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiem});
            // 
            // gvDiem
            // 
            this.gvDiem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDiem.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDiem.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvDiem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTT,
            this.gclMaHS,
            this.gclHoTen,
            this.gclNgaySinh});
            this.gvDiem.GridControl = this.gcDiem;
            this.gvDiem.Name = "gvDiem";
            this.gvDiem.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDiem.OptionsView.ColumnAutoWidth = false;
            this.gvDiem.OptionsView.EnableAppearanceOddRow = true;
            this.gvDiem.OptionsView.ShowGroupPanel = false;
            this.gvDiem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDiem_CellValueChanged_1);
            this.gvDiem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDiem_CellValueChanging_1);
            this.gvDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvDiem_KeyPress_1);
            // 
            // gclSTT
            // 
            this.gclSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gclSTT.AppearanceCell.Options.UseFont = true;
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
            this.gclSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclSTT.Visible = true;
            this.gclSTT.VisibleIndex = 0;
            this.gclSTT.Width = 31;
            // 
            // gclMaHS
            // 
            this.gclMaHS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gclMaHS.AppearanceCell.Options.UseFont = true;
            this.gclMaHS.AppearanceCell.Options.UseTextOptions = true;
            this.gclMaHS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclMaHS.AppearanceHeader.Options.UseFont = true;
            this.gclMaHS.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaHS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaHS.Caption = "Mã HS";
            this.gclMaHS.FieldName = "MaHocSinh";
            this.gclMaHS.Name = "gclMaHS";
            this.gclMaHS.OptionsColumn.AllowEdit = false;
            this.gclMaHS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclMaHS.Visible = true;
            this.gclMaHS.VisibleIndex = 1;
            // 
            // gclHoTen
            // 
            this.gclHoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gclHoTen.AppearanceCell.Options.UseFont = true;
            this.gclHoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclHoTen.AppearanceHeader.Options.UseFont = true;
            this.gclHoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.gclHoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHoTen.Caption = "Họ và tên";
            this.gclHoTen.FieldName = "HoVaTen";
            this.gclHoTen.Name = "gclHoTen";
            this.gclHoTen.OptionsColumn.AllowEdit = false;
            this.gclHoTen.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gclHoTen.Visible = true;
            this.gclHoTen.VisibleIndex = 2;
            this.gclHoTen.Width = 135;
            // 
            // gclNgaySinh
            // 
            this.gclNgaySinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gclNgaySinh.AppearanceCell.Options.UseFont = true;
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
            // lkuHocLuc
            // 
            this.lkuHocLuc.AutoHeight = false;
            this.lkuHocLuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuHocLuc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHocLuc", "Mã học lực"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHocLuc", "Tên học lực")});
            this.lkuHocLuc.DisplayMember = "TenHocLuc";
            this.lkuHocLuc.Name = "lkuHocLuc";
            this.lkuHocLuc.ValueMember = "MaHocLuc";
            // 
            // lkuHanhKiem
            // 
            this.lkuHanhKiem.AutoHeight = false;
            this.lkuHanhKiem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuHanhKiem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHanhKiem", "Mã hạnh kiểm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHanhKiem", "Tên hạnh kiểm")});
            this.lkuHanhKiem.DisplayMember = "TenHanhKiem";
            this.lkuHanhKiem.Name = "lkuHanhKiem";
            this.lkuHanhKiem.ValueMember = "MaHanhKiem";
            // 
            // lkuDanhHieu
            // 
            this.lkuDanhHieu.AutoHeight = false;
            this.lkuDanhHieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuDanhHieu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDanhHieu", "Mã danh hiệu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDanhHieu", "Tên danh hiệu")});
            this.lkuDanhHieu.DisplayMember = "TenDanhHieu";
            this.lkuDanhHieu.Name = "lkuDanhHieu";
            this.lkuDanhHieu.ValueMember = "MaDanhHieu";
            // 
            // frmNhapDiemHSChuyenTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 431);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.groupThongTin);
            this.Name = "frmNhapDiemHSChuyenTruong";
            this.Text = "Nhập điểm Học sinh chuyển trường";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapDiemHSChuyenTruong_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuHocLuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuHanhKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuDanhHieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiem;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHS;
        private DevExpress.XtraGrid.Columns.GridColumn gclHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn gclNgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkuHocLuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkuHanhKiem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkuDanhHieu;
    }
}