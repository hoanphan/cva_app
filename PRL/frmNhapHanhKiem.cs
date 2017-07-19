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
using DAL;
using DevExpress.XtraGrid.Columns;

namespace PRL
{
    public partial class frmNhapHanhKiem : DevExpress.XtraEditors.XtraForm
    {
        private string _tenDangNhap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public frmNhapHanhKiem(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
        }

        private void FillData()
        {
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();                        
        }     

        private void frmNhapHanhKiem_Load(object sender, EventArgs e)
        {            
            FillData();
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();
            if (DSGiaoVienBLL.LaGVCN(TenDangNhap))
                cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoiMaGVCN(maKhoi, TenDangNhap);
            else
                cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            gcHanhKiem.DataSource = DSTongKetTheoKyBLL.LayDuLieuHanhKiem(maLop, maHocKy);            
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                string maLop = cbLop.SelectedValue.ToString();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                gcHanhKiem.DataSource = DSTongKetTheoKyBLL.LayDuLieuHanhKiem(maLop, maHocKy);
            }
        }

        private void gvHanhKiem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn cot = e.Column;
            int dong = e.RowHandle;
            if ((e.Value.ToString() == "TT") || (e.Value.ToString() == "tt"))
            {                
                gvHanhKiem.SetRowCellValue(dong, cot, "Tốt");
            }
            if ((e.Value.ToString() == "K") || (e.Value.ToString() == "k"))
            {           
                gvHanhKiem.SetRowCellValue(dong, cot, "Khá");
            }
            if ((e.Value.ToString() == "TB") || (e.Value.ToString() == "tb"))
            {
                gvHanhKiem.SetRowCellValue(dong, cot, "Trung bình");
            }
            if ((e.Value.ToString() == "Y") || (e.Value.ToString() == "y"))
            {
                gvHanhKiem.SetRowCellValue(dong, cot, "Yếu");
            }
            SendKeys.Send("{End}");
        }        

        private void btnXetDanhHieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            DSTongKetTheoKyBLL.XetDanhHieu(maHocKy, TenDangNhap);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            DSTongKetTheoKyBLL.CapNhatHanhKiem(gcHanhKiem, maLop, maHocKy);
        }
    }
}