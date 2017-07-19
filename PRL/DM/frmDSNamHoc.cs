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
    public partial class frmDSNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmDSNamHoc()
        {
            InitializeComponent();
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcDSNamHoc.DataSource = DSNamHocBLL.LoadAll();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatNamHoc form = new frmCapNhatNamHoc ( null, true );
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MaNamHoc = this.gvDSNamHoc.GetRowCellValue(this.gvDSNamHoc.FocusedRowHandle, this.gcMaNamHoc).ToString();
            if (MaNamHoc != null)
            {
                frmCapNhatNamHoc form = new frmCapNhatNamHoc(DSNamHocBLL.TruyVanTheoMa(MaNamHoc), false);
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
            string MaNamHoc = this.gvDSNamHoc.GetRowCellValue(this.gvDSNamHoc.FocusedRowHandle, this.gcMaNamHoc).ToString();
            if (MaNamHoc != null)
            {
                if (UTL.Ultils.XacThucXoa("Năm học"))
                {
                    DSNamHocBLL.XoaNamHoc(MaNamHoc);
                    FillDataToGrid();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ultils.XuatRaExcel(gcDSNamHoc);
        }

        private void gcDSNamHoc_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }
    }
}