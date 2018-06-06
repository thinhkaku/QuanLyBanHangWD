using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class KTMTKhachHangBUL
    {
        KhachHangDAL myHang = new KhachHangDAL();
        public bool KT_MaTrung(string ma)
        {

            return myHang.KTMaTrung(ma);
        }
    }
}
