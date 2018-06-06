using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class KTMT_LSGBUL
    {
        LichSuGiaDAL myHang = new LichSuGiaDAL();
        public bool KT_MaTrung(string ma, string nbd)
        {

            return myHang.KTMaTrung(ma, nbd);
        }
    }
}
