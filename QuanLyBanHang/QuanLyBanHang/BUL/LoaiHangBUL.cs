using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class LoaiHangBUL
    {
        LoaiHangDAL myLoaiHang = new LoaiHangDAL();
        public List<LoaiHangDTO> HienBangLH()
        {

            return myLoaiHang.BangLoaiHang();
        }
    }
}
