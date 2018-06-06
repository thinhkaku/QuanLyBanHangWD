using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVienDTO() { }
        public NhanVienDTO(string mnv, string ht, string dc, string sdt)
        {
            MaNhanVien = mnv;
            HoTen = ht;
            DiaChi = dc;
            SoDienThoai = sdt;
        }
    }
}
