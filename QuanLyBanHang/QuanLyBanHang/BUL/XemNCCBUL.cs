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
    public class XemNCCBUL
    {
        XemNCCDAL myTK = new XemNCCDAL();
        public DataTable Timkiemsp(string ma)
        {
            return myTK.XemNCC(ma);
        }
    }
}
