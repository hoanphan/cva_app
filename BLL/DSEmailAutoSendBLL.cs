using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DSEmailAutoSendBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static void GuiMailTrenCung()
        {
            DSEmailAutoSend Email = DB.DSEmailAutoSends.FirstOrDefault();
            if (Email != null)
            {
                UTL.Ultils.SendMail(Email.DiaChiNguoiNhan, Email.TieuDeEmail, Email.NoiDungEmail);
                DB.DSEmailAutoSends.DeleteOnSubmit(Email);
                DB.SubmitChanges();
            }
        }
    }
}
