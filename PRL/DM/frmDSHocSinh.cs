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
    public partial class frmDSHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDSHocSinh()
        {
            InitializeComponent();
        }

        private void frmDSHocSinh_Load(object sender, EventArgs e)
        {
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcHocSinh.DataSource = DSHocSinhBLL.SelectDataFill();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDSHocSinh.GetRowCellValue(this.gvDSHocSinh.FocusedRowHandle, this.gclMaHocSinh);
            if (rowCellValue != null)
            {
                frmCapNhatHocSinh form = new frmCapNhatHocSinh(DSHocSinhBLL.TruyVanTheoMa((string)rowCellValue), false);
                form.ShowDialog();
                FillDataToGrid();
                ////gvDSHocSinh.CollapseAllGroups();
                //string tenLop = "Lớp: " + DSHocSinhBLL.LayTenLopTheoMaHocSinh(rowCellValue.ToString());
                //int groupRow = 0;                
                //groupRow = FindGroupRow(tenLop);
                //MessageBox.Show(groupRow.ToString());
                //gvDSHocSinh.ExpandGroupRow(groupRow);
                gvDSHocSinh.ExpandAllGroups();
                for (int i = 0; i < this.gvDSHocSinh.RowCount; i++)
                {
                    object temp = this.gvDSHocSinh.GetRowCellValue(i, this.gclMaHocSinh);
                    if ((temp != null) && temp.ToString().Equals(rowCellValue.ToString()))
                    {
                        this.gvDSHocSinh.FocusedRowHandle = i;
                        break;
                    }
                }
                //Guid IDBanAn = qg.IDBanAn;
                //if (qg.IDBanAn != new Guid())
                //{
                //    this.FillDataToGrid();
                //    for (int i = 0; i < this.grvBanAn.RowCount; i++)
                //    {
                //        object temp = this.grvBanAn.GetRowCellValue(i, this.grdcolID);
                //        if ((temp != null) && temp.ToString().Equals(qg.IDBanAn.ToString()))
                //        {
                //            this.grvBanAn.FocusedRowHandle = i;
                //            break;
                //        }
                //    }
                //}
            }
        }

        private int FindGroupRow(string textToFind)
        {
            int i = 0;
            while (i != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                i--;
                string value = gvDSHocSinh.GetGroupRowValue(i, gvDSHocSinh.Columns[6]).ToString();
                if (value == textToFind)
                    return i;
            }
            return 0;
        }

        private void gcHocSinh_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHocSinh form = new frmCapNhatHocSinh(null, true);
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnXuatDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UTL.Ultils.XuatRaExcel(gcHocSinh);
        }
    }
}