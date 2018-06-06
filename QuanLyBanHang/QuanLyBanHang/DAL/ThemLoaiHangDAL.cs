using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ThemLoaiHangDAL
    {
        public void ThemLoaiHang(string ma, string ten, string gc)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "INSERT INTO LoaiHang VALUES(@ma, @ten, @gc)";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("gc", gc);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
