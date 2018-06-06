using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class XoaLoaiHangBUL
    {
        XoaLoaiHangDAL myXoa = new XoaLoaiHangDAL();
        public void Xoasp(string ma)
        {
            myXoa.XoaLoaiHang(ma);
        }
    }
}
