using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class ThemKHBUL
    {
        ThenKhachHangDAL myThemHang = new ThenKhachHangDAL();
        public void ThemHang(string ma, string ten, string dvt, string dg)
        {
            myThemHang.ThemKH(ma, ten, dvt, dg);
        }
    }
}
