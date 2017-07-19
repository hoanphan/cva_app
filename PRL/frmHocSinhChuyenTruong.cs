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
    public partial class frmHocSinhChuyenTruong : DevExpress.XtraEditors.XtraForm
    {
        public frmHocSinhChuyenTruong()
        {
            InitializeComponent();
            FillForm();
        }

        private void frmHocSinhChuyenTruong_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Đổ thông tin ban đầu vào form
        /// </summary>
        void FillForm()
        {
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();
            cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
            if (cbLop.Items.Count == 0)
                gcHocSinhTheoLop.DataSource = null;
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            LoadHSDuocPhanLop(maLop);
        }

        private void LoadHSDuocPhanLop(string maLop)
        {
            gcHocSinhTheoLop.DataSource = DSHocSinhTheoLopBLL.LoadHocSinhTheoLop(maLop);
            for (int i = 0; i < gvHocSinhTheoLop.RowCount; i++)
            {
                gvHocSinhTheoLop.SetRowCellValue(i, gclSTT, (i + 1).ToString());
            }
        }

        private void rdbChuyenDi_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinhChuyenTruong();
            checkHeVNEN.Enabled = rdbChuyenDen.Checked;
        }        

        private void rdbChuyenDen_CheckedChanged(object sender, EventArgs e)
        {
            gcHocSinhChuyenTruong.DataSource = DSHocSinhChuyenTruongBLL.LoadHocSinhChuyenTruong(rdbChuyenDi.Checked);
            checkHeVNEN.Enabled = rdbChuyenDen.Checked;
        }

        private void LoadDanhSachHocSinhChuyenTruong()
        {
            gcHocSinhChuyenTruong.DataSource = DSHocSinhChuyenTruongBLL.LoadHocSinhChuyenTruong(rdbChuyenDi.Checked);
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            int[] rowsIndex = gvHocSinhTheoLop.GetSelectedRows();
            if (rowsIndex.Count() == 0)
                UTL.Ultils.ThongBao("Không có Học sinh nào được chọn để chuyển trường.", MessageBoxIcon.Information);
            else
            {
                int rowIndex = rowsIndex[0];
                string maHocSinh = gvHocSinhTheoLop.GetRowCellValue(rowIndex, "MaHocSinh").ToString();
                bool chuyenDi = rdbChuyenDi.Checked;
                if (txtNoiChuyen.Text.Trim() == "")
                {
                    UTL.Ultils.ThongBao("Phải nhập Nơi học sinh chuyển đến.", MessageBoxIcon.Information);
                    txtNoiChuyen.Focus();
                    return;
                }else
                {
                    DSHocSinhChuyenTruongBLL.ThemHocSinhChuyenTruong(rdbChuyenDi.Checked, maHocSinh, cbHocKy.SelectedValue.ToString(), txtNoiChuyen.Text.Trim(), checkHeVNEN.Checked);
                    LoadDanhSachHocSinhChuyenTruong();
                }
            }                
        }
    }
}