using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThemLSGDAL
    {
        public void ThemLSG(string ma, string ten, string dvt, string dg, string ml)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "INSERT INTO LichSuGia VALUES(@ma, @ten, @dvt, @dg, @ml)";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("dvt", dvt);
            cmd.Parameters.AddWithValue("dg", dg);
            cmd.Parameters.AddWithValue("ml", ml);
            
            

            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
