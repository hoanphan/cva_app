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
    public partial class frmCapNhatToChuyenMon : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMToChuyenMon _objToChuyenMon = new DMToChuyenMon();

        public DMToChuyenMon ObjToChuyenMon
        {
            get { return _objToChuyenMon; }
            set { _objToChuyenMon = value; }
        }

        public frmCapNhatToChuyenMon()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatToChuyenMon(DMToChuyenMon objToChuyenMon, bool themMoi)
        {
            ObjToChuyenMon = objToChuyenMon;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Tổ chuyên môn";
                txtMaToChuyenMon.Text = String.Empty;
                txtTenToChuyenMon.Text = "";
                txtMaToChuyenMon.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Tổ chuyên môn";
                txtMaToChuyenMon.Text = ObjToChuyenMon.MaToChuyenMon.ToString();
                txtTenToChuyenMon.Text = ObjToChuyenMon.TenToChuyenMon;
                txtTenToChuyenMon.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMToChuyenMonBLL.ThemToChuyenMon(txtTenToChuyenMon.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjToChuyenMon.TenToChuyenMon = txtTenToChuyenMon.Text.Trim();
                    DMToChuyenMonBLL.CapNhatToChuyenMon(ObjToChuyenMon);
                    base.Close();
                }
            }
        }

        private void txtTenToChuyenMon_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenToChuyenMon.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenToChuyenMon, "Tên Tỉnh thành không được trống.");
                txtTenToChuyenMon.Focus();
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
            txtTenToChuyenMon_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenToChuyenMon.Text.Trim()))
                return false;
            else
                return true;
        }

        private void frmCapNhatToChuyenMon_Load(object sender, EventArgs e)
        {

        }

    }
}