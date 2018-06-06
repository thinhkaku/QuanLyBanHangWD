using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class HoaDonDAL
    {
        public List<HoaDonDTO> BangHoaDon()
        {
            List<HoaDonDTO> ds = new List<HoaDonDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "SELECT * FROM HoaDon";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoaDonDTO sp = new HoaDonDTO(dr["MaHoaDon"].ToString(), dr["MaKhachHang"].ToString(), dr["NgayLap"].ToString(), dr["MaNhanVien"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }
    }
}
