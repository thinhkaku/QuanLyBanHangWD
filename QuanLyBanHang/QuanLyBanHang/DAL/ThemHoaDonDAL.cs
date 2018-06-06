using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ThemHoaDonDAL
    {
        public void ThemHD(string ma, string ten, string dvt, string dg)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "INSERT INTO HoaDon VALUES(@ma, @ten, @dvt, @dg)";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("dvt", dvt);
            cmd.Parameters.AddWithValue("dg", dg);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
