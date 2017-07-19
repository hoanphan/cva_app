using BLL;
using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace PRL
{
    public partial class frmDangKyDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKyDichVu()
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

        private void frmDangKyDichVu_Load(object sender, EventArgs e)
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
            gcHocSinhDuocPhanLop.DataSource = DSHocSinhTheoLopBLL.LoadHocSinhTheoLopDangKyDichVu(maLop);
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
                DSHocSinhBLL.CapNhatHocSinhDangKyDichVu(gcHocSinhDuocPhanLop);
            }else
            {
                UTL.Ultils.ThongBao("Dữ liệu nhập chưa chính xác. Vui lòng nhập lại ô đang được đánh dấu.", MessageBoxIcon.Error);
            }
        }      
  
        private bool CheckSave()
        {
            //for(byte i = 0; i < gvHocSinhDuocPhanLop.RowCount; i++)
            //{
            //    byte TT;
            //    if (byte.TryParse(gvHocSinhDuocPhanLop.GetRowCellValue(i, gvHocSinhDuocPhanLop.Columns[5]).ToString(), out TT) == false)
            //    {
            //        gvHocSinhDuocPhanLop.FocusedRowHandle = i;
            //        gvHocSinhDuocPhanLop.FocusedColumn = gvHocSinhDuocPhanLop.VisibleColumns[5];
            //        gvHocSinhDuocPhanLop.ShowEditor();
            //        return false;
            //    }
            //}
            return true;
        }

        private void gvHocSinhDuocPhanLop_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {            
            GridColumn cot = e.Column;
            int dong = e.RowHandle;
            if ((e.Value.ToString() == "t") || (e.Value.ToString() == "T"))
            {
                gvHocSinhDuocPhanLop.SetRowCellValue(dong, cot, "True");

            }
            else
            {
                gvHocSinhDuocPhanLop.SetRowCellValue(dong, cot, "False");
            }
            SendKeys.Send("{End}");
        }

        private void gcHocSinhDuocPhanLop_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!Char.IsLetter('t') && !Char.IsLetter('f') && !Char.IsLetter('T') && !Char.IsLetter('F'))
            {
                e.Handled = true;
            }
        }
    }
}