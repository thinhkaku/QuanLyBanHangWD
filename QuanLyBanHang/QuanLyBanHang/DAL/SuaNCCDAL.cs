using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuaNCCDAL
    {
        public void SuaNCC(string ma, string ten, string dg, string sl)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "UPDATE NhaCungCap SET TenNhaCungCap='" + ten + "', DiaChi='" + dg + "', SoDienThoai='" + sl + "' WHERE MaNhaCungCap='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
