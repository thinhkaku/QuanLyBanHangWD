using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string MaLoai { get; set; }
        public string DonViTinh { get; set; }
        public string MaNCC { get; set; }
        public string STT { get; set; }

        public HangDTO() { }
        public HangDTO(string stt, string ma, string ten, string dvt, string dg, string ml, string sl, string mncc)
        {
            STT = stt;
            MaSP = ma;
            TenSP = ten;
            SoLuong = sl;
            DonGia = dg;
            MaLoai = ml;
            DonViTinh = dvt;
            MaNCC = mncc;
        }
 
    }
}
