using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuaLSGDAL
    {
        public void SuaLSG(string ma, string ten, string dg, string sl, string ncc)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE LichSuGia SET NgayKetThuc='" + dg + "', DonGia='" + sl + "', NgayCapNhat='" + ncc + "' WHERE MaHang='" + ma + "' AND NgayBatDau='" + ten +"'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
