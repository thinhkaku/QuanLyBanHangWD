using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XoaNhanVienDAL
    {
        public void XoaNV(string ma)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl2 = "SELECT MaHoaDon FROM HoaDon WHERE MaNhanVien='" + ma + "'";
            SqlCommand cmd2 = new SqlCommand(sqlsl2, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd2.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCoSoDuLieu.Dongketnoi();

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                KetNoiCoSoDuLieu.Moketnoi();
                string sqlsl = "DELETE FROM HoaDonChiTiet WHERE MaHoaDon='" + tb.Rows[i]["MaHoaDon"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
                cmd.ExecuteNonQuery();
                KetNoiCoSoDuLieu.Dongketnoi();

            }

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl3 = "DELETE FROM HoaDon WHERE MaNhanVien='" + ma + "'";
            SqlCommand cmd3 = new SqlCommand(sqlsl3, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd3.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl4 = "DELETE FROM NhanVien WHERE MaNhanVien='" + ma + "'";
            SqlCommand cmd4 = new SqlCommand(sqlsl4, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd4.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
