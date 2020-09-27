using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DangNhap
    {
        public bool Login(string _Name, string _Pass)
        {
            string sql = @"select *  from NHANVIEN WHERE TenDN = '" + _Name + "' AND MatKhau =  CONVERT(NVARCHAR(32),HASHBYTES('MD5','" + _Pass + "'),2)";

            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
