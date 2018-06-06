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
    public partial class frmLSG : Form
    {
        public frmLSG()
        {
            InitializeComponent();
        }
    
        
        HoaDonBUL myHoaDon = new HoaDonBUL();
        HoaDonChiTietBUL myHDCT = new HoaDonChiTietBUL();
        KhachHangBUL myKH = new KhachHangBUL();
        LichSuGiaBUL myLSG = new LichSuGiaBUL();
        NhaCungCapBUL myNCC = new NhaCungCapBUL();
        NhanVienBUL myNhanVien = new NhanVienBUL();

        
        ThemKHBUL myThemKH = new ThemKHBUL();
       
        ThemLSGBUL myThemLSG = new ThemLSGBUL();
        ThemNCCBUL myThemNCC = new ThemNCCBUL();
        ThemNVBUL myThemNV = new ThemNVBUL();


        LoaiHangBUL myLoaiHang = new LoaiHangBUL();
        ThemLoaiHangBUL myThemLH = new ThemLoaiHangBUL();
        SuaLoaiHangBUL mySuaLH = new SuaLoaiHangBUL();
        XemLoaiHangBUL myXemLH = new XemLoaiHangBUL();
        XoaLoaiHangBUL myXoaLH = new XoaLoaiHangBUL();
        SuaLSGBUL mySuaLSG = new SuaLSGBUL();
        SuaNCCBUL mySuaNCC = new SuaNCCBUL();
        SuaNVBUL mySuaNV = new SuaNVBUL();
        SuaKHBUL mySuaKH = new SuaKHBUL();

        
        XemKHBUL myXemKH = new XemKHBUL();
        
        XemLSGBUL myXemLSG = new XemLSGBUL();
        XemNVBUL myXemNV = new XemNVBUL();
        XemNCCBUL myXemNCC = new XemNCCBUL();
        HangBUL myHang = new HangBUL();
        ThemHangBUL myThemHang = new ThemHangBUL();
        SuaHangBUL mySuaHang = new SuaHangBUL();
        XemHangBUL myXemHang = new XemHangBUL();
        XoaHangBUL myXoaHang = new XoaHangBUL();

        void HienLoaiHang()
        { dgvDanhMuc.DataSource = myLoaiHang.HienBangLH(); }
        void HienHang()
        { dgvDanhMuc.DataSource = myHang.HienBangHang(); }
        void HienNCC()
        { dgvDanhMuc.DataSource = myNCC.HienBangNCC(); }
        void HienNV()
        { dgvDanhMuc.DataSource = myNhanVien.HienBangNV(); }
        void HienKH()
        { dgvDanhMuc.DataSource = myKH.HienBangKH(); }
        void HienLSG()
        { dgvDanhMuc.DataSource = myLSG.HienBangLSG(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDanhMuc.Items.Add("Hàng");
            cmbDanhMuc.Items.Add("Loại Hàng");
            cmbDanhMuc.Items.Add("Nhà Cung Cấp");
            cmbDanhMuc.Items.Add("Nhân Viên");
            cmbDanhMuc.Items.Add("Khách Hàng");
            cmbDanhMuc.Items.Add("Lịch Sử Giá");
            cmbDanhMuc.SelectedIndex = 0;
            
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedItem == "Hàng")
            {
                grbHang.Visible = true;
                grbLoaiHang.Visible = false;

                cmbTenLoaiHang.DataSource = myLoaiHang.HienBangLH();
                cmbTenLoaiHang.DisplayMember = "TenLoai";
                cmbTenLoaiHang.ValueMember = "MaLoai";

                cmbTenNCCHang.DataSource = myNCC.HienBangNCC();
                cmbTenNCCHang.DisplayMember = "TenNhaCungCap";
                cmbTenNCCHang.ValueMember = "MaNhaCungCap";
                HienHang();
            }
            else if (cmbDanhMuc.SelectedItem == "Loại Hàng")
            {

                grbLoaiHang.Visible = true;
                grbNCC.Visible = false;

                HienLoaiHang();
            }
            else if (cmbDanhMuc.SelectedItem == "Nhà Cung Cấp")
            {
                grbLoaiHang.Visible = true;
                grbNCC.Visible = false;

                grbNCC.Visible = true;
                grbNhanVien.Visible = false;

                HienNCC();
            }
            else if (cmbDanhMuc.SelectedItem == "Nhân Viên")
            {
                grbLoaiHang.Visible = true;
                grbNCC.Visible = false;
                grbNCC.Visible = true;
                grbNhanVien.Visible = false;

                grbNhanVien.Visible = true;
                grbKhachHang.Visible = false;

                HienNV();
            }
            else if (cmbDanhMuc.SelectedItem == "Khách Hàng")
            {
                grbLoaiHang.Visible = true;
                grbNCC.Visible = false;
                grbNCC.Visible = true;
                grbNhanVien.Visible = false;
                grbNhanVien.Visible = true;
                grbKhachHang.Visible = false;

                grbKhachHang.Visible = true;
                grbLichSuGia.Visible = false;

                HienKH();
            }
            else if (cmbDanhMuc.SelectedItem == "Lịch Sử Giá")
            {
                grbLoaiHang.Visible = true;
                grbNCC.Visible = false;
                grbNCC.Visible = true;
                grbNhanVien.Visible = false;
                grbNhanVien.Visible = true;
                grbKhachHang.Visible = false;

                grbKhachHang.Visible = true;
                grbLichSuGia.Visible = false;

                grbLichSuGia.Visible = true;

                cmbTenHangLSG.DataSource = myHang.HienBangHang();
                cmbTenHangLSG.DisplayMember = "TenSP";
                cmbTenHangLSG.ValueMember = "MaSP";
                HienLSG();
                
            }
           
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frmBC = new FrmBaoCao();
            frmBC.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedItem == "Hàng")
            {
                myThemHang.ThemHang(txtMaHang.Text, txtTensp.Text, txtDVT.Text, txtDonGia.Text, cmbTenLoaiHang.SelectedValue.ToString(), txtSoLuong.Text, cmbTenNCCHang.SelectedValue.ToString());
            }
            else if (cmbDanhMuc.SelectedItem == "Loại Hàng")
            {

              

            }
            else if (cmbDanhMuc.SelectedItem == "Nhà Cung Cấp")
            {
         

            }
            else if (cmbDanhMuc.SelectedItem == "Nhân Viên")
            {
             
            }
            else if (cmbDanhMuc.SelectedItem == "Khách Hàng")
            {
            
            }
            else if (cmbDanhMuc.SelectedItem == "Lịch Sử Giá")
            {
                myThemLSG.ThemHang(cmbTenHangLSG.SelectedValue.ToString(), txtNgayBatDau.Text, txtNgayKetThuc.Text, txtDonGiaLSG.Text, txtNgayCapNhat.Text);
                HienLSG();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedItem == "Hàng")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Loại Hàng")
            {



            }
            else if (cmbDanhMuc.SelectedItem == "Nhà Cung Cấp")
            {


            }
            else if (cmbDanhMuc.SelectedItem == "Nhân Viên")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Khách Hàng")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Lịch Sử Giá")
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedItem == "Hàng")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Loại Hàng")
            {



            }
            else if (cmbDanhMuc.SelectedItem == "Nhà Cung Cấp")
            {


            }
            else if (cmbDanhMuc.SelectedItem == "Nhân Viên")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Khách Hàng")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Lịch Sử Giá")
            {

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedItem == "Hàng")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Loại Hàng")
            {



            }
            else if (cmbDanhMuc.SelectedItem == "Nhà Cung Cấp")
            {


            }
            else if (cmbDanhMuc.SelectedItem == "Nhân Viên")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Khách Hàng")
            {

            }
            else if (cmbDanhMuc.SelectedItem == "Lịch Sử Giá")
            {

            }
        }

        private void grbLichSuGia_Enter(object sender, EventArgs e)
        {

        }

     
    }
}
