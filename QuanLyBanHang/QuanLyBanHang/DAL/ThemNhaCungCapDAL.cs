using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThemNhaCungCapDAL
    {
        public void ThemNCC(string ma, string ten, string dvt, string dg)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "INSERT INTO NhaCungCap VALUES(@ma, @ten, @dvt, @dg)";
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
