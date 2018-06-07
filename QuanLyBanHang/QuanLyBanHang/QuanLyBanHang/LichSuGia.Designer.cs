namespace QuanLyBanHang
{
    partial class frmLichSuGia
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
            this.grbHang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.cmbTenHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHang
            // 
            this.grbHang.Controls.Add(this.label1);
            this.grbHang.Controls.Add(this.txtNgayCapNhat);
            this.grbHang.Controls.Add(this.cmbTenHang);
            this.grbHang.Controls.Add(this.label6);
            this.grbHang.Controls.Add(this.label4);
            this.grbHang.Controls.Add(this.txtDonGia);
            this.grbHang.Controls.Add(this.label5);
            this.grbHang.Controls.Add(this.txtNgayKetThuc);
            this.grbHang.Controls.Add(this.label2);
            this.grbHang.Controls.Add(this.txtNgayBatDau);
            this.grbHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHang.Location = new System.Drawing.Point(13, 25);
            this.grbHang.Margin = new System.Windows.Forms.Padding(4);
            this.grbHang.Name = "grbHang";
            this.grbHang.Padding = new System.Windows.Forms.Padding(4);
            this.grbHang.Size = new System.Drawing.Size(1023, 208);
            this.grbHang.TabIndex = 23;
            this.grbHang.TabStop = false;
            this.grbHang.Text = "Lịch Sử Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ngày Cập Nhật";
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Location = new System.Drawing.Point(516, 36);
            this.txtNgayCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.Size = new System.Drawing.Size(132, 26);
            this.txtNgayCapNhat.TabIndex = 34;
            // 
            // cmbTenHang
            // 
            this.cmbTenHang.FormattingEnabled = true;
            this.cmbTenHang.Location = new System.Drawing.Point(144, 43);
            this.cmbTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenHang.Name = "cmbTenHang";
            this.cmbTenHang.Size = new System.Drawing.Size(160, 28);
            this.cmbTenHang.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tên Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(839, 36);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(132, 26);
            this.txtDonGia.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày Kết Thúc";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(516, 135);
            this.txtNgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(132, 26);
            this.txtNgayKetThuc.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày Bắt Đầu";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(172, 135);
            this.txtNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(132, 26);
            this.txtNgayBatDau.TabIndex = 24;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXem.Location = new System.Drawing.Point(707, 263);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 46);
            this.btnXem.TabIndex = 22;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.Location = new System.Drawing.Point(488, 263);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 46);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.Location = new System.Drawing.Point(263, 263);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 46);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.Location = new System.Drawing.Point(47, 263);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 46);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.DonGia,
            this.NgayCapNhat});
            this.dgvDanhMuc.Location = new System.Drawing.Point(16, 22);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(977, 183);
            this.dgvDanhMuc.TabIndex = 18;
            this.dgvDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMuc_CellMouseClick);
            // 
            // MaHang
            // 
            this.MaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày cập nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(896, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhMuc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 212);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lịch sử giá mặt hàng";
            // 
            // frmLichSuGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbHang);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLichSuGia";
            this.Text = "LichSuGia";
            this.Load += new System.EventHandler(this.frmLichSuGia_Load);
            this.grbHang.ResumeLayout(false);
            this.grbHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHang;
        private System.Windows.Forms.ComboBox cmbTenHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
    }
}