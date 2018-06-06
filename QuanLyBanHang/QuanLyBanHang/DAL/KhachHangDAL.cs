    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> BangKhachHang()
        {
            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHangDTO sp = new KhachHangDTO(dr["MaKhachHang"].ToString(), dr["HoTen"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }

        public bool KTMaTrung(string ma)
        {
            bool check = false;
            KetNoiCoSoDuLieu.Moketnoi();
            string Sql = "select * from KhachHang where MaKhachHang='" + ma + "'";
            SqlDataAdapter da_kiemtra = new SqlDataAdapter(Sql, KetNoiCoSoDuLieu.chuoiketnoi);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);

            if (dt_kiemtra.Rows.Count > 0)
            {
                check = true;
            }
            da_kiemtra.Dispose();
            KetNoiCoSoDuLieu.Dongketnoi();
            return check;
        }
    }
}
