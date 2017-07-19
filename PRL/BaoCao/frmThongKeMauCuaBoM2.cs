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
    public partial class frmThongKeMauCuaBoM2 : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmThongKeMauCuaBoM2(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();            
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {                        
            string maHocKy = cbHocKy.SelectedValue.ToString();
            //if (DSTongKetTheoKyBLL.KiemTraDuLieu(maLop, maHocKy))
            //{
            splashScreenManager.ShowWaitForm();
            bool laTHCS = false;
            if (rdbTHCS.Checked)            
                laTHCS = true;

            rptPhanMemCuaBoM2 report;
            report = new rptPhanMemCuaBoM2(maHocKy, laTHCS);
            report.CreateDocument(true);
            reportViewer.DocumentSource = report;
            reportViewer.Update();
            splashScreenManager.CloseWaitForm();                        
            
        }
    }
}