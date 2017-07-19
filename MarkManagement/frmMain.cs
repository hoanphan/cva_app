using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRL;
using BLL;


namespace MarkManagement
{
    public partial class frmMain : Form
    {
        private string TenDangNhap;
        public frmMain(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            this.Text = UTL.Params.Title;
            string Status = "Người dùng: " + DSNguoiDungBLL.LayTenNguoiDung(TenDangNhap);
            lbStatus.Caption = Status;
        }

        private void btnTinhThanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMTinhThanh();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanHuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMQuanHuyen();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void MoForm(Form form)
        {
            
        }

        private void btnPhuongXa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMXaPhuong();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMDanToc();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMTonGiao();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTinhTrangSucKhoe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            var frm = new frmDMTinhTrangSucKhoe();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoTinHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMChucVu();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnToChuyenMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMToChuyenMon();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhanCongGiangDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmPhanCongGiangDay();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDanhSachGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDSGiaoVien();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDanhSachHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDSHocSinh();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDSLop();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDSMonHoc();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhanLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmPhanLop();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhanMonHocTheoLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmPhanMonHocTheoLop();
            if (ExistForm(frm)) return;  
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoNgoaiNgu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMTrinhDoNgoaiNgu();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoChinhTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMTrinhDoChinhTri();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTrinhDoQLGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDMTrinhDoQLGD();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmNhapDiem(TenDangNhap);
            if (ExistForm(frm)) return;                        
            frm.MdiParent = this;
            frm.Show();            
        }

