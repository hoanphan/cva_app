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
    public partial class frmTachDiemHangThangSangExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmTachDiemHangThangSangExcel()
        {
            InitializeComponent();
        }

        private void frmTachDiemHangThangSangExcel_Load(object sender, EventArgs e)
        {
            FillDataToComboBox();
        }

        private void FillDataToComboBox()
        {
            cbHocKy.DataSource = DSThangBLL.LayTatCaThang();
            cbNhaMang.DataSource = DMNhaMangBLL.LayTatCaNhaMang();
        }

        private void btnTaoDuLieuGui_Click(object sender, EventArgs e)
        {
            string maThang = cbHocKy.SelectedValue.ToString();
            if (DSEmailGuiBLL.KiemTraEmailGuiDaTonTai(maThang) == true)
            {
                bool xacThucXoa = UTL.Ultils.XacThucXoa("các Email và SMS của tháng " + DSThangBLL.LayTenThangTheoMaThang(maThang));
                if (xacThucXoa == true)
                {
                    DSEmailGuiBLL.XoaEmailSMSTheoThang(maThang);
                }
                else
                    return;
            }
            DSEmailGuiBLL.TaoMailDeGui(ref pgbTienTrinh, maThang);
            string maNhaMang = cbNhaMang.SelectedValue.ToString();
            CapNhatGridControl(maThang, maNhaMang);
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maThang = cbHocKy.SelectedValue.ToString();
            string maNhaMang;
            if (cbNhaMang.SelectedValue != null)
            {
                maNhaMang = cbNhaMang.SelectedValue.ToString();
                CapNhatGridControl(maThang, maNhaMang);
            }                
        }

        private void cbNhaMang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maThang;
            string maNhaMang = cbNhaMang.SelectedValue.ToString(); ;
            if (cbHocKy.SelectedValue != null)
            {
                maThang = cbHocKy.SelectedValue.ToString();
                CapNhatGridControl(maThang, maNhaMang);
            }
        }

        private void CapNhatGridControl(string maThang, string maNhaMang)
        {
            gcSMS.DataSource = DSEmailGuiBLL.LayDuLieuSMSDeXuatExcel(maThang, maNhaMang);
            lbSoDongThoaMan.Text = "Có " + gvSMS.RowCount.ToString() + " dòng thỏa mãn.";
        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            Ultils.XuatRaExcel(gcSMS);
        }
    }
}