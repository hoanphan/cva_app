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
    public partial class frmDMXaPhuong : DevExpress.XtraEditors.XtraForm
    {
        public frmDMXaPhuong()
        {
            InitializeComponent();
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcDMQuanHuyen.DataSource = DMXaPhuongBLL.LayDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatXaPhuong form = new frmCapNhatXaPhuong(null, true);
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDMXaPhuong.GetRowCellValue(this.gvDMXaPhuong.FocusedRowHandle, this.gcMaXaPhuong);
            if (rowCellValue != null)
            {
                frmCapNhatXaPhuong form = new frmCapNhatXaPhuong(DMXaPhuongBLL.TruyVanTheoMa((int)rowCellValue), false);
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
            object rowCellValue = this.gvDMXaPhuong.GetRowCellValue(this.gvDMXaPhuong.FocusedRowHandle, this.gcMaXaPhuong);
            if (rowCellValue != null)
            {
                if (UTL.Ultils.XacThucXoa("xã ,phường"))
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

        private void frmDMXaPhuong_Load(object sender, EventArgs e)
        {

        }
    }
}