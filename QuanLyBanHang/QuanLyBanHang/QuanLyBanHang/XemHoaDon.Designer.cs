﻿namespace QuanLyBanHang
{
    partial class frmXemHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaHD = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ColMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // cmbMaHD
            // 
            this.cmbMaHD.FormattingEnabled = true;
            this.cmbMaHD.Location = new System.Drawing.Point(334, 44);
            this.cmbMaHD.Name = "cmbMaHD";
            this.cmbMaHD.Size = new System.Drawing.Size(141, 21);
            this.cmbMaHD.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongTin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 329);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaHD,
            this.ColTenHang,
            this.ColTenKH,
            this.ColNgayLap,
            this.ColTenNV,
            this.ColSoLuong,
            this.ColDonGia,
            this.ColThanhTien});
            this.dgvThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTin.Location = new System.Drawing.Point(3, 16);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(701, 310);
            this.dgvThongTin.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColMaHD
            // 
            this.ColMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaHD.DataPropertyName = "MaHoaDon";
            dataGridViewCellStyle1.NullValue = null;
            this.ColMaHD.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColMaHD.HeaderText = "Mã Hóa Đơn";
            this.ColMaHD.Name = "ColMaHD";
            // 
            // ColTenHang
            // 
            this.ColTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenHang.DataPropertyName = "MaHang";
            this.ColTenHang.HeaderText = "Mã Hàng";
            this.ColTenHang.Name = "ColTenHang";
            this.ColTenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColTenKH
            // 
            this.ColTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenKH.DataPropertyName = "MaKH";
            this.ColTenKH.HeaderText = "Mã Khách Hàng";
            this.ColTenKH.Name = "ColTenKH";
            // 
            // ColNgayLap
            // 
            this.ColNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNgayLap.DataPropertyName = "NgayLap";
            this.ColNgayLap.HeaderText = "Ngày Lập";
            this.ColNgayLap.Name = "ColNgayLap";
            // 
            // ColTenNV
            // 
            this.ColTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenNV.DataPropertyName = "MaNV";
            this.ColTenNV.HeaderText = "Mã Nhân Viên";
            this.ColTenNV.Name = "ColTenNV";
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.ColSoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSoLuong.HeaderText = "Số Lượng";
            this.ColSoLuong.Name = "ColSoLuong";
            // 
            // ColDonGia
            // 
            this.ColDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.ColDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColDonGia.HeaderText = "Đơn Giá";
            this.ColDonGia.Name = "ColDonGia";
            // 
            // ColThanhTien
            // 
            this.ColThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.ColThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColThanhTien.HeaderText = "Thành Tiền";
            this.ColThanhTien.Name = "ColThanhTien";
            // 
            // frmXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMaHD);
            this.Controls.Add(this.label2);
            this.Name = "frmXemHoaDon";
            this.Text = "XemHoaDon";
            this.Load += new System.EventHandler(this.frmXemHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
    }
}