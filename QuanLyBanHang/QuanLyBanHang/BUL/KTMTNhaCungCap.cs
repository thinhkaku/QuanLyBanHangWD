using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUL
{
    public class KTMTNhaCungCap
    {
        private NhaCungCapDAL nccDal = new NhaCungCapDAL();
        public bool KT_MaTrung(string ma)
        {

            return nccDal.KTMaTrung(ma);
        }
    }
}
