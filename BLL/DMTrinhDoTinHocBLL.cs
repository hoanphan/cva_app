using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMTrinhDoTinHocBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTrinhDoTinHoc> LoadAll()
        {
            return DB.DMTrinhDoTinHocs.ToList();
        }

        public static DMTrinhDoTinHoc TruyVanTheoMa(short maTrinhDoTinHoc)
        {
            return DB.DMTrinhDoTinHocs.Where(q => q.MaTrinhDoTinHoc == maTrinhDoTinHoc).FirstOrDefault();
        }

        public static void ThemTrinhDoTinHoc(string tenTrinhDoTinHoc)
        {
            DMTrinhDoTinHoc TrinhDoTinHoc = new DMTrinhDoTinHoc
            {
                TenTrinhDoTinHoc = tenTrinhDoTinHoc
            };
            DB.DMTrinhDoTinHocs.InsertOnSubmit(TrinhDoTinHoc);
            DB.SubmitChanges();
        }

        public static void CapNhatTrinhDoTinHoc(DMTrinhDoTinHoc trinhDoTinHoc)
        {
            DMTrinhDoTinHoc TrinhDoTinHoc = TruyVanTheoMa(trinhDoTinHoc.MaTrinhDoTinHoc);
            TrinhDoTinHoc = trinhDoTinHoc;
            DB.SubmitChanges();
        }

        public static void XoaTrinhDoTinHoc(short maTrinhDoTinHoc)
        {
            DMTrinhDoTinHoc TrinhDoTinHoc = TruyVanTheoMa(maTrinhDoTinHoc);
            DB.DMTrinhDoTinHocs.DeleteOnSubmit(TrinhDoTinHoc);
            DB.SubmitChanges();
        }
    }
}
