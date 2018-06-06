using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetNoiCoSoDuLieu
    {
        private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLchuoiketnoi"].ToString());
        public static SqlConnection chuoiketnoi
        {
            get { return KetNoiCoSoDuLieu.conn; }
        }
        public static void Moketnoi()
        {
            conn.Open();
        }
        public static void Dongketnoi()
        {
            conn.Close();
        }
    }
}
