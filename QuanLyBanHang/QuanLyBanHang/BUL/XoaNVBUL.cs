using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class XoaNVBUL
    {
        XoaNhanVienDAL myXoa = new XoaNhanVienDAL();
        public void Xoasp(string ma)
        {
            myXoa.XoaNV(ma);
        }
    }
}
