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
    public partial class frmDSGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDSGiaoVien()
        {
            InitializeComponent();
        }

        private void frmDSGiaoVien_Load(object sender, EventArgs e)
        {
            FillDataToGrid();
        }

        private void FillDataToGrid()
        {
            gcGiaoVien.DataSource = DSGiaoVienBLL.SelectDataFill();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDSGiaoVien.GetRowCellValue(this.gvDSGiaoVien.FocusedRowHandle, this.gclMaGiaoVien);
            if (rowCellValue != null)
            {
                frmCapNhatGiaoVien form = new frmCapNhatGiaoVien(DSGiaoVienBLL.TruyVanTheoMa((string)rowCellValue), false, true);
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

        private void gcGiaoVien_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatGiaoVien form = new frmCapNhatGiaoVien(null, true, true);
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnXuatDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UTL.Ultils.XuatRaExcel(gcGiaoVien);
        }
    }
}