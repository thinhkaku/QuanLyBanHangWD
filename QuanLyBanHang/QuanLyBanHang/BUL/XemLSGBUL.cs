using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUL
{
    public class XemLSGBUL
    {
        XemLSGDAL myTK = new XemLSGDAL();
        public DataTable Timkiemsp(string ma, string ten)
        {
            return myTK.XemLSG(ma, ten);
        }
    }
}
