using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class KTMTLoaiHangBUL
    {
        LoaiHangDAL myLoaiHang = new LoaiHangDAL();
        public bool KT_MaTrung(string ma)
        {

            return myLoaiHang.KTMaTrung(ma);
        }
    }
}
