using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUL
{
    public class XemHoaDonBUL
    {
        XemHoaDonDAL myTK = new XemHoaDonDAL();
        public DataTable XemHoaDon(string ma)
        {
            return myTK.XemHD(ma);
        }
    }
}
