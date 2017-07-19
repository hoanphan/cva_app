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
    public partial class frmTachDiemTongKetHocKySangExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmTachDiemTongKetHocKySangExcel()
        {
            InitializeComponent();
        }

        private void frmTachDiemTongKetHocKySangExcel_Load(object sender, EventArgs e)
        {
            FillDataToComboBox();
        }

        private void FillDataToComboBox()
        {
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();
            cbNhaMang.DataSource = DMNhaMangBLL.LayTatCaNhaMang();
        }

        private void btnTaoDuLieuGui_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (DSGuiKetQuaHocKyBLL.KiemTraGuiKetQuaHocKyDaTonTai(maHocKy) == true)
            {
                bool xacThucXoa = UTL.Ultils.XacThucXoa("các Email và SMS của " + DSHocKyBLL.LayTenHocKyTheoMa(maHocKy));
                if (xacThucXoa == true)
                {
                    DSGuiKetQuaHocKyBLL.XoaEmailSMSTheoKy(maHocKy);
                }
                else
                    return;
            }
            DSGuiKetQuaHocKyBLL.TaoMailKetQuaCaHocKyDeGui(maHocKy, ref pgbTienTrinh);
            string maNhaMang = cbNhaMang.SelectedValue.ToString();
            CapNhatGridControl(maHocKy, maNhaMang);
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

        private void CapNhatGridControl(string maHocKy, string maNhaMang)
        {
            gcSMS.DataSource = DSGuiKetQuaHocKyBLL.LayDuLieuSMSDeXuatExcel(maHocKy, maNhaMang);
            lbSoDongThoaMan.Text = "Có " + gvSMS.RowCount.ToString() + " dòng thỏa mãn.";
        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            Ultils.XuatRaExcel(gcSMS);
        }
    }
}