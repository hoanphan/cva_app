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
    public partial class frmCapNhatChung : DevExpress.XtraEditors.XtraForm
    {
        
        bool _themMoi;
        string TenBang;

        public bool ThemMoi
        {
            get { return _themMoi; }
            set { _themMoi = value; }
        }

        DMTrinhDoTinHoc _objTrinhDoTinHoc = new DMTrinhDoTinHoc();

        public DMTrinhDoTinHoc ObjTrinhDoTinHoc
        {
            get { return _objTrinhDoTinHoc; }
            set { _objTrinhDoTinHoc = value; }
        }

        DMTrinhDoNgoaiNgu _objTrinhDoNgoaiNgu = new DMTrinhDoNgoaiNgu();

        public DMTrinhDoNgoaiNgu ObjTrinhDoNgoaiNgu
        {
            get { return _objTrinhDoNgoaiNgu; }
            set { _objTrinhDoNgoaiNgu = value; }
        }

        public frmCapNhatChung()
        {
            InitializeComponent();
            LoadForm();
        }

        public frmCapNhatChung(string tenBang, short maChung, bool themMoi)
        {
            TenBang = tenBang;
            switch (TenBang)
            {
                case "DMTrinhDoTinHoc":
                    ObjTrinhDoTinHoc = DMTrinhDoTinHocBLL.TruyVanTheoMa(maChung);
                    break;
                case "DMTrinhDoNgoaiNgu":
                    ObjTrinhDoNgoaiNgu = DMTrinhDoNgoaiNguBLL.TruyVanTheoMa(maChung);
                    break;
            }
            ThemMoi = themMoi;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (ThemMoi)
            {
                switch (TenBang)
                {
                    case "DMTrinhDoTinHoc":
                        this.Text = "Thêm mới Trình độ Tin học";
                        groupThongTin.Text = "Thông tin Trình độ Tin học";
                        break;
                    case "DMTrinhDoNgoaiNgu":
                        this.Text = "Thêm mới Trình độ Ngoại ngữ";
                        groupThongTin.Text = "Thông tin Trình độ Ngoại ngữ";
                        break;
                }                             
                txtMaChung.Text = String.Empty;
                txtTenChung.Text = "";
                txtMaChung.Focus();
            }
            else 
            {
                switch (TenBang)
                {
                    case "DMTrinhDoTinHoc":
                        this.Text = "Cập nhật Trình độ Tin học";
                        groupThongTin.Text = "Thông tin Trình độ Tin học";
                        txtMaChung.Text = ObjTrinhDoTinHoc.MaTrinhDoTinHoc.ToString();
                        txtTenChung.Text = ObjTrinhDoTinHoc.TenTrinhDoTinHoc;
                        break;
                    case "DMTrinhDoNgoaiNgu":
                        this.Text = "Cập nhật Trình độ Ngoại ngữ";
                        groupThongTin.Text = "Thông tin Trình độ Ngoại ngữ";
                        txtMaChung.Text = ObjTrinhDoNgoaiNgu.MaTrinhDoNgoaiNgu.ToString();
                        txtTenChung.Text = ObjTrinhDoNgoaiNgu.TenTrinhDoNgoaiNgu;
                        break;
                }                
                txtTenChung.Focus();                
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckSave())
            {
                if (ThemMoi)
                {
                    switch (TenBang)
                    {
                        case "DMTrinhDoTinHoc":
                            DMTrinhDoTinHocBLL.ThemTrinhDoTinHoc(txtTenChung.Text.Trim());
                            break;
                        case "DMTrinhDoNgoaiNgu":
                            DMTrinhDoNgoaiNguBLL.ThemTrinhDoNgoaiNgu(txtTenChung.Text.Trim());
                            break;
                    }                            
                    base.Close();
                }
                else
                {
                    switch (TenBang)
                    {
                        case "DMTrinhDoTinHoc":
                            ObjTrinhDoTinHoc.TenTrinhDoTinHoc = txtTenChung.Text.Trim();
                            DMTrinhDoTinHocBLL.CapNhatTrinhDoTinHoc(ObjTrinhDoTinHoc);                            
                            break;
                        case "DMTrinhDoNgoaiNgu":
                            ObjTrinhDoNgoaiNgu.TenTrinhDoNgoaiNgu = txtTenChung.Text.Trim();
                            DMTrinhDoNgoaiNguBLL.CapNhatTrinhDoNgoaiNgu(ObjTrinhDoNgoaiNgu);                            
                            break;
                    }
                    base.Close();                    
                }
            }
        }

        private void txtTenChung_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenChung.Text.Trim()))
            {
                String messenger = null;
                switch (TenBang)
                {
                    case "DMTrinhDoTinHoc":
                        messenger = "Tên Trình độ Tin học không được trống.";
                        break;
                    case "DMTrinhDoNgoaiNgu":
                        messenger = "Tên Trình độ Ngoại ngữ không được trống.";
                        break;
                }
                dxErrorProvider.SetError(txtTenChung, messenger);
                txtTenChung.Focus();
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
            txtTenChung_Leave(null, null);
            if (string.IsNullOrEmpty(txtTenChung.Text.Trim()))
                return false;
            else
                return true;
        }

    }
}