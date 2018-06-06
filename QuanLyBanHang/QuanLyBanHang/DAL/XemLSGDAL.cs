using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XemLSGDAL
    {
        public DataTable XemLSG(string ma, string ten)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "SELECT * FROM LichSuGia WHERE MaHang='" + ma + "' AND NgayBatDau='" + ten + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCoSoDuLieu.Dongketnoi();
            return tb;
        }
    }
}
