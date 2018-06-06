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
    public partial class frmHang : Form
    {
        public frmHang()
        {
            InitializeComponent();
        }
        HangBUL myHang = new HangBUL();
        ThemHangBUL myThemHang = new ThemHangBUL();
        SuaHangBUL mySuaHang = new SuaHangBUL();
        XemHangBUL myXemHang = new XemHangBUL();
        XoaHangBUL myXoaHang = new XoaHangBUL();

        LoaiHangBUL myLoaiHang = new LoaiHangBUL();
        NhaCungCapBUL myNCC = new NhaCungCapBUL();
        KTMTHangBUL myKTMTHang = new KTMTHangBUL();
        void HienHang()
        { dgvDanhMuc.DataSource = myHang.HienBangHang();
        for (int i = 0; i < dgvDanhMuc.Rows.Count; i++)
        {
            dgvDanhMuc.Rows[i].Cells[7].Value = i + 1;
        } 
        }
        private void frmHang_Load(object sender, EventArgs e)
        {
            cmbTenLoaiHang.DataSource = myLoaiHang.HienBangLH();
            cmbTenLoaiHang.DisplayMember = "TenLoai";
            cmbTenLoaiHang.ValueMember = "MaLoai";

            cmbTenNCCHang.DataSource = myNCC.HienBangNCC();
            cmbTenNCCHang.DisplayMember = "TenNhaCungCap";
            cmbTenNCCHang.ValueMember = "MaNhaCungCap";
            HienHang();
            txtMaHang.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Mã hàng k được bỏ trống!", "Eurro");
                txtMaHang.Focus();
            }
            else if (txtDVT.Text == "")
            {
                MessageBox.Show("Đơn vị tính k được bỏ trống!", "Eurro");
                txtDVT.Focus();
            }
            else if (txtTensp.Text == "")
            {
                MessageBox.Show("Tên hàng k được bỏ trống!", "Eurro");
                txtTensp.Focus();
            }
            else
            {
                int check = 1;
                try
                {
                    double gt = double.Parse(txtDonGia.Text);

                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của đơn giá k hợp lệ. Xin kiểm tra lai!", "Eurro");
                    txtDonGia.Clear();
                    txtDonGia.Focus();
                    check = 0;
                };


                try
                {

                    double gt1 = double.Parse(txtSoLuong.Text);
                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của số lượng k hợp lệ. Xin kiểm tra lai!", "Eurro");
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                    check = 0;
                };
                if (check == 1)
                {
                    if (myKTMTHang.KT_MaTrung(txtMaHang.Text))
                    {

                        MessageBox.Show("MaHang da bi trung. Xin kiem tra lai !", "Eurro");
                        txtDonGia.Clear();
                        txtDVT.Clear();
                        txtMaHang.Clear();
                        txtSoLuong.Clear();
                        txtTensp.Clear();
                        txtMaHang.Focus();
                    }
                    else
                    {
                        myThemHang.ThemHang(txtMaHang.Text, txtTensp.Text, txtDVT.Text, txtDonGia.Text, cmbTenLoaiHang.SelectedValue.ToString(), txtSoLuong.Text, cmbTenNCCHang.SelectedValue.ToString());
                        HienHang();
                        txtDonGia.Clear();
                        txtDVT.Clear();
                        txtMaHang.Clear();
                        txtSoLuong.Clear();
                        txtTensp.Clear();
                        txtMaHang.Focus();
                    }
                }
            }
           
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Mã hàng k được bỏ trống!", "Eurro");
                txtMaHang.Focus();
            }
            else if (txtDVT.Text == "")
            {
                MessageBox.Show("Đơn vị tính k được bỏ trống!", "Eurro");
                txtDVT.Focus();
            }
            else if (txtTensp.Text == "")
            {
                MessageBox.Show("Tên hàng k được bỏ trống!", "Eurro");
                txtTensp.Focus();
            }
            else
            {
                int check = 1;
                try
                {
                    double gt = double.Parse(txtDonGia.Text);

                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của đơn giá k hợp lệ. Xin kiểm tra lai!", "Eurro");
                    txtDonGia.Clear();
                    txtDonGia.Focus();
                    check = 0;
                };


                try
                {

                    double gt1 = double.Parse(txtSoLuong.Text);
                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của số lượng k hợp lệ. Xin kiểm tra lai!", "Eurro");
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                    check = 0;
                };
                if (check == 1)
                {
                    if (myKTMTHang.KT_MaTrung(txtMaHang.Text))
                    {
                        mySuaHang.Suasp(txtMaHang.Text, txtTensp.Text, txtDVT.Text, txtDonGia.Text, txtSoLuong.Text);
                        HienHang();
                        txtDonGia.Clear();
                        txtDVT.Clear();
                        txtMaHang.Clear();
                        txtSoLuong.Clear();
                        txtTensp.Clear();
                        txtMaHang.Focus();

                    }
                    else
                    {
                        MessageBox.Show("MaHang khong ton tai. Xin kiem tra lai !", "Eurro");
                        txtDonGia.Clear();
                        txtDVT.Clear();
                        txtMaHang.Clear();
                        txtSoLuong.Clear();
                        txtTensp.Clear();
                        txtMaHang.Focus();
                    }
                }
            }
           
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (myKTMTHang.KT_MaTrung(txtMaHang.Text))
            {
                myXoaHang.Xoasp(txtMaHang.Text);
                HienHang();
                txtDonGia.Clear();
                txtDVT.Clear();
                txtMaHang.Clear();
                txtSoLuong.Clear();
                txtTensp.Clear();
                txtMaHang.Focus();

            }
            else
            {
                MessageBox.Show("MaHang khong ton tai. Xin kiem tra lai !", "Eurro");
                txtDonGia.Clear();
                txtDVT.Clear();
                txtMaHang.Clear();
                txtSoLuong.Clear();
                txtTensp.Clear();
                txtMaHang.Focus();
            }
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (myKTMTHang.KT_MaTrung(txtMaHang.Text))
            {
                dgvDanhMuc.DataSource = myXemHang.Timkiemsp(txtMaHang.Text);
                txtDonGia.Clear();
                txtDVT.Clear();
                txtMaHang.Clear();
                txtSoLuong.Clear();
                txtTensp.Clear();
                txtMaHang.Focus();

            }
            else
            {
                MessageBox.Show("MaHang khong ton tai. Xin kiem tra lai !", "Eurro");
                txtDonGia.Clear();
                txtDVT.Clear();
                txtMaHang.Clear();
                txtSoLuong.Clear();
                txtTensp.Clear();
                txtMaHang.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtDVT.Clear();
            txtMaHang.Clear();
            txtSoLuong.Clear();
            txtTensp.Clear();
            txtMaHang.Focus();
        }

        private void dgvDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells[0].Value.ToString();
                txtTensp.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                cmbTenLoaiHang.SelectedValue = row.Cells[4].Value.ToString();
                txtDVT.Text = row.Cells[5].Value.ToString();
                cmbTenNCCHang.SelectedValue = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {


            }
        }
    }
}
