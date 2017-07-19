namespace PRL
{
    partial class frmXetCacTieuChuanToanTruong
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTBC = new DevExpress.XtraEditors.SimpleButton();
            this.btnXetHocLuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnXetDanhHieu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChonTatCa = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoChon = new DevExpress.XtraEditors.SimpleButton();
            this.lbLop = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PRL.frmWaiting), true, true);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 282);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXetDanhHieu);
            this.panel3.Controls.Add(this.btnXetHocLuc);
            this.panel3.Controls.Add(this.btnTinhTBC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 30);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "XÉT CÁC TIÊU CHUẨN TOÀN TRƯỜNG";
            // 
            // btnTinhTBC
            // 
            this.btnTinhTBC.Location = new System.Drawing.Point(51, 3);
            this.btnTinhTBC.Name = "btnTinhTBC";
            this.btnTinhTBC.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTBC.TabIndex = 0;
            this.btnTinhTBC.Text = "Tính &TBC";
            this.btnTinhTBC.Click += new System.EventHandler(this.btnTinhTBC_Click);
            // 
            // btnXetHocLuc
            // 
            this.btnXetHocLuc.Location = new System.Drawing.Point(177, 4);
            this.btnXetHocLuc.Name = "btnXetHocLuc";
            this.btnXetHocLuc.Size = new System.Drawing.Size(82, 23);
            this.btnXetHocLuc.TabIndex = 0;
            this.btnXetHocLuc.Text = "Xét &học lực";
            this.btnXetHocLuc.Click += new System.EventHandler(this.btnXetHocLuc_Click);
            // 
            // btnXetDanhHieu
            // 
            this.btnXetDanhHieu.Location = new System.Drawing.Point(309, 4);
            this.btnXetDanhHieu.Name = "btnXetDanhHieu";
            this.btnXetDanhHieu.Size = new System.Drawing.Size(86, 23);
            this.btnXetDanhHieu.TabIndex = 0;
            this.btnXetDanhHieu.Text = "Xét &danh hiệu";
            this.btnXetDanhHieu.Click += new System.EventHandler(this.btnXetDanhHieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbHocKy);
            this.groupBox1.Controls.Add(this.lbLop);
            this.groupBox1.Controls.Add(this.btnBoChon);
            this.groupBox1.Controls.Add(this.btnChonTatCa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp cần xét:";
            // 
            // btnChonTatCa
            // 
            this.btnChonTatCa.Location = new System.Drawing.Point(40, 59);
            this.btnChonTatCa.Name = "btnChonTatCa";
            this.btnChonTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnChonTatCa.TabIndex = 1;
            this.btnChonTatCa.Text = "&Chọn tất cả";
            this.btnChonTatCa.Click += new System.EventHandler(this.btnChonTatCa_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(40, 99);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(75, 23);
            this.btnBoChon.TabIndex = 1;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // lbLop
            // 
            this.lbLop.Location = new System.Drawing.Point(139, 61);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(293, 206);
            this.lbLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Học kỳ:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(241, 20);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cbHocKy.TabIndex = 3;
            this.cbHocKy.ValueMember = "MaHocKy";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // frmXetCacTieuChuanToanTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmXetCacTieuChuanToanTruong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xét các tiêu chuẩn toàn trường";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnXetDanhHieu;
        private DevExpress.XtraEditors.SimpleButton btnXetHocLuc;
        private DevExpress.XtraEditors.SimpleButton btnTinhTBC;
        private DevExpress.XtraEditors.SimpleButton btnBoChon;
        private DevExpress.XtraEditors.SimpleButton btnChonTatCa;
        private DevExpress.XtraEditors.CheckedListBoxControl lbLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHocKy;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}