using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XoaNCCDAL
    {
        public void XoaNCC(string ma)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM NhaCungCap WHERE MaNhaCungCap='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
