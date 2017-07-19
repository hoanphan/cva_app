using System;
using System.Drawing;
using System.Windows.Forms;
using DAL;
using BLL;
using UTL;

namespace PRL
{
    public partial class frmCapNhatHocSinh : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        OpenFileDialog openFile = new OpenFileDialog()
        {
            Title = Params.Title + " - Chọn ảnh Học sinh",
            Filter = "Jpeg (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp"
        };

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }
        DSHocSinh _objHocSinh = new DSHocSinh();

        public DSHocSinh ObjHocSinh
        {
            get { return _objHocSinh; }
            set { _objHocSinh = value; }
        }

        public frmCapNhatHocSinh()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatHocSinh(DSHocSinh objHocSinh, bool themMoi)
        {
            ObjHocSinh = objHocSinh;
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();           
        }

        private void LoadForm()
        {
            FillDataToGridLookup();
            if (ThemMoi)
            {
                this.Text = "Thêm mới Học sinh";
                LamSachForm();
            }
            else 
            {               
                this.Text = "Cập nhật thông tin Học sinh";                
                //Điền thông tin Học sinh vào TextBox                
                tbHoVaTen.Text = ObjHocSinh.HoDem + " " + ObjHocSinh.Ten;
                tbMaHocSinh.Text = ObjHocSinh.MaHocSinh;
                tbMatKhau.Text = ObjHocSinh.MatKhau;
                //tbNoiKetNapDang.Text = ObjHocSinh.NoiVaoDang;
                tbNoiKetNapDoan.Text = ObjHocSinh.NoiVaoDoan;
                //tbSoCMND.Text = ObjHocSinh.SoCMND;                
                //tbTenThuongGoi.Text = ObjHocSinh.TenThuongGoi;
                tbXacNhanMatKhau.Text = ObjHocSinh.MatKhau;                
                
                //Điền thông tin Học sinh vào các LookupEdit
                lkuDanToc.EditValue = ObjHocSinh.MaDanToc;
                //lkuNoiCapCMND.EditValue = ObjHocSinh.NoiCapCMND;
                lkuSucKhoe.EditValue = ObjHocSinh.MaTinhTrangSucKhoe;
                lkuTonGiao.EditValue = ObjHocSinh.MaTonGiao;

                //Điền thông tin Học sinh vào các DateTimePicker
                //if (ObjHocSinh.NgayCapCMND != null)
                //    dtpNgayCapCMND.Value = (DateTime)ObjHocSinh.NgayCapCMND;
                if (ObjHocSinh.NgaySinh != null)
                    dtpNgaySinh.Value = (DateTime)ObjHocSinh.NgaySinh;
                //if (ObjHocSinh.NgayVaoDang != null)
                //    dtpNgayVaoDang.Value = (DateTime)ObjHocSinh.NgayVaoDang;
                if (ObjHocSinh.NgayVaoDoan != null)
                {
                    dtpNgayVaoDoan.Value = (DateTime)ObjHocSinh.NgayVaoDoan;
                    tbNoiKetNapDoan.Text = ObjHocSinh.NoiVaoDoan;
                }                    
                else
                {                    
                    tbNoiKetNapDoan.Enabled = false;
                    dtpNgayVaoDoan.Enabled = false;
                }                    

                //Điền thông tin Học sinh vào các RadioButton
                if (ObjHocSinh.GioiTinh == true)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                
                if(ObjHocSinh.Anh != null && System.IO.File.Exists(ObjHocSinh.Anh))
                    pbAnh.Image = Image.FromFile(ObjHocSinh.Anh);

                nudDaQuaLop.Value = (decimal)ObjHocSinh.DaQuaLop;
                nudDaQuaLop.Enabled = false;

                tbEmail.Text = ObjHocSinh.EmailPhuHuynh;
                tbSoDienThoai.Text = ObjHocSinh.SoDienThoaiPhuHuynh;
            }
            tbHoVaTen.Focus();
        }

        private void LamSachForm()
        {
            //tbBiDanh.Text = "";
            //tbDienThoai.Text = "";
            //tbEmail.Text = "";
            //tbHoVaTen.Text = "";
            //tbMaCongChuc.Text = "";
            //tbMaHocSinh.Text = "";
            //tbMatKhau.Text = "";
            //tbNoiKetNapDang.Text = "";
            //tbNoiKetNapDoan.Text = "";
            //tbSoCMND.Text = "";
            
            //Gán giá trị rỗng cho các TextBox
            foreach (Control c in this.Controls)
            {
                if (c.Name.Contains("tb"))
                    c.Text = "";                
            }
            tbMaHocSinh.Text = DSHocSinhBLL.SinhMaHocSinh();

            //Gán giá trị null cho các LookupEdit
            lkuDanToc.EditValue = null;
            //lkuNoiCapCMND.EditValue = null;
            lkuSucKhoe.EditValue = null;
            lkuTonGiao.EditValue = null;
            
            //Gán giá trị mặc định cho các DateTimePicker
            dtpNgaySinh.Value = DateTime.Parse("01/01/1900");
            dtpNgayVaoDoan.Value = DateTime.Parse("01/01/1900");
            //dtpNgayVaoDang.Value = DateTime.Parse("01/01/1900");

            //Gán giá trị mặc định cho các CheckBox
            ceDaVaoDoan.Checked = false;
            //ceDaVaoDang.Checked = false;
            dtpNgayVaoDoan.Enabled = false;
            //dtpNgayVaoDang.Enabled = false;
            tbNoiKetNapDoan.Enabled = false;
            //tbNoiKetNapDang.Enabled = false;

            //Gán giá trị mặc định cho các RadioButton
            rdbNam.Checked = true;

            tbEmail.Text = "";
            tbSoDienThoai.Text = "";
        }

        private void FillDataToGridLookup()
        {
            lkuDanToc.Properties.DataSource = DMDanTocBLL.LoadAll();
            //lkuNoiCapCMND.Properties.DataSource = DMTinhThanhBLL.LoadAll();
            lkuSucKhoe.Properties.DataSource = DMTinhTrangSucKhoeBLL.LoadAll();
            lkuTonGiao.Properties.DataSource = DMTonGiaoBLL.LoadAll();            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    ganThongTinHocSinh();
                    DSHocSinhBLL.ThemHocSinh(ObjHocSinh);
                    QuanLySoLuongBLL.TangSoLuongHocSinh();                    
                }else
                {
                    ganThongTinHocSinh();
                    DSHocSinhBLL.CapNhatHocSinh(ObjHocSinh);                    
                }
                base.Close();
            }
        }

        private void ganThongTinHocSinh()
        {
            if (ThemMoi)
                ObjHocSinh = new DSHocSinh();
            //Gán giá trị các TextBox
            ObjHocSinh.MaHocSinh = tbMaHocSinh.Text.Trim();
            ObjHocSinh.HoDem = UTL.Ultils.CatHoDem(tbHoVaTen.Text);
            ObjHocSinh.Ten = UTL.Ultils.CatTen(tbHoVaTen.Text);
            ObjHocSinh.NgaySinh = dtpNgaySinh.Value;
            if (rdbNam.Checked)
                ObjHocSinh.GioiTinh = true;
            if (rdbNu.Checked)
                ObjHocSinh.GioiTinh = false;
            ObjHocSinh.MaDanToc = (short)lkuDanToc.EditValue;
            ObjHocSinh.MaTonGiao = (short)lkuTonGiao.EditValue;
            ObjHocSinh.MaTinhTrangSucKhoe = (short)lkuSucKhoe.EditValue;
            //ObjHocSinh.DienThoai = tbDienThoai.Text.Trim();            
            if (ceDaVaoDoan.Checked && dtpNgayVaoDoan.Value.ToString() != "01/01/1900")
            {
                ObjHocSinh.NgayVaoDoan = dtpNgayVaoDoan.Value;
                ObjHocSinh.NoiVaoDoan = tbNoiKetNapDoan.Text.Trim();
            }else
            {
                ObjHocSinh.NgayVaoDoan = null;
                ObjHocSinh.NoiVaoDoan = null;
            }
            if (openFile.FileName != "")
                ObjHocSinh.Anh = openFile.FileName;
            else
                ObjHocSinh.Anh = null;
            if (tbMatKhau.Text == tbXacNhanMatKhau.Text)
            {                
                ObjHocSinh.MatKhau = tbMatKhau.Text.Trim();
            }
            if (ThemMoi)
                ObjHocSinh.DaQuaLop = (short)nudDaQuaLop.Value;

            ObjHocSinh.EmailPhuHuynh = tbEmail.Text.Trim();
            ObjHocSinh.SoDienThoaiPhuHuynh = tbSoDienThoai.Text.Trim();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
        }

        private void pbAnh_DoubleClick(object sender, EventArgs e)
        {            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Image = Image.FromFile(openFile.FileName);
            }
        }

        private bool CheckSave()
        {
            return true;
            bool doanVien = (ceDaVaoDoan.Checked && (string.IsNullOrEmpty(tbNoiKetNapDoan.Text) || dtpNgayVaoDoan.Value == DateTime.Parse("01/01/1900")));
            bool khopMatKhau = (tbMatKhau.Text == tbXacNhanMatKhau.Text);
            if (string.IsNullOrEmpty(tbMaHocSinh.Text.Trim()) || string.IsNullOrEmpty(tbHoVaTen.Text.Trim())
                || dtpNgaySinh.Value == DateTime.Parse("01/01/1900") || doanVien || khopMatKhau)
                return false;
            else
                return true;            
        }

        private void ceDaVaoDoan_CheckedChanged(object sender, EventArgs e)
        {
            if (ceDaVaoDoan.Checked)
            {
                dtpNgayVaoDoan.Enabled = true;
                tbNoiKetNapDoan.Enabled = true;
            }else
            {
                dtpNgayVaoDoan.Enabled = false;
                tbNoiKetNapDoan.Enabled = false;
            }
        }

       

        private void frmCapNhatHocSinh_Load(object sender, EventArgs e)
        {
            
        }

        private void tbXacNhanMatKhau_Leave(object sender, EventArgs e)
        {
            if (tbXacNhanMatKhau.Text != tbMatKhau.Text)
            {
                dxErrorProvider.SetError(tbXacNhanMatKhau, "Xác nhận mật khẩu chưa trùng khớp.");                
            }else
            {
                dxErrorProvider.ClearErrors();
            }
        }

    }
}