using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Reflection;
using BLL;
using System.Net;
using System.Configuration;
using System.Data;

namespace MarkManagement
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        bool MoRong = true;

        //địa chỉ host, nơi chứa các tệp tin cập nhật
        private const string HOST_ADDRESS = "http://utb.edu.vn/download/qldiemcva";
        //tên file chứa thông tin về các tệp tin cần cập nhật
        private const string UPDATE_FILE_NAME = "update.txt";
        //tên thư mục tạm, chúng ta sẽ sử dụng để lưu các tệp tin tạm thời
        private const string TEMP_DIR = "QLDCVA_Temp";


        public frmLogin()
        {
            InitializeComponent();
            this.Height = 270;
            gbThongTinKetNoiCSDL.Visible = false;            
        }        

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            if (MoRong == true)
            {
                gbThongTinKetNoiCSDL.Visible = true;
                this.Height = 415;                
                MoRong = false;
            }else
            {
                gbThongTinKetNoiCSDL.Visible = false;
                this.Height = 270;                
                MoRong = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullPath = Path.Combine(strAppDir, "Setting.dat");
            string strServerName = tbTenMayChu.Text.Trim();
            string strDatabaseName = tbTenCSDL.Text.Trim();
            string strUserSQL = tbTenNguoiDungSQL.Text.Trim();
            string strPassSQL = tbMatKhauSQL.Text.Trim();
            if (strServerName != "" && strUserSQL != "" && strPassSQL != "")
            {
                using (StreamWriter file = File.CreateText(fullPath))
                {
                    file.WriteLine(UTL.Ultils.Encrypt(strServerName, "CVA"));
                    file.WriteLine(UTL.Ultils.Encrypt(strDatabaseName, "CVA"));
                    file.WriteLine(UTL.Ultils.Encrypt(strUserSQL, "CVA"));
                    file.WriteLine(UTL.Ultils.Encrypt(strPassSQL, "CVA"));
                }
                System.Diagnostics.Process.Start("MarkManagement.exe");                
                Application.Exit();
            }
            else
            {
                UTL.Ultils.ThongBao("Vui lòng nhập đầy đủ thông tin trước khi lưu.", MessageBoxIcon.Error);
            }

        }

        private void NhoThongTinDangNhap()
        {
            string strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullPath = Path.Combine(strAppDir, "Rem.dat");
            string strUserName = tbTenDangNhap.Text;
            string strPassword = tbMatKhau.Text;
            if (strUserName != "" && strPassword != "")
            {
                using (StreamWriter file = File.CreateText(fullPath))
                {
                    file.WriteLine(UTL.Ultils.Encrypt(strUserName, "CVA"));
                    file.WriteLine(UTL.Ultils.Encrypt(strPassword, "CVA"));                    
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            KiemTraCapNhat();
            DocThongTinServer();
            DocThongTinDangNhap();
        }

        private void KiemTraCapNhat()
        {
            //địa chỉ file update.txt ở trên Host
            string remotePath = HOST_ADDRESS + "/" + UPDATE_FILE_NAME;
            //đường dẫn tới thư mục tạm trên máy Local
            string localPath = System.IO.Path.GetTempPath() + TEMP_DIR + "\\" + UPDATE_FILE_NAME;
            //tạo thư mục tạm nếu chưa có (để tránh bị lỗi khi download)
            CreateTempDirectory();
            //tải tệp tin update.txt từ Host về thư mục tạm
            DownloadFile(remotePath, localPath, DateTime.Now);
            //phân tích tập tin update.txt để xem có file nào cần update hay không
            AnalyzeFile(localPath);
        }

        private void CreateTempDirectory()
        {
            //kiểm tra đường dấn tới thư mục tạm, nếu chưa có thì tạo thư mục
            string tempPath = System.IO.Path.GetTempPath() + TEMP_DIR;
            if (!System.IO.Directory.Exists(tempPath))
            {
                System.IO.Directory.CreateDirectory(tempPath);
            }
        }


        private void DownloadFiles(List<string> fileList, List<DateTime> dateModifiedList)
        {
            //xóa thư mục tạm để loại bỏ các file cũ nếu có
            System.IO.Directory.Delete(System.IO.Path.GetTempPath() + TEMP_DIR, true);
            //sau đó tạo lại, để tải các file mới về
            CreateTempDirectory();
            //duyệt danh sách các file và tải về thư mục tạm
            for (int i = 0; i < fileList.Count; i++)
            {
                //tạo đường dẫn tạm để lưu file
                string localPath = System.IO.Path.GetTempPath() + TEMP_DIR + "\\" + fileList[i];
                //xác định đường dẫn file trên host
                string remotePath = HOST_ADDRESS + "/" + fileList[i];
                //tải file từ host về thư mục tạm                
                DownloadFile(remotePath, localPath, dateModifiedList[i]);
            }
            splashScreenManager.CloseWaitForm();
            //gọi chương trình Update.exe để thực hiện việc ghi đè file mới lên file cũ
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "Updater.exe";
            //gán "runas" vào StartInfo để windows sẽ bật hộp thoại UAC - xác nhận quyền đọc - ghi cho ứng dụng
            p.StartInfo.Verb = "runas";
            p.Start();
            //sau đó thoát khỏi chương trình chính để giải phóng các tệp tin đang sử dụng
            Application.Exit();
        }


        private void AnalyzeFile(string filePath)
        {
            //khai báo 1 danh sách, để chứa toàn bộ các tên file cần Update
            List<String> FileList = new List<string>();
            List<DateTime> DateModifiedList = new List<DateTime>();

            if (File.Exists(filePath))
            {
                //đọc toàn bộ nội dung file vào biến
                string fileContent = System.IO.File.ReadAllText(filePath);
                //split nội dung file theo từng dòng (bằng ký tự CrLf)
                string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                //duyệt từng dòng (tương ứng với từng file)
                foreach (string line in lines)
                {
                    //với mỗi dòng, phân tách các phần bởi dấu tab
                    string[] parts = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    //tên file, nằm ở ngay phần đầu tiên
                    string fileName = parts[0];
                    //ngày tháng thay đổi của file, nằm ở phần 2
                    string modifiedDate = parts[1];
                    //kích thước file nằm ở phần cuối cùng
                    long fileSize = Convert.ToInt64(parts[2]);
                    //xác định file Local tương ứng với file remote
                    string localPath = Environment.CurrentDirectory + "\\" + fileName;
                    //kiểm tra xem file đã tồn tại trên máy Local chưa?
                    //nếu chưa có, nghĩa là file này là file mới được thêm vào project, vì vậy chắc chắn là chúng ta cần phải tải nó về
                    if (!System.IO.File.Exists(localPath))
                    {
                        //thêm file mới này vào danh sách để sau này chúng ta sẽ tải về
                        FileList.Add(fileName);
                        DateModifiedList.Add(DateTime.Parse(modifiedDate));
                    }
                    else //file đã tồn tại trên máy Local, thì cần kiểm tra thông tin file
                    {
                        //lấy thông tin của file
                        System.IO.FileInfo fileInfo = new System.IO.FileInfo(localPath);
                        //kiểm tra xem kích thước và ngày tháng Modified giữa tệp Local với tệp remote có khác nhau không?
                        //Nếu có 1 thông số khác nhau thì coi như file đã thay đổi và cần phải cập nhật
                        //ngày tháng cập nhật file ta lưu ở file update.txt dưới dạng Ticks cho đơn giản trong việc so sánh
                        if ((fileInfo.Length != fileSize) || (fileInfo.LastWriteTime.ToString() != modifiedDate))
                        {
                            //thêm file đã thay đổi vào danh sách để tải về sau này
                            FileList.Add(fileName);
                            DateModifiedList.Add(DateTime.Parse(modifiedDate));
                        }
                    }
                }
            }
            
            //sau khi phân tích tệp tin update.txt, nếu có file cần update thì ta tiến hành tải các file cần update về
            if (FileList.Count > 0)
            {
                if (MessageBox.Show("Chương trình đã có phiên bản mới. Quá trình cập nhật có thể kéo dài trong một thời gian nhất định. Bạn có muốn cập nhật chương trình không?",UTL.Params.Title,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    splashScreenManager.ShowWaitForm();
                    DownloadFiles(FileList, DateModifiedList);
                    splashScreenManager.CloseWaitForm();
                }                    
            }
        }


        private void DownloadFile(string remotePath, string localPath, DateTime dateModified)
        {
            try
            {
                WebClient client = new WebClient();
                //tải tệp tin tại địa chỉ remotePath và lưu về máy local tại địa chỉ localPath
                client.DownloadFile(remotePath, localPath);
                //Uri myUri = new Uri(remotePath);
                //HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(myUri); 
                //HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                //DateTime time = myHttpWebResponse.LastModified;
                System.IO.File.SetLastWriteTime(localPath, dateModified);
            }
            catch (System.Net.WebException ex)
            {
                UTL.Ultils.ThongBao("Chương trình không thể kết nối đến máy chủ để cập nhật.", MessageBoxIcon.Error);
            }
            
        }

        private void DocThongTinServer()
        {
            string strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullPath = Path.Combine(strAppDir, "Setting.dat");
            if (File.Exists(fullPath))
            {
                string strServerName = "", strDatabaseName = "", strUserSQL = "", strPassSQL = "";
                try
                {
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        string str = sr.ReadLine();
                        strServerName = UTL.Ultils.Decrypt(str, "CVA");
                        str = sr.ReadLine();
                        strDatabaseName = UTL.Ultils.Decrypt(str, "CVA");
                        str = sr.ReadLine();
                        strUserSQL = UTL.Ultils.Decrypt(str, "CVA");
                        str = sr.ReadLine();
                        strPassSQL = UTL.Ultils.Decrypt(str, "CVA");
                    }
                }finally
                {
                    
                }
                tbTenMayChu.Text = strServerName;
                tbTenCSDL.Text = strDatabaseName;
                tbTenNguoiDungSQL.Text = strUserSQL;
                tbMatKhauSQL.Text = strPassSQL;                
            }
        }

        private void DocThongTinDangNhap()
        {
            string strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullPath = Path.Combine(strAppDir, "Rem.dat");
            if (File.Exists(fullPath))
            {
                string strUserName = "", strPassword = "";
                try
                {
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        string str = sr.ReadLine();
                        strUserName = UTL.Ultils.Decrypt(str, "CVA");
                        str = sr.ReadLine();
                        strPassword = UTL.Ultils.Decrypt(str, "CVA");
                    }
                }
                finally
                {

                }
                tbTenDangNhap.Text = strUserName;
                tbMatKhau.Text = strPassword;
                chkNhoThongTin.Checked = true;
            }
        }

        private void XoaThongTinDangNhap()
        {
            string strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullPath = Path.Combine(strAppDir, "Rem.dat");
            if (File.Exists(fullPath))
            {
                try
                {
                    File.Delete(fullPath);
                }
                finally
                {

                }
            }
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            byte XTGV = DSGiaoVienBLL.XacThuc(tbTenDangNhap.Text, tbMatKhau.Text);
            byte XTND = DSNguoiDungBLL.XacThuc(tbTenDangNhap.Text, tbMatKhau.Text);
            if ((XTGV == 255) || (XTND == 255))
                UTL.Ultils.ThongBao("Lỗi kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại.", MessageBoxIcon.Error);
            else
                if ((XTGV == 1) || (XTND == 1))
                {
                    if (chkNhoThongTin.Checked)
                    {
                        NhoThongTinDangNhap();
                    }
                    else
                    {
                        XoaThongTinDangNhap();
                    }
                    frmMain frm = new frmMain(tbTenDangNhap.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    UTL.Ultils.ThongBao("Thông tin đăng nhập chưa chính xác. Vui lòng kiểm tra lại Tên đăng nhập và Mật khẩu.", MessageBoxIcon.Information);
                }
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        private void tbTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }
    }
}