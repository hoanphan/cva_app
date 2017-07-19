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
    public partial class frmXetCacTieuChuanToanTruong : DevExpress.XtraEditors.XtraForm
    {
        public frmXetCacTieuChuanToanTruong()
        {
            InitializeComponent();
            cbHocKy.DataSource = DSHocKyBLL.LoadAll();
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {            
            lbLop.DataSource = DSLopBLL.LayMaTatCaCacLop();
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            lbLop.CheckAll();                
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            lbLop.UnCheckAll();
        }

        private void btnTinhTBC_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string[] tenLops = new string[lbLop.CheckedItems.Count];
            if (lbLop.CheckedItems.Count > 0)
            {
                splashScreenManager.ShowWaitForm();
                for (byte i = 0; i < lbLop.CheckedItems.Count; i++)
                {
                    tenLops[i] = lbLop.CheckedItems[i].ToString();
                }
                DSTongKetTheoKyBLL.TinhDiemTBCTheoDSLop(maHocKy, tenLops);
                splashScreenManager.CloseWaitForm();
            }            
        }

        private void btnXetHocLuc_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();            
            string[] tenLops = new string[lbLop.CheckedItems.Count];
            if (lbLop.CheckedItems.Count > 0)
            {
                splashScreenManager.ShowWaitForm();
                for (byte i = 0; i < lbLop.CheckedItems.Count; i++)
                {
                    tenLops[i] = lbLop.CheckedItems[i].ToString();
                }
                DSTongKetTheoKyBLL.XetHocLucTheoDSLop(maHocKy, tenLops);
                splashScreenManager.CloseWaitForm();
            }
        }

        private void btnXetDanhHieu_Click(object sender, EventArgs e)
        {
            string maHocKy = cbHocKy.SelectedValue.ToString();
            string[] tenLops = new string[lbLop.CheckedItems.Count];
            if (lbLop.CheckedItems.Count > 0)
            {
                splashScreenManager.ShowWaitForm();
                for (byte i = 0; i < lbLop.CheckedItems.Count; i++)
                {
                    tenLops[i] = lbLop.CheckedItems[i].ToString();
                }
                DSTongKetTheoKyBLL.XetDanhHieuTheoDSLop(maHocKy, tenLops);
                splashScreenManager.CloseWaitForm();
            }
        }
    }
}