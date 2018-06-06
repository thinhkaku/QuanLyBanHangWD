using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class NhanVienBUL
    {
        NhanVienDAL myNV = new NhanVienDAL();
        public List<NhanVienDTO> HienBangNV()
        {
            return myNV.BangNhanVien();
        }
        public NhanVienDTO getNhanVien(String ma)
        {
            return myNV.getNhanVien(ma);
        }
    }
}
