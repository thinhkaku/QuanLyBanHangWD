using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class XoaHangDAL
    {
        public void XoaHang(string ma)
        {

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl1 = "DELETE FROM HoaDonChiTiet WHERE MaHang='" + ma + "'";
            SqlCommand cmd2 = new SqlCommand(sqlsl1, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd2.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM LichSuGia WHERE MaHang='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();

            KetNoiCoSoDuLieu.Moketnoi();
            string sqls = "DELETE FROM Hang WHERE MaSanPham='" + ma + "'";
            SqlCommand cmd1 = new SqlCommand(sqls, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd1.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
           
        }
    }
}
