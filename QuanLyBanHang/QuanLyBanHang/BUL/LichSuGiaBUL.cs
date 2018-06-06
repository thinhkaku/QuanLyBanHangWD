using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class LichSuGiaBUL
    {
        LichSuGiaDAL myLSG = new LichSuGiaDAL();
        public List<LichSuGiaDTO> HienBangLSG()
        {

            return myLSG.BangLichSuGia();
        }
    }
}
