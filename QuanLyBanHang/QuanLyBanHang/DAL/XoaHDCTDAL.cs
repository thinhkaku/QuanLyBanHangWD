using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class XoaHDCTDAL
    {
        public void XoaHDCT(string ma, string ten)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM HoaDonChiTiet WHERE MaHoaDon='" + ma + "' AND MaHang='" + ten + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
