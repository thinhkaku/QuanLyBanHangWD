using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuGiaDTO
    {
        public string MaHang { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string DonGia { get; set; }
        public string NgayCapNhat { get; set; }

        public LichSuGiaDTO() { }
        public LichSuGiaDTO(string mh, string nbd, string nkt, string dg, string ncn)
        {
            MaHang = mh;
            NgayBatDau = nbd;
            NgayKetThuc = nkt;
            DonGia = dg;
            NgayCapNhat = ncn;
        }
    }
}
