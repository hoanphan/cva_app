using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.IO.Ports;
using System.Threading;

namespace BLL
{
    public class DSSMSAutoSendBLL
    {
        static mCore.SMS objSMS = new mCore.SMS();
        static SerialPort port = new SerialPort();
        static SMSClass objclsSMS = new SMSClass();
        static ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();

        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());        

        public static string GuiTinNhanDauTien(SerialPort port, SMSClass objclsSMS)
        {
            DSSMSAutoSend SMS = DB.DSSMSAutoSends.FirstOrDefault();            
            if (SMS != null)
            {
                string SoDT = SMS.SoDienThoaiNhan;            
                objclsSMS.SendMsg(port, SMS.SoDienThoaiNhan, SMS.NoiDungSMS);
                DB.DSSMSAutoSends.DeleteOnSubmit(SMS);
                DB.SubmitChanges();
                return SoDT;
            }
            return "";         
        }

        /// <summary>
        /// Phương thức gửi tin nhắn đến toàn bộ giáo viên
        /// </summary>
        public static void GuiTinNhanDenToanBoGiaoVien(string noiDung, ref DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            string ComPort = "", Parity = "";
            int BaudRate = 0, DataBits = 0;
            float StopBit = 0.0f;
            if (BLL.ModemConfigBLL.LayThongTinModem(ref ComPort, ref BaudRate, ref DataBits, ref Parity, ref StopBit) == true)
            {
                SetCommParameters(ComPort, BaudRate, DataBits, 0, 0);
                if (objSMS.Connect())
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem thành công.", System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem không thành công.", System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
            }

            string[] MaGiaoVienDangGiangDay = DB.PhanCongGiangDays.Select(q => q.MaGiaoVien).Distinct().ToArray();
            List<DSGiaoVien> GiaoViens = DB.DSGiaoViens.Where(q => MaGiaoVienDangGiangDay.Contains(q.MaGiaoVien)).ToList();

            pgbTienTrinh.Properties.Minimum = 0;
            pgbTienTrinh.Properties.Maximum = GiaoViens.Count;
            pgbTienTrinh.Properties.Step = 1;
            foreach (DSGiaoVien GiaoVien in GiaoViens)
            {
                if ((GiaoVien.DienThoai != null) && (GiaoVien.DienThoai.Trim().Length > 0))
                {                        
                    objSMS.SendSMS(GiaoVien.DienThoai, noiDung);
                    Thread.Sleep(10000);
                }
                pgbTienTrinh.PerformStep();
                pgbTienTrinh.Update();
            }

            try
            {
                objSMS.Disconnect();
            }
            catch (mCore.GeneralException ex)
            {
                UTL.Ultils.ThongBao(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                UTL.Ultils.ThongBao(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private static void SetCommParameters(string comPort, int baudRate, int dataBits, int parity, int stopBit)
        {
            //Set communication parameters
            //check if port is already connected

            try
            {
                if (!objSMS.IsConnected)
                {
                    objSMS.Port = comPort;
                    objSMS.BaudRate = (mCore.BaudRate)(baudRate);
                    objSMS.DataBits = (mCore.DataBits)(dataBits);
                    objSMS.Parity = (mCore.Parity)parity;
                    objSMS.StopBits = (mCore.StopBits)(stopBit + 1);
                    objSMS.FlowControl = 0;
                    objSMS.DisableCheckPIN = true;
                    objSMS.DeliveryReport = false;
                    objSMS.LogType = mCore.LogType.ErrorEventLog;
                    objSMS.LogFolderPath = @"F:\SMSLogs\";
                }
            }
            catch (mCore.GeneralException ex)
            {

            }
        }

        public static void GuiTinNhanDenToanBoGVCN(string noiDung)
        {
            string[] MaGiaoVienDangGiangDay = DB.DSLops.Select(q => q.MaGVCN).ToArray();
            List<DSGiaoVien> GiaoViens = DB.DSGiaoViens.Where(q => MaGiaoVienDangGiangDay.Contains(q.MaGiaoVien)).ToList();
            int MessageLength = noiDung.Length;
            string Message1 = noiDung, Message2 = "";
            if (MessageLength > 160)
            {
                int ViTri = 159;
                while (Message1[ViTri] != ' ')
                    ViTri--;
                Message2 = Message1.Substring(ViTri, MessageLength - ViTri);
                Message1 = Message1.Substring(0, ViTri);
                foreach (DSGiaoVien GiaoVien in GiaoViens)
                {
                    if ((GiaoVien.DienThoai != null) && (GiaoVien.DienThoai.Trim().Length > 0))
                    {
                        DSSMSAutoSend SMS = new DSSMSAutoSend();
                        SMS.SoDienThoaiNhan = GiaoVien.DienThoai;
                        SMS.NoiDungSMS = Message1;
                        DB.DSSMSAutoSends.InsertOnSubmit(SMS);
                        DSSMSAutoSend SMS2 = new DSSMSAutoSend();
                        SMS2.SoDienThoaiNhan = GiaoVien.DienThoai;
                        SMS2.NoiDungSMS = Message2;
                        DB.DSSMSAutoSends.InsertOnSubmit(SMS2);
                    }
                }
            }
            else
            {
                foreach (DSGiaoVien GiaoVien in GiaoViens)
                {
                    if ((GiaoVien.DienThoai != null) && (GiaoVien.DienThoai.Trim().Length > 0))
                    {
                        DSSMSAutoSend SMS = new DSSMSAutoSend();
                        SMS.SoDienThoaiNhan = GiaoVien.DienThoai;
                        SMS.NoiDungSMS = Message1;
                        DB.DSSMSAutoSends.InsertOnSubmit(SMS);
                    }
                }
            }
            DB.SubmitChanges();
        }

        public static void TaoDuLieuSMSKetQuaHocKy(string maHocKy)
        {
            string maLoaiDiemHocKy = DSLoaiDiemBLL.LoadMaDiemTrungBinh();
            if (maHocKy == "K1")
            {
                List<DSLop> Lops = DB.DSLops.OrderBy(q=>q.TenLop).ToList();                
                List<DSDiem> DiemTatCaHocSinhs = DB.DSDiems.Where(q => q.MaLoaiDiem == maLoaiDiemHocKy 
                                                                    && q.MaHocKy == maHocKy).ToList();                
                foreach(DSLop Lop in Lops)
                {
                    List<DSMonHoc> MonHocs = DSMonHocTheoLopBLL.LayMonHocTheoLop(Lop.MaLop);
                    List<DSHocSinh> HocSinhs = DSHocSinhTheoLopBLL.LayDSHocSinhTheoLop(Lop.MaLop).Where(q=>q.DangKyDichVu== true).ToList();
                    foreach (DSHocSinh HocSinh in HocSinhs)
                    {
                        if ((HocSinh.SoDienThoaiPhuHuynh != null) && (HocSinh.SoDienThoaiPhuHuynh.Trim() != ""))
                        {
                            string SMS = "Ket qua hoc tap Hoc ky I - Nam hoc 2015-2016 cua Hoc sinh ";
                            SMS += UTL.Ultils.ConvertToUnSign(HocSinh.HoDem).Replace("-", " ").Trim()
                                    + " " + UTL.Ultils.ConvertToUnSign(HocSinh.Ten).Replace("-", " ").Trim() + ": ";
                            List<DSDiem> DiemCuaHocSinhs = DiemTatCaHocSinhs.Where(q => q.MaHocSinh == HocSinh.MaHocSinh).ToList();
                            foreach(DSMonHoc MonHoc in MonHocs)
                            {
                                double? diem = DiemCuaHocSinhs.Where(q => q.MaMonHoc == MonHoc.MaMonHoc).Select(q => q.Diem).FirstOrDefault();
                                if (diem != -1)
                                {
                                    if (MonHoc.DSHinhThucDanhGia.TinhDiem == true)
                                        SMS += "\r\n" + MonHoc.HienThiSMS + ": " + diem;
                                    else
                                        if (diem == -2)
                                            SMS += "\r\n" + MonHoc.HienThiSMS + ": " + "Dat";
                                        else
                                            SMS += "\r\n" + MonHoc.HienThiSMS + ": " + "Chua dat";
                                }                                    
                            }
                            DSTongKetTheoKy TongKetTheoKy = DSTongKetTheoKyBLL.LayTongKetTheoKyCuaMotHocSinh(maHocKy, HocSinh.MaHocSinh);
                            SMS += "\r\nTBC: " + TongKetTheoKy.TrungBinhChung;
                            SMS += "\r\nHoc luc: " + UTL.Ultils.ConvertToUnSign(TongKetTheoKy.DMHocLuc.TenHocLuc).Replace('-',' ').Trim();
                            SMS += "\r\nHanh kiem: " + UTL.Ultils.ConvertToUnSign(TongKetTheoKy.DMHanhKiem.TenHanhKiem).Replace('-', ' ').Trim();
                            if (TongKetTheoKy.MaDanhHieu == null)
                                SMS += "\r\nDanh hieu: Khong";
                            else
                                SMS += "\r\nDanh hieu: " + UTL.Ultils.ConvertToUnSign(TongKetTheoKy.DMDanhHieu.TenDanhHieu).Replace('-', ' ').Trim();
                            SMS += "\r\nNha truong xin kinh bao!";

                            int MessageLength = SMS.Length;
                            string Message1 = SMS, Message2 = "";
                            if (MessageLength > 160)
                            {
                                int ViTri = 159;
                                while (Message1[ViTri] != ' ')
                                    ViTri--;
                                Message2 = Message1.Substring(ViTri, MessageLength - ViTri);
                                Message1 = Message1.Substring(0, ViTri);
                                //Thêm vào bảng DSSMSAutoSend
                                DSSMSAutoSend newSMS1 = new DSSMSAutoSend();
                                newSMS1.SoDienThoaiNhan = HocSinh.SoDienThoaiPhuHuynh;
                                newSMS1.NoiDungSMS = Message1;
                                DB.DSSMSAutoSends.InsertOnSubmit(newSMS1);
                                DSSMSAutoSend newSMS2 = new DSSMSAutoSend();
                                newSMS2.SoDienThoaiNhan = HocSinh.SoDienThoaiPhuHuynh;
                                newSMS2.NoiDungSMS = Message2;
                                DB.DSSMSAutoSends.InsertOnSubmit(newSMS2);
                            }
                            else
                            {
                                //Thêm vào bảng DSSMSAutoSend
                                DSSMSAutoSend newSMS = new DSSMSAutoSend();
                                newSMS.SoDienThoaiNhan = HocSinh.SoDienThoaiPhuHuynh;
                                newSMS.NoiDungSMS = SMS;
                                DB.DSSMSAutoSends.InsertOnSubmit(newSMS);
                            }
                        }                        
                    }
                    DB.SubmitChanges();
                }
            }else
            {

            }
        }
    }
}
