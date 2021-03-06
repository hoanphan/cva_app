﻿using System;
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
    public partial class frmInDSTongKetTheoKy : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmInDSTongKetTheoKy(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();            
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {                        
            string maKhoi = cbKhoi.SelectedValue.ToString();            
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            //if (DSTongKetTheoKyBLL.KiemTraDuLieu(maLop, maHocKy))
            //{
            splashScreenManager.ShowWaitForm();
            rptTongKetTheoKy report;
            if (chkTongHopTheoKhoi.Checked)
                report = new rptTongKetTheoKy(maLop, maHocKy, maKhoi, true);
            else
                report = new rptTongKetTheoKy(maLop, maHocKy, null, false);
            report.CreateDocument(true);
            reportViewer.DocumentSource = report;
            reportViewer.Update();
            splashScreenManager.CloseWaitForm();
            //}
            //else
            //    UTL.Ultils.ThongBao("Dữ liệu chưa được cập nhật đầy đủ.\nVui lòng nhập đầy đủ điểm và tính Trung bình cộng các môn.\n"
            //                        + "Sau đó nhập Hạnh kiểm và xét danh hiệu trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
            
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();
            if (DSGiaoVienBLL.LaGVCN(TenDangNhap))
                cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoiMaGVCN(maKhoi, TenDangNhap);
            else
                cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
            if (cbLop.SelectedValue == null)
                btnLayDuLieu.Enabled = false;
            else
                btnLayDuLieu.Enabled = true;
        }

        private void chkTongHopTheoKhoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTongHopTheoKhoi.Checked)
                cbLop.Enabled = false;
            else
                cbLop.Enabled = true;
        }
    }
}