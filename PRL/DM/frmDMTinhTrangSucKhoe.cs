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
    public partial class frmDMTinhTrangSucKhoe : DevExpress.XtraEditors.XtraForm
    {
        public frmDMTinhTrangSucKhoe()
        {
            InitializeComponent();
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcDMTinhTranggSucKhoe.DataSource = DMTinhTrangSucKhoeBLL.LoadAll();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatTinhTrangSucKhoe form = new frmCapNhatTinhTrangSucKhoe(null, true);
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDMTinhTrangSucKhoe.GetRowCellValue(this.gvDMTinhTrangSucKhoe.FocusedRowHandle, this.gcMaTinhTrangSucKhoe);
            if (rowCellValue != null)
            {
                frmCapNhatTinhTrangSucKhoe form = new frmCapNhatTinhTrangSucKhoe(DMTinhTrangSucKhoeBLL.TruyVanTheoMa((short)rowCellValue), false);
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDMTinhTrangSucKhoe.GetRowCellValue(this.gvDMTinhTrangSucKhoe.FocusedRowHandle, this.gcMaTinhTrangSucKhoe);
            if (rowCellValue != null)
            {
                if (UTL.Ultils.XacThucXoa("Tỉnh, Thành phố"))
                {
                    DMTinhTrangSucKhoeBLL.XoaTinhTrangSucKhoe((short)rowCellValue);
                    FillDataToGrid();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ultils.XuatRaExcel(gcDMTinhTranggSucKhoe);
        }

        private void gcDMTinhThanh_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }

        private void frmDMTinhThanh_Load(object sender, EventArgs e)
        {

        }
    }
}