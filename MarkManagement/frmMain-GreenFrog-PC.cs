using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRL;

namespace MarkManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = UTL.Params.Title;
        }

        private void btnTinhThanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMTinhThanh frm = new frmDMTinhThanh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanHuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMQuanHuyen frm = new frmDMQuanHuyen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MoForm(Form form)
        {
            
        }

        private void btnPhuongXa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMXaPhuong frm = new frmDMXaPhuong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMDanToc frm = new frmDMDanToc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMTonGiao frm = new frmDMTonGiao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTinhTrangSucKhoe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            frmDMTinhTrangSucKhoe frm = new frmDMTinhTrangSucKhoe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoTinHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMChucVu frm = new frmDMChucVu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnToChuyenMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMToChuyenMon frm = new frmDMToChuyenMon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhanCongGiangDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanCongGiangDay frm = new frmPhanCongGiangDay();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDanhSachGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDSGiaoVien frm = new frmDSGiaoVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDanhSachHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDSMonHoc frm = new frmDSMonHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhanLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanLop frm = new frmPhanLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhanMonHocTheoLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanMonHocTheoLop frm = new frmPhanMonHocTheoLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoNgoaiNgu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMTrinhDoNgoaiNgu frm = new frmDMTrinhDoNgoaiNgu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoChinhTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMTrinhDoChinhTri frm = new frmDMTrinhDoChinhTri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoQLGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMTrinhDoQLGD frm = new frmDMTrinhDoQLGD();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapDiem frm = new frmNhapDiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoChuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

    }
}
