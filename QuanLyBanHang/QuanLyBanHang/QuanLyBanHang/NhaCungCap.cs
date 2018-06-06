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
        private KTMTNhaCungCap ktMaNhaCungCap = new KTMTNhaCungCap();

        void HienNCC()
        { dgvDanhMuc.DataSource = myNCC.HienBangNCC(); }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            HienNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được bỏ trống", "Thông báo");
                txtMaNhaCungCap.Focus();
            }
            else if (txtTenNCC.Text == "")
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
                    double gt = double.Parse(txtSDTNCC.Text);
                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của SĐT k hợp lệ. Xin kiểm tra lai!", "Thông báo");
                    txtSDTNCC.Clear();
                    txtSDTNCC.Focus();
                    check = 0;
                };

                if (check == 1)
                {
                    if (ktMaNhaCungCap.KT_MaTrung(txtMaNhaCungCap.Text))
                    {
                        MessageBox.Show("Mã nhà cung cấp đã bị trùng. Xin kiểm tra lại !", "Thông báo");
                    }
                    else
                    {
                        myThemNCC.ThemHang(txtMaNhaCungCap.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDTNCC.Text);
                        MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo");
                        clearText();

                    }
                }

            }
            
            HienNCC();
        }

        private void clearText()
        {
            txtMaNhaCungCap.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtSDTNCC.Clear();
            txtMaNhaCungCap.Focus();
        }

       

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được bỏ trống", "Thông báo");
                txtMaNhaCungCap.Focus();
            }
            else if (txtTenNCC.Text == "")
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
                    double gt = double.Parse(txtSDTNCC.Text);
                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu của SĐT k hợp lệ. Xin kiểm tra lai!", "Thông báo");
                    txtSDTNCC.Clear();
                    txtSDTNCC.Focus();
                    check = 0;
                };

                if (check == 1)
                {
                    if (ktMaNhaCungCap.KT_MaTrung(txtMaNhaCungCap.Text))
                    {
                        showMessageXacNhanSuaNCC();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhà cung cấp không chính xác!", "Thông báo");
                    }
                }

            }
           
            HienNCC();
        }

        private void showMessageXacNhanSuaNCC()
        {
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn sửa thông tin nhà cung cấp này?","Thông báo",MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                mySuaNCC.Suasp(txtMaNhaCungCap.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDTNCC.Text);
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công", "Thông báo");
                clearText();
            }
        }

        private void showMessageXacNhanXoaNCC()
        {
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                myXoaNCC.Xoasp(txtMaNhaCungCap.Text);
                MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo");
                clearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Chưa điền mã nhà cung cấp!", "Thông báo");
                txtMaNhaCungCap.Focus();
            }
            else
            {
                if (ktMaNhaCungCap.KT_MaTrung(txtMaNhaCungCap.Text))
                {
                    showMessageXacNhanXoaNCC();
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp không chính xác!", "Thông báo");
                }
            }
            
            HienNCC();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (ktMaNhaCungCap.KT_MaTrung(txtMaNhaCungCap.Text))
            {
                dgvDanhMuc.DataSource = myXemNCC.Timkiemsp(txtMaNhaCungCap.Text);
                clearText();
            }
            else if (txtMaNhaCungCap.Text == "")
            {
                HienNCC();
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại!", "Thông báo");
                clearText();

            }
            
        }

        private void dgvDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaNhaCungCap.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChiNCC.Text = row.Cells[2].Value.ToString();
                txtSDTNCC.Text = row.Cells[3].Value.ToString();

            }
            catch (Exception)
            {
                
            }
        }


    }
}
