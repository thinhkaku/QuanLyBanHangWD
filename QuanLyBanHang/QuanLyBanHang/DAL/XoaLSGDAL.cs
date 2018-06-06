using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XoaLSGDAL
    {
        public void XoaLSG(string ma, string nbd)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM LichSuGia WHERE MaHang='" + ma + "' AND NgayBatDau='"+nbd+"'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
