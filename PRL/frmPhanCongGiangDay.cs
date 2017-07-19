using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using BLL;
using DevExpress.XtraEditors.Repository;

namespace PRL
{
    public partial class frmPhanCongGiangDay : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanCongGiangDay()
        {
            InitializeComponent();            
        }

        private void TaoGridView(string maHocKy, string maKhoi)
        {
            string[] maTatCaMonHoc = DSMonHocBLL.LayMaMonHocTheoKhoiKy(maKhoi, maHocKy);
            string[] tenTatCaMonHoc = DSMonHocBLL.LayTenMonHocTheoKhoiKy(maKhoi, maHocKy);
            if (maTatCaMonHoc != null)
            {
                while (gvPhanCongGiangDay.Columns.Count > 5)
                    gvPhanCongGiangDay.Columns.Remove(gvPhanCongGiangDay.Columns[5]);

                for (byte i = 0; i < maTatCaMonHoc.Count(); i++)
                {
                    //Sinh lku
                    RepositoryItemGridLookUpEdit lku = new RepositoryItemGridLookUpEdit();
                    lku.Name = "lku" + maTatCaMonHoc[i];
                    lku.DisplayMember = "HoVaTen";
                    lku.ValueMember = "MaGiaoVien";
                    lku.AutoHeight = false;
                    lku.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                    lku.View = this.lkuGiaoVien;
                    gcPhanCongGiangDay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { lku });
                    lku.DataSource = DSGiaoVienBLL.TruyVanTheoMonGiangDay(maTatCaMonHoc[i]);

                    GridColumn cl = new GridColumn();
                    cl.Name = cl.FieldName = maTatCaMonHoc[i];
                    cl.Caption = tenTatCaMonHoc[i];
                    cl.ColumnEdit = lku;
                    cl.Width = 150;
                    cl.Visible = true;
                    cl.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                    cl.AppearanceHeader.Options.UseFont = true;
                    cl.AppearanceHeader.Options.UseTextOptions = true;
                    cl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    gvPhanCongGiangDay.Columns.Add(cl);
                }
            }            
        }

        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {            
            FillDataToComboBox();            
        }

        private void FillDataToComboBox()
        {
            cbHocKy.DataSource = DSHocKyBLL.LoadHocKyHoc();
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (cbKhoi.SelectedValue != null)
            {
                string maKhoi = cbKhoi.SelectedValue.ToString();
                TaoGridView(maHocKy, maKhoi);
                gcPhanCongGiangDay.DataSource = PhanCongGiangDayBLL.TruyVanPhanCongGiangDay(maHocKy, maKhoi);
            }                           
        }        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            PhanCongGiangDayBLL.CapNhatPhanCongGiangDay(maHocKy, gcPhanCongGiangDay);
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (cbKhoi.SelectedValue != null)
            {
                string maKhoi = cbKhoi.SelectedValue.ToString();
                TaoGridView(maHocKy, maKhoi);
                gcPhanCongGiangDay.DataSource = PhanCongGiangDayBLL.TruyVanPhanCongGiangDay(maHocKy, maKhoi);
            }            
        }
    }
}