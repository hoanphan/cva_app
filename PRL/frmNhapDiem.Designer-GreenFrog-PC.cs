namespace PRL
{
    partial class frmNhapDiem
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.btnTinhDiemTrungBinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gvDiem = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gclSTT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gclMaHS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gclHoTen = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gclNgaySinh = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.btnTinhDiemTrungBinh);
            this.groupThongTin.Controls.Add(this.btnLuu);
            this.groupThongTin.Controls.Add(this.cbMonHoc);
            this.groupThongTin.Controls.Add(this.cbHocKy);
            this.groupThongTin.Controls.Add(this.cbLop);
            this.groupThongTin.Controls.Add(this.cbKhoi);
            this.groupThongTin.Controls.Add(this.label4);
            this.groupThongTin.Controls.Add(this.simpleButton1);
            this.groupThongTin.Controls.Add(this.label3);
            this.groupThongTin.Controls.Add(this.label2);
            this.groupThongTin.Controls.Add(this.label1);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(1008, 60);
            this.groupThongTin.TabIndex = 0;
            this.groupThongTin.Text = "Chọn thông tin Lớp học:";
            // 
            // btnTinhDiemTrungBinh
            // 
            this.btnTinhDiemTrungBinh.Location = new System.Drawing.Point(895, 28);
            this.btnTinhDiemTrungBinh.Name = "btnTinhDiemTrungBinh";
            this.btnTinhDiemTrungBinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinhDiemTrungBinh.TabIndex = 14;
            this.btnTinhDiemTrungBinh.Text = "Tính điểm TB";
            this.btnTinhDiemTrungBinh.Click += new System.EventHandler(this.btnTinhDiemTrungBinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(804, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DisplayMember = "TenMonhoc";
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(534, 30);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(144, 21);
            this.cbMonHoc.TabIndex = 12;
            this.cbMonHoc.ValueMember = "MaMonHoc";
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(398, 30);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(65, 21);
            this.cbHocKy.TabIndex = 11;
            this.cbHocKy.ValueMember = "MaHocKy";
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "TenLop";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(255, 30);
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
            this.cbKhoi.Location = new System.Drawing.Point(121, 30);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(65, 21);
            this.cbKhoi.TabIndex = 9;
            this.cbKhoi.ValueMember = "MaKhoi";
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Học kỳ:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(713, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 33);
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
            this.gvDiem.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gvDiem.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gclSTT,
            this.gclMaHS,
            this.gclHoTen,
            this.gclNgaySinh});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Expression = "<5";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "<5";
            styleFormatCondition2.Name = "gclM2Rule";
            this.gvDiem.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gvDiem.GridControl = this.gcDiem;
            this.gvDiem.Name = "gvDiem";
            this.gvDiem.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDiem.OptionsView.ColumnAutoWidth = false;
            this.gvDiem.OptionsView.EnableAppearanceOddRow = true;
            this.gvDiem.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDiem_RowCellClick);
            this.gvDiem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDiem_CellValueChanging);
            this.gvDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvDiem_KeyPress);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.gclSTT);
            this.gridBand1.Columns.Add(this.gclMaHS);
            this.gridBand1.Columns.Add(this.gclHoTen);
            this.gridBand1.Columns.Add(this.gclNgaySinh);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 311;
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
            this.gclSTT.Name = "gclSTT";
            this.gclSTT.OptionsColumn.AllowEdit = false;
            this.gclSTT.Visible = true;
            this.gclSTT.Width = 30;
            // 
            // gclMaHS
            // 
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
            this.gclMaHS.Visible = true;
            this.gclMaHS.Width = 55;
            // 
            // gclHoTen
            // 
            this.gclHoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclHoTen.AppearanceHeader.Options.UseFont = true;
            this.gclHoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.gclHoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHoTen.Caption = "Họ và tên";
            this.gclHoTen.FieldName = "HoVaTen";
            this.gclHoTen.Name = "gclHoTen";
            this.gclHoTen.OptionsColumn.AllowEdit = false;
            this.gclHoTen.Visible = true;
            this.gclHoTen.Width = 150;
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
            this.gclNgaySinh.Visible = true;
            this.gclNgaySinh.Width = 76;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 431);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.groupThongTin);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập điểm";
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvDiem;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gclSTT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gclMaHS;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gclHoTen;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gclNgaySinh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.SimpleButton btnTinhDiemTrungBinh;        
    }
}