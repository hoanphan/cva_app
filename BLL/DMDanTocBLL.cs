using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DMDanTocBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());
        public static List<DMDanToc> LoadAll()
        {
            return DB.DMDanTocs.ToList();
        }

        public static DMDanToc TruyVanTheoMa(short maDanToc)
        {
            return DB.DMDanTocs.Where(q => q.MaDanToc == maDanToc).FirstOrDefault();
        }

        public static void ThemDanToc(string tenDanToc)
        {
            DMDanToc DanToc = new DMDanToc
            {
                TenDanToc = tenDanToc
            };
            DB.DMDanTocs.InsertOnSubmit(DanToc);
            DB.SubmitChanges();
        }

        public static void CapNhatDanToc(DMDanToc danToc)
        {
            DMDanToc DanToc = TruyVanTheoMa(danToc.MaDanToc);
            DanToc = danToc;
            DB.SubmitChanges();
        }

        public static void XoaDanToc(short maDanToc)
        {
            DMDanToc DanToc = TruyVanTheoMa(maDanToc);
            DB.DMDanTocs.DeleteOnSubmit(DanToc);
            DB.SubmitChanges();
        }

        /// <summary>
        /// Trả về mã dân tộc của dân tộc không thống kê trong việc thống kê dựa vào dân tộc
        /// Cụ thể ở đây là dân tộc Kinh
        /// </summary>
        public static short LayMaDanTocKhongThongKe()
        {
            return DB.DMDanTocs.Where(q => q.ThongKeDanToc == false).Select(q => q.MaDanToc).FirstOrDefault();
        }
    }
}
