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
    public partial class frmCapNhatTonGiao : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMTonGiao _objTonGiao = new DMTonGiao();

        public DMTonGiao ObjTonGiao
        {
            get { return _objTonGiao; }
            set { _objTonGiao = value; }
        }

        public frmCapNhatTonGiao()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatTonGiao(DMTonGiao objTonGiao, bool themMoi)
        {
            ObjTonGiao = objTonGiao;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Tôn giáo";
                txtMaTonGiao.Text = String.Empty;
                txtTenTonGiao.Text = "";
                txtMaTonGiao.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Tôn giáo";
                txtMaTonGiao.Text = ObjTonGiao.MaTonGiao.ToString();
                txtTenTonGiao.Text = ObjTonGiao.TenTonGiao;
                txtTenTonGiao.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMTonGiaoBLL.ThemTonGiao(txtTenTonGiao.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjTonGiao.TenTonGiao = txtTenTonGiao.Text.Trim();
                    DMTonGiaoBLL.CapNhatTonGiao(ObjTonGiao);
                    base.Close();
                }
            }
        }

        private void txtTenTonGiao_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTonGiao.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenTonGiao, "Tên Tôn giáo không được trống.");
                txtTenTonGiao.Focus();
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
            txtTenTonGiao_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenTonGiao.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}