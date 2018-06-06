using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XoaLoaiHangDAL
    {
        public void XoaLoaiHang(string ma)
        {

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl2 = "SELECT MaSanPham FROM Hang WHERE MaLoai='" + ma + "'";
            SqlCommand cmd2 = new SqlCommand(sqlsl2, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd2.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCoSoDuLieu.Dongketnoi();

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                KetNoiCoSoDuLieu.Moketnoi();
                string sqlsl = "DELETE FROM HoaDonChiTiet WHERE MaHang='" + tb.Rows[i]["MaSanPham"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
                cmd.ExecuteNonQuery();
                KetNoiCoSoDuLieu.Dongketnoi();

                KetNoiCoSoDuLieu.Moketnoi();
                string sqlsl1 = "DELETE FROM LichSuGia WHERE MaHang='" + tb.Rows[i]["MaSanPham"].ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(sqlsl1, KetNoiCoSoDuLieu.chuoiketnoi);
                cmd1.ExecuteNonQuery();
                KetNoiCoSoDuLieu.Dongketnoi();
            }

           

            KetNoiCoSoDuLieu.Moketnoi();
            string sqls3 = "DELETE FROM Hang WHERE MaLoai='" + ma + "'";
            SqlCommand cmd3 = new SqlCommand(sqls3, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd3.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();

            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl4 = "DELETE FROM LoaiHang WHERE MaLoai='" + ma + "'";
            SqlCommand cmd4 = new SqlCommand(sqlsl4, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd4.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
