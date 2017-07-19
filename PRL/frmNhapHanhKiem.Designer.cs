namespace PRL
{
    partial class frmNhapHanhKiem
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnTaoDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinhTBC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXetDanhHieu = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.gcHanhKiem = new DevExpress.XtraGrid.GridControl();
            this.gvHanhKiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclMaHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHanhKiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkuVD = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lkuGiaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclMaGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTenGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHanhKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHanhKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoDuLieu,
            this.btnTinhTBC,
            this.btnLuu1,
            this.btnXetDanhHieu});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(856, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Size = new System.Drawing.Size(856, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(856, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
            // 
            // btnTaoDuLieu
            // 
            this.btnTaoDuLieu.Caption = "Tạo dữ liệu";
            this.btnTaoDuLieu.Id = 0;
            this.btnTaoDuLieu.Name = "btnTaoDuLieu";
            // 
            // btnTinhTBC
            // 
            this.btnTinhTBC.Caption = "Tính TBC";
            this.btnTinhTBC.Id = 1;
            this.btnTinhTBC.Name = "btnTinhTBC";            
            // 
            // btnLuu1
            // 
            this.btnLuu1.Id = 4;
            this.btnLuu1.Name = "btnLuu1";
            // 
            // btnXetDanhHieu
            // 
            this.btnXetDanhHieu.Caption = "Xét danh hiệu";
            this.btnXetDanhHieu.Id = 3;
            this.btnXetDanhHieu.Name = "btnXetDanhHieu";
            this.btnXetDanhHieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXetDanhHieu_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cbHocKy);
            this.panelControl1.Controls.Add(this.cbLop);
            this.panelControl1.Controls.Add(this.cbKhoi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(856, 50);
            this.panelControl1.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(443, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Khối:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DisplayMember = "TenHocKy";
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(320, 12);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(74, 21);
            this.cbHocKy.TabIndex = 8;
            this.cbHocKy.ValueMember = "MaHocKy";
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "TenLop";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(189, 11);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(58, 21);
            this.cbLop.TabIndex = 9;
            this.cbLop.ValueMember = "MaLop";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbKhoi
            // 
            this.cbKhoi.DisplayMember = "TenKhoi";
            this.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(69, 12);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(58, 21);
            this.cbKhoi.TabIndex = 10;
            this.cbKhoi.ValueMember = "MaKhoi";
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // gcHanhKiem
            // 
            this.gcHanhKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcHanhKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHanhKiem.Location = new System.Drawing.Point(0, 50);
            this.gcHanhKiem.MainView = this.gvHanhKiem;
            this.gcHanhKiem.Name = "gcHanhKiem";
            this.gcHanhKiem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkuVD});
            this.gcHanhKiem.Size = new System.Drawing.Size(856, 340);
            this.gcHanhKiem.TabIndex = 14;
            this.gcHanhKiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHanhKiem});
            // 
            // gvHanhKiem
            // 
            this.gvHanhKiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSTT,
            this.gclMaHocSinh,
            this.gclTenHocSinh,
            this.gclNgaySinh,
            this.gclHanhKiem});
            this.gvHanhKiem.GridControl = this.gcHanhKiem;
            this.gvHanhKiem.Name = "gvHanhKiem";
            this.gvHanhKiem.OptionsView.ColumnAutoWidth = false;
            this.gvHanhKiem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvHanhKiem_CellValueChanging);
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
            this.gclSTT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gclSTT.Name = "gclSTT";
            this.gclSTT.OptionsColumn.AllowEdit = false;
            this.gclSTT.OptionsColumn.AllowSize = false;
            this.gclSTT.Visible = true;
            this.gclSTT.VisibleIndex = 0;
            this.gclSTT.Width = 40;
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
            this.gclMaHocSinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gclMaHocSinh.Name = "gclMaHocSinh";
            this.gclMaHocSinh.OptionsColumn.AllowEdit = false;
            this.gclMaHocSinh.OptionsColumn.AllowSize = false;
            this.gclMaHocSinh.Visible = true;
            this.gclMaHocSinh.VisibleIndex = 1;
            // 
            // gclTenHocSinh
            // 
            this.gclTenHocSinh.AppearanceCell.Options.UseTextOptions = true;
            this.gclTenHocSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenHocSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTenHocSinh.AppearanceHeader.Options.UseFont = true;
            this.gclTenHocSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenHocSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenHocSinh.Caption = "Họ và tên";
            this.gclTenHocSinh.FieldName = "HoVaTen";
            this.gclTenHocSinh.Name = "gclTenHocSinh";
            this.gclTenHocSinh.OptionsColumn.AllowEdit = false;
            this.gclTenHocSinh.Visible = true;
            this.gclTenHocSinh.VisibleIndex = 2;
            this.gclTenHocSinh.Width = 157;
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
            this.gclNgaySinh.VisibleIndex = 3;
            this.gclNgaySinh.Width = 109;
            // 
            // gclHanhKiem
            // 
            this.gclHanhKiem.AppearanceCell.Options.UseTextOptions = true;
            this.gclHanhKiem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHanhKiem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclHanhKiem.AppearanceHeader.Options.UseFont = true;
            this.gclHanhKiem.AppearanceHeader.Options.UseTextOptions = true;
            this.gclHanhKiem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclHanhKiem.Caption = "Hạnh kiểm";
            this.gclHanhKiem.FieldName = "HanhKiem";
            this.gclHanhKiem.Name = "gclHanhKiem";
            this.gclHanhKiem.Visible = true;
            this.gclHanhKiem.VisibleIndex = 4;
            this.gclHanhKiem.Width = 93;
            // 
            // lkuVD
            // 
            this.lkuVD.AutoHeight = false;
            this.lkuVD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuVD.DisplayMember = "HoVaTen";
            this.lkuVD.Name = "lkuVD";
            this.lkuVD.ValueMember = "MaGiaoVien";
            this.lkuVD.View = this.lkuGiaoVien;
            // 
            // lkuGiaoVien
            // 
            this.lkuGiaoVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclMaGiaoVien,
            this.gclTenGiaoVien});
            this.lkuGiaoVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lkuGiaoVien.Name = "lkuGiaoVien";
            this.lkuGiaoVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lkuGiaoVien.OptionsView.ShowGroupPanel = false;
            // 
            // gclMaGiaoVien
            // 
            this.gclMaGiaoVien.AppearanceCell.Options.UseTextOptions = true;
            this.gclMaGiaoVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaGiaoVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclMaGiaoVien.AppearanceHeader.Options.UseFont = true;
            this.gclMaGiaoVien.AppearanceHeader.Options.UseTextOptions = true;
            this.gclMaGiaoVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclMaGiaoVien.Caption = "Mã giáo viên";
            this.gclMaGiaoVien.FieldName = "MaGiaoVien";
            this.gclMaGiaoVien.Name = "gclMaGiaoVien";
            this.gclMaGiaoVien.Visible = true;
            this.gclMaGiaoVien.VisibleIndex = 0;
            // 
            // gclTenGiaoVien
            // 
            this.gclTenGiaoVien.AppearanceCell.Options.UseTextOptions = true;
            this.gclTenGiaoVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenGiaoVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gclTenGiaoVien.AppearanceHeader.Options.UseFont = true;
            this.gclTenGiaoVien.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTenGiaoVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTenGiaoVien.Caption = "Tên giáo viên";
            this.gclTenGiaoVien.FieldName = "HoVaTen";
            this.gclTenGiaoVien.Name = "gclTenGiaoVien";
            this.gclTenGiaoVien.Visible = true;
            this.gclTenGiaoVien.VisibleIndex = 1;
            // 
            // frmNhapHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 413);
            this.Controls.Add(this.gcHanhKiem);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhapHanhKiem";
            this.Text = "Nhập hạnh kiểm";
            this.Load += new System.EventHandler(this.frmNhapHanhKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHanhKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHanhKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnTaoDuLieu;
        private DevExpress.XtraBars.BarButtonItem btnTinhTBC;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLuu1;
        private DevExpress.XtraBars.BarButtonItem btnXetDanhHieu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private DevExpress.XtraGrid.GridControl gcHanhKiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHanhKiem;
        private DevExpress.XtraGrid.Columns.GridColumn gclSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn gclHanhKiem;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lkuVD;
        private DevExpress.XtraGrid.Views.Grid.GridView lkuGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn gclMaGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn gclTenGiaoVien;
    }
}