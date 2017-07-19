using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Threading;
using System.Data;

namespace BLL
{
    public class SMSBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        static mCore.SMS objSMS = new mCore.SMS();

        public static void GuiSMSHSToanTruong(string noiDung, DevExpress.XtraEditors.ProgressBarControl pgbTienTrinh)
        {
            List<DSHocSinh> HocSinhs = DB.DSHocSinhTheoLops.Select(q => q.DSHocSinh).Where(q => q.SoDienThoaiPhuHuynh != null && q.SoDienThoaiPhuHuynh != "").ToList();
            pgbTienTrinh.Properties.Maximum = HocSinhs.Count;
            pgbTienTrinh.Properties.Minimum = 0;
            pgbTienTrinh.Properties.Step = 1;
            pgbTienTrinh.Properties.PercentView = false;
            string ComPort = "", Parity = "";
            int BaudRate = 0, DataBits = 0;
            float StopBit = 0.0f;
            if (BLL.ModemConfigBLL.LayThongTinModem(ref ComPort, ref BaudRate, ref DataBits, ref Parity, ref StopBit) == true)
            {
                SetCommParameters(ComPort, BaudRate, DataBits, 0, 0);
                if (objSMS.Connect())
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem thành công.", System.Windows.Forms.MessageBoxIcon.Information);
                } else
                {
                    UTL.Ultils.ThongBao("Kết nối tới Modem thất bại.", System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
            }
            foreach (DSHocSinh HocSinh in HocSinhs)
            {
                objSMS.SendSMS(HocSinh.SoDienThoaiPhuHuynh, noiDung);
                pgbTienTrinh.PerformStep();
                pgbTienTrinh.Update();
                Thread.Sleep(10000);
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
                    //objSMS.DeliveryReport = true;
                    objSMS.LogType = mCore.LogType.ErrorEventLog;
                    objSMS.LogFolderPath = @"F:\SMSLogs\";
                }
            }
            catch (mCore.GeneralException ex)
            {

            }
        }

