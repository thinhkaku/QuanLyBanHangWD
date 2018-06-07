namespace QuanLyBanHang
{
    partial class frmBCTonKho
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
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnInBC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đơn vị";
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(408, 79);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(208, 22);
            this.txtDV.TabIndex = 1;
            this.txtDV.TextChanged += new System.EventHandler(this.txtDV_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(408, 155);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(208, 22);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn tháng năm báo cáo";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(39, 309);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(876, 283);
            this.reportViewer1.TabIndex = 6;
            // 
            // btnInBC
            // 
            this.btnInBC.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInBC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInBC.Location = new System.Drawing.Point(758, 143);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(100, 46);
            this.btnInBC.TabIndex = 7;
            this.btnInBC.Text = "In báo cáo";
            this.btnInBC.UseVisualStyleBackColor = false;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // frmBCTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 718);
            this.Controls.Add(this.btnInBC);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.label1);
            this.Name = "frmBCTonKho";
            this.Text = "frmBCTonKho";
            this.Load += new System.EventHandler(this.frmBCTonKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnInBC;
    }
}