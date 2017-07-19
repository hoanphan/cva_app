using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace PRL
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        private bool? LaChoDiem = true;
        private bool LaGiaoVien = false;
        private string TenDangNhap = "";
        private bool ThayDoi = false;
        bool[] KhoaChinhSua;// = new bool[gvDiem.Columns.Count];
        string[] maHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(1, "");
        string[] maHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, "");

        public frmNhapDiem(string tenDangNhap)
        {
            InitializeComponent();            
            LaGiaoVien = DSGiaoVienBLL.LaGiaoVien(tenDangNhap);
            if (LaGiaoVien)
                TenDangNhap = tenDangNhap;
            FillData();
        }

        public void FillData()
        {
            cbHocKy.DataSource = DSHocKyBLL.LoadHocKyHoc();  
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();      
            TaoGridView();            
        }

        private void TaoGridView()
        {
            string[] MaLoaiDiem = DSLoaiDiemBLL.LoadAllMaLoaiDiem();
            string[] TenLoaiDiem = DSLoaiDiemBLL.LoadAllTenLoaiDiem();            
            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();  
            bool?[] ChoPhepChinhSua = DSLoaiDiemBLL.LoadAllChinhSua();
            int colTemp = 4;
            Color[] Colors = { Color.Azure, Color.Beige, Color.LightGreen, Color.Red };    
            for (byte i = 0; i < TenLoaiDiem.Count(); i++)
            {
                if ((short)SoDiemToiDa.GetValue(i) > 1)
                {
                    GridBand gb = new GridBand();
                    gb.Caption = TenLoaiDiem[i];
                    gb.Width = 40 * (short)SoDiemToiDa.GetValue(i);
                    gb.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                    gb.AppearanceHeader.Options.UseFont = true;
                    gb.AppearanceHeader.Options.UseTextOptions = true;
                    gb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;                    

                    for (byte j = 0; j < (short)SoDiemToiDa.GetValue(i); j++)
                    {
                        BandedGridColumn cl = new BandedGridColumn();
                        cl.Name = cl.FieldName = MaLoaiDiem[i] + "_" + (j + 1).ToString();
                        cl.Caption =  HienThi[i] + (j+1).ToString();
                        cl.Width = 40;
                        cl.Visible = true;
                        cl.AppearanceCell.Options.UseTextOptions = true;                        
                        cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        cl.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
                        cl.AppearanceCell.BackColor = Color.Yellow;
                        cl.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
                        cl.AppearanceHeader.Options.UseFont = true;
                        cl.AppearanceHeader.Options.UseTextOptions = true;
                        cl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        cl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        gvDiem.Columns.Add(cl);
                        gb.Columns.Add(cl);
                        gvDiem.Columns[colTemp].AppearanceCell.BackColor = Colors[i];                        

                        //Tạo Conditional Format
                        //StyleFormatCondition styleFC = new StyleFormatCondition();
                        //styleFC.Appearance.ForeColor = System.Drawing.Color.Red;
                        //styleFC.Appearance.Options.UseForeColor = true;
                        //styleFC.Column = gvDiem.Columns[colTemp];
                        //styleFC.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
                        //styleFC.Expression = "[" + cl.Name + "]  <  \'5\'";
                        ////styleFC.Name = "ConditionLessThan5";
                        //this.gvDiem.FormatConditions.Add(styleFC);

                        colTemp++;
                    }
                    gvDiem.Bands.Add(gb);                
                }                
            }                   

            for (byte i = 0; i < TenLoaiDiem.Count(); i++)
            {
                if ((short)SoDiemToiDa.GetValue(i) == 1)
                {
                    GridBand gb = new GridBand();
                    gb.Width = 60;
                    gb.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                    gb.AppearanceHeader.Options.UseFont = true;
                    gb.AppearanceHeader.Options.UseTextOptions = true;
                    gb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    BandedGridColumn cl = new BandedGridColumn();
                    cl.Name = cl.FieldName = MaLoaiDiem[i] + "_" + (1).ToString();
                    cl.Caption = HienThi[i];
                    cl.Width = 60;
                    cl.Visible = true;                        
                    cl.AppearanceCell.Options.UseTextOptions = true;
                    cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    cl.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
                    cl.AppearanceHeader.Options.UseFont = true;
                    cl.AppearanceHeader.Options.UseTextOptions = true;
                    cl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    if ((bool)ChoPhepChinhSua.GetValue(i) == false)
                    {
                        cl.OptionsColumn.AllowEdit = false;                        
                        cl.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
                    }
                    cl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvDiem.Columns.Add(cl);
                    gb.Columns.Add(cl);

                    gvDiem.Bands.Add(gb);                    
                }
            }            

            for (byte i = 4; i < gvDiem.Columns.Count; i++)
            {                
                gvDiem.Columns[i].DisplayFormat.FormatString = "0.00";
                gvDiem.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            }
            gvDiem.Columns[gvDiem.Columns.Count - 1].AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            gvDiem.Columns[gvDiem.Columns.Count - 2].AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);

            //Lưu lại trạng thái cho phép chỉnh sửa ở mỗi cột
            KhoaChinhSua = new bool[gvDiem.Columns.Count];
            for (int i = 0; i < gvDiem.Columns.Count; i++)
                KhoaChinhSua[i] = gvDiem.Columns[i].OptionsColumn.AllowEdit;
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();
            cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
            if (cbLop.SelectedValue == null)
                gcDiem.DataSource = null;
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (LaGiaoVien)                
                cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKyGiaoVien(maLop, maHocKy, TenDangNhap);
            else
                cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKy(maLop, maHocKy);
            if (cbMonHoc.SelectedValue == null)
                gcDiem.DataSource = null;
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string maMonHoc = cbMonHoc.SelectedValue.ToString();
            LaChoDiem = DSMonHocBLL.LaChoDiem(maMonHoc);
            RefreshGridControl(maLop, maHocKy, maMonHoc);

        }

        private void RefreshGridControl(string maLop, string maHocKy, string maMonHoc)
        {            
            if ((cbLop.SelectedValue == null) || (cbMonHoc.SelectedValue == null))
                gcDiem.DataSource = null;
            else
                gcDiem.DataSource = DSDiemBLL.TruyVanDSDiem(maLop, maHocKy, maMonHoc);
                       
            //Kiểm tra xem đã khóa sổ hay chưa, nếu đã khóa sổ thì không cho chỉnh sửa nữa.
            if (DSDiemBLL.KiemTraKhoaSo(maHocKy) == true)
            {
                foreach (BandedGridColumn cl in gvDiem.Columns)
                {
                    cl.OptionsColumn.AllowEdit = false;
                }
                btnTinhDiemTrungBinh.Enabled = false;
            }
            else
            {
                btnTinhDiemTrungBinh.Enabled = true;
                for (int i = 0; i < gvDiem.Columns.Count; i++)
                    gvDiem.Columns[i].OptionsColumn.AllowEdit = KhoaChinhSua[i];
            }            
        }

        private void gvDiem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show(e.Column.VisibleIndex.ToString());
            if (LaChoDiem == true)
            {
                try
                {
                    if (e.Value.ToString() != "." && e.Value.ToString() != "")
                    {
                        float temp = float.Parse(e.Value.ToString());
                        if (temp > 100)
                            temp = temp / 100;
                        else
                            if (temp > 10)
                                temp = temp / 10;
                        GridColumn cot = e.Column;
                        int dong = e.RowHandle;
                        temp = (float)Math.Round(temp, 2);
                        gvDiem.SetRowCellValue(dong, cot, temp);
                        SendKeys.Send("{End}");
                    }
                }
                catch (FormatException ex)
                {
                    GridColumn cot = e.Column;
                    int dong = e.RowHandle;
                    gvDiem.SetRowCellValue(dong, cot, "-");
                }          
            }else
            {
                GridColumn cot = e.Column;
                int dong = e.RowHandle;
                if (e.Value.ToString() == "c")
                {                    
                    gvDiem.SetRowCellValue(dong, cot, "CĐ");
                    
                }else
                {
                    gvDiem.SetRowCellValue(dong, cot, "Đ");
                }
                SendKeys.Send("{End}");                    
            }            
        }

        private void gvDiem_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (LaChoDiem == true)
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }else
            {
                if (!Char.IsLetter('c') && !Char.IsLetter('d'))
                {
                    e.Handled = true;
                }
            }            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (gvDiem.RowCount > 0)
                if (ThayDoi)
                {                
                    if (CheckSave())
                    {
                        try
                        {
                            splashScreenManager.ShowWaitForm();
                            string maLop = cbLop.SelectedValue.ToString();
                            string maHocKy = cbHocKy.SelectedValue.ToString();
                            string maMonHoc = cbMonHoc.SelectedValue.ToString();
                            DSDiemBLL.CapNhatDiem(gcDiem, maLop, maHocKy, maMonHoc);
                            splashScreenManager.CloseWaitForm();
                            ThayDoi = false;
                        }catch(Exception ex)
                        {
                            splashScreenManager.CloseWaitForm();
                            UTL.Ultils.ThongBao("Quá trình lưu thông tin bị lỗi. Vui lòng thoát ra và thực hiện lại. \r\nLỗi: " + ex.Message, MessageBoxIcon.Error);
                        }
                    }else
                    {
                        UTL.Ultils.ThongBao("Dữ liệu nhập chưa chính xác. Vui lòng nhập lại ô đang được đánh dấu.", MessageBoxIcon.Error);
                    }
                }            
        }

        private bool CheckSave()
        {
            for (byte i = 0; i < gvDiem.RowCount; i++)
                for (byte j = 4; j < gvDiem.Columns.Count; j++)
                {
                    if (KiemTra1Cell(gvDiem.GetRowCellValue(i, gvDiem.Columns[j]).ToString()) == false)
                    {
                        gvDiem.FocusedRowHandle = i;
                        gvDiem.FocusedColumn = gvDiem.VisibleColumns[j];
                        gvDiem.ShowEditor();
                        return false;
                    }
                }
            return true;
        }

        private bool KiemTra1Cell(string giaTri)
        {
            if (giaTri == "-")
                return true;
            float tt;
            float.TryParse(giaTri, out tt);
            if (tt < 0)
                return false;
            else
                return true;
        }

        private void gvDiem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void btnTinhDiemTrungBinh_Click(object sender, EventArgs e)
        {
            //if (KiemTraNhapDiemHocKy())
            //{
            if (gvDiem.RowCount > 0)
            {
                if (ThayDoi)
                {                    
                    btnLuu_Click(sender, e);                                        
                }
                try
                {
                    splashScreenManager.ShowWaitForm();
                    string maHocKy = cbHocKy.SelectedValue.ToString();
                    string maLop = cbLop.SelectedValue.ToString();
                    string maMonHoc = cbMonHoc.SelectedValue.ToString();
                    DSDiemBLL.TinhDiemTrungBinh(maHocKy, maLop, maMonHoc);
                    if (maHocKy == "K2")
                    {
                        string maHocKyTongHop = DSHocKyBLL.MaHocKyTongHop();
                        DSDiemBLL.TinhDiemTrungBinh(maHocKyTongHop, maLop, maMonHoc);
                    }

                    RefreshGridControl(maLop, maHocKy, maMonHoc);
                    splashScreenManager.CloseWaitForm();
                }catch(Exception ex)
                {
                    splashScreenManager.CloseWaitForm();
                    UTL.Ultils.ThongBao("Quá trình tính điểm trung bình bị lỗi. Vui lòng thoát ra để thực hiện lại.\r\nLỗi: " + ex.Message, MessageBoxIcon.Error);
                }
                
            }                
                
            //}else
            //{
            //    UTL.Ultils.ThongBao("Điểm Học kỳ chưa được nhập đầy đủ. Vui lòng kiểm tra lại.", MessageBoxIcon.Error);
            //}            
        }

        private bool KiemTraNhapDiemHocKy()
        {
            int colIndex = gvDiem.Columns.Count - 2;
            for (byte i = 0; i < gvDiem.RowCount; i++)
                if (gvDiem.GetRowCellValue(i, gvDiem.Columns[colIndex]) == "-")
                    return false;
            return true;
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbLop.SelectedValue != null)
            {
                string maLop = cbLop.SelectedValue.ToString();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                maHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, maHocKy);
                if (LaGiaoVien)
                    cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKyGiaoVien(maLop, maHocKy, TenDangNhap);
                else
                    cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKy(maLop, maHocKy);
                if (cbMonHoc.SelectedValue != null)
                {                    
                    string maMonHoc = cbMonHoc.SelectedValue.ToString();
                    RefreshGridControl(maLop, maHocKy, maMonHoc);
                }else
                {
                    gcDiem.DataSource = null;
                }
            }            
                
        }

        private void gvDiem_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDiem.SetRowCellValue(e.RowHandle, gvDiem.Columns[0], gvDiem.RowCount.ToString());
        }

        private void gvDiem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ThayDoi = true;
        }

        private void frmNhapDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ThayDoi)
            {
                DialogResult result = MessageBox.Show("Dữ liệu đã được thay đổi. Bạn có muốn lưu dữ liệu trước khi thoát không?", UTL.Params.Title, MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    btnLuu_Click(sender, e);
            }
        }

        private void gvDiem_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            FontFamily ff = new FontFamily("Tahoma");
            GridView view = sender as GridView;            
            string maHS = view.GetRowCellDisplayText(e.RowHandle, view.Columns["MaHocSinh"]);
            if (maHSChuyenTruong.Contains(maHS) || maHSThoiHoc.Contains(maHS)) 
            {
                e.Appearance.Font = new Font(ff, 9.75f, FontStyle.Strikeout);
                
            }            
        }

        private void gvDiem_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView view = sender as GridView;
            string maHS = view.GetRowCellDisplayText(view.FocusedRowHandle, view.Columns["MaHocSinh"]);
            if (maHSChuyenTruong.Contains(maHS) || maHSThoiHoc.Contains(maHS))
            {                
                e.Cancel = true;
            }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (maHocKy != null)
            {
                maHSThoiHoc = DSHocSinhThoiHocBLL.LayMaHSThoiHoc(2, maHocKy);
                maHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(2, maHocKy);
            }                
        }
    }
}