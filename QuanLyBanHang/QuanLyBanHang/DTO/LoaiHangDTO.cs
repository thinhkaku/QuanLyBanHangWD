using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHangDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }
        public string STT { get; set; }

        public LoaiHangDTO() { }
        public LoaiHangDTO( string stt, string ma, string ten, string gc)
        {
            STT = stt;
            MaLoai = ma;
            TenLoai = ten;
            GhiChu = gc;
        }
    }
}
