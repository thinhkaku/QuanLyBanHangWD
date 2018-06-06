using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XoaKhachHangDAL
    {
        public void XoaKH(string ma)
        {


            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl2 = "SELECT MaHoaDon FROM HoaDon WHERE MaKhachHang='" + ma + "'";
            SqlCommand cmd2 = new SqlCommand(sqlsl2, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd2.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCoSoDuLieu.Dongketnoi();

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                KetNoiCoSoDuLieu.Moketnoi();
                string sqlsl3 = "DELETE FROM HoaDonChiTiet WHERE MaHoaDon='" + tb.Rows[i]["MaHoaDon"].ToString() + "'";
                SqlCommand cmd3 = new SqlCommand(sqlsl3, KetNoiCoSoDuLieu.chuoiketnoi);
                cmd3.ExecuteNonQuery();
                KetNoiCoSoDuLieu.Dongketnoi();
            }


            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl1 = "DELETE FROM HoaDon WHERE MaKhachHang='" + ma + "'";
            SqlCommand cmd1 = new SqlCommand(sqlsl1, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd1.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM KhachHang WHERE MaKhachHang='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
