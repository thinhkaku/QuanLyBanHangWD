using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class SuaNCCBUL
    {
        SuaNCCDAL mySua = new SuaNCCDAL();
        public void Suasp(string ma, string ten, string dvt, string dg)
        {
            mySua.SuaNCC(ma, ten, dvt, dg);
        }
    }
}
