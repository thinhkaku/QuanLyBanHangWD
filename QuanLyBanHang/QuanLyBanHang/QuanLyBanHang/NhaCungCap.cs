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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCapBUL myNCC = new NhaCungCapBUL();
        ThemNCCBUL myThemNCC = new ThemNCCBUL();
        SuaNCCBUL mySuaNCC = new SuaNCCBUL();
        XemNCCBUL myXemNCC = new XemNCCBUL();
        XoaNCCBUL myXoaNCC = new XoaNCCBUL();

        void HienNCC()
        { dgvDanhMuc.DataSource = myNCC.HienBangNCC(); }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            HienNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            myThemNCC.ThemHang(txtMaNhaCungCap.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDTNCC.Text);
            HienNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mySuaNCC.Suasp(txtMaNhaCungCap.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDTNCC.Text);
            HienNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            myXoaNCC.Xoasp(txtMaNhaCungCap.Text);
            HienNCC();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = myXemNCC.Timkiemsp(txtMaNhaCungCap.Text);
        }


    }
}
