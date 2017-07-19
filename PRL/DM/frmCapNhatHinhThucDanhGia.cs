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
    public partial class frmCapNhatHinhThucDanhGia : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DSHinhThucDanhGia _objHinhThucDanhGia = new DSHinhThucDanhGia();

        public DSHinhThucDanhGia ObjHinhThucDanhGia
        {
            get { return _objHinhThucDanhGia; }
            set { _objHinhThucDanhGia = value; }
        }

        public frmCapNhatHinhThucDanhGia()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatHinhThucDanhGia(DSHinhThucDanhGia objHinhThucDanhGia, bool themMoi)
        {
            ObjHinhThucDanhGia = objHinhThucDanhGia;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Hình thức đánh giá";
                txtMaHinhThucDanhGia.Text = String.Empty;
                txtTenHinhThucDanhGia.Text = "";
                txtMaHinhThucDanhGia.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Hình thức đánh giá";
                txtMaHinhThucDanhGia.Text = ObjHinhThucDanhGia.MaHinhThucDanhGia.ToString();
                txtTenHinhThucDanhGia.Text = ObjHinhThucDanhGia.TenHinhThucDanhGia;
                txtTenHinhThucDanhGia.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DSHinhThucDanhGiaBLL.ThemHinhThucDanhGia(txtTenHinhThucDanhGia.Text.Trim(), cbTinhDiem.Checked);
                    base.Close();
                }
                else
                {
                    ObjHinhThucDanhGia.TenHinhThucDanhGia = txtTenHinhThucDanhGia.Text.Trim();
                    ObjHinhThucDanhGia.TinhDiem = cbTinhDiem.Checked;
                    DSHinhThucDanhGiaBLL.CapNhatHinhThucDanhGia(ObjHinhThucDanhGia);
                    base.Close();
                }
            }
        }

        private void txtTenHinhThucDanhGia_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenHinhThucDanhGia.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenHinhThucDanhGia, "Tên Hình thức đánh giá không được trống.");
                txtTenHinhThucDanhGia.Focus();
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
            txtTenHinhThucDanhGia_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenHinhThucDanhGia.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}