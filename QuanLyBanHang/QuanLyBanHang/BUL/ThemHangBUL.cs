using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class ThemHangBUL
    {
        ThemHangDAL myThemHang = new ThemHangDAL();
        public void ThemHang(string ma, string ten, string dvt, string dg, string ml, string sl, string ncc)
        {
            myThemHang.ThemHang(ma, ten, dvt, dg, ml, sl, ncc);
        }
    }
}
