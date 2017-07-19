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
using UTL;

namespace PRL
{
    public partial class frmXuatTinNhanCanGuiSangExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmXuatTinNhanCanGuiSangExcel()
        {
            InitializeComponent();
        }

        private void frmXuatTinNhanCanGuiSangExcel_Load(object sender, EventArgs e)
        {
            FillDataToComboBox();
            checkNhacNhapDiem.Enabled = rdbGVToanTruong.Checked;
        }

        private void FillDataToComboBox()
        {            
            cbNhaMang.DataSource = DMNhaMangBLL.LayTatCaNhaMang();
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();
        }

        private void btnTaoDuLieuGui_Click(object sender, EventArgs e)
        {            
            string maNhaMang = cbNhaMang.SelectedValue.ToString();
            CapNhatGridControl(maNhaMang);
        }        

        private void cbNhaMang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CapNhatGridControl(string maNhaMang)
        {
            string doiTuong = "";
            if (rdbHSToanTruong.Checked)
                doiTuong = "HSToanTruong";
            if (rdbGVToanTruong.Checked)
                if (checkNhacNhapDiem.Checked)
                    doiTuong = "GVToanTruong-NhacNhapDiem";
                else
                    doiTuong = "GVToanTruong";
            if (rdbHocSinhTheoKhoi.Checked)
                if (checkTheoLop.Checked)
                    doiTuong = "HSTheoKhoiLop";
                else
                    doiTuong = "HSTheoKhoi";
            string maKhoi = cbKhoi.SelectedValue.ToString();
            string maLop = cbLop.SelectedValue.ToString();
            gcSMS.DataSource = SMSBLL.TaoDuLieuSMSGui(doiTuong, maNhaMang, txtNoiDung.Text, maKhoi, maLop);
            lbSoDongThoaMan.Text = "Có " + gvSMS.RowCount.ToString() + " dòng thỏa mãn.";
        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            Ultils.XuatRaExcel(gcSMS);
        }

        private void rdbGVToanTruong_CheckedChanged(object sender, EventArgs e)
        {
            checkNhacNhapDiem.Enabled = rdbGVToanTruong.Checked;
        }

        private void rdbHocSinhTheoKhoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkTheoLop_CheckedChanged(object sender, EventArgs e)
        {
            cbLop.Enabled = checkTheoLop.Checked;
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoi.SelectedValue != null)
                cbLop.DataSource = DSLopBLL.LayLopTheoMaKhoi(cbKhoi.SelectedValue.ToString());
        }
    }
}