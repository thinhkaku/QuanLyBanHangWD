using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class XemHoaDonDAL
    {
        public DataTable XemHD(string ma)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "SELECT * FROM HoaDon WHERE MaHoaDon='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCoSoDuLieu.Dongketnoi();
            return tb;
        }
    }
}
