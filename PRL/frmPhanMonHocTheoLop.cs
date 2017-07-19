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
    public partial class frmPhanMonHocTheoLop : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanMonHocTheoLop()
        {
            InitializeComponent();
            FillForm();
        }

        /// <summary>
        /// Đổ thông tin ban đầu vào form
        /// </summary>
        void FillForm()
        {
            cbHocKy.DataSource = DSHocKyBLL.LoadHocKyHoc();   
            cbKhoi.DataSource = DSKhoiBLL.LoadAll();                  
        }

        private void frmPhanMonHocTheoLop_Load(object sender, EventArgs e)
        {
            panelControl1.Width = (this.Width - 40) / 2;
            panelControl3.Width = (this.Width - 40) / 2;            
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();            
            cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);            
            if (cbLop.Items.Count == 0)
            {
                gcMonHocDuocPhanLop.DataSource = null;
                gcMonHocCanPhanLop.DataSource = null;
            }
            else
            {
                string maLop = cbLop.SelectedValue.ToString();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                LoadMonHocCanPhanLop(maLop, maHocKy);
            }
            lbThongDiep.Caption = "";            
        }

        private void LoadMonHocCanPhanLop(string maLop, string maHocKy)
        {
            gcMonHocCanPhanLop.DataSource = DSMonHocTheoLopBLL.LoadMHCanPhanLop(maLop, maHocKy);            
            for (int i = 0; i < gvMonHocCanPhanLop.DataRowCount; i++)
            {
                gvMonHocCanPhanLop.SetRowCellValue(i+1, gclSTT1, i + 1);
            }
        }

        private void LoadMonHocDuocPhanLop(string maLop, string maHocKy)
        {            
            gcMonHocDuocPhanLop.DataSource = DSMonHocTheoLopBLL.LoadMHDuocPhanLop(maLop, maHocKy);
            for (int i = 0; i < gvMonHocDuocPhanLop.RowCount; i++)
            {
                gvMonHocDuocPhanLop.SetRowCellValue(i, gclSTT2, (i + 1).ToString());                
            }                        
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            LoadMonHocCanPhanLop(maLop, maHocKy);
            LoadMonHocDuocPhanLop(maLop, maHocKy);
            lbThongDiep.Caption = "";
        }

        private void gvHocSinhDuocPhanMonHocTheoLop_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvMonHocDuocPhanLop.SetRowCellValue(e.RowHandle, "gcSTT2", gvMonHocDuocPhanLop.RowCount.ToString());            
        }

        private void btnPhanMonHocTheoLop_Click(object sender, EventArgs e)
        {
            int[] DongDaChon = gvMonHocCanPhanLop.GetSelectedRows();                       
            string maLop = cbLop.SelectedValue.ToString();
            string maKhoi = cbKhoi.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string maMH;
            foreach (int i in DongDaChon)
            {
                maMH = gvMonHocCanPhanLop.GetRowCellValue(i, gclMaMonHoc1).ToString();
                DSMonHocTheoLopBLL.ThemMonHocTheoLop(maMH, maLop, maHocKy);                
            }
            LoadMonHocCanPhanLop(maLop, maHocKy);
            LoadMonHocDuocPhanLop(maLop, maHocKy);
            lbThongDiep.Caption = "Đã chuyển thêm " + DongDaChon.Count().ToString() + " môn học vào lớp " + cbLop.Text.Trim() + ".";
        }

        private void btnBoPhanMonHocTheoLop_Click(object sender, EventArgs e)
        {
            int[] DongDaChon = gvMonHocDuocPhanLop.GetSelectedRows();            
            string maLop = cbLop.SelectedValue.ToString();
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string maMH;
            foreach (int i in DongDaChon)
            {
                maMH = gvMonHocDuocPhanLop.GetRowCellValue(i, gclMaMonHoc2).ToString();
                DSMonHocTheoLopBLL.XoaMonHocTheoMa(maMH, maLop, maHocKy);
            }
            LoadMonHocDuocPhanLop(maLop, maHocKy);
            LoadMonHocCanPhanLop(maLop, maHocKy);
            lbThongDiep.Caption = "Đã xóa " + DongDaChon.Count().ToString() + " học sinh ở lớp " + cbLop.Text.Trim() + ".";
        }

        private void frmPhanMonHocTheoLop_ResizeEnd(object sender, EventArgs e)
        {
            panelControl1.Width = (this.Width - 40) / 2;
            panelControl3.Width = (this.Width - 40) / 2;
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                string maLop = cbLop.SelectedValue.ToString();
                string maHocKy = cbHocKy.SelectedValue.ToString();
                LoadMonHocCanPhanLop(maLop, maHocKy);
                LoadMonHocDuocPhanLop(maLop, maHocKy);
                lbThongDiep.Caption = "";
            }
        }


    }
}