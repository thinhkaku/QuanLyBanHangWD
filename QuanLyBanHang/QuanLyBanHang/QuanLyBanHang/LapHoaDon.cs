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
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
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
        ThemHoaDonBUL myThemHD = new ThemHoaDonBUL();
        NhanVienBUL myNV = new NhanVienBUL();
        ThemHDCTBUL myThemHDCT = new ThemHDCTBUL();

        
        
        int dong = 0;

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            colMa.DataSource = myHang.HienBangHang();
            colMa.DisplayMember = "TenSP";
            colMa.ValueMember = "MaSP";

            cmbMaKH.DataSource = myKH.HienBangKH();
            cmbMaKH.DisplayMember = "HoTen";
            cmbMaKH.ValueMember = "MaKhachHang";

            cmbTenNV.DataSource = myNV.HienBangNV();
            cmbTenNV.DisplayMember = "HoTen";
            cmbTenNV.ValueMember = "MaNhanVien";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dgvThongTin_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTin.Rows[dong].Cells[2].Value != "0" && dgvThongTin.Rows[dong].Cells[1].Value != "0")
            {
                try
                {
                    dgvThongTin.Rows[dong].Cells[3].Value = (double.Parse(dgvThongTin.Rows[dong].Cells[1].Value.ToString()) * double.Parse(dgvThongTin.Rows[dong].Cells[2].Value.ToString())).ToString();
                }
                catch
                {
                }
            }

            try
            {
                DataTable dt = new DataTable();
                dt = myXemHang.Timkiemsp(dgvThongTin.Rows[dong].Cells[0].Value.ToString());
                dgvThongTin.Rows[dong].Cells[2].Value = double.Parse(dt.Rows[0]["DonGia"].ToString()).ToString();

            }
            catch
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myThemHD.ThemHang(txtMaHD.Text, cmbMaKH.SelectedValue.ToString(), DateTime.Now.ToString(), cmbTenNV.SelectedValue.ToString());

            try
            {
                for (int i = 0; i < dgvThongTin.Rows.Count - 1; i++)
                {
                    myThemHDCT.ThemHang(txtMaHD.Text, dgvThongTin.Rows[i].Cells[0].Value.ToString(), dgvThongTin.Rows[i].Cells[1].Value.ToString());
                }
                MessageBox.Show("Da Luu Thanh Cong !");
            }
            catch
            {
            }
        }

    }
}
