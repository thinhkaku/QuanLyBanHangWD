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
    public class XemLoaiHangBUL
    {
        XemLoaiHangDAL myTK = new XemLoaiHangDAL();
        public DataTable Timkiemsp(string ma)
        {
            return myTK.XemLoaiHang(ma);
        }
    }
}
