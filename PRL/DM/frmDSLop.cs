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
    public partial class frmDSLop : DevExpress.XtraEditors.XtraForm
    {
        public frmDSLop()
        {
            InitializeComponent();
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcDSLop.DataSource = DSLopBLL.LayDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatLop form = new frmCapNhatLop ( null, true );
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try{
                string MaLop = this.gvDSLop.GetRowCellValue(this.gvDSLop.FocusedRowHandle, this.gcMaLop).ToString();
                if (MaLop != null)
                {
                    frmCapNhatLop form = new frmCapNhatLop(DSLopBLL.TruyVanTheoMa(MaLop), false);
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
            }catch(NullReferenceException ex)
            { }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MaLop = this.gvDSLop.GetRowCellValue(this.gvDSLop.FocusedRowHandle, this.gcMaLop).ToString();
            if (MaLop != null)
            {
                if (UTL.Ultils.XacThucXoa("Lớp"))
                {
                    DSLopBLL.XoaLop(MaLop);
                    FillDataToGrid();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ultils.XuatRaExcel(gcDSLop);
        }

        private void gcDSLop_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }
    }
}