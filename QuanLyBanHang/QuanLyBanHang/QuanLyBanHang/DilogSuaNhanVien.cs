using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace QuanLyBanHang
{
    public partial class DilogSuaNhanVien : Form
    {
        String maNV;
        
        private NhanVienBUL getNV = new NhanVienBUL();
        private NhanVienDTO nv = new NhanVienDTO();
        public DilogSuaNhanVien(String maNV)
        {
            this.maNV = maNV;
            nv = getNV.getNhanVien(maNV);
            InitializeComponent();
            txtTenNV.Text = nv.HoTen;
            txtDC.Text = nv.DiaChi;
            txtSDT.Text = nv.SoDienThoai;
           
        }

       

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public void showMessageXacNhanSuaNhanVien()
        {
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn sửa thông tin nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                SuaNVBUL mySuaNV = new SuaNVBUL();
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show("Tên nhân viên không được bỏ trống", "Thông báo");
                    txtTenNV.Focus();
                }
                else if (txtDC.Text == "")
                {
                    MessageBox.Show("Dịa chỉ nhân viên không được bỏ trống", "Thông báo");
                    txtDC.Focus();
                }
                else
                {
                    int check = 1;
                    try
                    {
                        double gt = double.Parse(txtSDT.Text);

                    }
                    catch
                    {
                        MessageBox.Show("Kiểu dữ liệu của SĐT k hợp lệ. Xin kiểm tra lai!", "Thông báo");
                        txtSDT.Clear();
                        txtSDT.Focus();
                        check = 0;
                    };
                    if (check == 1)
                    {
                        mySuaNV.Suasp(maNV, txtTenNV.Text, txtDC.Text, txtSDT.Text);
                        MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo");
                        this.Close();
                    }
                }

            }
            

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            showMessageXacNhanSuaNhanVien();
        }
    }
}
