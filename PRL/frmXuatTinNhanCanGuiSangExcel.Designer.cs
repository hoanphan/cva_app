namespace PRL
{
    partial class frmXuatTinNhanCanGuiSangExcel
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
            this.gbChonThamSo = new DevExpress.XtraEditors.GroupControl();
            this.gbDoiTuongGui = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.rdbHocSinhTheoKhoi = new System.Windows.Forms.RadioButton();
            this.checkTheoLop = new System.Windows.Forms.CheckBox();
            this.checkNhacNhapDiem = new System.Windows.Forms.CheckBox();
            this.rdbGVToanTruong = new System.Windows.Forms.RadioButton();
            this.rdbHSToanTruong = new System.Windows.Forms.RadioButton();
            this.cbNhaMang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.btnTaoDuLieuGui = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbData = new DevExpress.XtraEditors.GroupControl();
            this.gcSMS = new DevExpress.XtraGrid.GridControl();
            this.gvSMS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNoiDungSMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbStatus = new DevExpress.XtraEditors.GroupControl();
            this.lbSoDongThoaMan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pgbTienTrinh = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.gbChonThamSo)).BeginInit();
            this.gbChonThamSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoiTuongGui)).BeginInit();
            this.gbDoiTuongGui.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbData)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).BeginInit();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChonThamSo
            // 
            this.gbChonThamSo.Controls.Add(this.gbDoiTuongGui);
            this.gbChonThamSo.Controls.Add(this.txtNoiDung);
            this.gbChonThamSo.Controls.Add(this.label1);
            this.gbChonThamSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChonThamSo.Location = new System.Drawing.Point(0, 0);
            this.gbChonThamSo.Name = "gbChonThamSo";
            this.gbChonThamSo.Size = new System.Drawing.Size(773, 278);
            this.gbChonThamSo.TabIndex = 0;
            this.gbChonThamSo.Text = "Chọn tham số:";
            // 
            // gbDoiTuongGui
            // 
            this.gbDoiTuongGui.Controls.Add(this.label5);
            this.gbDoiTuongGui.Controls.Add(this.label4);
            this.gbDoiTuongGui.Controls.Add(this.cbLop);
            this.gbDoiTuongGui.Controls.Add(this.cbKhoi);
            this.gbDoiTuongGui.Controls.Add(this.rdbHocSinhTheoKhoi);
            this.gbDoiTuongGui.Controls.Add(this.checkTheoLop);
            this.gbDoiTuongGui.Controls.Add(this.checkNhacNhapDiem);
            this.gbDoiTuongGui.Controls.Add(this.rdbGVToanTruong);
            this.gbDoiTuongGui.Controls.Add(this.rdbHSToanTruong);
            this.gbDoiTuongGui.Controls.Add(this.cbNhaMang);
            this.gbDoiTuongGui.Controls.Add(this.label2);
            this.gbDoiTuongGui.Controls.Add(this.btnXuatRaExcel);
            this.gbDoiTuongGui.Controls.Add(this.btnTaoDuLieuGui);
            this.gbDoiTuongGui.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDoiTuongGui.Location = new System.Drawing.Point(2, 20);
            this.gbDoiTuongGui.Name = "gbDoiTuongGui";
            this.gbDoiTuongGui.Size = new System.Drawing.Size(769, 111);
            this.gbDoiTuongGui.TabIndex = 7;
            this.gbDoiTuongGui.Text = "Đối tượng cần gửi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khối:";
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "TenLop";
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(454, 56);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(68, 21);
            this.cbLop.TabIndex = 7;
            this.cbLop.ValueMember = "MaLop";
            // 
            // cbKhoi
            // 
            this.cbKhoi.DisplayMember = "TenKhoi";
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(262, 56);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(68, 21);
            this.cbKhoi.TabIndex = 7;
            this.cbKhoi.ValueMember = "MaKhoi";
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // rdbHocSinhTheoKhoi
            // 
            this.rdbHocSinhTheoKhoi.AutoSize = true;
            this.rdbHocSinhTheoKhoi.Location = new System.Drawing.Point(59, 58);
            this.rdbHocSinhTheoKhoi.Name = "rdbHocSinhTheoKhoi";
            this.rdbHocSinhTheoKhoi.Size = new System.Drawing.Size(133, 17);
            this.rdbHocSinhTheoKhoi.TabIndex = 1;
            this.rdbHocSinhTheoKhoi.TabStop = true;
            this.rdbHocSinhTheoKhoi.Text = "Học sinh theo khối, lớp";
            this.rdbHocSinhTheoKhoi.UseVisualStyleBackColor = true;
            this.rdbHocSinhTheoKhoi.CheckedChanged += new System.EventHandler(this.rdbHocSinhTheoKhoi_CheckedChanged);
            // 
            // checkTheoLop
            // 
            this.checkTheoLop.AutoSize = true;
            this.checkTheoLop.Location = new System.Drawing.Point(350, 58);
            this.checkTheoLop.Name = "checkTheoLop";
            this.checkTheoLop.Size = new System.Drawing.Size(67, 17);
            this.checkTheoLop.TabIndex = 6;
            this.checkTheoLop.Text = "Theo lớp";
            this.checkTheoLop.UseVisualStyleBackColor = true;
            this.checkTheoLop.CheckedChanged += new System.EventHandler(this.checkTheoLop_CheckedChanged);
            // 
            // checkNhacNhapDiem
            // 
            this.checkNhacNhapDiem.AutoSize = true;
            this.checkNhacNhapDiem.Location = new System.Drawing.Point(196, 80);
            this.checkNhacNhapDiem.Name = "checkNhacNhapDiem";
            this.checkNhacNhapDiem.Size = new System.Drawing.Size(102, 17);
            this.checkNhacNhapDiem.TabIndex = 6;
            this.checkNhacNhapDiem.Text = "Nhắc nhập điểm";
            this.checkNhacNhapDiem.UseVisualStyleBackColor = true;
            // 
            // rdbGVToanTruong
            // 
            this.rdbGVToanTruong.AutoSize = true;
            this.rdbGVToanTruong.Location = new System.Drawing.Point(59, 80);
            this.rdbGVToanTruong.Name = "rdbGVToanTruong";
            this.rdbGVToanTruong.Size = new System.Drawing.Size(130, 17);
            this.rdbGVToanTruong.TabIndex = 2;
            this.rdbGVToanTruong.Text = "Giáo viên toàn trường";
            this.rdbGVToanTruong.UseVisualStyleBackColor = true;
            this.rdbGVToanTruong.CheckedChanged += new System.EventHandler(this.rdbGVToanTruong_CheckedChanged);
            // 
            // rdbHSToanTruong
            // 
            this.rdbHSToanTruong.AutoSize = true;
            this.rdbHSToanTruong.Checked = true;
            this.rdbHSToanTruong.Location = new System.Drawing.Point(59, 33);
            this.rdbHSToanTruong.Name = "rdbHSToanTruong";
            this.rdbHSToanTruong.Size = new System.Drawing.Size(126, 17);
            this.rdbHSToanTruong.TabIndex = 0;
            this.rdbHSToanTruong.TabStop = true;
            this.rdbHSToanTruong.Text = "Học sinh toàn trường";
            this.rdbHSToanTruong.UseVisualStyleBackColor = true;
            // 
            // cbNhaMang
            // 
            this.cbNhaMang.DisplayMember = "TenNhaMang";
            this.cbNhaMang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaMang.FormattingEnabled = true;
            this.cbNhaMang.Location = new System.Drawing.Point(412, 31);
            this.cbNhaMang.Name = "cbNhaMang";
            this.cbNhaMang.Size = new System.Drawing.Size(121, 21);
            this.cbNhaMang.TabIndex = 1;
            this.cbNhaMang.ValueMember = "MaNhaMang";
            this.cbNhaMang.SelectedIndexChanged += new System.EventHandler(this.cbNhaMang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà mạng:";
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.Location = new System.Drawing.Point(671, 30);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(89, 23);
            this.btnXuatRaExcel.TabIndex = 4;
            this.btnXuatRaExcel.Text = "Xuất ra Excel";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // btnTaoDuLieuGui
            // 
            this.btnTaoDuLieuGui.Location = new System.Drawing.Point(552, 30);
            this.btnTaoDuLieuGui.Name = "btnTaoDuLieuGui";
            this.btnTaoDuLieuGui.Size = new System.Drawing.Size(95, 23);
            this.btnTaoDuLieuGui.TabIndex = 3;
            this.btnTaoDuLieuGui.Text = "Tạo dữ liệu gửi";
            this.btnTaoDuLieuGui.UseVisualStyleBackColor = true;
            this.btnTaoDuLieuGui.Click += new System.EventHandler(this.btnTaoDuLieuGui_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(101, 137);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(592, 125);
            this.txtNoiDung.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nội dung:";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.gcSMS);
            this.gbData.Controls.Add(this.gbStatus);
            this.gbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbData.Location = new System.Drawing.Point(0, 278);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(773, 330);
            this.gbData.TabIndex = 1;
            this.gbData.Text = "Thông tin dữ liệu lọc:";
            // 
            // gcSMS
            // 
            this.gcSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSMS.Location = new System.Drawing.Point(2, 20);
            this.gcSMS.MainView = this.gvSMS;
            this.gcSMS.Name = "gcSMS";
            this.gcSMS.Size = new System.Drawing.Size(769, 253);
            this.gcSMS.TabIndex = 1;
            this.gcSMS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSMS});
            // 
            // gvSMS
            // 
            this.gvSMS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTT,
            this.gclSDT,
            this.gclNoiDungSMS});
            this.gvSMS.GridControl = this.gcSMS;
            this.gvSMS.Name = "gvSMS";
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
            this.gclSTT.Visible = true;
            this.gclSTT.VisibleIndex = 0;
            this.gclSTT.Width = 50;
            // 
            // gclSDT
            // 
            this.gclSDT.AppearanceCell.Options.UseTextOptions = true;
            this.gclSDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSDT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclSDT.AppearanceHeader.Options.UseFont = true;
            this.gclSDT.AppearanceHeader.Options.UseTextOptions = true;
            this.gclSDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSDT.Caption = "Số điện thoại";
            this.gclSDT.FieldName = "SoDienThoai";
            this.gclSDT.Name = "gclSDT";
            this.gclSDT.Visible = true;
            this.gclSDT.VisibleIndex = 1;
            this.gclSDT.Width = 150;
            // 
            // gclNoiDungSMS
            // 
            this.gclNoiDungSMS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclNoiDungSMS.AppearanceHeader.Options.UseFont = true;
            this.gclNoiDungSMS.AppearanceHeader.Options.UseTextOptions = true;
            this.gclNoiDungSMS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNoiDungSMS.Caption = "Nội dung SMS";
            this.gclNoiDungSMS.FieldName = "NoiDungSMS";
            this.gclNoiDungSMS.Name = "gclNoiDungSMS";
            this.gclNoiDungSMS.Visible = true;
            this.gclNoiDungSMS.VisibleIndex = 2;
            this.gclNoiDungSMS.Width = 553;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lbSoDongThoaMan);
            this.gbStatus.Controls.Add(this.label3);
            this.gbStatus.Controls.Add(this.pgbTienTrinh);
            this.gbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbStatus.Location = new System.Drawing.Point(2, 273);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(769, 55);
            this.gbStatus.TabIndex = 0;
            this.gbStatus.Text = "Trạng thái:";
            // 
            // lbSoDongThoaMan
            // 
            this.lbSoDongThoaMan.AutoSize = true;
            this.lbSoDongThoaMan.Location = new System.Drawing.Point(22, 32);
            this.lbSoDongThoaMan.Name = "lbSoDongThoaMan";
            this.lbSoDongThoaMan.Size = new System.Drawing.Size(107, 13);
            this.lbSoDongThoaMan.TabIndex = 4;
            this.lbSoDongThoaMan.Text = "Có ? dòng thỏa mãn.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiến trình:";
            // 
            // pgbTienTrinh
            // 
            this.pgbTienTrinh.Location = new System.Drawing.Point(307, 27);
            this.pgbTienTrinh.Name = "pgbTienTrinh";
            this.pgbTienTrinh.Properties.ShowTitle = true;
            this.pgbTienTrinh.Size = new System.Drawing.Size(215, 23);
            this.pgbTienTrinh.TabIndex = 0;
            // 
            // frmXuatTinNhanCanGuiSangExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 608);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbChonThamSo);
            this.Name = "frmXuatTinNhanCanGuiSangExcel";
            this.Text = "Xuất SMS cần gửi sang Excel";
            this.Load += new System.EventHandler(this.frmXuatTinNhanCanGuiSangExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbChonThamSo)).EndInit();
            this.gbChonThamSo.ResumeLayout(false);
            this.gbChonThamSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoiTuongGui)).EndInit();
            this.gbDoiTuongGui.ResumeLayout(false);
            this.gbDoiTuongGui.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbData)).EndInit();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbChonThamSo;
        private DevExpress.XtraEditors.GroupControl gbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNhaMang;
        private System.Windows.Forms.Button btnTaoDuLieuGui;
        private DevExpress.XtraGrid.GridControl gcSMS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSMS;
        private DevExpress.XtraEditors.GroupControl gbStatus;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gclSDT;
        private DevExpress.XtraGrid.Columns.GridColumn gclNoiDungSMS;
        private System.Windows.Forms.Label lbSoDongThoaMan;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private DevExpress.XtraEditors.GroupControl gbDoiTuongGui;
        private System.Windows.Forms.RadioButton rdbHSToanTruong;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbGVToanTruong;
        private System.Windows.Forms.CheckBox checkNhacNhapDiem;
        private System.Windows.Forms.RadioButton rdbHocSinhTheoKhoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.CheckBox checkTheoLop;
    }
}