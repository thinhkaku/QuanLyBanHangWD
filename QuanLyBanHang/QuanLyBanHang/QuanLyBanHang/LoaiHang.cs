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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        LoaiHangBUL myLoaiHang = new LoaiHangBUL();
        ThemLoaiHangBUL myThemLH = new ThemLoaiHangBUL();
        SuaLoaiHangBUL mySuaLH = new SuaLoaiHangBUL();
        XemLoaiHangBUL myXemLH = new XemLoaiHangBUL();
        XoaLoaiHangBUL myXoaLH = new XoaLoaiHangBUL();
        KTMTLoaiHangBUL myKTMTLoaiHang = new KTMTLoaiHangBUL();
        void HienLoaiHang()
        {
            
            dgvDanhMuc.DataSource = myLoaiHang.HienBangLH();
            for (int i = 0; i < dgvDanhMuc.Rows.Count; i++)
            {
                dgvDanhMuc.Rows[i].Cells[3].Value = i + 1;
            } 
        
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Mã loại k đc để trống. Xin kiểm tra lai !", "eurro");
                txtMaLoai.Focus();
            }
            else if(txtTenLoai.Text == "")
            {
                MessageBox.Show("Tên loại k đc để trống. Xin kiểm tra lai !", "eurro");
                txtTenLoai.Focus();
            }
            else if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Ghi chú k đc để trống. Xin kiểm tra lai !", "eurro");
                txtGhiChu.Focus();
            }
            else
            {

                if (myKTMTLoaiHang.KT_MaTrung(txtMaLoai.Text))
                {

                    MessageBox.Show("MaLoai da bi trung. Xin kiem tra lai !");
                    txtGhiChu.Clear();
                    txtMaLoai.Clear();
                    txtTenLoai.Clear();
                    txtMaLoai.Focus();
                }
                else
                {
                    myThemLH.ThemHang(txtMaLoai.Text, txtTenLoai.Text, txtGhiChu.Text);
                    HienLoaiHang();
                }
            }
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            HienLoaiHang();
            txtMaLoai.Focus();

            
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Mã loại k đc để trống. Xin kiểm tra lai !", "eurro");
                txtMaLoai.Focus();
            }
            else if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Tên loại k đc để trống. Xin kiểm tra lai !", "eurro");
                txtTenLoai.Focus();
            }
            else if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Ghi chú k đc để trống. Xin kiểm tra lai !", "eurro");
                txtGhiChu.Focus();
            }
            else
            {

                if (myKTMTLoaiHang.KT_MaTrung(txtMaLoai.Text))
                {
                    mySuaLH.Suasp(txtMaLoai.Text, txtTenLoai.Text, txtGhiChu.Text);
                    HienLoaiHang();
                    txtGhiChu.Clear();
                    txtMaLoai.Clear();
                    txtTenLoai.Clear();
                    txtMaLoai.Focus();

                }
                else
                {
                    MessageBox.Show("MaLoai khong ton tai. Xin kiem tra lai !");
                    txtGhiChu.Clear();
                    txtMaLoai.Clear();
                    txtTenLoai.Clear();
                    txtMaLoai.Focus();
                }
            }
           
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (myKTMTLoaiHang.KT_MaTrung(txtMaLoai.Text))
            {
                myXoaLH.Xoasp(txtMaLoai.Text);
                HienLoaiHang();

            }
            else
            {
                MessageBox.Show("MaLoai khong ton tai. Xin kiem tra lai !");
                txtGhiChu.Clear();
                txtMaLoai.Clear();
                txtTenLoai.Clear();
                txtMaLoai.Focus();
            }
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (myKTMTLoaiHang.KT_MaTrung(txtMaLoai.Text))
            {
                dgvDanhMuc.DataSource = myXemLH.Timkiemsp(txtMaLoai.Text);

            }
            else
            {
                MessageBox.Show("MaLoai khong ton tai. Xin kiem tra lai !");
                txtGhiChu.Clear();
                txtMaLoai.Clear();
                txtTenLoai.Clear();
                txtMaLoai.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtGhiChu.Clear();
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtMaLoai.Focus();
        }

        private void dgvDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
                txtGhiChu.Text = row.Cells[2].Value.ToString();
               

            }
            catch (Exception)
            {


            }
        }

       
    }
}
