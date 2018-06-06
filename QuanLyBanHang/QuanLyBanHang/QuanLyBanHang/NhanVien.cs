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

        public void hienthi()
        {

        }
        
        public frmNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBUL myNhanVien = new NhanVienBUL();
        ThemNVBUL myThemNV = new ThemNVBUL();
        XemNVBUL myXemNV = new XemNVBUL();
        XoaNVBUL myXoaNV = new XoaNVBUL();
        private KTMTNhanVien ktMaTrungNV = new KTMTNhanVien();
        
        
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
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống", "Thông báo");
                txtMaNV.Focus();
            }
            else if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống", "Thông báo");
                txtTenNV.Focus();
            }
            else if (txtDiaChiNV.Text == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được bỏ trống", "Thông báo");
                txtDiaChiNV.Focus();
            }
            else 
            {
                int check = 1;
                try
                {
                    double gt = double.Parse(txtSDTNV.Text);

                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của SĐT k hợp lệ. Xin kiểm tra lai!", "Thông báo");
                    txtSDTNV.Clear();
                    txtSDTNV.Focus();
                    check = 0;
                };

                if (check == 1)
                {
                    if (ktMaTrungNV.KT_MaTrung(txtMaNV.Text))
                    {

                        MessageBox.Show("Mã khách hàng đã bị trùng. Xin kiểm tra lại !", "Thông báo");
                     
                    }
                    else
                    {
                        myThemNV.ThemHang(txtMaNV.Text, txtTenNV.Text, txtDiaChiNV.Text, txtSDTNV.Text);
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                        clearText();
                        
                    }
                }

            }
            HienNV();
        }

        private void clearText()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChiNV.Clear();
            txtSDTNV.Clear();
            txtMaNV.Focus();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống", "Thông báo");
                txtMaNV.Focus();
            }
            
            else
            {
                    if (ktMaTrungNV.KT_MaTrung(txtMaNV.Text))
                    {
                      
                        DilogSuaNhanVien dlSuaNV = new DilogSuaNhanVien(txtMaNV.Text);
                        dlSuaNV.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo");
                        clearText();

                    }
                
                
            }
            
            HienNV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa điền mã nhân viên!", "Thông báo");
                txtMaNV.Focus();
            }
            else
            {
                if (ktMaTrungNV.KT_MaTrung(txtMaNV.Text))
                {
                    showMessageXacNhanXoaNhanVien();
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã nhân viên này!", "Thông báo");
                }
            }
            
            HienNV();
        }

        

       

        private void dgvDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
              
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtDiaChiNV.Text = row.Cells[2].Value.ToString();
                txtSDTNV.Text = row.Cells[3].Value.ToString();
                
            }
            catch (Exception)
            {


            }
        }

        public  void showMessageXacNhanXoaNhanVien()
        {
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                myXoaNV.Xoasp(txtMaNV.Text);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                clearText();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (ktMaTrungNV.KT_MaTrung(txtMaNV.Text))
            {
                dgvDanhMuc.DataSource = myXemNV.Timkiemsp(txtMaNV.Text);
                clearText();
            }
            else if (txtMaNV.Text == "")
            {
                HienNV();
            }
            else
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo");
                clearText();

            }
            
        }

        

       
    }
}
