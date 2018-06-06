using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class HoaDonChiTietDAL
    {
        public List<HoaDonChiTietDTO> BangHDCT()
        {
            List<HoaDonChiTietDTO> ds = new List<HoaDonChiTietDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "SELECT * FROM HoaDonChiTiet";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoaDonChiTietDTO sp = new HoaDonChiTietDTO(dr["MaHoaDon"].ToString(), dr["MaHang"].ToString(), dr["SoLuong"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }
    }
}
