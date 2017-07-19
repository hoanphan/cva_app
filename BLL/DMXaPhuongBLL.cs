using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
namespace BLL
{
  public static  class DMXaPhuongBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMXaPhuong> LoadAll()
        {
            return DB.DMXaPhuongs.ToList();
        }
      public static List<DMQuanHuyen>LoadQuanHuyenTheoTinhThanh(int maTinhThanh)
        {
            return DB.DMQuanHuyens.Where(q => q.MaTinhThanh == maTinhThanh).ToList();
        }
        public static DMXaPhuong TruyVanTheoMa(int maXaPhuong)
        {
            return DB.DMXaPhuongs.Where(q => q.MaXaPhuong==maXaPhuong).FirstOrDefault();
        }
         public static IList LayDuLieu()
        {
           
            return (from ds in DB.DMXaPhuongs
                    select new { MaXaPhuong = ds.MaXaPhuong,
                                 TenQuanHuyen = ds.DMQuanHuyen.TenQuanHuyen,
                                 TenTinhThanh =ds.DMQuanHuyen.DMTinhThanh.TenTinhThanh,
                                 TenXaPhuong = ds.TenXaPhuong }).ToList();
        }
        public static void ThemXaPhuong(string tenXaPhuong,int maQuanHuyen)
         {
             DMXaPhuong XaPhuong = new DMXaPhuong
             {
                 TenXaPhuong = tenXaPhuong,
                 MaQuanHuyen = maQuanHuyen
             };
             DB.DMXaPhuongs.InsertOnSubmit(XaPhuong);
             DB.SubmitChanges();
         }
        public static void CapNhatXaPhuong(DMXaPhuong xaPhuong)
        {
            DMXaPhuong XaPhuong = TruyVanTheoMa(xaPhuong.MaXaPhuong);
            XaPhuong = xaPhuong;
            DB.SubmitChanges();
        }
        public static void XoaXaPhuong(DMXaPhuong xaPhuong)
        {
            DMXaPhuong XaPhuong = TruyVanTheoMa(xaPhuong.MaXaPhuong);
            DB.DMXaPhuongs.DeleteOnSubmit(XaPhuong);
            DB.SubmitChanges();
        }
    }
}
