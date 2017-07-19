using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace PRL
{
    public partial class frmInBangDiemTheoMon : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmInBangDiemTheoMon(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            cbHocKy.DataSource = DSHocKyBLL.LoadHocKyHoc();  
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();                    
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {                        
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string maMonHoc = cbMonHoc.SelectedValue.ToString();
            if (maMonHoc != null)
            {
                if (DSDiemBLL.KiemTraDuLieu(maLop, maHocKy, maMonHoc))
                {
                    splashScreenManager.ShowWaitForm();
                    rptBangDiemTheoMon report = new rptBangDiemTheoMon(maLop, maHocKy, maMonHoc);
                    report.CreateDocument(true);
                    reportViewer.DocumentSource = report;
                    reportViewer.Update();
                    splashScreenManager.CloseWaitForm();
                }
                else
                    UTL.Ultils.ThongBao("Dữ liệu chưa được cập nhật đầy đủ.\nVui lòng nhập đầy đủ điểm và tính Trung bình cộng các môn.\n"
                                        + "Sau đó nhập Hạnh kiểm và xét danh hiệu trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
            }                        
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();
            cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);            
            if (cbLop.SelectedValue == null)
            {
                btnLayDuLieu.Enabled = false;
                reportViewer.DocumentSource = null;
                reportViewer.Update();
                //cbMonHoc.DataSource = null;
            }
            else
                btnLayDuLieu.Enabled = true;
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (DSGiaoVienBLL.LaGiaoVien(TenDangNhap))
                cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKyGiaoVien(maLop, maHocKy, TenDangNhap);
            else
                cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKy(maLop, maHocKy);
            if (cbMonHoc.SelectedValue == null)
            {
                btnLayDuLieu.Enabled = false;
                reportViewer.DocumentSource = null;
                reportViewer.Update();
            } 
            else
                btnLayDuLieu.Enabled = true;
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                string maLop = cbLop.SelectedValue.ToString();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                if (DSGiaoVienBLL.LaGiaoVien(TenDangNhap))
                    cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKyGiaoVien(maLop, maHocKy, TenDangNhap);
                else
                    cbMonHoc.DataSource = DSMonHocBLL.TruyVanMonHocTheoLopKy(maLop, maHocKy);
                if (cbMonHoc.SelectedValue == null)
                    btnLayDuLieu.Enabled = false;
                else
                    btnLayDuLieu.Enabled = true;
                if (cbMonHoc.SelectedValue == null)
                {
                    btnLayDuLieu.Enabled = false;
                    reportViewer.DocumentSource = null;
                    reportViewer.Update();
                }                    
                else
                    btnLayDuLieu.Enabled = true;
            }            
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }
    }
}