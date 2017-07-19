using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PRL
{
    public partial class frmKhoiTaoDuLieu : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiTaoDuLieu()
        {
            InitializeComponent();
        }

        private void btnKhoiTaoDuLieu_Click(object sender, EventArgs e)
        {
            pgbTongTienTrinh.Properties.Minimum = 1;
            pgbTongTienTrinh.Properties.Maximum = 3;
            pgbTongTienTrinh.Properties.PercentView = true;            

            DialogResult result = MessageBox.Show("Bạn có chắc chắn đã nhập đầy đủ thông tin ở các mục: " +
            "Học sinh, Phân lớp, Phân môn học theo lớp, Giáo viên, Phân công giảng dạy chưa. " +
            "Nếu đã chắc chắn hãy chọn Yes để tiếp tục tiến trình. Tác vụ này có thể diễn ra trong thời gian " +
            "khoảng vài phút. Hãy vui lòng đợi!", UTL.Params.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string maHocKy = cbHocKy.SelectedValue.ToString();
            if (result == DialogResult.Yes)
            {                
                DSDiemBLL.KhoiTaoDuLieuDiem(maHocKy, ref pgbTienTrinhCon);
                pgbTongTienTrinh.PerformStep();
                pgbTongTienTrinh.Update();
                DSTongKetTheoKyBLL.TaoDuLieu(maHocKy, ref pgbTienTrinhCon);
                pgbTongTienTrinh.PerformStep();
                pgbTongTienTrinh.Update();
                PhanCongGiangDayBLL.KhoiTaoDuLieu(maHocKy, ref pgbTienTrinhCon);
                pgbTongTienTrinh.PerformStep();
                pgbTongTienTrinh.Update();
            }
        }

        private void frmKhoiTaoDuLieu_Load(object sender, EventArgs e)
        {
            cbHocKy.DataSource = DSHocKyBLL.LayHocKyHocTap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
            List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaHocKy == "K1" && q.MaLoaiDiem == "LD5").ToList();
            foreach (DSDiem DiemCon in Diems)
            {
                DSDiem Diem = new DSDiem();
                Diem.MaHocSinh = DiemCon.MaHocSinh;
                Diem.MaHocKy = "K3";
                Diem.MaLoaiDiem = DiemCon.MaLoaiDiem;
                Diem.MaMonHoc = DiemCon.MaMonHoc;
                Diem.MaNamHoc = DiemCon.MaNamHoc;
                Diem.STTDiem = 1;
                Diem.Diem = -1;
                Diem.ChoPhepDang = false;
                if (DSDiemBLL.TimKhoaTrung(Diem.MaHocSinh, Diem.MaHocKy, Diem.MaMonHoc, Diem.MaLoaiDiem, Diem.STTDiem))
                    DB.DSDiems.InsertOnSubmit(Diem);
                //DB.SubmitChanges();
            }
            DB.SubmitChanges();
        }
    }
}
