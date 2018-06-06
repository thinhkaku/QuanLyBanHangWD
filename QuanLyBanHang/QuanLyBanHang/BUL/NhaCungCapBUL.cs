using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
   public class NhaCungCapBUL
    {
        NhaCungCapDAL myNCC = new NhaCungCapDAL();
        public List<NhaCungCapDTO> HienBangNCC()
        {

            return myNCC.BangNhaCungCap();
        }
    }
}
