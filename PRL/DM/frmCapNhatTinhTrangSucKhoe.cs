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
    public partial class frmCapNhatTinhTrangSucKhoe : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMTinhTrangSucKhoe _objTinhTrangSucKhoe = new DMTinhTrangSucKhoe();

        public DMTinhTrangSucKhoe ObjTinhTrangSucKhoe
        {
            get { return _objTinhTrangSucKhoe; }
            set { _objTinhTrangSucKhoe = value; }
        }

        public frmCapNhatTinhTrangSucKhoe()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatTinhTrangSucKhoe(DMTinhTrangSucKhoe objTinhTrangSucKhoe,bool themMoi)
        {
            ObjTinhTrangSucKhoe = objTinhTrangSucKhoe;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm tình trạng sức khỏe";
                txtMaTinhTrangSucKhoe.Text = String.Empty;
                txtTenTinhTrangSucKhoe.Text = "";
                txtTenTinhTrangSucKhoe.Focus();
            }
            else 
            {
                this.Text = "Cập nhật tình trạng sức khỏe";
                txtMaTinhTrangSucKhoe.Text = ObjTinhTrangSucKhoe.MaTinhTrangSucKhoe.ToString();
                txtTenTinhTrangSucKhoe.Text = ObjTinhTrangSucKhoe.TenTinhTrangSucKhoe;
                txtTenTinhTrangSucKhoe.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                   DMTinhTrangSucKhoeBLL.ThemTinhTrangSucKhoe(txtTenTinhTrangSucKhoe.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjTinhTrangSucKhoe.TenTinhTrangSucKhoe = txtTenTinhTrangSucKhoe.Text.Trim();
                    DMTinhTrangSucKhoeBLL.CapNhatTinhTrangSucKhoe(ObjTinhTrangSucKhoe);
                    base.Close();
                }
            }
        }

        private void txtTenTinhThanh_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTinhTrangSucKhoe.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenTinhTrangSucKhoe, "Tên tình trạng sức khỏe không đẻ trống");
                txtTenTinhTrangSucKhoe.Focus();
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
            if (string.IsNullOrEmpty(txtTenTinhTrangSucKhoe.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}