using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuaLoaiHangDAL
    {
        public void SuaLoaiHang(string ma, string ten, string gc)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE LoaiHang SET TenLoai='" + ten + "', GhiChu='" + gc + "' WHERE MaLoai='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
