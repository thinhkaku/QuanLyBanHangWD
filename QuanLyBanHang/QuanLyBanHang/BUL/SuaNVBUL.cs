using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class SuaNVBUL
    {
        SuaNhanVienDAL mySua = new SuaNhanVienDAL();
        public void Suasp(string ma, string ten, string dvt, string dg)
        {
            mySua.SuaNV(ma, ten, dvt, dg);
        }
    }
}
