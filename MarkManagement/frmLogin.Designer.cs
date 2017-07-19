namespace MarkManagement
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoRong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.gbThongTinKetNoiCSDL = new DevExpress.XtraEditors.GroupControl();
            this.tbTenMayChu = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKetNoiThu = new DevExpress.XtraEditors.SimpleButton();
            this.tbMatKhauSQL = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenNguoiDungSQL = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuuThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.gbThongTinDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.chkNhoThongTin = new DevExpress.XtraEditors.CheckEdit();
            this.tbMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::MarkManagement.frmWaiting), true, true);
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenCSDL = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbThongTinKetNoiCSDL)).BeginInit();
            this.gbThongTinKetNoiCSDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenMayChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhauSQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNguoiDungSQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbThongTinDangNhap)).BeginInit();
            this.gbThongTinDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhoThongTin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCSDL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MarkManagement.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Location = new System.Drawing.Point(196, 26);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(148, 20);
            this.tbTenDangNhap.TabIndex = 0;
            this.tbTenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenDangNhap_KeyDown);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(98, 96);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng &nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnMoRong
            // 
            this.btnMoRong.Location = new System.Drawing.Point(195, 96);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Size = new System.Drawing.Size(75, 23);
            this.btnMoRong.TabIndex = 4;
            this.btnMoRong.Text = "Mở &rộng";
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(292, 96);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbThongTinKetNoiCSDL
            // 
            this.gbThongTinKetNoiCSDL.Controls.Add(this.tbTenMayChu);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.label4);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.btnKetNoiThu);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.tbMatKhauSQL);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.label5);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.tbTenCSDL);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.label6);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.tbTenNguoiDungSQL);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.label3);
            this.gbThongTinKetNoiCSDL.Controls.Add(this.btnLuuThongTin);
            this.gbThongTinKetNoiCSDL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbThongTinKetNoiCSDL.Location = new System.Drawing.Point(0, 222);
            this.gbThongTinKetNoiCSDL.Name = "gbThongTinKetNoiCSDL";
            this.gbThongTinKetNoiCSDL.Size = new System.Drawing.Size(462, 154);
            this.gbThongTinKetNoiCSDL.TabIndex = 4;
            this.gbThongTinKetNoiCSDL.Text = "Thông tin kết nối CSDL:";
            // 
            // tbTenMayChu
            // 
            this.tbTenMayChu.Location = new System.Drawing.Point(224, 23);
            this.tbTenMayChu.Name = "tbTenMayChu";
            this.tbTenMayChu.Size = new System.Drawing.Size(148, 20);
            this.tbTenMayChu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên máy chủ SQL Server:";
            // 
            // btnKetNoiThu
            // 
            this.btnKetNoiThu.Location = new System.Drawing.Point(156, 123);
            this.btnKetNoiThu.Name = "btnKetNoiThu";
            this.btnKetNoiThu.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoiThu.TabIndex = 10;
            this.btnKetNoiThu.Text = "&Kết nối thử";
            // 
            // tbMatKhauSQL
            // 
            this.tbMatKhauSQL.Location = new System.Drawing.Point(224, 95);
            this.tbMatKhauSQL.Name = "tbMatKhauSQL";
            this.tbMatKhauSQL.Properties.PasswordChar = '*';
            this.tbMatKhauSQL.Size = new System.Drawing.Size(148, 20);
            this.tbMatKhauSQL.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu:";
            // 
            // tbTenNguoiDungSQL
            // 
            this.tbTenNguoiDungSQL.Location = new System.Drawing.Point(224, 71);
            this.tbTenNguoiDungSQL.Name = "tbTenNguoiDungSQL";
            this.tbTenNguoiDungSQL.Size = new System.Drawing.Size(148, 20);
            this.tbTenNguoiDungSQL.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên người dùng:";
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Location = new System.Drawing.Point(253, 123);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(75, 23);
            this.btnLuuThongTin.TabIndex = 11;
            this.btnLuuThongTin.Text = "&Lưu thông tin";
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // gbThongTinDangNhap
            // 
            this.gbThongTinDangNhap.Controls.Add(this.chkNhoThongTin);
            this.gbThongTinDangNhap.Controls.Add(this.tbTenDangNhap);
            this.gbThongTinDangNhap.Controls.Add(this.label1);
            this.gbThongTinDangNhap.Controls.Add(this.btnThoat);
            this.gbThongTinDangNhap.Controls.Add(this.label2);
            this.gbThongTinDangNhap.Controls.Add(this.btnMoRong);
            this.gbThongTinDangNhap.Controls.Add(this.tbMatKhau);
            this.gbThongTinDangNhap.Controls.Add(this.btnDangNhap);
            this.gbThongTinDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThongTinDangNhap.Location = new System.Drawing.Point(0, 97);
            this.gbThongTinDangNhap.Name = "gbThongTinDangNhap";
            this.gbThongTinDangNhap.Size = new System.Drawing.Size(462, 125);
            this.gbThongTinDangNhap.TabIndex = 5;
            this.gbThongTinDangNhap.Text = "Thông tin đăng nhập:";
            // 
            // chkNhoThongTin
            // 
            this.chkNhoThongTin.Location = new System.Drawing.Point(196, 74);
            this.chkNhoThongTin.Name = "chkNhoThongTin";
            this.chkNhoThongTin.Properties.Caption = "Nhớ thông tin đăng nhập";
            this.chkNhoThongTin.Size = new System.Drawing.Size(148, 19);
            this.chkNhoThongTin.TabIndex = 2;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(196, 50);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Properties.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(148, 20);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMatKhau_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cơ sở dữ liệu:";
            // 
            // tbTenCSDL
            // 
            this.tbTenCSDL.Location = new System.Drawing.Point(224, 47);
            this.tbTenCSDL.Name = "tbTenCSDL";
            this.tbTenCSDL.Size = new System.Drawing.Size(148, 20);
            this.tbTenCSDL.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 376);
            this.Controls.Add(this.gbThongTinDangNhap);
            this.Controls.Add(this.gbThongTinKetNoiCSDL);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbThongTinKetNoiCSDL)).EndInit();
            this.gbThongTinKetNoiCSDL.ResumeLayout(false);
            this.gbThongTinKetNoiCSDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenMayChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhauSQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNguoiDungSQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbThongTinDangNhap)).EndInit();
            this.gbThongTinDangNhap.ResumeLayout(false);
            this.gbThongTinDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhoThongTin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCSDL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tbTenDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnMoRong;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.GroupControl gbThongTinKetNoiCSDL;
        private DevExpress.XtraEditors.TextEdit tbTenMayChu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnKetNoiThu;
        private DevExpress.XtraEditors.TextEdit tbMatKhauSQL;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbTenNguoiDungSQL;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnLuuThongTin;
        private DevExpress.XtraEditors.GroupControl gbThongTinDangNhap;
        private DevExpress.XtraEditors.CheckEdit chkNhoThongTin;
        private DevExpress.XtraEditors.TextEdit tbMatKhau;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.TextEdit tbTenCSDL;
        private System.Windows.Forms.Label label6;
    }
}