        public static void GuiSMSDenMotSoCuThe(string soDienThoai, string noiDung)
        {
            objSMS.NewDeliveryReport += new mCore.SMS.NewDeliveryReportEventHandler(objSMS_NewDeliveryReport);

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
                    UTL.Ultils.ThongBao("Kết nối tới Modem thất bại.", System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
            }
            objSMS.SendSMS(soDienThoai, noiDung);
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

        private static void objSMS_NewDeliveryReport(object sender, mCore.NewDeliveryReportEventArgs e)
        {

            string noiDung = "";
            if (e.Status)
            {
                noiDung += "true#" + "MESSAGE DELIVERED" + "\r\n" + "TO: " + e.Phone + "\r\n" +
                                       "DELIVERY DATE/TIME: " + e.DeliveryTimeStamp.ToString() +
                                       "\r\n" + "[Message Ref.: " + e.MessageReference.ToString() + "]";
                //UTL.Ultils.ThongBao(noiDung, System.Windows.Forms.MessageBoxIcon.Information);                
            }
            else
            {
                noiDung += "false#" + "MESSAGE DELIVERY FALED" + "\r\n" + "TO: " + e.Phone + "\r\n" +
                                       "DELIVERY DATE/TIME: " + e.DeliveryTimeStamp.ToString() +
                                       "\r\n" + "[Message Ref.: " + e.MessageReference.ToString() + "]";
                //UTL.Ultils.ThongBao(noiDung, System.Windows.Forms.MessageBoxIcon.Information);                
            }

            UTL.Ultils.ThongBao(noiDung, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static DataTable TaoDuLieuSMSGui(string doiTuong, string maNhaMang, string noiDung, string maKhoi, string maLop)
        {
            DMNhaMang nhaMang = DB.DMNhaMangs.Where(q => q.MaNhaMang == maNhaMang).FirstOrDefault();
            string[] dauSos = nhaMang.DauSo.Split('#');
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("SoDienThoai", typeof(string));
            dataTable.Columns.Add("NoiDungSMS", typeof(string));

            string hoVaTen;

            switch (doiTuong)
            {
                case "HSToanTruong":
                    {
                        List<DSHocSinh> hocSinhDangKyDichVus = DB.DSHocSinhs.Where(q => q.DangKyDichVu == true).ToList();
                        if (nhaMang.TatCa == true)
                        {
                            int dem = 0;
                            foreach (DSHocSinh hocSinh in hocSinhDangKyDichVus)
                            {
                                if ((hocSinh.SoDienThoaiPhuHuynh != null) && (hocSinh.SoDienThoaiPhuHuynh.Length > 9))
                                {
                                    hoVaTen = UTL.Ultils.ConvertToUnSign(hocSinh.HoDem).Replace("-", " ") + " "
                                        + UTL.Ultils.ConvertToUnSign(hocSinh.Ten).Replace("-", " ");
                                    DataRow row = dataTable.NewRow();
                                    row[0] = ++dem;
                                    row[1] = "84" + hocSinh.SoDienThoaiPhuHuynh.Substring(1, hocSinh.SoDienThoaiPhuHuynh.Length - 1);
                                    row[2] = noiDung.Replace("{HoVaTen}", hoVaTen.Trim());
                                    dataTable.Rows.Add(row);
                                }
                            }
                        } else
                        {
                            int dem = 0;
                            foreach (DSHocSinh hocSinh in hocSinhDangKyDichVus)
                            {
                                if ((hocSinh.SoDienThoaiPhuHuynh != null) && (hocSinh.SoDienThoaiPhuHuynh.Length > 9))
                                {
                                    hoVaTen = UTL.Ultils.ConvertToUnSign(hocSinh.HoDem).Replace("-", " ") + " "
                                        + UTL.Ultils.ConvertToUnSign(hocSinh.Ten).Replace("-", " ");
                                    DataRow row = dataTable.NewRow();
                                    row[0] = ++dem;
                                    row[1] = "84" + hocSinh.SoDienThoaiPhuHuynh.Substring(1, hocSinh.SoDienThoaiPhuHuynh.Length - 1);
                                    row[2] = noiDung.Replace("{HoVaTen}", hoVaTen.Trim());
                                    bool thuocMang = false;
                                    foreach (string dauSo in dauSos)
                                        if (row[1].ToString().StartsWith(dauSo))
                                        {
                                            thuocMang = true;
                                            break;
                                        }
                                    if (thuocMang == true)
                                        dataTable.Rows.Add(row);
                                }
                            }
                        }
                        break;
                    }
                case "GVToanTruong-NhacNhapDiem":
                    {
                        dataTable = DSDiemBLL.TaoSMSGiaoVienChuaNhapDiemTheoThang(noiDung, maNhaMang);
                        break;
                    }
                case "HSTheoKhoi":
                    {
                        dataTable = TaoSMSHocSinhTheoKhoiLop(maKhoi, maLop, false, noiDung, maNhaMang);
                        break;
                    }
                case "HSTheoKhoiLop":
                    {
                        dataTable = TaoSMSHocSinhTheoKhoiLop(maKhoi, maLop, true, noiDung, maNhaMang);
                        break;
                    }
            }

            return dataTable;
        }

        public static DataTable TaoSMSHocSinhTheoKhoiLop(string maKhoi, string maLop, bool theoLop, string noiDung, string maNhaMang)
        {
            DMNhaMang nhaMang = DB.DMNhaMangs.Where(q => q.MaNhaMang == maNhaMang).FirstOrDefault();
            string[] dauSos = nhaMang.DauSo.Split('#');
            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("STT", typeof(int));
            tempTable.Columns.Add("SoDienThoai", typeof(string));
            tempTable.Columns.Add("NoiDungSMS", typeof(string));
            List<DSHocSinh> HocSinhTheoKhoiLops;
            if (theoLop == true)
                HocSinhTheoKhoiLops = DB.DSHocSinhTheoLops.Where(q => q.DSLop.MaLop == maLop).Select(q => q.DSHocSinh).ToList();
            else
                HocSinhTheoKhoiLops = DB.DSHocSinhTheoLops.Where(q => q.DSLop.DSKhoi.MaKhoi == maKhoi).Select(q => q.DSHocSinh).ToList();
            int dem = 0;
            foreach(DSHocSinh HocSinh in HocSinhTheoKhoiLops)
            {
                if (HocSinh.SoDienThoaiPhuHuynh != null)
                    if (HocSinh.SoDienThoaiPhuHuynh.Length > 9)
                    {
                        DataRow row = tempTable.NewRow();
                        row[0] = ++dem;
                        row[1] = "84" + HocSinh.SoDienThoaiPhuHuynh.Substring(1, HocSinh.SoDienThoaiPhuHuynh.Length - 1);
                        string HoVaTen = UTL.Ultils.ConvertToUnSign(HocSinh.HoDem).Replace("-", " ") + " " + UTL.Ultils.ConvertToUnSign(HocSinh.Ten).Replace("-", "");
                        row[2] = noiDung.Replace("{HoVaTen}", HoVaTen);
                        if (nhaMang.TatCa != true)
                        {
                            bool thuocMang = false;
                            foreach (string dauSo in dauSos)
                                if (row[1].ToString().StartsWith(dauSo))
                                {
                                    thuocMang = true;
                                    break;
                                }
                            if (thuocMang == true)
                                tempTable.Rows.Add(row);
                        }
                        else
                            tempTable.Rows.Add(row);
                    }                
            }
            return tempTable;
        }
    }
}
