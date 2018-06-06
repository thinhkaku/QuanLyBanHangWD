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

        public bool KTMaTrung(string ma)
        {
            bool check = false;
            KetNoiCoSoDuLieu.Moketnoi();
            string Sql = "select * from NhaCungCap where MaNhaCungCap='" + ma + "'";
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
