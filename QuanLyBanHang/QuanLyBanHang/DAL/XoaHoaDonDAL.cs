using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class XoaHoaDonDAL
    {
        public void XoaHD(string ma)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM HoaDon WHERE MaHoaDon='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
