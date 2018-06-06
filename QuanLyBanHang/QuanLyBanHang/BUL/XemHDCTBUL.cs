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
    public class XemHDCTBUL
    {
        XemHDCTDAL myTK = new XemHDCTDAL();
        public DataTable XemHDCT(string ma)
        {
            return myTK.XemHDCT(ma);
        }
    }
}
