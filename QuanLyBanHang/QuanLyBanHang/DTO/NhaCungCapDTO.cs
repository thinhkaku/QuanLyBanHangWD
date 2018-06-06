using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NhaCungCapDTO() { }
        public NhaCungCapDTO(string mncc, string tncc, string dc, string sdt)
        {
            MaNhaCungCap = mncc;
            TenNhaCungCap = tncc;
            DiaChi = dc;
            SoDienThoai = sdt;
        }
    }
}
