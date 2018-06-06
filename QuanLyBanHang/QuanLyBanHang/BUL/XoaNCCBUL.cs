using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class XoaNCCBUL
    {
        XoaNCCDAL myXoa = new XoaNCCDAL();
        public void Xoasp(string ma)
        {
            myXoa.XoaNCC(ma);
        }
    }
}
