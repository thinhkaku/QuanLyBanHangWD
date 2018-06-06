using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class SuaHDCTDAL
    {
        public void SuaHDCT(string ma, string ten, string gc)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE HoaDonChiTiet SET SoLuong='" + gc + "' WHERE MaHoaDon='" + ma + "' AND MaHang='"+ten+"'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
