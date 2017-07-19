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
    public partial class frmDMChung : DevExpress.XtraEditors.XtraForm
    {
        string TenBang;
        public frmDMChung(string tenBang)
        {
            InitializeComponent();
            TenBang = tenBang;
            LoadForm();
            FillDataToGrid();
        }

        private void LoadForm()
        {
            switch (TenBang)
            {
                case "DMTrinhDoTinHoc":
                    this.Text = "Danh mục Trình độ Tin học";
                    gcMaChung.FieldName = "MaTrinhDoTinHoc";
                    gcMaChung.Caption = "Mã Trình độ Tin học";
                    gcTenChung.FieldName = "TenTrinhDoTinHoc";
                    gcTenChung.Caption = "Tên Trình độ Tin học";
                    break;
                case "DMTrinhDoNgoaiNgu":
                    this.Text = "Danh mục Trình độ Ngoại ngữ";
                    gcMaChung.FieldName = "MaTrinhDoNgoaiNgu";
                    gcMaChung.Caption = "Mã Trình độ Ngoại ngữ";
                    gcTenChung.FieldName = "TenTrinhDoNgoaiNgu";
                    gcTenChung.Caption = "Tên Trình độ Ngoại ngữ";
                    break;
            }
        }

        private void FillDataToGrid()
        {
            switch (TenBang)
            {
                case "DMTrinhDoTinHoc": 
                    gcDMChung.DataSource = DMTrinhDoTinHocBLL.LoadAll();
                    break;
                case "DMTrinhDoNgoaiNgu":
                    gcDMChung.DataSource = DMTrinhDoNgoaiNguBLL.LoadAll();
                    break;
            }
        }        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatChung form = new frmCapNhatChung (TenBang, 0, true );
            form.ShowDialog();
            FillDataToGrid();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDMChung.GetRowCellValue(this.gvDMChung.FocusedRowHandle, this.gcMaChung);
            if (rowCellValue != null)
            {
                frmCapNhatChung form = new frmCapNhatChung(TenBang, (short)rowCellValue, false);
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
            object rowCellValue = this.gvDMChung.GetRowCellValue(this.gvDMChung.FocusedRowHandle, this.gcMaChung);
            string messenger = null;
            switch (TenBang)
            {
                case "DMTrinhDoTinHoc":
                    messenger = "Trình độ Tin học";
                    break;
                case "DMTrinhDoNgoaiNgu":
                    messenger = "Trình độ Ngoại ngữ";
                    break;
            }        
            if (rowCellValue != null)
            {
                if (UTL.Ultils.XacThucXoa(messenger))
                {
                    switch (TenBang)
                    {
                        case "DMTrinhDoTinHoc":
                            DMTrinhDoTinHocBLL.XoaTrinhDoTinHoc((short)rowCellValue);
                            break;
                        case "DMTrinhDoNgoaiNgu":
                            DMTrinhDoNgoaiNguBLL.XoaTrinhDoNgoaiNgu((short)rowCellValue);
                            break;
                    }                    
                    FillDataToGrid();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ultils.XuatRaExcel(gcDMChung);
        }

        private void gcDMChung_DoubleClick(object sender, EventArgs e)
        {
            this.btnSua_ItemClick(null, null);
        }
    }
}