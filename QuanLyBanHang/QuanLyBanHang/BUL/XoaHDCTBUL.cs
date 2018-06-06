using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class XoaHDCTBUL
    {
        XoaHDCTDAL myXoa = new XoaHDCTDAL();
        public void Xoasp(string ma, string nbd)
        {
            myXoa.XoaHDCT(ma, nbd);
        }
    }
}
