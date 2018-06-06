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
    public partial class DialogSuaNCC : Form
    {
        private String maNCC;
        SuaNCCBUL mySuaNCC = new SuaNCCBUL();
        private NhaCungCapBUL nccBul = new NhaCungCapBUL();
        private NhaCungCapDTO ncc = new NhaCungCapDTO();
        public DialogSuaNCC(String maNCC)
        {
            this.maNCC = maNCC;
            InitializeComponent();
            ncc = nccBul.getNhaCungCap(maNCC);
            txtTenNCC.Text=ncc.TenNhaCungCap;
            txtDiaChiNCC.Text=ncc.DiaChi;
            txtSDT.Text = ncc.SoDienThoai;
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChiNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được bỏ trống", "Thông báo");
                txtTenNCC.Focus();
            }
            else if (txtDiaChiNCC.Text == "")
            {
                MessageBox.Show("Địa chỉ nhà cung cấp không được bỏ trống", "Thông báo");
                txtDiaChiNCC.Focus();
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
                    showMessageXacNhanSuaNCC();
                }

            }
        }
        private void showMessageXacNhanSuaNCC()
        {
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn sửa thông tin nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                mySuaNCC.Suasp(maNCC, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDT.Text);
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công", "Thông báo");
                this.Close();
            }
        }


    }
}
