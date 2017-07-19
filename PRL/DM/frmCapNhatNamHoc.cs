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
    public partial class frmCapNhatNamHoc : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DSNamHoc _objNamHoc = new DSNamHoc();

        public DSNamHoc ObjNamHoc
        {
            get { return _objNamHoc; }
            set { _objNamHoc = value; }
        }

        public frmCapNhatNamHoc()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatNamHoc(DSNamHoc objNamHoc, bool themMoi)
        {
            ObjNamHoc = objNamHoc;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                ObjNamHoc = new DSNamHoc();
                this.Text = "Thêm mới Năm học";
                txtMaNamHoc.Text = DSNamHocBLL.SinhMaNamHoc();
                txtTenNamHoc.Text = DSNamHocBLL.SinhTenNamHoc();              
                txtMaNamHoc.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Năm học";
                txtMaNamHoc.Text = ObjNamHoc.MaNamHoc.ToString();
                txtTenNamHoc.Text = ObjNamHoc.TenNamHoc;
                chkNamHienTai.Checked = (bool)ObjNamHoc.NamHienTai;
                txtTenNamHoc.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    ObjNamHoc.MaNamHoc = txtMaNamHoc.Text;
                    ObjNamHoc.TenNamHoc = txtTenNamHoc.Text;
                    if (chkNamHienTai.Checked)
                    {
                        DSNamHocBLL.BoNamHienTai();
                        ObjNamHoc.NamHienTai = true;
                    }
                    else
                    {
                        ObjNamHoc.NamHienTai = false;
                    }
                    DSNamHocBLL.ThemNamHoc(ObjNamHoc);
                    base.Close();
                }
                else
                {
                    ObjNamHoc.TenNamHoc = txtTenNamHoc.Text.Trim();                    
                    if (chkNamHienTai.Checked)
                    {
                        DSNamHocBLL.BoNamHienTai();
                        ObjNamHoc.NamHienTai = true;
                    }else
                    { 
                        ObjNamHoc.NamHienTai = false;
                    }
                    DSNamHocBLL.CapNhatNamHoc(ObjNamHoc);
                    base.Close();
                }
            }
        }

        private void txtTenNamHoc_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenNamHoc.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenNamHoc, "Tên Dân tộc không được trống.");
                txtTenNamHoc.Focus();
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
            txtTenNamHoc_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenNamHoc.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}