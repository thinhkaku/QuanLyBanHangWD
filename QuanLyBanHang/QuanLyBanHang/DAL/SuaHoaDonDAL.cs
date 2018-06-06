using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class SuaHoaDonDAL
    {
        public void SuaHD(string ma, string ten, string dg, string sl)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE HoaDon SET MaKhachHang='" + ten + "', NgayLap='" + dg + "', MaNhanVien='" + sl + "' WHERE MaHoaDon='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
