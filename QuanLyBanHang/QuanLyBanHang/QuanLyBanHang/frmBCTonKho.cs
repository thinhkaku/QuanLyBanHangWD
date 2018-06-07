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
    public partial class frmBCTonKho : Form
    {
        public frmBCTonKho()
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

        


        private void frmBCTonKho_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {

        }

        private void txtDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
