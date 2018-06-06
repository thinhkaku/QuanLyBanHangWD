using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class KhachHangBUL
    {
        KhachHangDAL myKH = new KhachHangDAL();
        public List<KhachHangDTO> HienBangKH()
        {

            return myKH.BangKhachHang();
        }
    }
}
