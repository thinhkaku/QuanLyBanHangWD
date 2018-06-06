using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public KhachHangDTO() { }
        public KhachHangDTO(string mncc, string ht, string dc, string sdt)
        {
            MaKhachHang = mncc;
            HoTen = ht;
            DiaChi = dc;
            SoDienThoai = sdt;
        }
    }
}
