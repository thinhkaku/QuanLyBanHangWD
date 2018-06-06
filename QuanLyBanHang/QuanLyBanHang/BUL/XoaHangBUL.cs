using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class XoaHangBUL
    {
        XoaHangDAL myXoa = new XoaHangDAL();
        public void Xoasp(string ma)
        {
            myXoa.XoaHang(ma);
        }
    }
}
