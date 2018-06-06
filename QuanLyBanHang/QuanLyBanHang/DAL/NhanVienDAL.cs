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

        public NhanVienDTO getNhanVien(String ma)
        {
            NhanVienDTO nv=new NhanVienDTO();
            KetNoiCoSoDuLieu.Moketnoi();
            string SQlSL = "select * from NhanVien where MaNhanVien='" + ma + "'";
            SqlCommand cmd = new SqlCommand(SQlSL, KetNoiCoSoDuLieu.chuoiketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               nv = new NhanVienDTO(dr["MaNhanVien"].ToString(), dr["HoTen"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString());
                
            }
            KetNoiCoSoDuLieu.Dongketnoi();
            return nv;

        }

        public bool KTMaTrung(string ma)
        {
            bool check = false;
            KetNoiCoSoDuLieu.Moketnoi();
            string Sql = "select * from NhanVien where MaNhanVien='" + ma + "'";
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
