using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using BLL;
using UTL;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace PRL
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        private bool? LaChoDiem = true;

        public frmNhapDiem()
        {
            InitializeComponent();
            FillData();
        }

        public void FillData()
        {
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();            
            TaoGridView();
        }

        private void TaoGridView()
        {
            string[] MaLoaiDiem = DSLoaiDiemBLL.LoadAllMaLoaiDiem();
            string[] TenLoaiDiem = DSLoaiDiemBLL.LoadAllTenLoaiDiem();            
            string[] HienThi = DSLoaiDiemBLL.LoadAllHienThi();
            short?[] SoDiemToiDa = DSLoaiDiemBLL.LoadAllSoDiemToiDa();  
            bool?[] ChoPhepChinhSua = DSLoaiDiemBLL.LoadAllChinhSua();
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
                        cl.AppearanceCell.BackColor = Color.Yellow;
                        cl.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
                        cl.AppearanceHeader.Options.UseFont = true;
                        cl.AppearanceHeader.Options.UseTextOptions = true;
                        cl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;                        
                        gvDiem.Columns.Add(cl);
                        gb.Columns.Add(cl);
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
                    
                    gvDiem.Columns.Add(cl);
                    gb.Columns.Add(cl);

                    gvDiem.Bands.Add(gb);
                }
            }
            //GridBand gb1 = new GridBand();
            //gb1.Width = 110;
            //gb1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            //gb1.AppearanceHeader.Options.UseFont = true;
            //gb1.AppearanceHeader.Options.UseTextOptions = true;
            //gb1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //BandedGridColumn cl1 = new BandedGridColumn();
            //cl1.Name = "HK1";
            //cl1.FieldName = "HK";
            //cl1.Caption = "Học kỳ";
            //cl1.Width = 50;
            //cl1.Visible = true;
            //cl1.AppearanceCell.Options.UseTextOptions = true;
            //cl1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //cl1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            //cl1.AppearanceHeader.Options.UseFont = true;
            //cl1.AppearanceHeader.Options.UseTextOptions = true;
            //cl1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gvDiem.Columns.Add(cl1);
            //gb1.Columns.Add(cl1);
            //BandedGridColumn cl2 = new BandedGridColumn();
            //cl2.Name = "TB1";
            //cl2.FieldName = "TB";
            //cl2.Caption = "Trung bình";
            //cl2.Width = 60;
            //cl2.Visible = true;
            //cl2.AppearanceCell.Options.UseTextOptions = true;
            //cl2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //cl2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            //cl2.AppearanceHeader.Options.UseFont = true;
            //cl2.AppearanceHeader.Options.UseTextOptions = true;
            //cl2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gvDiem.Columns.Add(cl2);
            //gb1.Columns.Add(cl2);
            //gvDiem.Bands.Add(gb1);

            for (byte i = 4; i < gvDiem.Columns.Count; i++)
            {
                gvDiem.Columns[i].DisplayFormat.FormatString = "0.00";
                gvDiem.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DSDiemBLL.KhoiTaoDuLieuDiem();
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
            cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLop(maLop);
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
                    MessageBox.Show("Lỗi: " + ex.ToString());
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
            CheckSave();
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string maMonHoc = cbMonHoc.SelectedValue.ToString();
            DSDiemBLL.CapNhatDiem(gcDiem, maLop, maHocKy, maMonHoc);
        }

        private void CheckSave()
        {
            if (gvDiem.HasColumnErrors)
            {
                UTL.Ultils.NhapDuLieuError();
            }
        }

        private void gvDiem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void btnTinhDiemTrungBinh_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string maLop = cbLop.SelectedValue.ToString();
            string maMonHoc = cbMonHoc.SelectedValue.ToString();
            DSDiemBLL.TinhDiemTrungBinh(maHocKy, maLop, maMonHoc);
            RefreshGridControl(maLop, maHocKy, maMonHoc);
        }
    }
}