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
    public partial class frmNhapDiemHSChuyenTruong : DevExpress.XtraEditors.XtraForm
    {
        private bool? LaChoDiem = true;
        private bool LaGiaoVien = false;
        private string TenDangNhap = "";
        private bool ThayDoi = false;
        bool[] KhoaChinhSua;// = new bool[gvDiem.Columns.Count];
        //string[] maHSChuyenTruong = DSHocSinhChuyenTruongBLL.LayMaHSChuyenTruong(0, "");

        public frmNhapDiemHSChuyenTruong(string tenDangNhap)
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
            lkuHocLuc.DataSource = DMHocLucBLL.LayTatCaHocLuc();
            lkuHanhKiem.DataSource = DMHanhKiemBLL.LayTatCaHanhKiem();
            lkuDanhHieu.DataSource = DMDanhHieuBLL.LayTatCaDanhHieu();
        }

        private void TaoGridView(string maLop, string maHocKy)
        {
            while (gvDiem.Columns.Count > 4)
                gvDiem.Columns.RemoveAt(gvDiem.Columns.Count - 1);
            string[] maMonHocTheoLopKy = DSMonHocTheoLopBLL.LayMaMonHocTheoLopHocKy(maLop, maHocKy);
            string[] hienThiMonHocTheoLopKy = DSMonHocTheoLopBLL.LayHienThiMonHocTheoLopHocKy(maLop, maHocKy);            
            int colTemp = 4;
            Color[] Colors = { Color.Azure, Color.Beige, Color.LightGreen, Color.Red };
            

            for(byte i = 0; i < maMonHocTheoLopKy.Count(); i++)
            {
                GridColumn cl = new GridColumn();
                cl.Name = cl.FieldName = maMonHocTheoLopKy[i];
                cl.Caption = hienThiMonHocTheoLopKy[i];
                cl.Width = 40;
                cl.Visible = true;
                cl.AppearanceCell.Options.UseTextOptions = true;
                cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cl.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
                cl.AppearanceCell.BackColor = Color.Yellow;
                cl.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
                cl.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                cl.AppearanceHeader.Options.UseFont = true;
                cl.AppearanceHeader.Options.UseTextOptions = true;
                cl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                gvDiem.Columns.Add(cl);                
                //gb.Columns.Add(cl);
                //gvDiem.Columns[colTemp].AppearanceCell.BackColor = Colors[i];
            }

            GridColumn clTBC = new GridColumn();
            clTBC.Name = clTBC.FieldName = "TBCCaKy";
            clTBC.Caption = "TBC cả kỳ";
            clTBC.Width = 40;
            clTBC.Visible = true;
            clTBC.AppearanceCell.Options.UseTextOptions = true;
            clTBC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clTBC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            clTBC.AppearanceCell.BackColor = Color.Yellow;
            clTBC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            clTBC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            clTBC.AppearanceHeader.Options.UseFont = true;
            clTBC.AppearanceHeader.Options.UseTextOptions = true;
            clTBC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clTBC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gvDiem.Columns.Add(clTBC);

            GridColumn clHocLuc = new GridColumn();
            clHocLuc.Name = clHocLuc.FieldName = "HocLuc";
            clHocLuc.Caption = "Học lực";
            clHocLuc.Width = 60;
            clHocLuc.ColumnEdit = lkuHocLuc;
            clHocLuc.Visible = true;
            clHocLuc.AppearanceCell.Options.UseTextOptions = true;
            clHocLuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clHocLuc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            clHocLuc.AppearanceCell.BackColor = Color.Yellow;
            clHocLuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            clHocLuc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            clHocLuc.AppearanceHeader.Options.UseFont = true;
            clHocLuc.AppearanceHeader.Options.UseTextOptions = true;
            clHocLuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clHocLuc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gvDiem.Columns.Add(clHocLuc);

            GridColumn clHanhKiem = new GridColumn();
            clHanhKiem.Name = clHanhKiem.FieldName = "HanhKiem";
            clHanhKiem.Caption = "Hạnh kiểm";
            clHanhKiem.Width = 60;
            clHanhKiem.ColumnEdit = lkuHanhKiem;
            clHanhKiem.Visible = true;
            clHanhKiem.AppearanceCell.Options.UseTextOptions = true;
            clHanhKiem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clHanhKiem.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            clHanhKiem.AppearanceCell.BackColor = Color.Yellow;
            clHanhKiem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            clHanhKiem.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            clHanhKiem.AppearanceHeader.Options.UseFont = true;
            clHanhKiem.AppearanceHeader.Options.UseTextOptions = true;
            clHanhKiem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clHanhKiem.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gvDiem.Columns.Add(clHanhKiem);

            GridColumn clDanhHieu = new GridColumn();
            clDanhHieu.Name = clDanhHieu.FieldName = "DanhHieu";
            clDanhHieu.Caption = "Danh hiệu";
            clDanhHieu.Width = 60;
            clDanhHieu.ColumnEdit = lkuDanhHieu;
            clDanhHieu.Visible = true;
            clDanhHieu.AppearanceCell.Options.UseTextOptions = true;
            clDanhHieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clDanhHieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            clDanhHieu.AppearanceCell.BackColor = Color.Yellow;
            clDanhHieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            clDanhHieu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            clDanhHieu.AppearanceHeader.Options.UseFont = true;
            clDanhHieu.AppearanceHeader.Options.UseTextOptions = true;
            clDanhHieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clDanhHieu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gvDiem.Columns.Add(clDanhHieu);



            for (byte i = 4; i < gvDiem.Columns.Count; i++)
            {                
                gvDiem.Columns[i].DisplayFormat.FormatString = "0.00";
                gvDiem.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            }            
            gvDiem.Columns[gvDiem.Columns.Count - 1].AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);            

            //Lưu lại trạng thái cho phép chỉnh sửa ở mỗi cột
            KhoaChinhSua = new bool[gvDiem.Columns.Count];
            for (int i = 0; i < gvDiem.Columns.Count; i++)
                KhoaChinhSua[i] = gvDiem.Columns[i].OptionsColumn.AllowEdit;

            gvDiem.OptionsView.AllowHtmlDrawHeaders = true;
            gvDiem.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gvDiem.ColumnPanelRowHeight = 40;
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
            RefreshGridControl(maLop, maHocKy);
        }      

        private void RefreshGridControl(string maLop, string maHocKy)
        {            
            if ((cbLop.SelectedValue == null))
                gcDiem.DataSource = null;
            else
            {
                TaoGridView(maLop, maHocKy);
                gcDiem.DataSource = DSDiemBLL.TruyVanDSDiemHocKyHSChuyenTruong(maLop, maHocKy);
            }                                       
            //Kiểm tra xem đã khóa sổ hay chưa, nếu đã khóa sổ thì không cho chỉnh sửa nữa.
            //if (DSDiemBLL.KiemTraKhoaSo(maHocKy) == true)
            //{
            //    foreach (BandedGridColumn cl in gvDiem.Columns)
            //    {
            //        cl.OptionsColumn.AllowEdit = false;
            //    }
            //    btnTinhDiemTrungBinh.Enabled = false;
            //}
            //else
            //{
            //    btnTinhDiemTrungBinh.Enabled = true;
            //    for (int i = 0; i < gvDiem.Columns.Count; i++)
            //        gvDiem.Columns[i].OptionsColumn.AllowEdit = KhoaChinhSua[i];
            //}            
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
                        splashScreenManager.ShowWaitForm();
                        string maLop = cbLop.SelectedValue.ToString();
                        string maHocKy = cbHocKy.SelectedValue.ToString();                        
                        DSDiemBLL.CapNhatDiemTrungBinhMon(gcDiem, maHocKy);
                        splashScreenManager.CloseWaitForm();
                        ThayDoi = false;
                    }else
                    {
                        UTL.Ultils.ThongBao("Dữ liệu nhập chưa chính xác. Vui lòng nhập lại ô đang được đánh dấu.", MessageBoxIcon.Error);
                    }
                }            
        }

        private bool CheckSave()
        {
            for (byte i = 0; i < gvDiem.RowCount; i++)
                for (byte j = 4; j < gvDiem.Columns.Count - 3; j++)
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
            if ((giaTri == "-") || (giaTri == "Đ") || (giaTri == "CĐ"))
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
                splashScreenManager.ShowWaitForm();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                string maLop = cbLop.SelectedValue.ToString();                
                //DSDiemBLL.TinhDiemTrungBinh(maHocKy, maLop, maMonHoc);
                if (maHocKy == "K2")
                {
                    string maHocKyTongHop = DSHocKyBLL.MaHocKyTongHop();
                    //DSDiemBLL.TinhDiemTrungBinh(maHocKyTongHop, maLop, maMonHoc);
                }
                
                splashScreenManager.CloseWaitForm();
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
                TaoGridView(maLop, maHocKy);
                if (maLop != null)
                    RefreshGridControl(maLop, maHocKy);
                }else
                {
                    gcDiem.DataSource = null;
                }
            }

        private void gvDiem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ThayDoi = true;
        }

        private void frmNhapDiemHSChuyenTruong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ThayDoi)
            {
                DialogResult result = MessageBox.Show("Dữ liệu đã được thay đổi. Bạn có muốn lưu dữ liệu trước khi thoát không?", UTL.Params.Title, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    btnLuu_Click(sender, e);
            }
        }

        private void gvDiem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (gvDiem.FocusedColumn.FieldName.Contains("MH"))
            {
                bool? LaChoDiem = DSMonHocBLL.LaChoDiem(gvDiem.FocusedColumn.FieldName);
                if (LaChoDiem == true)
                {
                    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!Char.IsLetter('c') && !Char.IsLetter('d'))
                    {
                        e.Handled = true;
                    }
                }
            }            
        }

        private void gvDiem_CellValueChanging_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName.Contains("MH"))
            {
                bool? LaChoDiem = DSMonHocBLL.LaChoDiem(gvDiem.FocusedColumn.FieldName);
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
                            temp = (float)Math.Round(temp, 1);
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
                }
                else
                {
                    GridColumn cot = e.Column;
                    int dong = e.RowHandle;
                    if (e.Value.ToString() == "c")
                    {
                        gvDiem.SetRowCellValue(dong, cot, "CĐ");

                    }
                    else
                    {
                        gvDiem.SetRowCellValue(dong, cot, "Đ");
                    }
                    SendKeys.Send("{End}");
                }
            }else
            {
                if (e.Column.FieldName.Contains("TBCCaKy"))
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
                            temp = (float)Math.Round(temp, 1);
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
                }
                else
                {
                    GridColumn cot = e.Column;
                    int dong = e.RowHandle;
                    gvDiem.SetRowCellValue(dong, cot, e.Value);
                }                
            }            
        }

        private void gvDiem_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ThayDoi = true;
        }
    }
}