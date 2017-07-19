using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class frmCapNhat : Form
    {

        private const string TEMP_DIR = "QLDCVA_Temp";

        public frmCapNhat()
        {
            InitializeComponent();
        }

        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            //đợi 2 giây, cho chương trình chính (Program1.exe) thoát hoàn toàn
            //các bạn có thể sử dụng các kỹ thuật cao hơn như kiểm tra Process để xác định xem 
            //khi nào Program1.exe đã thoát hoàn toàn thì mới tiến hành ghi đè file. Nếu không sẽ phát sinh lỗi
            System.Threading.Thread.Sleep(2000);
            //tiến hành ghi đè file
            CopyFiles();
        }

        private void CopyFiles()
        {
            //xác định thư mục hiện thời, nơi chương trình đang chạy
            string currentDirectory = Environment.CurrentDirectory;
            //xác định thư mục tạm, nơi Program1.exe đã tải các file cần cập nhật về
            string tempDirectory = Path.GetTempPath() + TEMP_DIR;
            //lấy danh sách tất cả các file trong thư mục tạm
            string[] fileList = Directory.GetFiles(tempDirectory);
            //duyệt từng file và copy đè lên file cũ trong thư mục đang chạy chương trình
            foreach (string sourceFile in fileList)
            {
                //tách tên file ra khỏi đường dẫn (tên file sẽ dùng để tạo đường dẫn đích cần copy đè)
                string fileName = Path.GetFileName(sourceFile);
                //tạo đường dẫn đích để copy file mới tới
                string destinationFile = currentDirectory + "\\" + fileName;
                //thực hiện copy đè
                File.Copy(sourceFile, destinationFile, true);
            }
            //sau khi copy đè tất cả các file xong, ta sẽ tiến hành gọi lại chương trình chính (Program1.exe) để chạy lại chương trình
            System.Diagnostics.Process.Start("MarkManagement.exe");
            //và thoát khỏi chương trình update
            Application.Exit();
        }

    }
}
