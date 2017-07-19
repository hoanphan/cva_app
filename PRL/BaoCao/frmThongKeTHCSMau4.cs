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
    public partial class frmThongKeTHCSMau4 : DevExpress.XtraEditors.XtraForm
    {
        private string TenDangNhap;

        public frmThongKeTHCSMau4(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();            
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {                        
            string maHocKy = cbHocKy.SelectedValue.ToString();
            bool laTHCS = true;
            if (rdbTHPT.Checked)
                laTHCS = false;           
            //if (DSTongKetTheoKyBLL.KiemTraDuLieu(maLop, maHocKy))
            //{
            splashScreenManager.ShowWaitForm();
            rptThongKeTHCSMau04 report;
            if (rdbTheoDanToc.Checked)
                report = new rptThongKeTHCSMau04(maHocKy, true, laTHCS);           
            else
                report = new rptThongKeTHCSMau04(maHocKy, false, laTHCS);
            report.CreateDocument(true);
            reportViewer.DocumentSource = report;
            reportViewer.Update();
            splashScreenManager.CloseWaitForm();
            //}
            //else
            //    UTL.Ultils.ThongBao("Dữ liệu chưa được cập nhật đầy đủ.\nVui lòng nhập đầy đủ điểm và tính Trung bình cộng các môn.\n"
            //                        + "Sau đó nhập Hạnh kiểm và xét danh hiệu trước khi thực hiện chức năng này.", MessageBoxIcon.Error);
            
        }
    }
}