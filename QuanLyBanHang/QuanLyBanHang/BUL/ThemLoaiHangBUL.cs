using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class ThemLoaiHangBUL
    {
        ThemLoaiHangDAL myThemLoaiHang = new ThemLoaiHangDAL();
        public void ThemHang(string ma, string ten, string gc)
        {
            myThemLoaiHang.ThemLoaiHang(ma, ten, gc);
        }
    }
}
