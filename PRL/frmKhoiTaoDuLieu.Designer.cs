namespace PRL
{
    partial class frmKhoiTaoDuLieu
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
            this.btnKhoiTaoDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.pgbTienTrinhCon = new DevExpress.XtraEditors.ProgressBarControl();
            this.pgbTongTienTrinh = new DevExpress.XtraEditors.ProgressBarControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinhCon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTongTienTrinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKhoiTaoDuLieu
            // 
            this.btnKhoiTaoDuLieu.Location = new System.Drawing.Point(273, 114);
            this.btnKhoiTaoDuLieu.Name = "btnKhoiTaoDuLieu";
            this.btnKhoiTaoDuLieu.Size = new System.Drawing.Size(91, 23);
            this.btnKhoiTaoDuLieu.TabIndex = 0;
            this.btnKhoiTaoDuLieu.Text = "Khởi tạo dữ liệu";
            this.btnKhoiTaoDuLieu.Click += new System.EventHandler(this.btnKhoiTaoDuLieu_Click);
            // 
            // pgbTienTrinhCon
            // 
            this.pgbTienTrinhCon.Location = new System.Drawing.Point(194, 56);
            this.pgbTienTrinhCon.Name = "pgbTienTrinhCon";
            this.pgbTienTrinhCon.Size = new System.Drawing.Size(316, 18);
            this.pgbTienTrinhCon.TabIndex = 1;
            // 
            // pgbTongTienTrinh
            // 
            this.pgbTongTienTrinh.Location = new System.Drawing.Point(194, 90);
            this.pgbTongTienTrinh.Name = "pgbTongTienTrinh";
            this.pgbTongTienTrinh.Size = new System.Drawing.Size(316, 18);
            this.pgbTongTienTrinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiến trình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiến trình con:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Học kỳ:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(290, 12);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(74, 21);
            this.cbHocKy.TabIndex = 8;
            this.cbHocKy.ValueMember = "MaHocKy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKhoiTaoDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 149);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbTongTienTrinh);
            this.Controls.Add(this.pgbTienTrinhCon);
            this.Controls.Add(this.btnKhoiTaoDuLieu);
            this.Name = "frmKhoiTaoDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khởi tạo dữ liệu";
            this.Load += new System.EventHandler(this.frmKhoiTaoDuLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinhCon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTongTienTrinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKhoiTaoDuLieu;
        private DevExpress.XtraEditors.ProgressBarControl pgbTienTrinhCon;
        private DevExpress.XtraEditors.ProgressBarControl pgbTongTienTrinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Button button1;
    }
}

