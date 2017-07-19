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
    public partial class frmCapNhatDanToc : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMDanToc _objDanToc = new DMDanToc();

        public DMDanToc ObjDanToc
        {
            get { return _objDanToc; }
            set { _objDanToc = value; }
        }

        public frmCapNhatDanToc()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatDanToc(DMDanToc objDanToc, bool themMoi)
        {
            ObjDanToc = objDanToc;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Dân tộc";
                txtMaDanToc.Text = String.Empty;
                txtTenDanToc.Text = "";
                txtMaDanToc.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Dân tộc";
                txtMaDanToc.Text = ObjDanToc.MaDanToc.ToString();
                txtTenDanToc.Text = ObjDanToc.TenDanToc;
                txtTenDanToc.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMDanTocBLL.ThemDanToc(txtTenDanToc.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjDanToc.TenDanToc = txtTenDanToc.Text.Trim();
                    DMDanTocBLL.CapNhatDanToc(ObjDanToc);
                    base.Close();
                }
            }
        }

        private void txtTenDanToc_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenDanToc.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenDanToc, "Tên Dân tộc không được trống.");
                txtTenDanToc.Focus();
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
            txtTenDanToc_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenDanToc.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}