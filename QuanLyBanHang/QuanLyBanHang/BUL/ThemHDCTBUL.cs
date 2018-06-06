using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class ThemHDCTBUL
    {
        ThemHDCTDAL myThemLoaiHang = new ThemHDCTDAL();
        public void ThemHang(string ma, string ten, string gc)
        {
            myThemLoaiHang.ThemHDCT(ma, ten, gc);
        }
    }
}
