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
    public partial class frmCapNhatTrinhDoQLGD : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMTrinhDoQLGD _objTrinhDoQLGD = new DMTrinhDoQLGD();

        public DMTrinhDoQLGD ObjTrinhDoQLGD
        {
            get { return _objTrinhDoQLGD; }
            set { _objTrinhDoQLGD = value; }
        }

        public frmCapNhatTrinhDoQLGD()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatTrinhDoQLGD(DMTrinhDoQLGD objTrinhDoQLGD, bool themMoi)
        {
            ObjTrinhDoQLGD = objTrinhDoQLGD;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Trình độ quản lí giáo dục";
                txtMaTrinhDoQLGD.Text = String.Empty;
                txtTenTrinhDoQLGD.Text = "";
                txtTenTrinhDoQLGD.Focus();
            }
            else 
            {
                this.Text = "Cập nhật quản lí giáo dục";
                txtMaTrinhDoQLGD.Text = ObjTrinhDoQLGD.MaTrinhDoQLGD.ToString();
                txtTenTrinhDoQLGD.Text = ObjTrinhDoQLGD.TenTrinhDoQLGD;
                txtTenTrinhDoQLGD.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                   DMTrinhDoQLGDBLL.ThemQLGD(txtTenTrinhDoQLGD.Text.Trim());
                    base.Close();
                }
                else
                {
                   ObjTrinhDoQLGD.TenTrinhDoQLGD= txtTenTrinhDoQLGD.Text.Trim();
                    DMTrinhDoQLGDBLL.CapNhatQLGD(ObjTrinhDoQLGD);
                    base.Close();
                }
            }
        }

        private void txtTenTinhThanh_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTrinhDoQLGD.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenTrinhDoQLGD, "tên Trình độ quản lí giáo dục không bỏ trống.");
                txtTenTrinhDoQLGD.Focus();
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
            if (string.IsNullOrEmpty(txtTenTrinhDoQLGD.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}