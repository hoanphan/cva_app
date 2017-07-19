namespace PRL
{
    partial class frmKhoaSo
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
            this.btnKhoaSoDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.pgbTienTrinh = new DevExpress.XtraEditors.ProgressBarControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.btnMoKhoaSoDuLieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKhoaSoDuLieu
            // 
            this.btnKhoaSoDuLieu.Location = new System.Drawing.Point(207, 99);
            this.btnKhoaSoDuLieu.Name = "btnKhoaSoDuLieu";
            this.btnKhoaSoDuLieu.Size = new System.Drawing.Size(104, 23);
            this.btnKhoaSoDuLieu.TabIndex = 1;
            this.btnKhoaSoDuLieu.Text = "Khóa sổ dữ liệu";
            this.btnKhoaSoDuLieu.Click += new System.EventHandler(this.btnKhoaSoDuLieu_Click);
            // 
            // pgbTienTrinh
            // 
            this.pgbTienTrinh.Location = new System.Drawing.Point(193, 58);
            this.pgbTienTrinh.Name = "pgbTienTrinh";
            this.pgbTienTrinh.Properties.PercentView = false;
            this.pgbTienTrinh.Properties.ShowTitle = true;
            this.pgbTienTrinh.Size = new System.Drawing.Size(316, 18);
            this.pgbTienTrinh.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiến trình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 14);
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
            this.cbHocKy.Location = new System.Drawing.Point(294, 12);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(74, 21);
            this.cbHocKy.TabIndex = 0;
            this.cbHocKy.ValueMember = "MaHocKy";
            // 
            // btnMoKhoaSoDuLieu
            // 
            this.btnMoKhoaSoDuLieu.Location = new System.Drawing.Point(341, 99);
            this.btnMoKhoaSoDuLieu.Name = "btnMoKhoaSoDuLieu";
            this.btnMoKhoaSoDuLieu.Size = new System.Drawing.Size(104, 23);
            this.btnMoKhoaSoDuLieu.TabIndex = 2;
            this.btnMoKhoaSoDuLieu.Text = "Mở khóa sổ dữ liệu";
            this.btnMoKhoaSoDuLieu.Click += new System.EventHandler(this.btnMoKhoaSoDuLieu_Click);
            // 
            // frmKhoaSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgbTienTrinh);
            this.Controls.Add(this.btnMoKhoaSoDuLieu);
            this.Controls.Add(this.btnKhoaSoDuLieu);
            this.Name = "frmKhoaSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khóa sổ dữ liệu";
            this.Load += new System.EventHandler(this.frmKhoaSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgbTienTrinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKhoaSoDuLieu;
        private DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKy;
        private DevExpress.XtraEditors.SimpleButton btnMoKhoaSoDuLieu;
    }
}

