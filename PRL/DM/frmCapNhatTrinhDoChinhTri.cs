using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace PRL
{
    public partial class frmCapNhatTrinhDoChinhTri : Form
    {
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DMTrinhDoChinhTri _objTrinhDoChinhtri = new DMTrinhDoChinhTri();
        public DMTrinhDoChinhTri ObjTrinhDoChinhTri
        {
            get { return _objTrinhDoChinhtri; }
            set { _objTrinhDoChinhtri = value; }
        }
        public frmCapNhatTrinhDoChinhTri(DMTrinhDoChinhTri objTrinhDoChinhTri, bool themMoi)
        {
            ObjTrinhDoChinhTri = objTrinhDoChinhTri;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void LoadForm()
        {
            if(ThemMoi)
            {
                this.Text="Thêm mới trình độ chính trị";
                txtMaTrinhDoChinhTri.Text = String.Empty;
                txtTenTrinhDoChinhTri.Text = "";
                txtTenTrinhDoChinhTri.Focus();
            }
            else
            {
                this.Text = "Cập nhật trình độ chính trị ";
              txtMaTrinhDoChinhTri.Text  = ObjTrinhDoChinhTri.MaTrinhDoChinhTri.ToString();
             txtTenTrinhDoChinhTri.Text = ObjTrinhDoChinhTri.TenTrinhDoChinhTri;
             txtTenTrinhDoChinhTri.Focus();
            }
        }
        private void frmCapNhatTrinhDoChinhTri_Load(object sender, EventArgs e)
        {
            txtMaTrinhDoChinhTri.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
        }

        private void txtTenTrinhDoChinhTri_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTrinhDoChinhTri.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtTenTrinhDoChinhTri, "Tên trình độ chính trị không để trống");
                txtTenTrinhDoChinhTri.Focus();
            }
            else
                dxErrorProvider1.ClearErrors();
        }
        private bool CheckSave()
        {
            txtTenTrinhDoChinhTri_Leave(null, null);
            if(String.IsNullOrEmpty(txtTenTrinhDoChinhTri.Text.Trim()))
                return false;
            else
                return true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CheckSave())
            {
                if(ThemMoi)
                {
                    DMTrinhDoChinhTriBLL.ThemTrinhDoChinhTri(txtTenTrinhDoChinhTri.Text.Trim());
                    base.Close();
                }
                else
                {
                    ObjTrinhDoChinhTri.TenTrinhDoChinhTri = txtTenTrinhDoChinhTri.Text.Trim();
                    DMTrinhDoChinhTriBLL.CapNhatTrinhDoChinhTri(ObjTrinhDoChinhTri);
                    base.Close();
                }
            }
        }

    

    }
}
