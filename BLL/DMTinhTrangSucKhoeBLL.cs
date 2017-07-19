using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMTinhTrangSucKhoeBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTinhTrangSucKhoe> LoadAll()
        {
            return DB.DMTinhTrangSucKhoes.ToList();
        }

        public static DMTinhTrangSucKhoe TruyVanTheoMa(short maTinhTrangSucKhoe)
        {
            return DB.DMTinhTrangSucKhoes.Where(q => q.MaTinhTrangSucKhoe == maTinhTrangSucKhoe).FirstOrDefault();
        }

        public static void ThemTinhTrangSucKhoe(string tenTinhTrangSucKhoe)
        {
            DMTinhTrangSucKhoe TinhTrangSucKhoe = new DMTinhTrangSucKhoe
            {
                TenTinhTrangSucKhoe = tenTinhTrangSucKhoe
            };
            DB.DMTinhTrangSucKhoes.InsertOnSubmit(TinhTrangSucKhoe);
            DB.SubmitChanges();
        }

        public static void CapNhatTinhTrangSucKhoe(DMTinhTrangSucKhoe danToc)
        {
            DMTinhTrangSucKhoe TinhTrangSucKhoe = TruyVanTheoMa(danToc.MaTinhTrangSucKhoe);
            TinhTrangSucKhoe = danToc;
            DB.SubmitChanges();
        }

        public static void XoaTinhTrangSucKhoe(short maTinhTrangSucKhoe)
        {
            DMTinhTrangSucKhoe TinhTrangSucKhoe = TruyVanTheoMa(maTinhTrangSucKhoe);
            DB.DMTinhTrangSucKhoes.DeleteOnSubmit(TinhTrangSucKhoe);
            DB.SubmitChanges();
        }
    }
}
