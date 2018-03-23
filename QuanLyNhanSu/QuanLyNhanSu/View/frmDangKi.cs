using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.View
{
    public partial class frmDangKi : Form
    {
        string strCon = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.Show();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtDKTaiKhoan.Text=="")
            {
                lblLoiDKTaiKhoan.Text = "Bạn chưa nhập tài khoản";
            }else if (txtDKMatKhau.Text=="")
            {
                lblLoiDangKiMatKhau.Text = "Bạn chưa nhập mật khẩu";
            }
            else if (txtDKMatKhau.Text!=txtNhapLaiMatKhau.Text)
            {
                lblLoiNhapLaiMatKhau.Text = "Mật khẩu không trùng khớp";
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(strCon))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("SP_DangKi", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taikhoan", txtDKTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@matkhau", txtDKMatKhau.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("tạo tài khoản thành công");
                    connect.Close();

                }
            }
            
        }

        private void txtDKTaiKhoan_Click(object sender, EventArgs e)
        {
            lblLoiDKTaiKhoan.Text = "";
        }

        private void txtDKMatKhau_Click(object sender, EventArgs e)
        {
            lblLoiDangKiMatKhau.Text = "";
        }

        private void txtNhapLaiMatKhau_Click(object sender, EventArgs e)
        {
            lblLoiNhapLaiMatKhau.Text = "";
        }

        private void checkShow1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkpass = checkShow1.Checked;
            if (checkpass)
            {
                txtDKMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtDKMatKhau.UseSystemPasswordChar = true;
        }
    }
}
