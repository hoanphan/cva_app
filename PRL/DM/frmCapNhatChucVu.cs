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
    public partial class frmCapNhatChucVu : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMChucVu _objChucVu = new DMChucVu();

        public DMChucVu ObjChucVu
        {
            get { return _objChucVu; }
            set { _objChucVu = value; }
        }

        public frmCapNhatChucVu()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatChucVu(DMChucVu objChucVu, bool themMoi)
        {
            ObjChucVu = objChucVu;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Chức vụ";
                txtMaChucVu.Text = String.Empty;
                txtTenChucVu.Text = "";
                txtMaChucVu.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Chức vụ";
                txtMaChucVu.Text = ObjChucVu.MaChucVu.ToString();
                txtTenChucVu.Text = ObjChucVu.TenChucVu;
                txtTenChucVu.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMChucVuBLL.ThemChucVu(txtTenChucVu.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjChucVu.TenChucVu = txtTenChucVu.Text.Trim();
                    DMChucVuBLL.CapNhatChucVu(ObjChucVu);
                    base.Close();
                }
            }
        }

        private void txtTenChucVu_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenChucVu.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenChucVu, "Tên Dân tộc không được trống.");
                txtTenChucVu.Focus();
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
            txtTenChucVu_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenChucVu.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}