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

namespace PRL
{
    public partial class frmGuiTinNhan : DevExpress.XtraEditors.XtraForm
    {
        public frmGuiTinNhan()
        {
            InitializeComponent();
            txtSoDienThoai.Enabled = false;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            lbSoKyTu.Text = "Bạn đã nhập: " + txtNoiDung.Text.Trim().Length + " ký tự.";
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (rdNhacNhapDiem.Checked)
                DSDiemBLL.KiemTraNhapDiemTheoThang(txtNoiDung.Text.Trim(), ref pgbTienTrinh);
            if (rdGuiGVToanTruong.Checked)
                DSSMSAutoSendBLL.GuiTinNhanDenToanBoGiaoVien(txtNoiDung.Text.Trim(), ref pgbTienTrinh);
            if (rdbGuiGVCN.Checked)
                DSSMSAutoSendBLL.GuiTinNhanDenToanBoGVCN(txtNoiDung.Text.Trim());
            if (rdbGuiHSToanTruong.Checked)
                SMSBLL.GuiSMSHSToanTruong(txtNoiDung.Text.Trim(), pgbTienTrinh);
            if (rdbGuiDenSoCuThe.Checked)
                SMSBLL.GuiSMSDenMotSoCuThe(txtSoDienThoai.Text.Trim(), txtNoiDung.Text);
        }

        private void btnGuiDenSoCuThe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGuiDenSoCuThe.Checked)
            {
                txtSoDienThoai.Enabled = true;
            }
            else
            {
                txtSoDienThoai.Enabled = false;
            }
        }
    }
}