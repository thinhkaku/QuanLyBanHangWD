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
    public class LoaiHangDAL
    {
        public List<LoaiHangDTO> BangLoaiHang()
        {
            List<LoaiHangDTO> ds = new List<LoaiHangDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "select *, lh.MaLoai as 'STT' from LoaiHang lh";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHangDTO sp = new LoaiHangDTO( dr["STT"].ToString(), dr["MaLoai"].ToString(), dr["TenLoai"].ToString(), dr["GhiChu"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }
        public bool KTMaTrung(string ma)
        {
            bool check = false;
            KetNoiCoSoDuLieu.Moketnoi();
            string Sql = "select * from LoaiHang where MaLoai='"+ma+"'";
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
