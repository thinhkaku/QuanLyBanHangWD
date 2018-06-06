using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public string NgayLap { get; set; }
        public string MaNhanVien { get; set; }

        public HoaDonDTO() { }
        public HoaDonDTO(string mhd, string mkh, string nl, string mnv)
        {
            MaHoaDon = mhd;
            MaKhachHang = mkh;
            NgayLap = nl;
            MaNhanVien = mnv;
        }
    }
}
