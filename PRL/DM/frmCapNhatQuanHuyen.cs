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
    public partial class frmCapNhatQuanHuyen : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMQuanHuyen _objQuanHuyen = new DMQuanHuyen();

        public DMQuanHuyen ObjQuanHuyen
        {
            get { return _objQuanHuyen; }
            set { _objQuanHuyen = value; }
        }

        public frmCapNhatQuanHuyen()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatQuanHuyen(DMQuanHuyen objQuanHuyen, bool themMoi)
        {
            ObjQuanHuyen = objQuanHuyen;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void FillDataToGrid()
        {
            lkuTinhThanh.Properties.DataSource = DMTinhThanhBLL.LoadAll();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Quận, huyện";
                txtMaQuanHuyen.Text = String.Empty;
                txtTenQuanHuyen.Text = "";
                FillDataToGrid();
                lkuTinhThanh.EditValue = null;
                lkuTinhThanh.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Quận, huyện";
                txtMaQuanHuyen.Text = ObjQuanHuyen.MaQuanHuyen.ToString();
                txtTenQuanHuyen.Text = ObjQuanHuyen.TenQuanHuyen;
                FillDataToGrid();
                lkuTinhThanh.EditValue = ObjQuanHuyen.DMTinhThanh.MaTinhThanh;
                txtTenQuanHuyen.Focus();                
            }            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMQuanHuyenBLL.ThemQuanHuyen(txtTenQuanHuyen.Text.Trim(), (short)lkuTinhThanh.EditValue);
                    base.Close();
                }
                else
                {
                    ObjQuanHuyen.TenQuanHuyen = txtTenQuanHuyen.Text.Trim();
                    ObjQuanHuyen.MaTinhThanh = (short)lkuTinhThanh.EditValue;
                    DMQuanHuyenBLL.CapNhatQuanHuyen(ObjQuanHuyen);
                    base.Close();
                }
            }
        }

        private void txtTenQuanHuyen_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenQuanHuyen.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenQuanHuyen, "Tên Quận, huyện không được trống.");
                txtTenQuanHuyen.Focus();
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
            txtTenQuanHuyen_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenQuanHuyen.Text.Trim()))
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

    }
}