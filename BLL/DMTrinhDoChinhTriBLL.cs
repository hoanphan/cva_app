using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMTrinhDoChinhTriBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMTrinhDoChinhTri> LoadAll()
        {
            return DB.DMTrinhDoChinhTris.ToList();
        }

        public static DMTrinhDoChinhTri TruyVanTheoMa(short maTrinhDoChinhTri)
        {
            return DB.DMTrinhDoChinhTris.Where(q => q.MaTrinhDoChinhTri == maTrinhDoChinhTri).FirstOrDefault();
        }

        public static void ThemTrinhDoChinhTri(string tenTrinhDoChinhTri)
        {
            DMTrinhDoChinhTri TrinhDoChinhTri = new DMTrinhDoChinhTri
            {
                TenTrinhDoChinhTri = tenTrinhDoChinhTri
            };
            DB.DMTrinhDoChinhTris.InsertOnSubmit(TrinhDoChinhTri);
            DB.SubmitChanges();
        }

        public static void CapNhatTrinhDoChinhTri(DMTrinhDoChinhTri trinhDoChinhTri)
        {
            DMTrinhDoChinhTri TrinhDoChinhTri = TruyVanTheoMa(trinhDoChinhTri.MaTrinhDoChinhTri);
            TrinhDoChinhTri = trinhDoChinhTri;
            DB.SubmitChanges();
        }

        public static void XoaTrinhDoChinhTri(short maTrinhDoChinhTri)
        {
            DMTrinhDoChinhTri TrinhDoChinhTri = TruyVanTheoMa(maTrinhDoChinhTri);
            DB.DMTrinhDoChinhTris.DeleteOnSubmit(TrinhDoChinhTri);
            DB.SubmitChanges();
        }
    }
}
