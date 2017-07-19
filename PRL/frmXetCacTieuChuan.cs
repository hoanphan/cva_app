using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using BLL;

namespace PRL
{
    public partial class frmXetCacTieuChuan : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmXetCacTieuChuan(string tenDangNhap)
        {
            InitializeComponent();
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();
            TenDangNhap = tenDangNhap;
        }

        private void btnTinhDiemTBC_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            //progressTienTrinh.Visible = true;
            string danhSachMonChuaNhapDiemHocKy = "";
            if (DSLopBLL.LaGVCN(TenDangNhap) != null)
            { 
                if (DSDiemBLL.KiemTraNhapDiemHocKyCacMonHocDuocTinhTBC(maHocKy, TenDangNhap, ref danhSachMonChuaNhapDiemHocKy) == true)
                {
                    splashScreenManager.ShowWaitForm();
                    DSTongKetTheoKyBLL.TinhDiemTBC(maHocKy, TenDangNhap);
                    splashScreenManager.CloseWaitForm();
                }
                else
                {
                    UTL.Ultils.ThongBao("Chưa cập nhật điểm học kỳ ở các môn: " + danhSachMonChuaNhapDiemHocKy
                        + ". Vui lòng nhập đầy đủ trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
                }
            }
            else
            {
                if (DSDiemBLL.KiemTraNhapDiemHocKyCacMonHocDuocTinhTBCToanTruong(maHocKy, TenDangNhap, ref danhSachMonChuaNhapDiemHocKy) == true)
                {
                    splashScreenManager.ShowWaitForm();
                    DSTongKetTheoKyBLL.TinhDiemTBC(maHocKy, TenDangNhap);
                    splashScreenManager.CloseWaitForm();
                }
                else
                {
                    UTL.Ultils.ThongBao("Chưa cập nhật điểm học kỳ ở các môn: " + danhSachMonChuaNhapDiemHocKy
                        + ". Vui lòng nhập đầy đủ trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
                }
            }
            //progressTienTrinh.Visible = false;
        }

        private void btnXetDanhHieu_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            splashScreenManager.ShowWaitForm();
            DSTongKetTheoKyBLL.XetDanhHieu(maHocKy, TenDangNhap);
            splashScreenManager.CloseWaitForm();
        }

        private void btnXetHocLuc_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string danhSachMonChuaNhapDiemHocKy = "";
            if (DSLopBLL.LaGVCN(TenDangNhap) != null)
            {
                if (DSDiemBLL.KiemTraNhapDiemHocKyCacMonHoc(maHocKy, TenDangNhap, ref danhSachMonChuaNhapDiemHocKy) == true)
                {
                    splashScreenManager.ShowWaitForm();
                    DSTongKetTheoKyBLL.XetHocLuc(maHocKy, TenDangNhap);
                    splashScreenManager.CloseWaitForm();
                }
                else
                {
                    UTL.Ultils.ThongBao("Chưa cập nhật điểm học kỳ ở các môn: " + danhSachMonChuaNhapDiemHocKy
                        + "\r\nVui lòng nhập đầy đủ trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
                }
            }
            else
            {
                if (DSDiemBLL.KiemTraNhapDiemHocKyCacMonHocToanTruong(maHocKy, TenDangNhap, ref danhSachMonChuaNhapDiemHocKy) == true)
                {
                    splashScreenManager.ShowWaitForm();
                    DSTongKetTheoKyBLL.XetHocLuc(maHocKy, TenDangNhap);
                    splashScreenManager.CloseWaitForm();
                }
                else
                {
                    UTL.Ultils.ThongBao("Chưa cập nhật điểm học kỳ ở các môn: " + danhSachMonChuaNhapDiemHocKy
                        + "\r\nVui lòng nhập đầy đủ trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}