using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class SuaLSGBUL
    {
        SuaLSGDAL mySua = new SuaLSGDAL();
        public void Suasp(string ma, string ten, string dvt, string dg, string sl)
        {
            mySua.SuaLSG(ma, ten, dvt, dg, sl);
        }
    }
}
