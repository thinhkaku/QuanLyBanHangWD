using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class SuaHDCTBUL
    {
        SuaHDCTDAL mySua = new SuaHDCTDAL();
        public void Suasp(string ma, string ten, string gc)
        {
            mySua.SuaHDCT(ma, ten, gc);
        }
    }
}
