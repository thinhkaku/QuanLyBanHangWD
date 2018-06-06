namespace QuanLyBanHang
{
    partial class DilogSuaNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(232, 35);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(208, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(764, 35);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(208, 22);
            this.txtDC.TabIndex = 2;
            this.txtDC.TextChanged += new System.EventHandler(this.txtDC_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(232, 98);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(208, 22);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHuy.Location = new System.Drawing.Point(644, 219);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 46);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXong
            // 
            this.btnXong.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXong.Location = new System.Drawing.Point(356, 219);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(100, 46);
            this.btnXong.TabIndex = 7;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = false;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // DilogSuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 317);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label1);
            this.Name = "DilogSuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXong;
    }
}