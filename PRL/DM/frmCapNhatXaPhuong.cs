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
    public partial class frmCapNhatXaPhuong : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMXaPhuong _objXaPhuong = new DMXaPhuong();

        public DMXaPhuong ObjXaPhuong
        {
            get { return _objXaPhuong; }
            set { _objXaPhuong = value; }
        }

        public frmCapNhatXaPhuong()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatXaPhuong(DMXaPhuong objXaPhuong, bool themMoi)
        {
            ObjXaPhuong=objXaPhuong;
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
                this.Text = "Thêm mới Xã, phường";
                txtMaXaPhuong.Text = String.Empty;
                txtTenXaPhuong.Text = "";
                FillDataToGrid();
                lkuTinhThanh.EditValue = null;
                lkuQuanHuyen.EditValue = null;
                lkuQuanHuyen.Focus();
            }
            else 
            {
                this.Text = "Cập nhật xã phường";
                txtMaXaPhuong.Text = ObjXaPhuong.MaQuanHuyen.ToString();
                txtTenXaPhuong.Text = ObjXaPhuong.TenXaPhuong;
                FillDataToGrid();
                lkuTinhThanh.EditValue = ObjXaPhuong.DMQuanHuyen.MaTinhThanh;
                lkuTinhThanh.Enabled = false;
                lkuQuanHuyen.EditValue = ObjXaPhuong.DMQuanHuyen.MaQuanHuyen;
                txtTenXaPhuong.Focus();                
            }            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    DMXaPhuongBLL.ThemXaPhuong(txtTenXaPhuong.Text.Trim(), (int)lkuQuanHuyen.EditValue);
                    base.Close();
                }
                else
                {
                   ObjXaPhuong.TenXaPhuong = txtTenXaPhuong.Text.Trim();
                   ObjXaPhuong.MaQuanHuyen = (int)lkuQuanHuyen.EditValue;
                    DMXaPhuongBLL.CapNhatXaPhuong(ObjXaPhuong);
                    base.Close();
                }
            }
        }

        private void txtTenQuanHuyen_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenXaPhuong.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenXaPhuong, "Tên xã, phường không được trống.");
                txtTenXaPhuong.Focus();
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
            if (string.IsNullOrEmpty(txtTenXaPhuong.Text.Trim()))
                return false;
            else
                return true;
        }

        private void btnTinhThanh_Click(object sender, EventArgs e)
        {
            frmDMTinhThanh form = new frmDMTinhThanh();
            form.ShowDialog();
            FillDataToGrid();
        }

        private void lkuTinhThanh_EditValueChanged(object sender, EventArgs e)
        {
            if (lkuTinhThanh.EditValue != null)
            {
                int MaTinhThanh = int.Parse(lkuTinhThanh.EditValue.ToString()); //Sao MaQuanHuyen lai lay du lieu tu lkuTinhThanh ???
                lkuQuanHuyen.Properties.DataSource = DMXaPhuongBLL.LoadQuanHuyenTheoTinhThanh(MaTinhThanh);
            }            
        }

        private void btnQuanHuyen_Click(object sender, EventArgs e)
        {
            frmDMQuanHuyen form = new frmDMQuanHuyen();
            form.ShowDialog();
            FillDataToGrid();
        }

    }
}