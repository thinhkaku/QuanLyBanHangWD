using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuaHangDAL
    {
        public void SuaHang(string ma, string ten, string dvt, string dg, string sl)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE Hang SET TenSanPham='" + ten + "', DonGia='" + dg + "', SoLuong='" + sl + "', DonViTinh='"+dvt+"' WHERE MaSanPham='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}

