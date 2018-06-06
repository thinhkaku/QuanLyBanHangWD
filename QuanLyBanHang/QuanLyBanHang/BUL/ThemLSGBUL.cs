using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class ThemLSGBUL
    {
        ThemLSGDAL myThemHang = new ThemLSGDAL();
        public void ThemHang(string ma, string ten, string dvt, string dg, string ml)
        {
            myThemHang.ThemLSG(ma, ten, dvt, dg, ml); 
        }
    }
}
