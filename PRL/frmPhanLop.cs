using BLL;
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

namespace PRL
{
    public partial class frmPhanLop : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanLop()
        {
            InitializeComponent();
            FillForm();
        }

        /// <summary>
        /// Đổ thông tin ban đầu vào form
        /// </summary>
        void FillForm()
        {
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();                        
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();            
            cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
            if (cbLop.Items.Count == 0)
                gcHocSinhDuocPhanLop.DataSource = null;
            LoadHSCanPhanLop(maKhoi);
            lbThongDiep.Caption = "";            
        }

        private void LoadHSCanPhanLop(string maKhoi)
        {
            gcHocSinhCanPhanLop.DataSource = DSHocSinhTheoLopBLL.LoadHSCanPhanLop(maKhoi);            
            for (int i = 0; i < gvHocSinhCanPhanLop.DataRowCount; i++)
            {
                gvHocSinhCanPhanLop.SetRowCellValue(i+1, gcSTT1, i + 1);
            }
        }

        private void LoadHSDuocPhanLop(string maLop)
        {
            gcHocSinhDuocPhanLop.DataSource = DSHocSinhTheoLopBLL.LoadHSDuocPhanLop(maLop);
            for (int i = 0; i < gvHocSinhDuocPhanLop.RowCount; i++)
            {
                gvHocSinhDuocPhanLop.SetRowCellValue(i, gcSTT2, (i + 1).ToString());                
            }                        
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            LoadHSDuocPhanLop(maLop);
            lbThongDiep.Caption = "";
        }

        private void gvHocSinhDuocPhanLop_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvHocSinhDuocPhanLop.SetRowCellValue(e.RowHandle, "gcSTT2", gvHocSinhDuocPhanLop.RowCount.ToString());            
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            int[] DongDaChon = gvHocSinhCanPhanLop.GetSelectedRows();                       
            string maLop = cbLop.SelectedValue.ToString();
            string maKhoi = cbKhoi.SelectedValue.ToString();
            string maHS;
            foreach (int i in DongDaChon)
            {
                maHS = gvHocSinhCanPhanLop.GetRowCellValue(i, gcMaHocSinh1).ToString();
                DSHocSinhTheoLopBLL.ThemHocSinhTheoLop(maHS, maLop);                
            }
            LoadHSCanPhanLop(maKhoi);
            LoadHSDuocPhanLop(maLop);
            lbThongDiep.Caption = "Đã chuyển thêm " + DongDaChon.Count().ToString() + " học sinh vào lớp " + cbLop.Text.Trim() + ".";
        }

        private void btnBoPhanLop_Click(object sender, EventArgs e)
        {
            int[] DongDaChon = gvHocSinhDuocPhanLop.GetSelectedRows();            
            string maLop = cbLop.SelectedValue.ToString();
            string maKhoi = cbKhoi.SelectedValue.ToString();
            string maHS;
            foreach (int i in DongDaChon)
            {
                maHS = gvHocSinhDuocPhanLop.GetRowCellValue(i, gcMaHocSinh2).ToString();
                DSHocSinhTheoLopBLL.XoaHocSinhTheoMa(maHS);
            }
            LoadHSDuocPhanLop(maLop);
            LoadHSCanPhanLop(maKhoi);
            lbThongDiep.Caption = "Đã xóa " + DongDaChon.Count().ToString() + " học sinh ở lớp " + cbLop.Text.Trim() + ".";
        }

        private void frmPhanLop_SizeChanged(object sender, EventArgs e)
        {
            panelControl1.Width = (this.Width - 40) / 2;
            panelControl3.Width = (this.Width - 40) / 2;
        }

    }
}