using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PRL
{
    public partial class frmKhoaSo : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoaSo()
        {
            InitializeComponent();
        }

        private void frmKhoaSo_Load(object sender, EventArgs e)
        {
            cbHocKy.DataSource = DSHocKyBLL.LayHocKyHocTap();
        }

        private void btnKhoaSoDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn khóa sổ dữ liệu?"
                , UTL.Params.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (result == DialogResult.Yes)
            {
                DSDiemBLL.KhoaSoDuLieu(maHocKy);
            }
        }

        private void btnMoKhoaSoDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn mở khóa sổ dữ liệu?"
                , UTL.Params.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (result == DialogResult.Yes)
            {
                DSDiemBLL.MoKhoaSoDuLieu(maHocKy);
            }
        }
    }
}
