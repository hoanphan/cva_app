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
    public partial class frmInDSHSDatDanhHieu : DevExpress.XtraEditors.XtraForm
    {
        public frmInDSHSDatDanhHieu()
        {
            InitializeComponent();
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            rptDSHocSinhDanhHieu report = new rptDSHocSinhDanhHieu(maHocKy);
            report.CreateDocument(true);
            reportViewer.DocumentSource = report;
            reportViewer.Update();
            splashScreenManager.CloseWaitForm();
        }
    }
}