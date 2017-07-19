using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BLL;

namespace PRL
{
    public partial class frmCapNhatMonHoc : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DSMonHoc _objMonHoc = new DSMonHoc();

        public DSMonHoc ObjMonHoc
        {
            get { return _objMonHoc; }
            set { _objMonHoc = value; }
        }

        public frmCapNhatMonHoc()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatMonHoc(DSMonHoc objMonHoc, bool themMoi)
        {
            ObjMonHoc = objMonHoc;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void FillDataToGrid()
        {
            lkuHinhThucDanhGia.Properties.DataSource = DSHinhThucDanhGiaBLL.LoadAll();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Môn học";
                txtMaMonHoc.Text = DSMonHocBLL.SinhMaMonHoc();
                txtTenMonHoc.Text = "";
                FillDataToGrid();
                lkuHinhThucDanhGia.EditValue = null;
                txtTenMonHoc.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Môn học";
                txtMaMonHoc.Text = ObjMonHoc.MaMonHoc.ToString();
                txtTenMonHoc.Text = ObjMonHoc.TenMonHoc;
                FillDataToGrid();
                lkuHinhThucDanhGia.EditValue = ObjMonHoc.MaHinhThucDanhGia;
                nudHeSo.Value = (decimal)ObjMonHoc.HeSo;
                txtTenMonHoc.Focus();                
            }            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DSMonHocBLL.ThemMonHoc(txtMaMonHoc.Text, txtTenMonHoc.Text.Trim(), (short)lkuHinhThucDanhGia.EditValue, (short)nudHeSo.Value);
                    base.Close();
                }
                else
                {
                    ObjMonHoc.TenMonHoc = txtTenMonHoc.Text.Trim();
                    ObjMonHoc.MaHinhThucDanhGia = (short)lkuHinhThucDanhGia.EditValue;
                    ObjMonHoc.HeSo = (short)nudHeSo.Value;
                    DSMonHocBLL.CapNhatMonHoc(ObjMonHoc);
                    base.Close();
                }
            }
        }

        private void txtTenMonHoc_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenMonHoc.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenMonHoc, "Tên môn học không được trống.");
                txtTenMonHoc.Focus();
            }else
            {
                dxErrorProvider.ClearErrors();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
        }

        private bool CheckSave()
        {
            txtTenMonHoc_Leave(null, null);
            lkuHinhThucDanhGia_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenMonHoc.Text.Trim()) || (lkuHinhThucDanhGia.EditValue == null))
                return false;
            else
                return true;
        }

        private void btnTinhThanh_Click(object sender, EventArgs e)
        {
            frmCapNhatTinhThanh form = new frmCapNhatTinhThanh (null, true);
            form.ShowDialog();
            FillDataToGrid();
        }

        private void lkuHinhThucDanhGia_Leave(object sender, EventArgs e)
        {
            if (lkuHinhThucDanhGia.EditValue == null)
            {
                dxErrorProvider.SetError(lkuHinhThucDanhGia, "Hình thức đánh giá không được trống.");
                lkuHinhThucDanhGia.Focus();
            }else
            {
                dxErrorProvider.ClearErrors();
            }
        }

    }
}