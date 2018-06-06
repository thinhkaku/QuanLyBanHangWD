using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class NhaCungCapDAL
    {
        public List<NhaCungCapDTO> BangNhaCungCap()
        {
            List<NhaCungCapDTO> ds = new List<NhaCungCapDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "SELECT * FROM NhaCungCap";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhaCungCapDTO sp = new NhaCungCapDTO(dr["MaNhaCungCap"].ToString(), dr["TenNhaCungCap"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }
    }
}
