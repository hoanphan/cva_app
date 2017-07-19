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
using UTL;

namespace PRL
{
    public partial class frmCapNhatGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }

        bool _chinhSua;

        public bool ChinhSua
        {
            get { return _chinhSua; }
            set { _chinhSua = value; }
        }

        DSGiaoVien _objGiaoVien = new DSGiaoVien();

        public DSGiaoVien ObjGiaoVien
        {
            get { return _objGiaoVien; }
            set { _objGiaoVien = value; }
        }

        public frmCapNhatGiaoVien()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatGiaoVien(DSGiaoVien objGiaoVien, bool themMoi, bool chinhSua)
        {
            ObjGiaoVien = objGiaoVien;
            ThemMoi = themMoi;
            ChinhSua = chinhSua;
            InitializeComponent();
            LoadForm();           
        }

        private void LoadForm()
        {
            FillDataToGridLookup();
            if (ThemMoi)
            {
                this.Text = "Thêm mới Giáo viên";
                LamSachForm();
                tbMaGiaoVien.Text = DSGiaoVienBLL.SinhMaGiaoVien();
                tbHoVaTen.Focus();
            }
            else 
            {                   
                this.Text = "Cập nhật thông tin Giáo viên";                
                //Điền thông tin Giáo viên vào TextBox                                               
                tbMaGiaoVien.Text = ObjGiaoVien.MaGiaoVien;
                tbMaCongChuc.Text = ObjGiaoVien.MaCongChuc;
                tbHoVaTen.Text = ObjGiaoVien.HoDem + " " + ObjGiaoVien.Ten;
                tbTenThuongGoi.Text = ObjGiaoVien.TenThuongGoi;
                tbBiDanh.Text = ObjGiaoVien.BiDanh;                
                tbNoiKetNapDang.Text = ObjGiaoVien.NoiVaoDang;
                tbNoiKetNapDoan.Text = ObjGiaoVien.NoiVaoDoan;
                tbSoCMND.Text = ObjGiaoVien.SoCMND;                                
                tbDienThoai.Text = ObjGiaoVien.DienThoai;
                tbEmail.Text = ObjGiaoVien.Email;                
                tbMatKhau.Text = tbXacNhanMatKhau.Text = UTL.Ultils.Decrypt(ObjGiaoVien.MatKhau, "CVA");                 
                
                //Điền thông tin Giáo viên vào các LookupEdit
                lkuDanToc.EditValue = ObjGiaoVien.MaDanToc;
                lkuNoiCapCMND.EditValue = ObjGiaoVien.NoiCapCMND;
                lkuSucKhoe.EditValue = ObjGiaoVien.MaTinhTrangSucKhoe;
                lkuTonGiao.EditValue = ObjGiaoVien.MaTonGiao;

                //Điền thông tin Giáo viên vào các DateTimePicker
                if (ObjGiaoVien.NgayCapCMND != null)
                    dtpNgayCapCMND.Value = (DateTime)ObjGiaoVien.NgayCapCMND;
                if (ObjGiaoVien.NgaySinh != null)
                    dtpNgaySinh.Value = (DateTime)ObjGiaoVien.NgaySinh;
                if (ObjGiaoVien.NgayVaoDang != null)
                    dtpNgayVaoDang.Value = (DateTime)ObjGiaoVien.NgayVaoDang;
                if (ObjGiaoVien.NgayVaoDoan != null)
                    dtpNgayVaoDoan.Value = (DateTime)ObjGiaoVien.NgayVaoDoan;                

                //Điền thông tin Giáo viên vào các RadioButton
                if (ObjGiaoVien.GioiTinh == true)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;

                //Điền thông tin môn giảng dạy vào listbox
                string[] maMonHocs = DSMonHocBLL.LayMaTatCaMonHoc();
                string[] tenMonHocs = DSMonHocBLL.LayTenTatCaMonHoc();
                for(byte i = 0; i < maMonHocs.Length; i++)
                {
                    if (ObjGiaoVien.MonGiangDay != null)
                    {
                        if (ObjGiaoVien.MonGiangDay.Contains(maMonHocs.GetValue(i).ToString()))
                            listMonHoc.Items[i].CheckState = CheckState.Checked;
                    }
                }
                tbHoVaTen.Focus();
                if (ChinhSua == false)
                {
                    this.Text = "Thông tin Giáo viên";                                                                
                    tbMaGiaoVien.Enabled = false;
                    tbMaCongChuc.Enabled = false;
                    tbHoVaTen.Enabled = false;
                    tbTenThuongGoi.Enabled = false;
                    tbBiDanh.Enabled = false;
                    tbNoiKetNapDang.Enabled = false;
                    tbNoiKetNapDoan.Enabled = false;
                    tbSoCMND.Enabled = false;
                    tbDienThoai.Enabled = false;
                    tbEmail.Enabled = false;                    

                    lkuDanToc.Enabled = false;
                    lkuNoiCapCMND.Enabled = false;
                    lkuSucKhoe.Enabled = false;
                    lkuTonGiao.Enabled = false;

                    dtpNgaySinh.Enabled = false;

                    rdbNam.Enabled = false;
                    rdbNu.Enabled = false;
                    
                    groupCMND.Enabled = false;
                    groupMonGiangDay.Enabled = false;
                    groupDoanThe.Enabled = false;
                    

                    tbMatKhau.Focus();
                }
            }
        }

        private void LamSachForm()
        {
            //tbBiDanh.Text = "";
            //tbDienThoai.Text = "";
            //tbEmail.Text = "";
            //tbHoVaTen.Text = "";
            //tbMaCongChuc.Text = "";
            //tbMaGiaoVien.Text = "";
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
            tbMaGiaoVien.Text = DSGiaoVienBLL.SinhMaGiaoVien();

            //Gán giá trị null cho các LookupEdit
            lkuDanToc.EditValue = null;
            lkuNoiCapCMND.EditValue = null;
            lkuSucKhoe.EditValue = null;
            lkuTonGiao.EditValue = null;
            
            //Gán giá trị mặc định cho các DateTimePicker
            dtpNgaySinh.Value = DateTime.Parse("01/01/1900");
            dtpNgayVaoDoan.Value = DateTime.Parse("01/01/1900");
            dtpNgayVaoDang.Value = DateTime.Parse("01/01/1900");

            //Gán giá trị mặc định cho các CheckBox
            ceDaVaoDoan.Checked = false;
            ceDaVaoDang.Checked = false;
            dtpNgayVaoDoan.Enabled = false;
            dtpNgayVaoDang.Enabled = false;
            tbNoiKetNapDoan.Enabled = false;
            tbNoiKetNapDang.Enabled = false;

            //Gán giá trị mặc định cho các RadioButton
            rdbNam.Checked = true;

            //Xóa lựa chọn trong DS môn học
            listMonHoc.UnCheckAll();
            
        }

        private void FillDataToGridLookup()
        {
            lkuDanToc.Properties.DataSource = DMDanTocBLL.LoadAll();
            lkuNoiCapCMND.Properties.DataSource = DMTinhThanhBLL.LoadAll();
            lkuSucKhoe.Properties.DataSource = DMTinhTrangSucKhoeBLL.LoadAll();
            lkuTonGiao.Properties.DataSource = DMTonGiaoBLL.LoadAll();
            string[] maMonHocs = DSMonHocBLL.LayMaTatCaMonHoc();
            string[] tenMonHocs = DSMonHocBLL.LayTenTatCaMonHoc();
            foreach(string tenMonHoc in tenMonHocs)
            {
                listMonHoc.Items.Add(tenMonHoc);
            }            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                string[] maMonHocs = DSMonHocBLL.LayMaTatCaMonHoc();
                string monGiangDay = "";
                for (byte i = 0; i < listMonHoc.Items.Count; i++)
                {
                    if (listMonHoc.Items[i].CheckState.ToString() == "Checked")
                        monGiangDay += "#" + maMonHocs[i];
                }
                monGiangDay += "#";

                if (ThemMoi)
                {
                    ObjGiaoVien = new DSGiaoVien();                    
                    ganThongTinGiaoVien(monGiangDay);
                    DSGiaoVienBLL.ThemGiaoVien(ObjGiaoVien);
                    base.Close();
                }
                else
                {
                    ganThongTinGiaoVien(monGiangDay);
                    DSGiaoVienBLL.CapNhatGiaoVien(ObjGiaoVien);
                    base.Close();
                }
            }else
            {
                UTL.Ultils.ThongBao("Thông tin nhập chưa đầy đủ. Vui lòng kiểm tra các mục: Họ và tên, Ngày sinh, " + 
                "Xác nhận mật khẩu.", MessageBoxIcon.Error);
            }
        }

        private void ganThongTinGiaoVien(string monGiangDay)
        {
            //Gán giá trị các TextBox
            if (ThemMoi)
                ObjGiaoVien.MaGiaoVien = tbMaGiaoVien.Text.Trim();
            ObjGiaoVien.MaCongChuc = tbMaCongChuc.Text.Trim();
            ObjGiaoVien.HoDem = UTL.Ultils.CatHoDem(tbHoVaTen.Text);
            ObjGiaoVien.Ten = UTL.Ultils.CatTen(tbHoVaTen.Text);
            ObjGiaoVien.TenThuongGoi = tbTenThuongGoi.Text.Trim();
            ObjGiaoVien.BiDanh = tbBiDanh.Text.Trim();
            ObjGiaoVien.NgaySinh = dtpNgaySinh.Value;
            if (rdbNam.Checked)
                ObjGiaoVien.GioiTinh = true;
            else
                ObjGiaoVien.GioiTinh = false;
            if (lkuDanToc.EditValue != null)
                ObjGiaoVien.MaDanToc = (short)lkuDanToc.EditValue;
            if (lkuTonGiao.EditValue != null)
                ObjGiaoVien.MaTonGiao = (short)lkuTonGiao.EditValue;
            if (lkuSucKhoe.EditValue != null)
                ObjGiaoVien.MaTinhTrangSucKhoe = (short)lkuSucKhoe.EditValue;
            ObjGiaoVien.Email = tbEmail.Text.Trim();
            ObjGiaoVien.DienThoai = tbDienThoai.Text.Trim();
            ObjGiaoVien.SoCMND = tbSoCMND.Text.Trim();
            ObjGiaoVien.NgayCapCMND = dtpNgayCapCMND.Value;
            if (lkuNoiCapCMND.EditValue != null)
                ObjGiaoVien.NoiCapCMND = (short)lkuNoiCapCMND.EditValue;            
            if (ceDaVaoDoan.Checked)
            {
                ObjGiaoVien.NgayVaoDoan = dtpNgayVaoDoan.Value;
                ObjGiaoVien.NoiVaoDoan = tbNoiKetNapDoan.Text.Trim();
            }else
            {
                ObjGiaoVien.NgayVaoDoan = DateTime.Parse("01/01/1900");
                ObjGiaoVien.NoiVaoDoan = "";
            }
            if (ceDaVaoDang.Checked)
            {
                ObjGiaoVien.NgayVaoDang = dtpNgayVaoDang.Value;
                ObjGiaoVien.NoiVaoDang = tbNoiKetNapDang.Text.Trim();
            }
            else
            {
                ObjGiaoVien.NgayVaoDang = DateTime.Parse("01/01/1900");
                ObjGiaoVien.NoiVaoDang = "";
            }
            ObjGiaoVien.MatKhau = UTL.Ultils.Encrypt(tbMatKhau.Text, "CVA"); 
            ObjGiaoVien.MonGiangDay = monGiangDay;
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
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Title = Params.Title + " - Chọn ảnh giáo viên",
                Filter = "Jpeg (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Image = Image.FromFile(openFile.FileName);
            }
        }

        private bool CheckSave()
        {            
            bool doanVien;
            if (ceDaVaoDang.Checked)
                doanVien = ((string.IsNullOrEmpty(tbNoiKetNapDoan.Text) || dtpNgayVaoDoan.Value == DateTime.Parse("01/01/1900")));
            else
                doanVien = false;
            bool dangVien;
            if (ceDaVaoDang.Checked)
                dangVien = (ceDaVaoDang.Checked && (string.IsNullOrEmpty(tbNoiKetNapDang.Text) || dtpNgayVaoDang.Value == DateTime.Parse("01/01/1900")));
            else
                dangVien = false;
            bool khopMatKhau = ((tbMatKhau.Text != tbXacNhanMatKhau.Text) || (string.IsNullOrEmpty(tbMatKhau.Text)));
            if (string.IsNullOrEmpty(tbMaGiaoVien.Text.Trim()) || string.IsNullOrEmpty(tbHoVaTen.Text.Trim())
                || dtpNgaySinh.Value == DateTime.Parse("01/01/1900") || doanVien || dangVien || khopMatKhau)
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

        private void ceDaVaoDang_CheckedChanged(object sender, EventArgs e)
        {
            if (ceDaVaoDang.Checked)
            {
                dtpNgayVaoDang.Enabled = true;
                tbNoiKetNapDang.Enabled = true;
            }
            else
            {
                dtpNgayVaoDang.Enabled = false;
                tbNoiKetNapDang.Enabled = false;
            }
        }

        private void frmCapNhatGiaoVien_Load(object sender, EventArgs e)
        {
            tbMaCongChuc.Focus();
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