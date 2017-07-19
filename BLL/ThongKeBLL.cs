using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ThongKeBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void ThongKeTheoDiemThiTungMon(string maLop, string maHocKy, string maMonHoc, ref string[] tenHocLuc, ref int[] soLuongHocLuc, ref double[] phanTramHocLuc, ref int tongSo, bool theoDiemHocKy)
        {
            if (theoDiemHocKy == true)
            {                
                List<DMHocLucTheoDiemThi> HocLucTheoDiemThis = DB.DMHocLucTheoDiemThis.OrderBy(q => q.MucUuTien).ToList();
                string namHienTai = DSNamHocBLL.TruyVanNamHocHienTai();
                string maLoaiDiemHocKy = DB.DSLoaiDiems.Where(q => q.LaHocKy == true).Select(q => q.MaLoaiDiem).FirstOrDefault();
                string[] maHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLopKy(maLop, maHocKy);
                double?[] Diems = DB.DSDiems.Where(q => maHocSinhTheoLop.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiemHocKy).Select(q => q.Diem).ToArray();
                string[] maHocLuc = HocLucTheoDiemThis.Select(q => q.MaHocLuc).ToArray();
                tenHocLuc = HocLucTheoDiemThis.Select(q => q.TenHocLuc).ToArray();
                tongSo = Diems.Length;
                for (byte i = 0; i < maHocLuc.Length; i++)
                {
                    byte dem = 0;
                    for (int j = 0; j < tongSo; j++)
                        if ((Diems[j] >= HocLucTheoDiemThis[i].DiemMocDuoi) && (Diems[j] < HocLucTheoDiemThis[i].DiemMocTren))
                            dem++;
                    soLuongHocLuc[i] = dem;
                    phanTramHocLuc[i] = Math.Round((double)dem / tongSo, 3) * 100;
                }
                for (int i = maHocLuc.Length - 1; i >= 0; i--)
                {
                    if (phanTramHocLuc[i] > 0)
                    {
                        phanTramHocLuc[i] = 100;
                        for (int j = 0; j < i; j++)
                        {
                            phanTramHocLuc[i] -= phanTramHocLuc[j];
                        }
                        break;
                    }
                }
            }else
            {
                List<DMHocLuc> HocLucs = DB.DMHocLucs.OrderBy(q => q.MucUuTien).ToList();
                string namHienTai = DSNamHocBLL.TruyVanNamHocHienTai();
                string maLoaiDiemTBC = DB.DSLoaiDiems.Where(q => q.TongHop == true).Select(q => q.MaLoaiDiem).FirstOrDefault();
                string[] maHocSinhTheoLop = DSHocSinhTheoLopBLL.MaHocSinhTheoLopKy(maLop, maHocKy);
                double?[] Diems = DB.DSDiems.Where(q => maHocSinhTheoLop.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == maMonHoc && q.MaLoaiDiem == maLoaiDiemTBC).Select(q => q.Diem).ToArray();
                string[] maHocLuc = HocLucs.Select(q => q.MaHocLuc).ToArray();
                tenHocLuc = HocLucs.Select(q => q.TenHocLuc).ToArray();
                tongSo = Diems.Length;
                for (byte i = 0; i < maHocLuc.Length; i++)
                {
                    byte dem = 0;
                    for (int j = 0; j < tongSo; j++)
                        if ((Diems[j] >= HocLucs[i].DiemMocDuoi) && (Diems[j] < HocLucs[i].DiemMocTren))
                            dem++;
                    soLuongHocLuc[i] = dem;
                    phanTramHocLuc[i] = Math.Round((double)dem / tongSo, 3) * 100;
                }
                for (int i = maHocLuc.Length - 1; i >= 0; i--)
                {
                    if (phanTramHocLuc[i] > 0)
                    {
                        phanTramHocLuc[i] = 100;
                        for (int j = 0; j < i; j++)
                        {
                            phanTramHocLuc[i] -= phanTramHocLuc[j];
                        }
                        break;
                    }
                }
            }
            

        }

        public static DataTable ThongKeDiemHocKyTHCS(string maHocKy, bool laTHCS)
        {
            //Tạo bảng chứa dữ liệu
            DataTable tableTemp = new DataTable();
            DataColumn clTenMon = new DataColumn();
            clTenMon.ColumnName = "TenMon";
            tableTemp.Columns.Add(clTenMon);
            DataColumn clTongSo = new DataColumn();
            clTongSo.ColumnName = "TongSo";
            tableTemp.Columns.Add(clTongSo);
            List<DMHocLucTheoDiemThi> HocLucTheoDiemThis = DB.DMHocLucTheoDiemThis.OrderBy(q => q.MucUuTien).ToList();
            for (byte i = 0; i < HocLucTheoDiemThis.Count; i++)
            {
                DataColumn clTS = new DataColumn();
                clTS.ColumnName = HocLucTheoDiemThis[i].MaHocLuc + "TS";
                tableTemp.Columns.Add(clTS);
                DataColumn clPT = new DataColumn();
                clPT.ColumnName = HocLucTheoDiemThis[i].MaHocLuc + "PT";
                tableTemp.Columns.Add(clPT);
            }

            //Lấy dữ liệu vào bảng
            string maLoaiDiem = DSLoaiDiemBLL.LoadMaDiemHocKy();
            List<DSMonHoc> MonHocs;
            string[] maKhois;
            if (laTHCS)
            {
                MonHocs = DB.DSMonHocs.Where(q => q.ThuTuThongKeTHCS != 0).OrderBy(q => q.ThuTuThongKeTHCS).ToList();
                maKhois = DB.DSKhois.Where(q => q.MaCap == "CTHCS").Select(q => q.MaKhoi).ToArray();
            }else
            {
                MonHocs = DB.DSMonHocs.Where(q => q.ThuTuThongKeTHPT != 0).OrderBy(q => q.ThuTuThongKeTHCS).ToList();
                maKhois = DB.DSKhois.Where(q => q.MaCap == "CTHPT").Select(q => q.MaKhoi).ToArray();
            }
            
            string[] maLops = DB.DSLops.Where(q => maKhois.Contains(q.MaKhoi)).Select(q => q.MaLop).ToArray();
            
            //Lấy mã danh sách học sinh không thống kê
            string[] maDSHSKhongThongKe = DSHocSinhChuyenTruongBLL.LayMaHSKhongXet(maHocKy);

            string[] maHocSinhs = DB.DSHocSinhTheoLops.Where(q => maLops.Contains(q.MaLop) && !maDSHSKhongThongKe.Contains(q.MaHocSinh)).Select(q => q.MaHocSinh).ToArray();
            foreach (DSMonHoc MonHoc in MonHocs)
            {                
                double?[] Diems = DB.DSDiems.Where(q => maHocSinhs.Contains(q.MaHocSinh) && q.MaHocKy == maHocKy && q.MaMonHoc == MonHoc.MaMonHoc && q.MaLoaiDiem == maLoaiDiem).Select(q => q.Diem).ToArray();
                //Khai báo biến tổng hợp số lượng và phần trăm theo học lực
                int[] tongSoDiemTheoHocLuc = new int[HocLucTheoDiemThis.Count];
                double[] phanTramDiemTheoHocLuc = new double[HocLucTheoDiemThis.Count];
                for (byte i = 0; i < tongSoDiemTheoHocLuc.Length; i++)
                {
                    tongSoDiemTheoHocLuc[i] = 0;
                    phanTramDiemTheoHocLuc[i] = 0;
                }

                if (MonHoc.DSHinhThucDanhGia.TinhDiem == true)
                {
                    for (byte i = 0; i < HocLucTheoDiemThis.Count; i++)
                    {
                        foreach (double? Diem in Diems)
                            if ((Diem < HocLucTheoDiemThis[i].DiemMocTren) && (Diem >= HocLucTheoDiemThis[i].DiemMocDuoi))
                                tongSoDiemTheoHocLuc[i]++;
                        if (Diems.Length != 0)
                            phanTramDiemTheoHocLuc[i] = Math.Round((((double)tongSoDiemTheoHocLuc[i] / Diems.Length) * 100), 1, MidpointRounding.AwayFromZero);
                    }
                    for (int i = HocLucTheoDiemThis.Count - 1; i >= 0; i--)
                        if (phanTramDiemTheoHocLuc[i] > 0)
                        {
                            phanTramDiemTheoHocLuc[i] = 100;
                            for (byte j = 0; j < i; j++)
                                phanTramDiemTheoHocLuc[i] -= phanTramDiemTheoHocLuc[j];
                            phanTramDiemTheoHocLuc[i] = Math.Round(phanTramDiemTheoHocLuc[i], 1);
                            break;
                        }                    
                }
                else
                {
                    foreach (double? Diem in Diems)
                    {
                        if (Diem == -2)
                            tongSoDiemTheoHocLuc[0]++;
                        if (Diem == -3)
                            tongSoDiemTheoHocLuc[3]++;
                    }
                    if (Diems.Length != 0)
                    {
                        phanTramDiemTheoHocLuc[0] = Math.Round((((double)tongSoDiemTheoHocLuc[0] / Diems.Length) * 100), 1, MidpointRounding.AwayFromZero);
                        phanTramDiemTheoHocLuc[3] = Math.Round((100-phanTramDiemTheoHocLuc[0]),1);
                    }                        
                }
                //Thêm dữ liệu dòng vào bảng
                DataRow row = tableTemp.NewRow();
                row[0] = MonHoc.TenMonHoc;
                row[1] = Diems.Length;
                for (byte i = 0; i < HocLucTheoDiemThis.Count; i++)
                {
                    row[i * 2 + 2] = tongSoDiemTheoHocLuc[i];
                    row[i * 2 + 3] = phanTramDiemTheoHocLuc[i];
                }
                tableTemp.Rows.Add(row);
            }
            return tableTemp;

        }

        public static DataTable ThongKeTheoHocLucHanhKiem(string maHocKy, bool laTHCS)
        {
            DataTable tableTemp = new DataTable();
            DataColumn clDanhGiaHocSinh = new DataColumn();
            clDanhGiaHocSinh.ColumnName = "DanhGiaHocSinh";            
            DataColumn clTongSo = new DataColumn();
            clTongSo.ColumnName = "TongSo";           
            tableTemp.Columns.Add(clDanhGiaHocSinh);
            tableTemp.Columns.Add(clTongSo);
            string maCap;
            if (laTHCS)
            {
                maCap = "CTHCS";
                
            }else
            {
                maCap = "CTHPT";
            }
            List<DSKhoi> Khois = DB.DSKhois.Where(q => q.MaCap == maCap).OrderBy(q => q.TenKhoi).ToList();
            foreach (DSKhoi Khoi in Khois)
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = Khoi.TenKhoi;
                tableTemp.Columns.Add(cl);
            }
            DataColumn clMauNen = new DataColumn();
            clMauNen.ColumnName = "MauNen";
            tableTemp.Columns.Add(clMauNen);
            DataColumn clInDam = new DataColumn();
            clInDam.ColumnName = "InDam";
            tableTemp.Columns.Add(clInDam);

            //Lấy ds mã học sinh không thống kê do chuyển trường, thôi học
            string[] maDSHSKhongThongKe = DSHocSinhChuyenTruongBLL.LayMaHSKhongXet(maHocKy);

            //Lấy dữ liệu vào DataTable
            string[] maCacKhoi = Khois.Select(q => q.MaKhoi).ToArray();
            List<DSTongKetTheoKy> TongKetTheoKies = DB.DSTongKetTheoKies.Where(q => q.MaHocKy == maHocKy 
                            && maCacKhoi.Contains(q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi)
                            && !maDSHSKhongThongKe.Contains(q.MaHocSinh)).ToList();
            //Xử lý theo hạnh kiểm
            List<DMHanhKiem> HanhKiems = DB.DMHanhKiems.ToList();
            //Thêm dòng dữ liệu đầu tiên
            DataRow row = tableTemp.NewRow();
            row[0] = " Số học sinh chia theo hạnh kiểm";
            row[1] = TongKetTheoKies.Count;
            for(byte i = 0; i < Khois.Count; i++)
            {
                row[2 + i] = TongKetTheoKies.Where(q => q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
            }
            row["MauNen"] = "1";
            row["InDam"] = "1";
            tableTemp.Rows.Add(row);
            byte kt = 0;
            foreach (DMHanhKiem HanhKiem in HanhKiems)
            {
                //Thêm dòng thống kê theo hạnh kiểm
                row = tableTemp.NewRow();
                if (kt == 0)
                    row[0] = " Chia ra: - " + HanhKiem.TenHanhKiem;
                else
                    row[0] = "             - " + HanhKiem.TenHanhKiem;
                kt++;

                row[1] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "1";
                tableTemp.Rows.Add(row);

                //Thêm dòng thống kê hạnh kiểm theo nữ
                row = tableTemp.NewRow();
                row[0] = "              Trong TS:    + Nữ";
                row[1] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.GioiTinh == false).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.GioiTinh == false&& q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "0";
                tableTemp.Rows.Add(row);

                //Thêm dòng thống kê hạnh kiểm theo dân tộc
                row = tableTemp.NewRow();
                row[0] = "                                 + Dân tộc";
                row[1] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.DMDanToc.ThongKeDanToc == true).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.DMDanToc.ThongKeDanToc == true && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "0";
                tableTemp.Rows.Add(row);

                //Thêm dòng thống kê hạnh kiểm theo Nữ dân tộc
                row = tableTemp.NewRow();
                row[0] = "                                 + Nữ dân tộc";
                row[1] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.GioiTinh == false && q.DSHocSinh.DMDanToc.ThongKeDanToc == true).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHanhKiem == HanhKiem.MaHanhKiem && q.DSHocSinh.GioiTinh == false && q.DSHocSinh.DMDanToc.ThongKeDanToc == true && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "0";
                tableTemp.Rows.Add(row);
            }

            //Xử lý theo Học lực
            List<DMHocLuc> HocLucs = DB.DMHocLucs.ToList();
            //Thêm dòng dữ liệu đầu tiên
            row = tableTemp.NewRow();
            row[0] = " Số học sinh chia theo học lực";
            row[1] = TongKetTheoKies.Count;
            for (byte i = 0; i < Khois.Count; i++)
            {
                row[2 + i] = TongKetTheoKies.Where(q => q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
            }
            row["MauNen"] = "1";
            row["InDam"] = "1";
            tableTemp.Rows.Add(row);
            kt = 0;
            foreach (DMHocLuc HocLuc in HocLucs)
            {
                //Thêm dòng thống kê theo hạnh kiểm
                row = tableTemp.NewRow();
                if (kt == 0)
                    row[0] = " Chia ra: - " + HocLuc.TenHocLuc;
                else
                    row[0] = "             - " + HocLuc.TenHocLuc;
                kt++;

                row[1] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "1";
                tableTemp.Rows.Add(row);

                //Thêm dòng thống kê hạnh kiểm theo nữ
                row = tableTemp.NewRow();
                row[0] = "              Trong TS:    + Nữ";
                row[1] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.GioiTinh == false).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.GioiTinh == false && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "0";
                tableTemp.Rows.Add(row);

                //Thêm dòng thống kê hạnh kiểm theo dân tộc
                row = tableTemp.NewRow();
                row[0] = "                                 + Dân tộc";
                row[1] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.DMDanToc.ThongKeDanToc == true).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.DMDanToc.ThongKeDanToc == true && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "0";
                tableTemp.Rows.Add(row);

                //Thêm dòng thống kê hạnh kiểm theo Nữ dân tộc
                row = tableTemp.NewRow();
                row[0] = "                                 + Nữ dân tộc";
                row[1] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.GioiTinh == false && q.DSHocSinh.DMDanToc.ThongKeDanToc == true).Count();
                for (byte i = 0; i < Khois.Count; i++)
                {
                    row[2 + i] = TongKetTheoKies.Where(q => q.MaHocLuc == HocLuc.MaHocLuc && q.DSHocSinh.GioiTinh == false && q.DSHocSinh.DMDanToc.ThongKeDanToc == true && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khois[i].MaKhoi).Count();
                }
                row["MauNen"] = "0";
                row["InDam"] = "0";
                tableTemp.Rows.Add(row);
            }

            return tableTemp;

        }

        public static DataTable ThongKeTheoMonHoc(string maHocKy, bool laTHCS)
        {
            DataTable tableTemp = new DataTable();
            DataColumn clDanhGiaHocSinh = new DataColumn();
            clDanhGiaHocSinh.ColumnName = "MonHoc";
            DataColumn clTongSo = new DataColumn();
            clTongSo.ColumnName = "TongSo";
            tableTemp.Columns.Add(clDanhGiaHocSinh);
            tableTemp.Columns.Add(clTongSo);
            string maCap;
            if (laTHCS)
            {
                maCap = "CTHCS";

            }
            else
            {
                maCap = "CTHPT";
            }
            List<DSKhoi> Khois = DB.DSKhois.Where(q => q.MaCap == maCap).OrderBy(q => q.TenKhoi).ToList();
            foreach (DSKhoi Khoi in Khois)
            {
                DataColumn cl = new DataColumn();
                cl.ColumnName = Khoi.TenKhoi;
                tableTemp.Columns.Add(cl);
            }

            //Lấy ds mã học sinh không thống kê do chuyển trường
            string[] maDSHSKhongThongKe = DSHocSinhChuyenTruongBLL.LayMaHSKhongXet(maHocKy);

            string maLoaiDiem = DSLoaiDiemBLL.LoadMaDiemTongHop();
            List<DSDiem> Diems = DB.DSDiems.Where(q => q.MaHocKy == maHocKy && q.MaLoaiDiem == maLoaiDiem 
                                && q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.DSCap.MaCap == maCap
                                && !maDSHSKhongThongKe.Contains(q.MaHocSinh)).ToList();
            List<DSMonHoc> MonHocs;
            if (laTHCS == true)
                MonHocs = DB.DSMonHocTheoLops.Where(q => q.DSLop.DSKhoi.DSCap.MaCap == maCap).Select(q => q.DSMonHoc).OrderBy(q=>q.ThuTuThongKeTHCS).Distinct().ToList();
            else
                MonHocs = DB.DSMonHocTheoLops.Where(q => q.DSLop.DSKhoi.DSCap.MaCap == maCap).Select(q => q.DSMonHoc).OrderBy(q => q.ThuTuThongKeTHPT).Distinct().ToList();
            List<DMHocLuc> HocLucs = DB.DMHocLucs.OrderBy(q => q.MucUuTien).ToList();
            foreach(DSMonHoc MonHoc in MonHocs)
            {
                List<DSDiem> DiemTheoMons = Diems.Where(q => q.MaMonHoc == MonHoc.MaMonHoc).ToList();
                DataRow row = tableTemp.NewRow();
                row[0] = " " + MonHoc.TenMonHoc;
                row[1] = DiemTheoMons.Count();
                byte i = 0;
                foreach(DSKhoi Khoi in Khois)
                {
                    row[2 + i] = DiemTheoMons.Where(q =>q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                    i++;
                }                
                tableTemp.Rows.Add(row);
                //Tạo dữ liệu cho các dòng theo học lực
                if (MonHoc.DSHinhThucDanhGia.TinhDiem == true)
                {
                    i = 0;
                    foreach (DMHocLuc HocLuc in HocLucs)
                    {
                        List<DSDiem> DiemTheoMonHocLucs = DiemTheoMons.Where(q => q.Diem >= HocLuc.DiemMocDuoi && q.Diem < HocLuc.DiemMocTren).ToList();
                        row = tableTemp.NewRow();
                        if (i == 0)
                            row[0] = "   Chia ra: - " + HocLuc.TenHocLuc;
                        else
                            row[0] = "               - " + HocLuc.TenHocLuc;
                        row[1] = DiemTheoMonHocLucs.Count();
                        byte j = 0;
                        foreach (DSKhoi Khoi in Khois)
                        {
                            row[2 + j] = DiemTheoMonHocLucs.Where(q => q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                            j++;
                        }
                        i++;
                        tableTemp.Rows.Add(row);
                    }
                }else
                {
                    //Đếm điểm theo môn đánh giá bằng nhận xét
                    //Đếm điểm đạt
                    row = tableTemp.NewRow();                    
                    row[0] = "   Chia ra: - Đạt";
                    List<DSDiem> DiemTheoMonDats = DiemTheoMons.Where(q => q.Diem == -2).ToList();                                      
                    row[1] = DiemTheoMonDats.Count();
                    byte j = 0;
                    foreach (DSKhoi Khoi in Khois)
                    {
                        row[2 + j] = DiemTheoMonDats.Where(q => q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                        j++;
                    }
                    tableTemp.Rows.Add(row);
                    row = tableTemp.NewRow();

                    //Đếm điểm chưa đạt
                    row[0] = "               - Chưa đạt";
                    List<DSDiem> DiemTheoMonChuaDats = DiemTheoMons.Where(q => q.Diem == -3).ToList();
                    row[1] = DiemTheoMonChuaDats.Count();
                    j = 0;
                    foreach (DSKhoi Khoi in Khois)
                    {
                        row[2 + j] = DiemTheoMonChuaDats.Where(q => q.DSHocSinh.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                        j++;
                    }
                    tableTemp.Rows.Add(row);
                }
                
            }

            return tableTemp;

        }

        public static DataTable ThongKeTheoDanToc(string maHocKy, bool laTHCS)
        {
            DataTable tableTemp = new DataTable();

            DataColumn clDanToc = new DataColumn();
            clDanToc.ColumnName = "DanToc";
            tableTemp.Columns.Add(clDanToc);
            DataColumn clTongSo = new DataColumn();
            clTongSo.ColumnName = "TongSo";
            tableTemp.Columns.Add(clTongSo);
            DataColumn clNu = new DataColumn();
            clNu.ColumnName = "Nu";
            tableTemp.Columns.Add(clNu);            
            string maCap = "";
            if (laTHCS == true)
                maCap = "CTHCS";
            else
                maCap = "CTHPT";
            List<DSKhoi> Khois = DSKhoiBLL.LayKhoiTheoMaCap(maCap);
            foreach (DSKhoi Khoi in Khois)
            {
                DataColumn clTS = new DataColumn();
                clTS.ColumnName = "TS" + Khoi.TenKhoi;
                tableTemp.Columns.Add(clTS);
                DataColumn clPT = new DataColumn();
                clPT.ColumnName = "Nu" + Khoi.TenKhoi;
                tableTemp.Columns.Add(clPT);
            }            
            List<DMDanToc> DanTocs = DB.DMDanTocs.Where(q=>q.ThongKeDanToc == true).ToList();

            //Lấy mã ds học sinh không thống kê do chuyển trường hoặc thôi học
            string[] maDSHSKhongThongKe = DSHocSinhChuyenTruongBLL.LayMaHSKhongXet(maHocKy);

            List<DSHocSinh> HocSinhDanTocs = DB.DSHocSinhTheoLops.Where(q => q.DSLop.DSKhoi.DSCap.MaCap == maCap 
                            && q.DSHocSinh.DMDanToc.ThongKeDanToc == true
                            && !maDSHSKhongThongKe.Contains(q.MaHocSinh)).Select(q => q.DSHocSinh).ToList();
            //Thêm dòng tổng số
            DataRow row = tableTemp.NewRow();
            row[0] = " Tổng số";
            row[1] = HocSinhDanTocs.Count;
            row[2] = HocSinhDanTocs.Where(q => q.GioiTinh == false).Count();
            byte i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[3 + i] = HocSinhDanTocs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                row[4 + i] = HocSinhDanTocs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi && q.GioiTinh == false).Count();
                i += 2;
            }
            tableTemp.Rows.Add(row);
            byte j = 0;
            foreach (DMDanToc DanToc in DanTocs)
            {                
                List<DSHocSinh> HocSinhDanTocTheoDanTocs = HocSinhDanTocs.Where(q => q.MaDanToc == DanToc.MaDanToc).ToList();
                row = tableTemp.NewRow();
                if (j == 0)
                    row[0] = " Chia ra: " + DanToc.TenDanToc;
                else
                    row[0] = "              " + DanToc.TenDanToc;
                row[1] = HocSinhDanTocTheoDanTocs.Count;
                row[2] = HocSinhDanTocTheoDanTocs.Where(q => q.GioiTinh == false).Count();
                i = 0;
                foreach(DSKhoi Khoi in Khois)
                {
                    row[3 + i] = HocSinhDanTocTheoDanTocs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                    row[4 + i] = HocSinhDanTocTheoDanTocs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi && q.GioiTinh == false).Count();
                    i += 2;
                }
                tableTemp.Rows.Add(row);
                j++;
            }
            
            return tableTemp;
        }

        public static DataTable ThongKeTheoDoTuoi(string maHocKy, bool laTHCS)
        {
            DataTable tableTemp = new DataTable();
            DataColumn clHocSinh = new DataColumn();
            clHocSinh.ColumnName = "HocSinh";
            tableTemp.Columns.Add(clHocSinh);
            DataColumn clTongSo = new DataColumn();
            clTongSo.ColumnName = "TongSo";
            tableTemp.Columns.Add(clTongSo);

            string maCap = "CTHPT";
            if (laTHCS == true)
                maCap = "CTHCS";
            List<DSKhoi> Khois = DSKhoiBLL.LayKhoiTheoMaCap(maCap);
            foreach(DSKhoi Khoi in Khois)
            {
                DataColumn clKhoi = new DataColumn();
                clKhoi.ColumnName = Khoi.TenKhoi;
                tableTemp.Columns.Add(clKhoi);
            }

            //Lấy mã ds học sinh không thống kê do chuyển trường hoặc thôi học
            string[] maDSHSKhongThongKe = DSHocSinhChuyenTruongBLL.LayMaHSKhongXet(maHocKy);

            List<DSHocSinh> HocSinhs = DB.DSHocSinhTheoLops.Where(q => q.DSLop.DSKhoi.DSCap.MaCap == maCap
                                            && !maDSHSKhongThongKe.Contains(q.MaHocSinh)).Select(q=>q.DSHocSinh).ToList();

            //Thêm dòng đầu tiên
            DataRow row = tableTemp.NewRow();
            row[0] = " Tổng số học sinh";
            row[1] = HocSinhs.Count;
            byte i = 0;
            foreach(DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm dòng thống kê theo nữ
            row = tableTemp.NewRow();
            row[0] = " Trong TS: + Nữ";
            row[1] = HocSinhs.Where(q => q.GioiTinh == false).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => q.GioiTinh == false && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm dòng thống kê theo dân tộc
            row = tableTemp.NewRow();
            row[0] = "                 + Dân tộc";
            row[1] = HocSinhs.Where(q => q.DMDanToc.ThongKeDanToc == true).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => q.DMDanToc.ThongKeDanToc == true && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm dòng thống kê theo Nữ dân tộc
            row = tableTemp.NewRow();
            row[0] = "                 + Nữ dân tộc";
            row[1] = HocSinhs.Where(q => q.GioiTinh == false && q.DMDanToc.ThongKeDanToc == true).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => q.GioiTinh == false && q.DMDanToc.ThongKeDanToc == true && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            int[] doTuoi;
            if (laTHCS == true)
                doTuoi = new int[] { 11, 12, 13, 14 };
            else
                doTuoi = new int[] { 15, 16, 17 };
            int namNay = DateTime.Now.Year;

            //Thống kê Số học sinh theo độ tuổi
            //Dòng đầu tiên:
            row = tableTemp.NewRow();
            row[0] = " Số học sinh theo độ tuổi";
            row[1] = HocSinhs.Count;
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm dòng dưới ? tuổi
            row = tableTemp.NewRow();
            row[0] = " Chia ra: - Dưới " + doTuoi[0] + " tuổi";
            row[1] = HocSinhs.Where(q=> namNay - DateTime.Parse(q.NgaySinh.ToString()).Year < doTuoi[0]).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year < doTuoi[0] && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm các dòng bằng tuổi
            for (byte j = 0; j < doTuoi.Length; j++)
            {
                row = tableTemp.NewRow();
                row[0] = "              - " + doTuoi[j] + " tuổi";
                row[1] = HocSinhs.Where(q => (namNay - DateTime.Parse(q.NgaySinh.ToString()).Year) == doTuoi[j]).Count();
                i = 0;
                foreach (DSKhoi Khoi in Khois)
                {
                    row[2 + i] = HocSinhs.Where(q => ((namNay - DateTime.Parse(q.NgaySinh.ToString()).Year) == doTuoi[j]) && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                    i++;
                }
                tableTemp.Rows.Add(row);
            }

            //Thêm dòng trên ? tuổi
            row = tableTemp.NewRow();
            row[0] = "              - Trên " + doTuoi[doTuoi.Length-1] + " tuổi";
            row[1] = HocSinhs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year > doTuoi[doTuoi.Length - 1]).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year > doTuoi[doTuoi.Length - 1] && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);


            //Thống kê học sinh Nữ theo độ tuổi
            //Dòng đầu tiên:
            List<DSHocSinh> HocSinhNus = HocSinhs.Where(q => q.GioiTinh == false).ToList();

            row = tableTemp.NewRow();
            row[0] = " Số học sinh Nữ theo độ tuổi";
            row[1] = HocSinhNus.Count;
            i = 0;            
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhNus.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm dòng dưới ? tuổi
            row = tableTemp.NewRow();
            row[0] = " Chia ra: - Dưới " + doTuoi[0] + " tuổi";
            row[1] = HocSinhNus.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year < doTuoi[0]).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhNus.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year < doTuoi[0] && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm các dòng bằng tuổi
            for (byte j = 0; j < doTuoi.Length; j++)
            {
                row = tableTemp.NewRow();
                row[0] = "              - " + doTuoi[j] + " tuổi";
                row[1] = HocSinhNus.Where(q => (namNay - DateTime.Parse(q.NgaySinh.ToString()).Year) == doTuoi[j]).Count();
                i = 0;
                foreach (DSKhoi Khoi in Khois)
                {
                    row[2 + i] = HocSinhNus.Where(q => ((namNay - DateTime.Parse(q.NgaySinh.ToString()).Year) == doTuoi[j]) && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                    i++;
                }
                tableTemp.Rows.Add(row);
            }

            //Thêm dòng trên ? tuổi
            row = tableTemp.NewRow();
            row[0] = "              - Trên " + doTuoi[doTuoi.Length - 1] + " tuổi";
            row[1] = HocSinhNus.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year > doTuoi[doTuoi.Length - 1]).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhNus.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year > doTuoi[doTuoi.Length - 1] && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thống kê học sinh Dân tộc theo độ tuổi
            //Dòng đầu tiên:
            row = tableTemp.NewRow();
            row[0] = " Số học sinh Dân tộc theo độ tuổi";
            List<DSHocSinh> HocSinhDanTocs = HocSinhs.Where(q => q.DMDanToc.ThongKeDanToc == true).ToList();
            row[1] = HocSinhDanTocs.Count;
            i = 0;            
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhDanTocs.Where(q => q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm dòng dưới ? tuổi
            row = tableTemp.NewRow();
            row[0] = " Chia ra: - Dưới " + doTuoi[0] + " tuổi";
            row[1] = HocSinhDanTocs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year < doTuoi[0]).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhDanTocs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year < doTuoi[0] && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            //Thêm các dòng bằng tuổi
            for (byte j = 0; j < doTuoi.Length; j++)
            {
                row = tableTemp.NewRow();
                row[0] = "              - " + doTuoi[j] + " tuổi";
                row[1] = HocSinhDanTocs.Where(q => (namNay - DateTime.Parse(q.NgaySinh.ToString()).Year) == doTuoi[j]).Count();
                i = 0;
                foreach (DSKhoi Khoi in Khois)
                {
                    row[2 + i] = HocSinhDanTocs.Where(q => ((namNay - DateTime.Parse(q.NgaySinh.ToString()).Year) == doTuoi[j]) && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                    i++;
                }
                tableTemp.Rows.Add(row);
            }

            //Thêm dòng trên ? tuổi
            row = tableTemp.NewRow();
            row[0] = "              - Trên " + doTuoi[doTuoi.Length - 1] + " tuổi";
            row[1] = HocSinhDanTocs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year > doTuoi[doTuoi.Length - 1]).Count();
            i = 0;
            foreach (DSKhoi Khoi in Khois)
            {
                row[2 + i] = HocSinhDanTocs.Where(q => namNay - DateTime.Parse(q.NgaySinh.ToString()).Year > doTuoi[doTuoi.Length - 1] && q.DSHocSinhTheoLop.DSLop.DSKhoi.MaKhoi == Khoi.MaKhoi).Count();
                i++;
            }
            tableTemp.Rows.Add(row);

            return tableTemp;
        }
    }
}
