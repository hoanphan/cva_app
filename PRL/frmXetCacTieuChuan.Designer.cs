namespace PRL
{
    partial class frmXetCacTieuChuan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXetDanhHieu = new System.Windows.Forms.Button();
            this.btnXetHocLuc = new System.Windows.Forms.Button();
            this.btnTinhDiemTBC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PRL.frmWaiting), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnXetDanhHieu);
            this.groupControl1.Controls.Add(this.btnXetHocLuc);
            this.groupControl1.Controls.Add(this.btnTinhDiemTBC);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbHocKy);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 116);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin:";
            // 
            // btnXetDanhHieu
            // 
            this.btnXetDanhHieu.Location = new System.Drawing.Point(305, 72);
            this.btnXetDanhHieu.Name = "btnXetDanhHieu";
            this.btnXetDanhHieu.Size = new System.Drawing.Size(82, 23);
            this.btnXetDanhHieu.TabIndex = 3;
            this.btnXetDanhHieu.Text = "Xét danh hiệu";
            this.btnXetDanhHieu.UseVisualStyleBackColor = true;
            this.btnXetDanhHieu.Click += new System.EventHandler(this.btnXetDanhHieu_Click);
            // 
            // btnXetHocLuc
            // 
            this.btnXetHocLuc.Location = new System.Drawing.Point(194, 72);
            this.btnXetHocLuc.Name = "btnXetHocLuc";
            this.btnXetHocLuc.Size = new System.Drawing.Size(79, 23);
            this.btnXetHocLuc.TabIndex = 3;
            this.btnXetHocLuc.Text = "Xét học lực";
            this.btnXetHocLuc.UseVisualStyleBackColor = true;
            this.btnXetHocLuc.Click += new System.EventHandler(this.btnXetHocLuc_Click);
            // 
            // btnTinhDiemTBC
            // 
            this.btnTinhDiemTBC.Location = new System.Drawing.Point(76, 72);
            this.btnTinhDiemTBC.Name = "btnTinhDiemTBC";
            this.btnTinhDiemTBC.Size = new System.Drawing.Size(91, 23);
            this.btnTinhDiemTBC.TabIndex = 3;
            this.btnTinhDiemTBC.Text = "Tính điểm TBC";
            this.btnTinhDiemTBC.UseVisualStyleBackColor = true;
            this.btnTinhDiemTBC.Click += new System.EventHandler(this.btnTinhDiemTBC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kỳ:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(180, 29);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cbHocKy.TabIndex = 1;
            this.cbHocKy.ValueMember = "MaHocKy";
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmXetCacTieuChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 116);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmXetCacTieuChuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xét các tiêu chuẩn";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnXetDanhHieu;
        private System.Windows.Forms.Button btnXetHocLuc;
        private System.Windows.Forms.Button btnTinhDiemTBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}