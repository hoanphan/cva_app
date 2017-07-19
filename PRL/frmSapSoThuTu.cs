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
    public partial class frmSapSoThuTu : DevExpress.XtraEditors.XtraForm
    {
        public frmSapSoThuTu()
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

        private void frmSapSoThuTu_Load(object sender, EventArgs e)
        {
            
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoi = cbKhoi.SelectedValue.ToString();            
            cbLop.DataSource = DSLopBLL.TruyVanTheoMaKhoi(maKhoi);
            if (cbLop.Items.Count == 0)
                gcHocSinhDuocPhanLop.DataSource = null;            
            lbThongDiep.Caption = "";            
        }

        private void LoadHSDuocPhanLop(string maLop)
        {
            gcHocSinhDuocPhanLop.DataSource = DSHocSinhTheoLopBLL.LoadHocSinhTheoLop(maLop);
            for (int i = 0; i < gvHocSinhDuocPhanLop.RowCount; i++)
            {
                gvHocSinhDuocPhanLop.SetRowCellValue(i, gclSTT, (i + 1).ToString());                
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
            gvHocSinhDuocPhanLop.SetRowCellValue(e.RowHandle, "gclSTT", gvHocSinhDuocPhanLop.RowCount.ToString());            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                string maLop = cbLop.SelectedValue.ToString();
                DSHocSinhTheoLopBLL.CapNhatThuTuHocSinhTrongLop(maLop, gcHocSinhDuocPhanLop);
            }else
            {
                UTL.Ultils.ThongBao("Dữ liệu nhập chưa chính xác. Vui lòng nhập lại ô đang được đánh dấu.", MessageBoxIcon.Error);
            }
        }      
  
        private bool CheckSave()
        {
            for(byte i = 0; i < gvHocSinhDuocPhanLop.RowCount; i++)
            {
                byte TT;
                if (byte.TryParse(gvHocSinhDuocPhanLop.GetRowCellValue(i, gvHocSinhDuocPhanLop.Columns[5]).ToString(), out TT) == false)
                {
                    gvHocSinhDuocPhanLop.FocusedRowHandle = i;
                    gvHocSinhDuocPhanLop.FocusedColumn = gvHocSinhDuocPhanLop.VisibleColumns[5];
                    gvHocSinhDuocPhanLop.ShowEditor();
                    return false;
                }
            }
            return true;
        }

    }
}