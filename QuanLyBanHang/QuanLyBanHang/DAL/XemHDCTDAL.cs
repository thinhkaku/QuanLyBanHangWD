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
    public class XemHDCTDAL
    {
        public DataTable XemHDCT(string ma)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "SELECT * FROM HoaDonChiTiet WHERE MaHoaDon='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCoSoDuLieu.Dongketnoi();
            return tb;
        }
    }
}
