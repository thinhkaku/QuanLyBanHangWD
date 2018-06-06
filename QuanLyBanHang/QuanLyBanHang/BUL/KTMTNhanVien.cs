using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class KTMTNhanVien
    {
        NhanVienDAL nhanVienDal = new NhanVienDAL();
        public bool KT_MaTrung(string ma)
        {
            return nhanVienDal.KTMaTrung(ma);
        }
    }
}
