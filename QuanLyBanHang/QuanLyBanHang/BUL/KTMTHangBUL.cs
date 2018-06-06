using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class KTMTHangBUL
    {
        HangDAL myHang = new HangDAL();
        public bool KT_MaTrung(string ma)
        {

            return myHang.KTMaTrung(ma);
        }
    }
}
