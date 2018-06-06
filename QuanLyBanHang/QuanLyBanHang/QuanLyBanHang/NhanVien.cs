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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBUL myNhanVien = new NhanVienBUL();
        ThemNVBUL myThemNV = new ThemNVBUL();
        SuaNVBUL mySuaNV = new SuaNVBUL();
        XemNVBUL myXemNV = new XemNVBUL();
        XoaNVBUL myXoaNV = new XoaNVBUL();
        void HienNV()
        { dgvDanhMuc.DataSource = myNhanVien.HienBangNV(); }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienNV();
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
               
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            myThemNV.ThemHang(txtMaNV.Text, txtTenNV.Text, txtDiaChiNV.Text, txtSDTNV.Text);
            HienNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mySuaNV.Suasp(txtMaNV.Text, txtTenNV.Text, txtDiaChiNV.Text, txtSDTNV.Text);
            HienNV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            myXoaNV.Xoasp(txtMaNV.Text);
            HienNV();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = myXemNV.Timkiemsp(txtMaNV.Text);
        }
    }
}
