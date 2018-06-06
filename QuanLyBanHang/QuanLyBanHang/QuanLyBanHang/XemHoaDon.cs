using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;

namespace QuanLyBanHang
{
    public partial class frmXemHoaDon : Form
    {
        public frmXemHoaDon()
        {
            InitializeComponent();
        }
        HangBUL myHang = new HangBUL();
        HoaDonBUL myHD = new HoaDonBUL();
        HoaDonChiTietBUL myHDCT = new HoaDonChiTietBUL();
        XemHangBUL myXemHang = new XemHangBUL();
        HoaDonDTO HD = new HoaDonDTO();
        HoaDonChiTietDTO HDCT = new HoaDonChiTietDTO();
        KhachHangBUL myKH = new KhachHangBUL();
        //ThemHoaDonBUL myThemHD = new ThemHoaDonBUL();
        NhanVienBUL myNV = new NhanVienBUL();
        XemHDCTBUL myXemHDCT = new XemHDCTBUL();
        XemHoaDonBUL myXemHoaDon = new XemHoaDonBUL();
        XemKHBUL myXemKH = new XemKHBUL();
        //ThemHDCTBUL myThemHDCT = new ThemHDCTBUL();

        private void frmXemHoaDon_Load(object sender, EventArgs e)
        {
            cmbMaHD.DataSource = myHD.HienBangHD();
            cmbMaHD.DisplayMember = "MaHoaDon";
            cmbMaHD.ValueMember = "MaHoaDon";           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
             dt = myXemHDCT.XemHDCT(cmbMaHD.SelectedValue.ToString());
             //MessageBox.Show(dt.Rows.Count.ToString());
             DataTable dt1 = new DataTable();
             dt1 = myXemHoaDon.XemHoaDon(cmbMaHD.SelectedValue.ToString());

             DataTable dt2 = new DataTable();
            dt2 = myXemHang.Timkiemsp(dt.Rows[0]["MaHang"].ToString());


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvThongTin.Rows[i].Cells[0].Value = dt.Rows[0]["MaHoaDon"];
                dgvThongTin.Rows[i].Cells[1].Value = dt.Rows[i]["MaHang"];
                dgvThongTin.Rows[i].Cells[2].Value = dt1.Rows[0]["MaKhachHang"];
                dgvThongTin.Rows[i].Cells[3].Value = dt1.Rows[0]["NgayLap"];
                dgvThongTin.Rows[i].Cells[4].Value = dt1.Rows[0]["MaNhanVien"];


                dgvThongTin.Rows[i].Cells[6].Value = dt2.Rows[0]["DonGia"];
                dgvThongTin.Rows[i].Cells[7].Value = (double.Parse(dt.Rows[i]["SoLuong"].ToString()) * double.Parse(dt2.Rows[0]["DonGia"].ToString())).ToString();
                dgvThongTin.Rows[i].Cells[5].Value = double.Parse(dt.Rows[i]["SoLuong"].ToString()).ToString();
                
            }
            
        }
    }
}
