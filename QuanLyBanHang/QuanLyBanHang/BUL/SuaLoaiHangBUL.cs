using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class SuaLoaiHangBUL
    {
        SuaLoaiHangDAL mySua = new SuaLoaiHangDAL();
        public void Suasp(string ma, string ten, string gc)
        {
            mySua.SuaLoaiHang(ma, ten, gc);
        }
    }
}
