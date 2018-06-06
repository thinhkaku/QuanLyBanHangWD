using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class SuaHoaDonBUL
    {
        SuaHoaDonDAL mySua = new SuaHoaDonDAL();
        public void Suasp(string ma, string ten, string dvt, string dg)
        {
            mySua.SuaHD(ma, ten, dvt, dg);
        }
    }
}
