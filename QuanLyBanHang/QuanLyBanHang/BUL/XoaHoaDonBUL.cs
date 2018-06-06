using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class XoaHoaDonBUL
    {
        XoaHoaDonDAL myXoa = new XoaHoaDonDAL();
        public void Xoasp(string ma)
        {
            myXoa.XoaHD(ma);
        }
    }
}
