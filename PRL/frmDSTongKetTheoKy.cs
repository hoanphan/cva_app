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
    public partial class frmDSTongKetTheoKy : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmDSTongKetTheoKy(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
        }

        private void TaoGridView(string maLop, string maHocKy)
        {
            
            while (gvDiemTrungBinhCong.Columns.Count > 4)
            {
                GridColumn gcl = gvDiemTrungBinhCong.Columns[4];
                gvDiemTrungBinhCong.Columns.Remove(gcl);
            }
            string[] maTatCaMonHoc = null;
            string[] hienThiTatCaMonHoc = null;
            if (DSHocKyBLL.LaTongHop(maHocKy) == true)
            {
                maTatCaMonHoc = DSMonHocTheoLopBLL.LayMaMonHocTheoLopKyTongHop(maLop);
                hienThiTatCaMonHoc = DSMonHocTheoLopBLL.LayHienThiMonHocTheoLopKyTongHop(maLop);
            }else
            {
                maTatCaMonHoc = DSMonHocTheoLopBLL.LayMaMonHocTheoLopHocKy(maLop, maHocKy);
                hienThiTatCaMonHoc = DSMonHocTheoLopBLL.LayHienThiMonHocTheoLopHocKy(maLop, maHocKy);
            }
            
            for (byte i = 0; i < maTatCaMonHoc.Count(); i++)
            {
                GridColumn cl = new GridColumn();
                cl.Name = cl.FieldName = maTatCaMonHoc[i];
                cl.Caption = hienThiTatCaMonHoc[i];
                cl.Width = 60;
                cl.Visible = true;
                cl.VisibleIndex = i + 4;
                cl.AppearanceCell.Options.UseTextOptions = true;
                cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cl.OptionsColumn.AllowEdit = false;
                cl.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
                cl.AppearanceHeader.Options.UseFont = true;
                cl.AppearanceHeader.Options.UseTextOptions = true;
                cl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cl.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                cl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                gvDiemTrungBinhCong.Columns.Add(cl);
            }
            GridColumn clTB = new GridColumn();
            clTB.Name = "TBC";
            clTB.Caption = "TBHK";
            clTB.FieldName = "TBC";
            clTB.Width = 60;
            clTB.Visible = true;
            clTB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            clTB.AppearanceHeader.Options.UseFont = true;
            clTB.AppearanceHeader.Options.UseTextOptions = true;            
            clTB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clTB.AppearanceCell.Options.UseTextOptions = true;
            clTB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            clTB.AppearanceCell.Options.UseFont = true;
            clTB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            clTB.OptionsColumn.AllowEdit = false;
            clTB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gvDiemTrungBinhCong.Columns.Add(clTB);
            
        }

        private void FillData()
        {
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();  
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();                      
        }      

        private void frmDSTongKetTheoKy_Load(object sender, EventArgs e)
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
            RefreshGridView(maLop, maHocKy);
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                string maLop = cbLop.SelectedValue.ToString();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                RefreshGridView(maLop, maHocKy);
            }
        }

        private void RefreshGridView(string maLop, string maHocKy)
        {            
            if (DSTongKetTheoKyBLL.KiemTraDuLieu(maLop, maHocKy))
            {
                splashScreenManager.ShowWaitForm();
                TaoGridView(maLop, maHocKy);
                gcDiemTrungBinhCong.DataSource = DSTongKetTheoKyBLL.LayDuLieuTBTatCaCacMon(maLop, maHocKy);
                splashScreenManager.CloseWaitForm();
            }else
                UTL.Ultils.ThongBao("Dữ liệu chưa được cập nhật đầy đủ.\nVui lòng nhập đầy đủ điểm và tính Trung bình cộng các môn.\n"
                                    + "Sau đó nhập Hạnh kiểm và xét danh hiệu trước khi thực hiện chức năng này.", MessageBoxIcon.Error);                       
        }

    }
}