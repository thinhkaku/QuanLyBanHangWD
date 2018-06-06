using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuaKhachHangDAL
    {
        public void SuaKH(string ma, string ten, string dg, string sl)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE KhachHang SET HoTen='" + ten + "', DiaChi='" + dg + "', SoDienThoai='" + sl + "' WHERE MaKhachHang='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
