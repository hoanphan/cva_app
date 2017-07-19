using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using System.IO.Ports;

namespace PRL
{
    public partial class frmGuiEmail : DevExpress.XtraEditors.XtraForm
    {        

        public frmGuiEmail()
        {
            InitializeComponent();
        }

        private void btnTaoEmailSMS_Click(object sender, EventArgs e)
        {
            DSEmailSMSGuiToanBoBLL.ThemEmailSMS(txtNoiDungEmail.Text.Trim(), txtNoiDungSMS.Text.Trim());
        }

        private void btnGui_Click(object sender, EventArgs e)
        {            
            DSEmailSMSGuiToanBoBLL.GuiSMS(ref progressBarControl1);
        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            DSEmailSMSGuiToanBoBLL.CapNhatSDTEmail();
        }

        private void btnGuiSMSThang_Click(object sender, EventArgs e)
        {
            //DSEmailGuiBLL.TaoMailDeGui();
            DSEmailGuiBLL.GuiSMSThangNew(ref progressBarControl1);
        }

        private void btnTaoMailSMSHangThang_Click(object sender, EventArgs e)
        {
            //DSEmailGuiBLL.TaoMailDeGui(ref progressBarControl1,);
        }

        private void btnChuyenSangHeThongTuDong_Click(object sender, EventArgs e)
        {
            DSEmailGuiBLL.ChuyenSMSSangBangTuDongGui();
        }

        private void btnGuiMailHangThang_Click(object sender, EventArgs e)
        {
            DSEmailGuiBLL.SendListMailHangThang(ref progressBarControl1);
        }

        private void btnGuiKetQuaHocKy_Click(object sender, EventArgs e)
        {
            DSSMSAutoSendBLL.TaoDuLieuSMSKetQuaHocKy("K1");
        }

        private void btnGuiEmailKQHocKy_Click(object sender, EventArgs e)
        {
            DSEmailGuiBLL.TaoMailKetQuaCaHocKyDeGui("K1", ref progressBarControl1);
        }

        private void btnGuiLaiSMS_Click(object sender, EventArgs e)
        {
            DSEmailGuiBLL.GuiLaiSMSThangNew(ref progressBarControl1);
        }
    }
}