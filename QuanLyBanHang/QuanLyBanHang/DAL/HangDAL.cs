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
    public class HangDAL
    {
        public List<HangDTO> BangHang()
        {
            List<HangDTO> ds = new List<HangDTO>();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "select *, h.DonGia as 'STT' from Hang h";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HangDTO sp = new HangDTO(dr["DonGia"].ToString(), dr["MaSanPham"].ToString(), dr["TenSanPham"].ToString(), dr["DonViTinh"].ToString(), dr["DonGia"].ToString(), dr["MaLoai"].ToString(), dr["SoLuong"].ToString(), dr["MaNhaCungCap"].ToString());
                ds.Add(sp);
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return ds;
        }

        public bool KTMaTrung(string ma)
        {
            bool check = false;
            KetNoiCoSoDuLieu.Moketnoi();
            string Sql = "select * from Hang where MaSanPham='" + ma + "'";
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
