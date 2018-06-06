using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class ThemNCCBUL
    {
        ThemNhaCungCapDAL myThemHang = new ThemNhaCungCapDAL();
        public void ThemHang(string ma, string ten, string dvt, string dg)
        {
            myThemHang.ThemNCC(ma, ten, dvt, dg);
        }
    }
}
