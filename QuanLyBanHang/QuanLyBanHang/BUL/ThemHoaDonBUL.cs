using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class ThemHoaDonBUL
    {
        ThemHoaDonDAL myThemHang = new ThemHoaDonDAL();
        public void ThemHang(string ma, string ten, string dvt, string dg)
        {
            myThemHang.ThemHD(ma, ten, dvt, dg);
        }
    }
}
