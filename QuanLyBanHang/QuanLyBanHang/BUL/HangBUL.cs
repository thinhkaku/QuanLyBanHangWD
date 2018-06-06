using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class HangBUL
    {
        HangDAL myHang = new HangDAL();
        public List<HangDTO> HienBangHang()
        {
            return myHang.BangHang();
        }
    }
}
