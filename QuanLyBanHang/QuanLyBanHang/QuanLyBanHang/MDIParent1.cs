using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        private frmHang frmH = new frmHang();
        private frmLoaiHang frmLH = new frmLoaiHang();
        private frmNhaCungCap frmNCC = new frmNhaCungCap();
        private frmNhanVien frmNV = new frmNhanVien();
        private frmKhachHang frmKH = new frmKhachHang();
        private frmLichSuGia frmLSG = new frmLichSuGia();
        private frmXemHoaDon frmXemHD = new frmXemHoaDon();
        private frmLapHoaDon frmLapHD = new frmLapHoaDon();
        private frmBCNgay frmBaoCaoNgay = new frmBCNgay();
        private frmBCDoanhSo frmBaoCaoDS = new frmBCDoanhSo();
        private frmBCTonKho frmBaoCaoTonKho = new frmBCTonKho();

        public MDIParent1()
        {
            InitializeComponent();
            switchForms(frmH);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        

        private void mnuQLHang_Click(object sender, EventArgs e)
        {
            switchForms(frmH);
        }

        private void quaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms(frmLH);
        }

        

        private void switchForms(Form forms)
        {
            frmH.Hide();
            frmLH.Hide();
            frmNV.Hide();
            frmNCC.Hide();
            frmKH.Hide();
            frmLSG.Hide();
            frmXemHD.Hide();
            frmLapHD.Hide();
            frmBaoCaoNgay.Hide();
            frmBaoCaoDS.Hide();
            frmBaoCaoTonKho.Hide();
            forms.MdiParent = this;
            forms.Show();
        }

        private void quảnLýNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms(frmNCC);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms(frmNV);
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms(frmKH);
        }


        private void quảnLýLSGToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switchForms(frmLSG);
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switchForms(frmLapHD);
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switchForms(frmXemHD);
        }

        private void báoCáoHàngBánTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switchForms(frmBaoCaoNgay);
        }

        private void báoCáoDoanhSốBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switchForms(frmBaoCaoDS);
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void báoCáoHàngTồnCuốiThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms(frmBaoCaoTonKho);
        }
    }
}
