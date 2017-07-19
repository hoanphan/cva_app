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
    public partial class frmInDSLop : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmInDSLop(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();            
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            if (chkKemEmail.Checked)
            {
                rptDSLopKemEmailSDTs report = new rptDSLopKemEmailSDTs(maLop);
                report.CreateDocument(true);
                reportViewer.DocumentSource = report;
                reportViewer.Update();
            }
            else
            {
                rptDSLop report = new rptDSLop(maLop);
                report.CreateDocument(true);
                reportViewer.DocumentSource = report;
                reportViewer.Update();
            }                                   
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();
            if (DSGiaoVienBLL.LaGVCN(TenDangNhap))
                cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoiMaGVCN(maKhoi, TenDangNhap);
            else
                cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
        }
    }
}