using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class HoaDonChiTietBUL
    {
        HoaDonChiTietDAL myHDCT = new HoaDonChiTietDAL();
        public List<HoaDonChiTietDTO> HienBangHDCT()
        {

            return myHDCT.BangHDCT();
        }
    }
}
