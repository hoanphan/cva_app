using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ModemConfigBLL
    {
        static SchoolManagementDataContext DB = new SchoolManagementDataContext(UTL.Ultils.GetConnectionString());

        public static bool LayThongTinModem(ref string comPort, ref int baudRate, ref int dataBits, ref string parity, ref float stopBit)
        {
            ModemConfig md = DB.ModemConfigs.FirstOrDefault();
            if (md != null)
            {
                comPort = md.PortCom;
                baudRate = int.Parse(md.BaudRate);
                dataBits = int.Parse(md.DataBits);
                parity = md.Parity;
                stopBit = float.Parse(md.StopBits);
                return true;
            }
            return false;
        }
    }
}
