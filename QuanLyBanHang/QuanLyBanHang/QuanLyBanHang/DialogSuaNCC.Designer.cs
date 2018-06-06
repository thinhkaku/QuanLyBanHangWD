namespace QuanLyBanHang
{
    partial class DialogSuaNCC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(279, 54);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(208, 22);
            this.txtTenNCC.TabIndex = 3;
            this.txtTenNCC.TextChanged += new System.EventHandler(this.txtTenNCC_TextChanged);
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(725, 53);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(208, 22);
            this.txtDiaChiNCC.TabIndex = 4;
            this.txtDiaChiNCC.TextChanged += new System.EventHandler(this.txtDiaChiNCC_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(279, 131);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(208, 22);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // btnXong
            // 
            this.btnXong.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXong.Location = new System.Drawing.Point(279, 219);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(100, 46);
            this.btnXong.TabIndex = 6;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = false;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(639, 219);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 46);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // DialogSuaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 317);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChiNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DialogSuaNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogSuaNCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Button btnHuy;
    }
}