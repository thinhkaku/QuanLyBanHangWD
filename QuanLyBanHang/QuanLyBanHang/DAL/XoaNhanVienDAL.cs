using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XoaNhanVienDAL
    {
        public void XoaNV(string ma)
        {
            KetNoiCoSoDuLieu.Moketnoi();
            string sqlsl = "DELETE FROM NhanVien WHERE MaNhanVien='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlsl, KetNoiCoSoDuLieu.chuoiketnoi);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.Dongketnoi();
        }
    }
}
