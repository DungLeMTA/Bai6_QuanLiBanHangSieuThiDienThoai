using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class KetNoiDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=DESKTOP-SAU51IQ;Initial Catalog=Bai6_BanHangSieuThi;Integrated Security=True");

        }
    }
}
