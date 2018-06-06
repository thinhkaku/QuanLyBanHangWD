using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class SuaKHBUL
    {
        SuaKhachHangDAL mySua = new SuaKhachHangDAL();
        public void Suasp(string ma, string ten, string dvt, string dg)
        {
            mySua.SuaKH(ma, ten, dvt, dg);
        }
    }
}
