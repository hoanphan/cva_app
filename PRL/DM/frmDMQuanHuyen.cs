using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using UTL;

namespace PRL
{
    public partial class frmDMQuanHuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDMQuanHuyen()
        {
            InitializeComponent();
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcDMQuanHuyen.DataSource = DMQuanHuyenBLL.LayDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatQuanHuyen form = new frmCapNhatQuanHuyen ( null, true );
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDMQuanHuyen.GetRowCellValue(this.gvDMQuanHuyen.FocusedRowHandle, this.gcMaQuanHuyen);
            if (rowCellValue != null)
            {
                frmCapNhatQuanHuyen form = new frmCapNhatQuanHuyen ( DMQuanHuyenBLL.TruyVanTheoMa((int)rowCellValue), false );
                form.ShowDialog();
                FillDataToGrid();
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDMQuanHuyen.GetRowCellValue(this.gvDMQuanHuyen.FocusedRowHandle, this.gcMaQuanHuyen);
            if (rowCellValue != null)
            {
                if (UTL.Ultils.XacThucXoa("Quận huyện"))
                {
                    DMQuanHuyenBLL.XoaQuanHuyen((int)rowCellValue);
                    FillDataToGrid();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ultils.XuatRaExcel(gcDMQuanHuyen);
        }

        private void gcDMQuanHuyen_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }
    }
}