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
    public partial class frmCapNhatTinhThanh : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMTinhThanh _objTinhThanh = new DMTinhThanh();

        public DMTinhThanh ObjTinhThanh
        {
            get { return _objTinhThanh; }
            set { _objTinhThanh = value; }
        }

        public frmCapNhatTinhThanh()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatTinhThanh(DMTinhThanh objTinhThanh, bool themMoi)
        {
            ObjTinhThanh = objTinhThanh;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Tỉnh, Thành phố";
                txtMaTinhThanh.Text = String.Empty;
                txtTenTinhThanh.Text = "";
                txtMaTinhThanh.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Tỉnh, Thành phố";
                txtMaTinhThanh.Text = ObjTinhThanh.MaTinhThanh.ToString();
                txtTenTinhThanh.Text = ObjTinhThanh.TenTinhThanh;
                txtTenTinhThanh.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMTinhThanhBLL.ThemTinhThanh(txtTenTinhThanh.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjTinhThanh.TenTinhThanh = txtTenTinhThanh.Text.Trim();
                    DMTinhThanhBLL.CapNhatTinhThanh(ObjTinhThanh);
                    base.Close();
                }
            }
        }

        private void txtTenTinhThanh_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTinhThanh.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenTinhThanh, "Tên Tỉnh thành không được trống.");
                txtTenTinhThanh.Focus();
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
            txtTenTinhThanh_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenTinhThanh.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}