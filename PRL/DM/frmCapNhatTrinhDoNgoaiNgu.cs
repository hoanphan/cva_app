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
    public partial class frmCapNhatTrinhDoNgoaiNgu : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMTrinhDoNgoaiNgu _objTrinhDoNgoaiNgu = new DMTrinhDoNgoaiNgu();
        public DMTrinhDoNgoaiNgu ObjTrinhDoNgoaiNgu
        {
            get { return _objTrinhDoNgoaiNgu; }
            set { _objTrinhDoNgoaiNgu = value; }
        }

        public frmCapNhatTrinhDoNgoaiNgu()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatTrinhDoNgoaiNgu(DMTrinhDoNgoaiNgu objTrinhDoNgoaiNgu, bool themMoi)
        {
            ObjTrinhDoNgoaiNgu = objTrinhDoNgoaiNgu;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm trình độ ngoại ngữ";
                txtMaTrinhDoNgoaiNgu.Text = String.Empty;
                txtTenTrinhDoNgoaiNgu.Text = "";
                txtTenTrinhDoNgoaiNgu.Focus();
            }
            else 
            {
                this.Text = "Cập nhật trình độ ngoại ngữ ";
                txtMaTrinhDoNgoaiNgu.Text = ObjTrinhDoNgoaiNgu.MaTrinhDoNgoaiNgu.ToString();
                txtTenTrinhDoNgoaiNgu.Text = ObjTrinhDoNgoaiNgu.TenTrinhDoNgoaiNgu;
                txtTenTrinhDoNgoaiNgu.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                   DMTrinhDoNgoaiNguBLL.ThemTrinhDoNgoaiNgu(txtTenTrinhDoNgoaiNgu.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjTrinhDoNgoaiNgu.TenTrinhDoNgoaiNgu = txtTenTrinhDoNgoaiNgu.Text.Trim();
                    DMTrinhDoNgoaiNguBLL.CapNhatTrinhDoNgoaiNgu(ObjTrinhDoNgoaiNgu);
                    base.Close();
                }
            }
        }

        private void txtTenTinhThanh_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTrinhDoNgoaiNgu.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenTrinhDoNgoaiNgu, "Tên Trình độ ngoại ngữ không để trống");
                txtTenTrinhDoNgoaiNgu.Focus();
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
            if (string.IsNullOrEmpty(txtTenTrinhDoNgoaiNgu.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}