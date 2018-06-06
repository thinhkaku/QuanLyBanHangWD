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
    public partial class frmLichSuGia : Form
    {
        public frmLichSuGia()
        {
            InitializeComponent();
        }
        LichSuGiaBUL myLSG = new LichSuGiaBUL();
        ThemLSGBUL myThemLSG = new ThemLSGBUL();
        SuaLSGBUL mySuaLSG = new SuaLSGBUL();
        XemLSGBUL myXemLSG = new XemLSGBUL();
        XoaLSGBUL myXoaLSG = new XoaLSGBUL();

        HangBUL myHang = new HangBUL();
        KTMT_LSGBUL myKTMT = new KTMT_LSGBUL();
        

        void HienLSG()
        { dgvDanhMuc.DataSource = myLSG.HienBangLSG(); }
        
        private void frmLichSuGia_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            cmbTenHang.DataSource = myHang.HienBangHang();
            cmbTenHang.DisplayMember = "TenSP";
            cmbTenHang.ValueMember = "MaSP";     
            HienLSG();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNgayBatDau.Text == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống !", "Eurro");
                txtNgayBatDau.Focus();
            }
            else if (txtNgayKetThuc.Text == "")
            {
                MessageBox.Show("Ngày kết thúc không được để trống !", "Eurro");
                txtNgayKetThuc.Focus();
            }
            else if (txtNgayCapNhat.Text == "")
            {
                MessageBox.Show("Ngày cập nhật không được để trống !", "Eurro");
                txtNgayCapNhat.Focus();
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


                if (check == 1)
                {
                    if (myKTMT.KT_MaTrung(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text))
                    {

                        MessageBox.Show("Mã khách hàng đã bị trùng. Xin kiểm tra lại !", "Eurro");
                        txtDonGia.Clear();
                        txtNgayBatDau.Clear();
                        txtNgayCapNhat.Clear();
                        txtNgayKetThuc.Clear();
                        txtNgayBatDau.Focus();
                    }
                    else
                    {
                        myThemLSG.ThemHang(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text, txtNgayKetThuc.Text, txtDonGia.Text, txtNgayCapNhat.Text);
                        HienLSG();
                        txtDonGia.Clear();
                        txtNgayBatDau.Clear();
                        txtNgayCapNhat.Clear();
                        txtNgayKetThuc.Clear();
                        txtNgayBatDau.Focus();
                    }
                }
            }
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNgayBatDau.Text == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống !", "Eurro");
                txtNgayBatDau.Focus();
            }
            else if (txtNgayKetThuc.Text == "")
            {
                MessageBox.Show("Ngày kết thúc không được để trống !", "Eurro");
                txtNgayKetThuc.Focus();
            }
            else if (txtNgayCapNhat.Text == "")
            {
                MessageBox.Show("Ngày cập nhật không được để trống !", "Eurro");
                txtNgayCapNhat.Focus();
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


                if (check == 1)
                {
                    if (myKTMT.KT_MaTrung(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text))
                    {
                        mySuaLSG.Suasp(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text, txtNgayKetThuc.Text, txtDonGia.Text, txtNgayCapNhat.Text);
                        HienLSG();

                        txtDonGia.Clear();
                        txtNgayBatDau.Clear();
                        txtNgayCapNhat.Clear();
                        txtNgayKetThuc.Clear();
                        txtNgayBatDau.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại mã hàng và ngày bắt đầu. Xin kiểm tra lại !", "Eurro");
                        txtDonGia.Clear();
                        txtNgayBatDau.Clear();
                        txtNgayCapNhat.Clear();
                        txtNgayKetThuc.Clear();
                        txtNgayBatDau.Focus();
                    }
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (myKTMT.KT_MaTrung(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text))
            {
                myXoaLSG.Xoasp(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text);
                HienLSG();
                txtDonGia.Clear();
                txtNgayBatDau.Clear();
                txtNgayCapNhat.Clear();
                txtNgayKetThuc.Clear();
                txtNgayBatDau.Focus();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã hàng và ngày bắt đầu. Xin kiểm tra lại !", "Eurro");
                txtDonGia.Clear();
                txtNgayBatDau.Clear();
                txtNgayCapNhat.Clear();
                txtNgayKetThuc.Clear();
                txtNgayBatDau.Focus();
            }
         
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (myKTMT.KT_MaTrung(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text))
            {
                dgvDanhMuc.DataSource = myXemLSG.Timkiemsp(cmbTenHang.SelectedValue.ToString(), txtNgayBatDau.Text);
                txtDonGia.Clear();
                txtNgayBatDau.Clear();
                txtNgayCapNhat.Clear();
                txtNgayKetThuc.Clear();
                txtNgayBatDau.Focus();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã hàng và ngày bắt đầu. Xin kiểm tra lại !", "Eurro");
                txtDonGia.Clear();
                txtNgayBatDau.Clear();
                txtNgayCapNhat.Clear();
                txtNgayKetThuc.Clear();
                txtNgayBatDau.Focus();
            }
           
        }

        private void dgvDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                cmbTenHang.SelectedValue = row.Cells[0].Value.ToString();
                txtNgayBatDau.Text = row.Cells[1].Value.ToString();
                txtNgayKetThuc.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtNgayCapNhat.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtNgayBatDau.Clear();
            txtNgayCapNhat.Clear();
            txtNgayKetThuc.Clear();
            txtNgayBatDau.Focus();
        }
    }
}
