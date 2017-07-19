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
    public partial class frmCapNhatHeDaoTao : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMHeDaoTao _objHeDaoTao = new DMHeDaoTao();

        public DMHeDaoTao ObjHeDaoTao
        {
            get { return _objHeDaoTao; }
            set { _objHeDaoTao = value; }
        }

        public frmCapNhatHeDaoTao()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatHeDaoTao(DMHeDaoTao objHeDaoTao, bool themMoi)
        {
            ObjHeDaoTao = objHeDaoTao;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Hệ đào tạo";
                txtMaHeDaoTao.Text = String.Empty;
                txtTenHeDaoTao.Text = "";
                txtMaHeDaoTao.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Hệ đào tạo";
                txtMaHeDaoTao.Text = ObjHeDaoTao.MaHeDaoTao.ToString();
                txtTenHeDaoTao.Text = ObjHeDaoTao.TenHeDaoTao;
                txtTenHeDaoTao.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMHeDaoTaoBLL.ThemHeDaoTao(txtTenHeDaoTao.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjHeDaoTao.TenHeDaoTao = txtTenHeDaoTao.Text.Trim();
                    DMHeDaoTaoBLL.CapNhatHeDaoTao(ObjHeDaoTao);
                    base.Close();
                }
            }
        }

        private void txtTenHeDaoTao_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenHeDaoTao.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenHeDaoTao, "Tên Hệ đào tạo không được trống.");
                txtTenHeDaoTao.Focus();
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
            txtTenHeDaoTao_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenHeDaoTao.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}