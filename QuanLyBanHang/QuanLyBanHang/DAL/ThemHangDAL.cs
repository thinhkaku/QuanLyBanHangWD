using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ThemHangDAL
    {
        public void ThemHang(string ma, string ten, string dvt, string dg, string ml, string sl, string ncc)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "INSERT INTO Hang VALUES(@ma, @ten, @dvt, @dg, @ml, @sl, @ncc)";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("dvt", dvt);
            cmd.Parameters.AddWithValue("dg", dg);
            cmd.Parameters.AddWithValue("ml", ml);
            cmd.Parameters.AddWithValue("sl", sl);
            cmd.Parameters.AddWithValue("ncc", ncc);

            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
