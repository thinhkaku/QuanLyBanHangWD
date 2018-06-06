using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class SuaHangBUL
    {
        SuaHangDAL mySua = new SuaHangDAL();
        public void Suasp(string ma, string ten, string dvt, string dg, string sl)
        {
            mySua.SuaHang(ma, ten, dvt, dg, sl);
        }
    }
}
