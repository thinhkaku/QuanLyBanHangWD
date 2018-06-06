using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class XoaKHBUL
    {
        XoaKhachHangDAL myXoa = new XoaKhachHangDAL();
        public void Xoasp(string ma)
        {
            myXoa.XoaKH(ma);
        }
    }
}
