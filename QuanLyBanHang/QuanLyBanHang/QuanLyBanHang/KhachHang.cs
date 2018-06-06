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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void HienKH()
        { dgvDanhMuc.DataSource = myKH.HienBangKH(); }

        KhachHangBUL myKH = new KhachHangBUL();
        ThemKHBUL myThemKH = new ThemKHBUL();
        SuaKHBUL mySuaKH = new SuaKHBUL();
        XemKHBUL myXemKH = new XemKHBUL();
        XoaKHBUL myXoaKH = new XoaKHBUL();
        KTMTKhachHangBUL myKTMT = new KTMTKhachHangBUL();

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            HienKH();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống", "Eurro");
                txtMaKH.Focus();
            }
            else if (txtTenKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống", "Eurro");
                txtTenKH.Focus();
            }
            else if (txtDiaChiKH.Text == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được bỏ trống", "Eurro");
                txtDiaChiKH.Focus();
            }
            else
            {
                int check = 1;
                try
                {
                    double gt = double.Parse(txtSDTKH.Text);

                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của SĐT k hợp lệ. Xin kiểm tra lai!", "Eurro");
                    txtSDTKH.Clear();
                    txtSDTKH.Focus();
                    check = 0;
                };


                if (check == 1)
                {
                    if (myKTMT.KT_MaTrung(txtMaKH.Text))
                    {

                        MessageBox.Show("Mã khách hàng đã bị trùng. Xin kiểm tra lại !", "Eurro");
                        txtDiaChiKH.Clear();
                        txtMaKH.Clear();
                        txtSDTKH.Clear();
                        txtTenKH.Clear();
                        txtMaKH.Focus();
                    }
                    else
                    {
                        myThemKH.ThemHang(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSDTKH.Text);
                        HienKH();
                        txtDiaChiKH.Clear();
                        txtMaKH.Clear();
                        txtSDTKH.Clear();
                        txtTenKH.Clear();
                        txtMaKH.Focus();
                    }
                }
            }

         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống", "Eurro");
                txtMaKH.Focus();
            }
            else if (txtTenKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống", "Eurro");
                txtTenKH.Focus();
            }
            else if (txtDiaChiKH.Text == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được bỏ trống", "Eurro");
                txtDiaChiKH.Focus();
            }
            else
            {
                int check = 1;
                try
                {
                    double gt = double.Parse(txtSDTKH.Text);

                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của SĐT k hợp lệ. Xin kiểm tra lai!", "Eurro");
                    txtSDTKH.Clear();
                    txtSDTKH.Focus();
                    check = 0;
                };


                if (check == 1)
                {
                    if (myKTMT.KT_MaTrung(txtMaKH.Text))
                    {
                        mySuaKH.Suasp(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSDTKH.Text);
                        HienKH();

                        txtDiaChiKH.Clear();
                        txtMaKH.Clear();
                        txtSDTKH.Clear();
                        txtTenKH.Clear();
                        txtMaKH.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại. Xin kiểm tra lại !", "Eurro");
                        txtDiaChiKH.Clear();
                        txtMaKH.Clear();
                        txtSDTKH.Clear();
                        txtTenKH.Clear();
                        txtMaKH.Focus();
                    }
                }
            }
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (myKTMT.KT_MaTrung(txtMaKH.Text))
            {
                myXoaKH.Xoasp(txtMaKH.Text);
                HienKH();
                txtDiaChiKH.Clear();
                txtMaKH.Clear();
                txtSDTKH.Clear();
                txtTenKH.Clear();
                txtMaKH.Focus();

            }
            else
            {
                MessageBox.Show("Ma khách hàng khong ton tai. Xin kiem tra lai !", "Eurro");
                txtDiaChiKH.Clear();
                txtMaKH.Clear();
                txtSDTKH.Clear();
                txtTenKH.Clear();
                txtMaKH.Focus();
            }
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (myKTMT.KT_MaTrung(txtMaKH.Text))
            {
                dgvDanhMuc.DataSource = myXemKH.Timkiemsp(txtMaKH.Text);
                txtDiaChiKH.Clear();
                txtMaKH.Clear();
                txtSDTKH.Clear();
                txtTenKH.Clear();
                txtMaKH.Focus();

            }
            else
            {
                MessageBox.Show("Ma khách hàng khong ton tai. Xin kiem tra lai !", "Eurro");
                txtDiaChiKH.Clear();
                txtMaKH.Clear();
                txtSDTKH.Clear();
                txtTenKH.Clear();
                txtMaKH.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDiaChiKH.Clear();
            txtMaKH.Clear();
            txtSDTKH.Clear();
            txtTenKH.Clear();
            txtMaKH.Focus();
        }

        private void dgvDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDiaChiKH.Text = row.Cells[2].Value.ToString();
                txtSDTKH.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

    }
}
