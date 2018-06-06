using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class XoaLSGBUL
    {
        XoaLSGDAL myXoa = new XoaLSGDAL();
        public void Xoasp(string ma, string nbd)
        {
            myXoa.XoaLSG(ma, nbd);
        }
    }
}
