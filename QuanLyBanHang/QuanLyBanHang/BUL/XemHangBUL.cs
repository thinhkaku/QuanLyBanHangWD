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
    public class XemHangBUL
    {
        XemHangDAL myTK = new XemHangDAL();
        public DataTable Timkiemsp(string ma)
        {
            return myTK.XemHang(ma);
        }
    }
}
