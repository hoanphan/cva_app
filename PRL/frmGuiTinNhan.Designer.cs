namespace PRL
{
    partial class frmGuiTinNhan
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
            this.gcTuyChon = new DevExpress.XtraEditors.GroupControl();
            this.rdbGuiHSToanTruong = new System.Windows.Forms.RadioButton();
            this.rdbGuiGVCN = new System.Windows.Forms.RadioButton();
            this.rdGuiGVToanTruong = new System.Windows.Forms.RadioButton();
            this.rdNhacNhapDiem = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbSoKyTu = new System.Windows.Forms.ToolStripStatusLabel();
            this.gcNoiDung = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pgbTienTrinh = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGui = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.rdbGuiDenSoCuThe = new System.Windows.Forms.RadioButton();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuyChon)).BeginInit();
            this.gcTuyChon.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoiDung)).BeginInit();
            this.gcNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcTuyChon
            // 
            this.gcTuyChon.Controls.Add(this.rdbGuiDenSoCuThe);
            this.gcTuyChon.Controls.Add(this.rdbGuiHSToanTruong);
            this.gcTuyChon.Controls.Add(this.rdbGuiGVCN);
            this.gcTuyChon.Controls.Add(this.rdGuiGVToanTruong);
            this.gcTuyChon.Controls.Add(this.rdNhacNhapDiem);
            this.gcTuyChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTuyChon.Location = new System.Drawing.Point(0, 0);
            this.gcTuyChon.Name = "gcTuyChon";
            this.gcTuyChon.Size = new System.Drawing.Size(609, 68);
            this.gcTuyChon.TabIndex = 0;
            this.gcTuyChon.Text = "Tùy chọn:";
            // 
            // rdbGuiHSToanTruong
            // 
            this.rdbGuiHSToanTruong.AutoSize = true;
            this.rdbGuiHSToanTruong.Location = new System.Drawing.Point(329, 34);
            this.rdbGuiHSToanTruong.Name = "rdbGuiHSToanTruong";
            this.rdbGuiHSToanTruong.Size = new System.Drawing.Size(118, 17);
            this.rdbGuiHSToanTruong.TabIndex = 3;
            this.rdbGuiHSToanTruong.TabStop = true;
            this.rdbGuiHSToanTruong.Text = "Gửi HS toàn trường";
            this.rdbGuiHSToanTruong.UseVisualStyleBackColor = true;
            // 
            // rdbGuiGVCN
            // 
            this.rdbGuiGVCN.AutoSize = true;
            this.rdbGuiGVCN.Location = new System.Drawing.Point(252, 34);
            this.rdbGuiGVCN.Name = "rdbGuiGVCN";
            this.rdbGuiGVCN.Size = new System.Drawing.Size(71, 17);
            this.rdbGuiGVCN.TabIndex = 2;
            this.rdbGuiGVCN.TabStop = true;
            this.rdbGuiGVCN.Text = "Gửi GVCN";
            this.rdbGuiGVCN.UseVisualStyleBackColor = true;
            // 
            // rdGuiGVToanTruong
            // 
            this.rdGuiGVToanTruong.AutoSize = true;
            this.rdGuiGVToanTruong.Location = new System.Drawing.Point(119, 34);
            this.rdGuiGVToanTruong.Name = "rdGuiGVToanTruong";
            this.rdGuiGVToanTruong.Size = new System.Drawing.Size(127, 17);
            this.rdGuiGVToanTruong.TabIndex = 1;
            this.rdGuiGVToanTruong.TabStop = true;
            this.rdGuiGVToanTruong.Text = "Gửi toàn bộ giáo viên";
            this.rdGuiGVToanTruong.UseVisualStyleBackColor = true;
            // 
            // rdNhacNhapDiem
            // 
            this.rdNhacNhapDiem.AutoSize = true;
            this.rdNhacNhapDiem.Checked = true;
            this.rdNhacNhapDiem.Location = new System.Drawing.Point(12, 34);
            this.rdNhacNhapDiem.Name = "rdNhacNhapDiem";
            this.rdNhacNhapDiem.Size = new System.Drawing.Size(101, 17);
            this.rdNhacNhapDiem.TabIndex = 0;
            this.rdNhacNhapDiem.TabStop = true;
            this.rdNhacNhapDiem.Text = "Nhắc nhập điểm";
            this.rdNhacNhapDiem.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSoKyTu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbSoKyTu
            // 
            this.lbSoKyTu.Name = "lbSoKyTu";
            this.lbSoKyTu.Size = new System.Drawing.Size(82, 17);
            this.lbSoKyTu.Text = "Bạn đã nhập ...";
            // 
            // gcNoiDung
            // 
            this.gcNoiDung.Controls.Add(this.panelControl2);
            this.gcNoiDung.Controls.Add(this.panelControl1);
            this.gcNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoiDung.Location = new System.Drawing.Point(0, 68);
            this.gcNoiDung.Name = "gcNoiDung";
            this.gcNoiDung.Size = new System.Drawing.Size(609, 274);
            this.gcNoiDung.TabIndex = 2;
            this.gcNoiDung.Text = "Nội dung:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtSoDienThoai);
            this.panelControl2.Controls.Add(this.pgbTienTrinh);
            this.panelControl2.Controls.Add(this.txtNoiDung);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 20);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(513, 252);
            this.panelControl2.TabIndex = 1;
            // 
            // pgbTienTrinh
            // 
            this.pgbTienTrinh.Location = new System.Drawing.Point(117, 224);
            this.pgbTienTrinh.Name = "pgbTienTrinh";
            this.pgbTienTrinh.Properties.PercentView = false;
            this.pgbTienTrinh.Properties.ShowTitle = true;
            this.pgbTienTrinh.Size = new System.Drawing.Size(217, 18);
            this.pgbTienTrinh.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(10, 46);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(484, 171);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung gửi:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(515, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(92, 252);
            this.panelControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnGui, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThoat, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(88, 248);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGui.Location = new System.Drawing.Point(3, 3);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(82, 118);
            this.btnGui.TabIndex = 0;
            this.btnGui.Text = "&Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Location = new System.Drawing.Point(3, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 118);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "&Thoát";
            // 
            // rdbGuiDenSoCuThe
            // 
            this.rdbGuiDenSoCuThe.AutoSize = true;
            this.rdbGuiDenSoCuThe.Location = new System.Drawing.Point(453, 34);
            this.rdbGuiDenSoCuThe.Name = "rdbGuiDenSoCuThe";
            this.rdbGuiDenSoCuThe.Size = new System.Drawing.Size(109, 17);
            this.rdbGuiDenSoCuThe.TabIndex = 3;
            this.rdbGuiDenSoCuThe.TabStop = true;
            this.rdbGuiDenSoCuThe.Text = "Gửi đến số cụ thể";
            this.rdbGuiDenSoCuThe.UseVisualStyleBackColor = true;
            this.rdbGuiDenSoCuThe.CheckedChanged += new System.EventHandler(this.btnGuiDenSoCuThe_CheckedChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(260, 10);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(199, 21);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // frmGuiTinNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 364);
            this.Controls.Add(this.gcNoiDung);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gcTuyChon);
            this.Name = "frmGuiTinNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi tin nhắn";
            ((System.ComponentModel.ISupportInitialize)(this.gcTuyChon)).EndInit();
            this.gcTuyChon.ResumeLayout(false);
            this.gcTuyChon.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoiDung)).EndInit();
            this.gcNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcTuyChon;
        private System.Windows.Forms.RadioButton rdNhacNhapDiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbSoKyTu;
        private DevExpress.XtraEditors.GroupControl gcNoiDung;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnGui;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.RadioButton rdGuiGVToanTruong;
        private System.Windows.Forms.RadioButton rdbGuiGVCN;
        private System.Windows.Forms.RadioButton rdbGuiHSToanTruong;
        private DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh;
        private System.Windows.Forms.RadioButton rdbGuiDenSoCuThe;
        private System.Windows.Forms.TextBox txtSoDienThoai;
    }
}