using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace QuanLyBanHang
{
    public partial class frmBCDoanhSo : Form
    {
        public frmBCDoanhSo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void setparameter(string nl)
        {
            ReportParameter rp = new ReportParameter("NguoiLap");
            rp.Values.Add(nl);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        private void setparameter1(string dv)
        {
            ReportParameter rp = new ReportParameter("DonVi");
            rp.Values.Add(dv);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        private void frmBCDoanhSo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.HoaDonChiTiet' table. You can move, or remove it, as needed.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "")
            {
                MessageBox.Show("Tên đơn vị k đc bỏ trống. Xin kiểm tra lại !", "eurro");
                txtTenDV.Focus();
            }
            else if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên k đc bỏ trống. Xin kiểm tra lại !", "eurro");
                txtTenNV.Focus();
            }
            else
            {
                this.HoaDonChiTietTableAdapter.Fill(this.DataSet2.HoaDonChiTiet, dateTimePicker1.Value.Year, dateTimePicker1.Value.Month);

                this.reportViewer1.RefreshReport();
                setparameter(txtTenNV.Text);
                reportViewer1.RefreshReport();

                setparameter1(txtTenDV.Text);
                reportViewer1.RefreshReport();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.PrintDialog();
            }
            catch
            {
                MessageBox.Show("Cú pháp k hợp lệ. Xin kiểm tra lại !", "Eurro");
            };
        }
    }
}
