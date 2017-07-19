using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class KhoaSoBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void KhoaSo()
        {
            if (KiemTraDieuKienKhoaSo())
            {
                ////Copy dữ liệu từ bảng DSLop sang bảng DSLopCu
                //List<DSLop> Lops = DB.DSLops.ToList();
                //foreach (DSLop Lop in Lops)
                //{
                //    DSLopCu LopCu = new DSLopCu();
                //    LopCu.MaLop = Lop.MaLop;
                //    LopCu.TenLop = Lop.TenLop;
                //    LopCu.MaGVCN = Lop.MaGVCN;
                //    LopCu.MaNamHoc = Lop.MaNamHoc;
                //    LopCu.MaKhoi = Lop.MaKhoi;
                //    DB.DSLopCus.InsertOnSubmit(LopCu);
                //}
                //DB.SubmitChanges();

                ////Copy dữ liệu từ bảng DSHocSinhTheoLops sang bảng DSHocSinhTheoLopCu
                //List<DSHocSinhTheoLop> HocSinhTheoLops = DB.DSHocSinhTheoLops.ToList();
                //foreach (DSHocSinhTheoLop HocSinhTheoLop in HocSinhTheoLops)
                //{
                //    DSHocSinhTheoLopCu HocSinhTheoLopCu = new DSHocSinhTheoLopCu();
                //    HocSinhTheoLopCu.MaHocSinh = HocSinhTheoLop.MaHocSinh;
                //    HocSinhTheoLopCu.MaNamHoc = HocSinhTheoLop.MaNamHoc;
                //    HocSinhTheoLopCu.MaLop = HocSinhTheoLop.MaLop;
                //    HocSinhTheoLopCu.STT = HocSinhTheoLop.STT;
                //    DB.DSHocSinhTheoLopCus.InsertOnSubmit(HocSinhTheoLopCu);
                //}
                //DB.SubmitChanges();

                ////Copy dữ liệu từ bảng DSMonHocTheoLop sang bảng DSMonHocTheoLopCu
                //List<DSMonHocTheoLop> MonHocTheoLops = DB.DSMonHocTheoLops.ToList();
                //foreach (DSMonHocTheoLop MonHocTheoLop in MonHocTheoLops)
                //{
                //    DSMonHocTheoLopCu MonHocTheoLopCu = new DSMonHocTheoLopCu();
                //    MonHocTheoLopCu.MaNamHoc = MonHocTheoLop.MaNamHoc;
                //    MonHocTheoLopCu.MaLop = MonHocTheoLop.MaLop;
                //    MonHocTheoLopCu.MaMonHoc = MonHocTheoLop.MaMonHoc;
                //    MonHocTheoLopCu.MaHocKy = MonHocTheoLop.MaHocKy;
                //    MonHocTheoLopCu.MaGiaoVien = MonHocTheoLop.MaGiaoVien;
                //    DB.DSMonHocTheoLopCus.InsertOnSubmit(MonHocTheoLopCu);
                //}
                //DB.SubmitChanges();

                ////Copy dữ liệu từ bảng DSTongKetTheoKy sang bảng DSTongKetTheoKyCu
                //List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.ToList();
                //foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                //{
                //    DSTongKetTheoKyCu TongKetTheoKyCu = new DSTongKetTheoKyCu();
                //    TongKetTheoKyCu.MaNamHoc = TongKetTheoKy.MaNamHoc;
                //    TongKetTheoKyCu.MaHocKy = TongKetTheoKy.MaHocKy;
                //    TongKetTheoKyCu.MaHocSinh = TongKetTheoKy.MaHocSinh;
                //    TongKetTheoKyCu.TrungBinhChung = TongKetTheoKy.TrungBinhChung;
                //    TongKetTheoKyCu.MaHanhKiem = TongKetTheoKy.MaHanhKiem;
                //    TongKetTheoKyCu.MaDanhHieu = TongKetTheoKy.MaDanhHieu;
                //    TongKetTheoKyCu.MaHocLuc = TongKetTheoKy.MaHocLuc;
                //    TongKetTheoKyCu.MaLenLop = TongKetTheoKy.MaLenLop;
                //    TongKetTheoKyCu.SoBuoiNghi = TongKetTheoKy.SoBuoiNghi;
                //    DB.DSTongKetTheoKyCus.InsertOnSubmit(TongKetTheoKyCu);
                //}
                //DB.SubmitChanges();

                ////Copy dữ liệu từ bảng DSDiem sang bảng DSDiemCu
                //List<DSDiem> Diems = DB.DSDiems.ToList();
                //foreach (DSDiem Diem in Diems)
                //{
                //    DSDiemCu DiemCu = new DSDiemCu();
                //    DiemCu.MaHocSinh = Diem.MaHocSinh;
                //    DiemCu.MaNamHoc = Diem.MaNamHoc;
                //    DiemCu.MaHocKy = Diem.MaHocKy;
                //    DiemCu.MaMonHoc = Diem.MaMonHoc;
                //    DiemCu.MaLoaiDiem = Diem.MaLoaiDiem;
                //    DiemCu.STTDiem = Diem.STTDiem;
                //    DiemCu.Diem = Diem.Diem;
                //    DiemCu.NgayCapNhat = Diem.NgayCapNhat;
                //    DiemCu.NgayChinhSua = Diem.NgayChinhSua;
                //    DiemCu.ChoPhepDang = Diem.ChoPhepDang;
                //    DB.DSDiemCus.InsertOnSubmit(DiemCu);
                //}
                //DB.SubmitChanges();

                ////Copy dữ liệu từ bảng PhanCongGiangDay sang bảng PhanCongGiangDayCu
                //List<PhanCongGiangDay> PhanCongGiangDays = DB.PhanCongGiangDays.ToList();
                //foreach (PhanCongGiangDay PhanCongGiangDay in PhanCongGiangDays)
                //{
                //    PhanCongGiangDayCu PhanCongGiangDayCu = new PhanCongGiangDayCu();
                //    PhanCongGiangDayCu.MaNamHoc = PhanCongGiangDay.MaNamHoc;
                //    PhanCongGiangDayCu.MaHocKy = PhanCongGiangDay.MaHocKy;
                //    PhanCongGiangDayCu.MaGiaoVien = PhanCongGiangDay.MaGiaoVien;
                //    PhanCongGiangDayCu.MaMonHoc = PhanCongGiangDay.MaMonHoc;
                //    PhanCongGiangDayCu.MaLop = PhanCongGiangDay.MaLop;
                //    DB.PhanCongGiangDayCus.InsertOnSubmit(PhanCongGiangDayCu);
                //}
                //DB.SubmitChanges();
                //Copy dữ liệu từ bảng DSHocSinh sang bảng DSHocSinhCu
                List<DSHocSinh> DSHocSinhs = DB.DSHocSinhs.Where(q => q.DaQuaLop == 12).ToList();
                foreach (DSHocSinh HocSinh in DSHocSinhs)
                {
                    DSHocSinhCu HocSinhCu = new DSHocSinhCu();
                    HocSinhCu.MaHocSinh = HocSinh.MaHocSinh;
                    HocSinhCu.HoDem = HocSinh.HoDem;
                    HocSinhCu.Ten = HocSinh.Ten;
                    HocSinhCu.TenThuongGoi = HocSinh.TenThuongGoi;
                    HocSinhCu.DaQuaLop = HocSinh.DaQuaLop;
                    HocSinhCu.NgaySinh = HocSinh.NgaySinh;
                    HocSinhCu.GioiTinh = HocSinh.GioiTinh;
                    HocSinhCu.NoiSinh = HocSinh.NoiSinh;
                    HocSinhCu.QueQuan = HocSinh.QueQuan;
                    HocSinhCu.HoTenBo = HocSinh.HoTenBo;
                    HocSinhCu.NgheNghiepBo = HocSinh.NgheNghiepBo;
                    HocSinhCu.HoTenMe = HocSinh.HoTenMe;
                    HocSinhCu.NgheNghiepMe = HocSinh.NgheNghiepMe;
                    HocSinhCu.Anh = HocSinh.Anh;
                    HocSinhCu.MaDanToc = HocSinh.MaDanToc;
                    HocSinhCu.MaTonGiao = HocSinh.MaTonGiao;
                    HocSinhCu.MaTinhTrangSucKhoe = HocSinh.MaTinhTrangSucKhoe;
                    HocSinhCu.NgayVaoDoan = HocSinh.NgayVaoDoan;
                    HocSinhCu.NoiVaoDoan = HocSinh.NoiVaoDoan;
                    HocSinhCu.MatKhau = HocSinh.MatKhau;
                    HocSinhCu.EmailPhuHuynh = HocSinh.EmailPhuHuynh;
                    HocSinhCu.SoDienThoaiPhuHuynh = HocSinh.SoDienThoaiPhuHuynh;
                    HocSinhCu.DangKyDichVu = HocSinh.DangKyDichVu;
                    DB.DSHocSinhCus.InsertOnSubmit(HocSinhCu);
                }
                DB.SubmitChanges();

                //Xóa dữ liệu trong các bảng trên
                DB.ExecuteCommand("Delete From PhanCongGiangDay");
                DB.ExecuteCommand("Delete From DSHocSinhTheoLop");
                DB.ExecuteCommand("Delete From DSMonHocTheoLop");
                DB.ExecuteCommand("Delete From DSTongKetTheoKy");
                DB.ExecuteCommand("Delete From DSDiem");
                DB.ExecuteCommand("Delete From DSLop");
                DB.ExecuteCommand("Delete From DSHocSinh Where DaQuaLop = 12");
                DB.SubmitChanges();
            }else
            {
                UTL.Ultils.ThongBao("Chức năng Khóa sổ chỉ thực hiện được sau khi thực hiện chức năng Xét lên lớp. " +
                                    "Vui lòng Xét lên lớp trước khi thực hiện chức năng này.", System.Windows.Forms.MessageBoxIcon.Error);
            }            
        }

        public static bool XacThuc(string matKhau)
        {
            string str = DB.KhoaSos.Select(q => q.MatKhau).First();
            UTL.Ultils.ThongBao(UTL.Ultils.Decrypt(str, "CVA"), System.Windows.Forms.MessageBoxIcon.Error);
            if (UTL.Ultils.Decrypt(str, "CVA") == matKhau)
                return true;
            else
                return false;
        }

        public static bool KiemTraDieuKienKhoaSo()
        {
            string maHocKy = DSHocKyBLL.MaHocKyTongHop();
            string[] MaHocSinhChuyenTruong = DB.DSHocSinhChuyenTruongs.Where(q => q.ChuyenDi == true).Select(q => q.MaHocSinh).ToArray();
            string[] MaHocSinhThoiHoc = DB.DSHocSinhThoiHocs.Select(q => q.MaHocSinh).ToArray();
            List<DSTongKetTheoKy> TongKetTheoKies = DSTongKetTheoKyBLL.LoadAll(maHocKy).Where(q=>!MaHocSinhChuyenTruong.Contains(q.MaHocSinh) && !MaHocSinhThoiHoc.Contains(q.MaHocSinh)).ToList();
            if (TongKetTheoKies.Count > 0)
                foreach (DSTongKetTheoKy TongKetTheoKy in TongKetTheoKies)
                {
                    if (TongKetTheoKy.MaLenLop == null)
                        return false;
                }
            else
                return false;
            return true;
        }
    }
}
