using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTietDTO
    {
        public string MaHoaDon { get; set; }
        public string MaHang { get; set; }
        public string SoLuong { get; set; }

        public HoaDonChiTietDTO() { }
        public HoaDonChiTietDTO(string mhd, string mh, string sl)
        {
            MaHoaDon = mhd;
            MaHang = mh;
            SoLuong = sl;
        }
    }
}
