using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class ThemNVBUL
    {
        ThemNhanVienDAL myThemHang = new ThemNhanVienDAL();
        public void ThemHang(string ma, string ten, string dvt, string dg)
        {
            myThemHang.ThemNV(ma, ten, dvt, dg);
        }
    }
}
