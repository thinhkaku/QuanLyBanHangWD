using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL
    {
        public List<NhanVienDTO> BangNhanVien()
        {
            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "SELECT * FROM NhanVien";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVienDTO sp = new NhanVienDTO(dr["MaNhanVien"].ToString(), dr["HoTen"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }
    }
}
