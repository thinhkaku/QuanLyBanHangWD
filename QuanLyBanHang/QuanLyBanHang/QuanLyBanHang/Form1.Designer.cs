namespace QuanLyBanHang
{
    partial class frmLSG
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
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.grbLichSuGia = new System.Windows.Forms.GroupBox();
            this.cmbTenHangLSG = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDonGiaLSG = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.grbLichSuGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(12, 340);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(767, 161);
            this.dgvDanhMuc.TabIndex = 2;
            // 
            // grbLichSuGia
            // 
            this.grbLichSuGia.Controls.Add(this.cmbTenHangLSG);
            this.grbLichSuGia.Controls.Add(this.label29);
            this.grbLichSuGia.Controls.Add(this.label28);
            this.grbLichSuGia.Controls.Add(this.txtNgayCapNhat);
            this.grbLichSuGia.Controls.Add(this.label24);
            this.grbLichSuGia.Controls.Add(this.txtNgayKetThuc);
            this.grbLichSuGia.Controls.Add(this.label25);
            this.grbLichSuGia.Controls.Add(this.txtNgayBatDau);
            this.grbLichSuGia.Controls.Add(this.label26);
            this.grbLichSuGia.Controls.Add(this.txtDonGiaLSG);
            this.grbLichSuGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLichSuGia.Location = new System.Drawing.Point(16, 40);
            this.grbLichSuGia.Name = "grbLichSuGia";
            this.grbLichSuGia.Size = new System.Drawing.Size(767, 169);
            this.grbLichSuGia.TabIndex = 45;
            this.grbLichSuGia.TabStop = false;
            this.grbLichSuGia.Text = "Lịch Sử Giá";
            this.grbLichSuGia.Enter += new System.EventHandler(this.grbLichSuGia_Enter);
            // 
            // cmbTenHangLSG
            // 
            this.cmbTenHangLSG.FormattingEnabled = true;
            this.cmbTenHangLSG.Location = new System.Drawing.Point(619, 111);
            this.cmbTenHangLSG.Name = "cmbTenHangLSG";
            this.cmbTenHangLSG.Size = new System.Drawing.Size(121, 24);
            this.cmbTenHangLSG.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(541, 119);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 16);
            this.label29.TabIndex = 42;
            this.label29.Text = "Tên Hàng";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(294, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "Ngày Cập Nhật";
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Location = new System.Drawing.Point(406, 31);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.Size = new System.Drawing.Size(100, 22);
            this.txtNgayCapNhat.TabIndex = 40;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(288, 120);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 16);
            this.label24.TabIndex = 39;
            this.label24.Text = "Ngày Kết Thúc";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(400, 114);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(100, 22);
            this.txtNgayKetThuc.TabIndex = 38;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 16);
            this.label25.TabIndex = 37;
            this.label25.Text = "Ngày Bắt Đầu";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(153, 34);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(100, 22);
            this.txtNgayBatDau.TabIndex = 36;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(41, 123);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 16);
            this.label26.TabIndex = 29;
            this.label26.Text = "Đơn Giá";
            // 
            // txtDonGiaLSG
            // 
            this.txtDonGiaLSG.Location = new System.Drawing.Point(136, 117);
            this.txtDonGiaLSG.Name = "txtDonGiaLSG";
            this.txtDonGiaLSG.Size = new System.Drawing.Size(100, 22);
            this.txtDonGiaLSG.TabIndex = 28;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(96, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(307, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(482, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(665, 263);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 37);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmLSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(795, 545);
            this.Controls.Add(this.grbLichSuGia);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhMuc);
            this.Name = "frmLSG";
            this.Text = "QuanLyBanHang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.grbLichSuGia.ResumeLayout(false);
            this.grbLichSuGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox grbLichSuGia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNgayKetThuc;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDonGiaLSG;
        private System.Windows.Forms.ComboBox cmbTenHangLSG;
        private System.Windows.Forms.Label label29;
    }
}

