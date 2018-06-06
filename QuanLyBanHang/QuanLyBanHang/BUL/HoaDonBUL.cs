using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class HoaDonBUL
    {
        HoaDonDAL myHoaDon = new HoaDonDAL();
        public List<HoaDonDTO> HienBangHD()
        {

            return myHoaDon.BangHoaDon();
        }
    }
}
