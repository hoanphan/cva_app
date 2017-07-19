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
using UTL;
namespace PRL
{
    public partial class frmDMTrinhDoChinhTri : DevExpress.XtraEditors.XtraForm
    {
        public frmDMTrinhDoChinhTri()
        {
            InitializeComponent();
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            gcDMTrinhDoChinhTri.DataSource = DMTrinhDoChinhTriBLL.LoadAll();
        }
        private void frmDMTrinhDoChinhTri_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatTrinhDoChinhTri form = new frmCapNhatTrinhDoChinhTri(null, true);
            form.ShowDialog();
            FillDataGrid();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCelValues = this.gvDMTrinhDoChinhTri.GetRowCellValue(this.gvDMTrinhDoChinhTri.FocusedRowHandle, this.gcMaTrinhDoChinhTri);
            if(rowCelValues!=null)
            {
                frmCapNhatTrinhDoChinhTri form = new frmCapNhatTrinhDoChinhTri(DMTrinhDoChinhTriBLL.TruyVanTheoMa((short)rowCelValues), false);
                form.ShowDialog();
                FillDataGrid();
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ultils.XuatRaExcel(gcDMTrinhDoChinhTri);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCelValues = this.gvDMTrinhDoChinhTri.GetRowCellValue(this.gvDMTrinhDoChinhTri.FocusedRowHandle, this.gcMaTrinhDoChinhTri);
            if (rowCelValues != null)
            {
                if (UTL.Ultils.XacThucXoa("Trình độ chính trị"))
                {
                    DMTrinhDoChinhTriBLL.XoaTrinhDoChinhTri((short)rowCelValues);
                    FillDataGrid();
                }
            }
        }

        private void gcDMTrinhDoChinhTri_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }
    }
}