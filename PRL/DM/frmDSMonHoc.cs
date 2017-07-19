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
    public partial class frmDSMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmDSMonHoc()
        {
            InitializeComponent();
        }

        private void frmDSMonHoc_Load(object sender, EventArgs e)
        {
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcMonHoc.DataSource = DSMonHocBLL.LayDuLieu();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDSMonHoc.GetRowCellValue(this.gvDSMonHoc.FocusedRowHandle, this.gclMaMonHoc);
            if (rowCellValue != null)
            {
                frmCapNhatMonHoc form = new frmCapNhatMonHoc(DSMonHocBLL.TruyVanTheoMa((string)rowCellValue), false);
                form.ShowDialog();
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
            FillDataToGrid();
        }

        private void gcMonHoc_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatMonHoc form = new frmCapNhatMonHoc(null, true);
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDSMonHoc.GetRowCellValue(this.gvDSMonHoc.FocusedRowHandle, this.gclMaMonHoc);
            if (rowCellValue != null)
            {
                if (UTL.Ultils.XacThucXoa("Môn học"))
                {
                    DSMonHocBLL.XoaMonHoc((string)rowCellValue);
                    FillDataToGrid();
                }
            }
        }

        private void btnXuatDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UTL.Ultils.XuatRaExcel(gcMonHoc);
        }
    }
}