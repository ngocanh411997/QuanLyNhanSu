namespace QuanLyNhanSu.View
{
    partial class frmDangKi
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
            this.txtDKTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDKMatKhau = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.lblLoiDKTaiKhoan = new System.Windows.Forms.Label();
            this.lblLoiDangKiMatKhau = new System.Windows.Forms.Label();
            this.lblLoiNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkShow1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // txtDKTaiKhoan
            // 
            this.txtDKTaiKhoan.Location = new System.Drawing.Point(207, 77);
            this.txtDKTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDKTaiKhoan.Name = "txtDKTaiKhoan";
            this.txtDKTaiKhoan.Size = new System.Drawing.Size(289, 26);
            this.txtDKTaiKhoan.TabIndex = 1;
            this.txtDKTaiKhoan.Click += new System.EventHandler(this.txtDKTaiKhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtDKMatKhau
            // 
            this.txtDKMatKhau.Location = new System.Drawing.Point(207, 144);
            this.txtDKMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDKMatKhau.Name = "txtDKMatKhau";
            this.txtDKMatKhau.Size = new System.Drawing.Size(289, 26);
            this.txtDKMatKhau.TabIndex = 1;
            this.txtDKMatKhau.UseSystemPasswordChar = true;
            this.txtDKMatKhau.Click += new System.EventHandler(this.txtDKMatKhau_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(234, 264);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 32);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(374, 264);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 32);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(207, 210);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(289, 26);
            this.txtNhapLaiMatKhau.TabIndex = 1;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            this.txtNhapLaiMatKhau.Click += new System.EventHandler(this.txtNhapLaiMatKhau_Click);
            // 
            // lblLoiDKTaiKhoan
            // 
            this.lblLoiDKTaiKhoan.AutoSize = true;
            this.lblLoiDKTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiDKTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblLoiDKTaiKhoan.Location = new System.Drawing.Point(207, 101);
            this.lblLoiDKTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoiDKTaiKhoan.Name = "lblLoiDKTaiKhoan";
            this.lblLoiDKTaiKhoan.Size = new System.Drawing.Size(0, 15);
            this.lblLoiDKTaiKhoan.TabIndex = 0;
            // 
            // lblLoiDangKiMatKhau
            // 
            this.lblLoiDangKiMatKhau.AutoSize = true;
            this.lblLoiDangKiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiDangKiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblLoiDangKiMatKhau.Location = new System.Drawing.Point(207, 168);
            this.lblLoiDangKiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoiDangKiMatKhau.Name = "lblLoiDangKiMatKhau";
            this.lblLoiDangKiMatKhau.Size = new System.Drawing.Size(0, 15);
            this.lblLoiDangKiMatKhau.TabIndex = 0;
            // 
            // lblLoiNhapLaiMatKhau
            // 
            this.lblLoiNhapLaiMatKhau.AutoSize = true;
            this.lblLoiNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNhapLaiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNhapLaiMatKhau.Location = new System.Drawing.Point(204, 234);
            this.lblLoiNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoiNhapLaiMatKhau.Name = "lblLoiNhapLaiMatKhau";
            this.lblLoiNhapLaiMatKhau.Size = new System.Drawing.Size(0, 15);
            this.lblLoiNhapLaiMatKhau.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "ĐĂNG KÍ TÀI KHOẢN";
            // 
            // checkShow1
            // 
            this.checkShow1.AutoSize = true;
            this.checkShow1.Location = new System.Drawing.Point(414, 178);
            this.checkShow1.Name = "checkShow1";
            this.checkShow1.Size = new System.Drawing.Size(107, 24);
            this.checkShow1.TabIndex = 3;
            this.checkShow1.Text = "Show Pass";
            this.checkShow1.UseVisualStyleBackColor = true;
            this.checkShow1.CheckedChanged += new System.EventHandler(this.checkShow1_CheckedChanged);
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 311);
            this.Controls.Add(this.checkShow1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDKMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDKTaiKhoan);
            this.Controls.Add(this.lblLoiNhapLaiMatKhau);
            this.Controls.Add(this.lblLoiDangKiMatKhau);
            this.Controls.Add(this.lblLoiDKTaiKhoan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDangKi";
            this.Text = "frmDangKi";
            this.Load += new System.EventHandler(this.frmDangKi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDKTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDKMatKhau;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label lblLoiDKTaiKhoan;
        private System.Windows.Forms.Label lblLoiDangKiMatKhau;
        private System.Windows.Forms.Label lblLoiNhapLaiMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkShow1;
    }
}