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
    public class LichSuGiaDAL
    {
        public List<LichSuGiaDTO> BangLichSuGia()
        {
            List<LichSuGiaDTO> ds = new List<LichSuGiaDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "SELECT * FROM LichSuGia";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LichSuGiaDTO sp = new LichSuGiaDTO(dr["MaHang"].ToString(), dr["NgayBatDau"].ToString(), dr["NgayKetThuc"].ToString(), dr["DonGia"].ToString(), dr["NgayCapNhat"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }

        public bool KTMaTrung(string ma, string nbd)
        {
            bool check = false;
            KetNoiCoSoDuLieu.Moketnoi();
            string Sql = "select * from LichSuGia where MaHang='" + ma + "' AND NgayBatDau='"+ nbd +"'";
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