        private void btnTrinhDoChuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDSTongKetTheoKy(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNhapHanhKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmNhapHanhKiem(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnInDSHocSinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmInDSLop(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKhoiTaoDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoiTaoDuLieu frm = new frmKhoiTaoDuLieu();
            frm.ShowDialog();
        }

        private void btnInDSHSDanhHieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmInDSHSDatDanhHieu();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnInBangTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmInDSTongKetTheoKy(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemHocSinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmDSHocSinh();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnXetDanhHieu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DSLopBLL.LaGVCN(TenDangNhap) == null)
            {
                frmXetCacTieuChuanToanTruong frm = new frmXetCacTieuChuanToanTruong();
                frm.ShowDialog();
            }
            else
            {
                frmXetCacTieuChuan frm = new frmXetCacTieuChuan(TenDangNhap);
                frm.ShowDialog();
            }            
        }

        private void itemDanhSachHSDatDanhHieu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmInDSHSDatDanhHieu();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemBangDiemTongKet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmInDSTongKetTheoKy(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemInDSHocSinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmInDSLop(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KhoaTheoTaiKhoan();
        }

        private void KhoaTheoTaiKhoan()
        {
            if (DSGiaoVienBLL.LaGiaoVien(TenDangNhap))
            {
                rpgQuanHuyenTinh.Enabled = false;
                rpgDanhMucChung.Enabled = false;
                rpgTrinhDo.Enabled = false;
                btnDanhSachGV.Enabled = false;
                rpgHoatDongGiaoVien.Enabled = false;
                rpgInThe.Enabled = false;
                rpgDSHocSinh.Enabled = false;
                rpgPhanLop.Enabled = false;
                rpgHocTapChung.Enabled = false;
                rpgMonHoc.Enabled = false;
                rpgKhoiTaoDuLieu.Enabled = false;                              
                btnInDSHSDanhHieu.Enabled = false;                                
                if (DSLopBLL.LaGVCN(TenDangNhap) == null)
                {
                    rpgXepLoai.Enabled = false;  
                    btnInDSHocSinh.Enabled = false;
                    btnNhapHanhKiem.Enabled = false;
                    btnInBangTongKet.Enabled = false;
                    btnTongKet.Enabled = false;
                    btnSapThuTu.Enabled = false;
                    btnInBangTongKet.Enabled = false;               
                    itemHanhKiem.Enabled = false;
                    itemInDSHocSinh.Enabled = false;                    
                    itemBangDiemTongKet.Enabled = false;
                    itemInDSCacKy.Enabled = false;                                                 
                }                    
                itemLop.Enabled = false;
                itemMonHoc.Enabled = false;
                itemHocSinh.Enabled = false;
                itemPhanLop.Enabled = false;
                itemGiaoVien.Enabled = false;
                itemPhanCongGiangDay.Enabled = false;                                                
                itemDanhSachHSDatDanhHieu.Enabled = false;
                btnXetLenLop.Enabled = false;
                //navBarControl.Enabled = false;
                //rpDanhMuc.Visible = false;
                rpSoLienLacDienTu.Visible = false;
                rpHeThong.Visible = false;
                btnKhoaSo.Enabled = false;
                btnNhapDiemHSChuyenTruong.Enabled = false;
                btnHocSinhChuyenTruong.Enabled = false;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void itemGiaoVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDSGiaoVien frm = new frmDSGiaoVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemPhanCongGiangDay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmPhanCongGiangDay();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemNhapDiem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmNhapDiem(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemHanhKiem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmNhapHanhKiem(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemPhanLop_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmPhanLop();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemLop_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void itemMonHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmDSMonHoc();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDSNamHoc();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("MarkManagement.exe");
            Application.Exit();
        }

        private void btnChinhSuaGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DSGiaoVienBLL.LaGiaoVien(TenDangNhap))
            {
                frmCapNhatGiaoVien frm = new frmCapNhatGiaoVien(DSGiaoVienBLL.LayGiaoVienTheoMa(TenDangNhap), false, false);
                frm.ShowDialog();
            }
        }

        private void btnSapThuTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSapSoThuTu frm = new frmSapSoThuTu();            
            frm.ShowDialog();
        }

        private void btnInBangDiemTheoMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmInBangDiemTheoMon(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemInBangDiemTungMon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmInBangDiemTheoMon(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemInDSCacKy_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new frmInDSTongKetCacKy(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnXetLenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            splashScreenManager.ShowWaitForm();
            DSTongKetTheoKyBLL.XetLenLop();
            splashScreenManager.CloseWaitForm();
        }

        private void btnGuiEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DSHocSinhBLL.ResetTatCaMatKhauHocSinh();
            //MessageBox.Show(DateTime.Parse("14/10/2015 8:00:00 AM").ToString());
            //DSEmailGuiBLL.TaoMailDeGui();
            //DSEmailGuiBLL.SendListMailHangThang();
            //DSEmailGuiBLL.SendListMailToanBo();
            MessageBox.Show(DSGiaoVienBLL.VD());
        }

        private void btnDangKyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDangKyDichVu();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGuiEmailSMS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            var frm = new frmGuiEmail();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();            
        }

        private void btnTestGVNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            //DSDiemBLL.KiemTraNhapDiemTheoThang();
        }

        private void btnGuiSMS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGuiTinNhan frm = new frmGuiTinNhan();
            frm.ShowDialog();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaoMailSMSDeGui_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmGuiEmail();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnTKHocLucHanhKiemDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmThongKeTHCSMau4(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongKeTheoHocLuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmThongKeTHCSMau1(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DSGiaoVienBLL.HienMatKhau();
        }

        private void btnChuyenDuLieuNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                UTL.Ultils.ThongBao("Vui lòng đóng các tab đang mở để thực hiện chức năng này.", MessageBoxIcon.Information);
            }
            else
            {
                string matKhau = Microsoft.VisualBasic.Interaction.InputBox("Để thực hiện chức năng này, vui lòng nhập mật khẩu khóa sổ.", UTL.Params.Title);
                if (KhoaSoBLL.XacThuc(matKhau))
                {
                    splashScreenManager.ShowWaitForm();
                    KhoaSoBLL.KhoaSo();
                    splashScreenManager.CloseWaitForm();
                    UTL.Ultils.ThongBao("Đã khóa sổ dữ liệu xong.", MessageBoxIcon.Information);
                }
                else
                    UTL.Ultils.ThongBao("Mật khẩu sai. Chức năng sẽ tự thoát.", MessageBoxIcon.Error);
            }
        }

        private void btnKhoaSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoaSo frm = new frmKhoaSo();
            frm.ShowDialog();
        }

        private void btnThongKeBoTheoHocLucHanhKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmThongKeMauCuaBo(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongKeBoTheoDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmThongKeMauCuaBoM1(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongKeBoTheoDoTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmThongKeMauCuaBoM2(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSMSTest frm = new frmSMSTest();
            frm.ShowDialog();
        }

        private void btnGhiDuLieuThangRaExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmTachDiemHangThangSangExcel();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnXuatTinCanGuiRaExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmXuatTinNhanCanGuiSangExcel();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHocSinhChuyenTruong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmHocSinhChuyenTruong();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNhapDiemHSChuyenTruong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmNhapDiemHSChuyenTruong(TenDangNhap);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHSThoiHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmHocSinhThoiHoc();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGhiDuLieuHocKyRaExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmTachDiemTongKetHocKySangExcel();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
