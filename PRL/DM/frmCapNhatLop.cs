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
    public partial class frmCapNhatLop : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DSLop _objLop = new DSLop();

        public DSLop ObjLop
        {
            get { return _objLop; }
            set { _objLop = value; }
        }

        public frmCapNhatLop()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatLop(DSLop objLop, bool themMoi)
        {
            ObjLop = objLop;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void FillDataToGrid()
        {
            lkuKhoi.Properties.DataSource = DSKhoiBLL.LoadAll();
            lkuGVCN.Properties.DataSource = DSGiaoVienBLL.SelectGiaoVien();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                this.Text = "Thêm mới Lớp";
                txtMaLop.Text = DSLopBLL.SinhMaLop();
                txtTenLop.Text = "";
                FillDataToGrid();
                lkuKhoi.EditValue = null;
                lkuKhoi.Focus();
            }
            else 
            {
                this.Text = "Cập nhật Lớp";
                txtMaLop.Text = ObjLop.MaLop.ToString();
                txtTenLop.Text = ObjLop.TenLop;
                FillDataToGrid();
                lkuKhoi.EditValue = ObjLop.MaKhoi;
                lkuGVCN.EditValue = ObjLop.MaGVCN;
                txtTenLop.Focus();                
            }            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    ObjLop = new DSLop();
                    ObjLop.MaLop = txtMaLop.Text;
                    ObjLop.TenLop = txtTenLop.Text;
                    ObjLop.MaKhoi = lkuKhoi.EditValue.ToString();
                    ObjLop.MaGVCN = lkuGVCN.EditValue.ToString();
                    ObjLop.MaNamHoc = DSNamHocBLL.TruyVanNamHocHienTai();
                    DSLopBLL.ThemLop(ObjLop);
                    QuanLySoLuongBLL.TangSoLuongLop();
                    base.Close();
                }
                else
                {
                    ObjLop.TenLop = txtTenLop.Text;
                    ObjLop.MaKhoi = lkuKhoi.EditValue.ToString();
                    ObjLop.MaGVCN = lkuGVCN.EditValue.ToString();
                    DSLopBLL.CapNhatLop(ObjLop);
                    base.Close();
                }
            }
        }

        private void txtTenLop_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenLop.Text.Trim()))
            {
                dxErrorProvider.SetError(txtTenLop, "Tên Lớp không được trống.");
                txtTenLop.Focus();
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
            txtTenLop_Leave(null, null);
            lkuKhoi_Leave(null, null);
            lkuGVCN_Leave(null, null);            
            if (string.IsNullOrEmpty(txtTenLop.Text.Trim()))
                return false;
            else
                return true;
        }

        private void btnKhoi_Click(object sender, EventArgs e)
        {
            //frmCapNhatKhoi form = new frmCapNhatKhoi (null, true);
            //form.ShowDialog();
            //FillDataToGrid();
        }

        private void lkuKhoi_Leave(object sender, EventArgs e)
        {
            if (lkuKhoi.EditValue == null)
            {
                dxErrorProvider.SetError(txtTenLop, "Cần phải chọn Khối cho lớp.");
                lkuKhoi.Focus();
            }
            else
            {
                dxErrorProvider.ClearErrors();
            }
        }

        private void lkuGVCN_Leave(object sender, EventArgs e)
        {
            if (lkuGVCN.EditValue == null)
            {
                dxErrorProvider.SetError(txtTenLop, "Cần phải chọn Giáo viên chủ nhiệm cho lớp.");
                lkuGVCN.Focus();
            }
            else
            {
                dxErrorProvider.ClearErrors();
            }
        }

        

    }
}