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
    public partial class frmLogin : Form
    {
        string strCon = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(strCon))
                {
                    connect.Open();
                    string tk = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    string query = "select * from NguoiDung where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (txtTenDangNhap.Text=="")
                    {
                        lblLoiTenDN.Text = "Vui lòng nhập tài khoản";
                    }
                    if (txtMatKhau.Text == "")
                    {
                        lblLoiMK.Text = "Vui lòng nhập mật khẩu";
                    }
                    if (datareader.Read())
                    {
                        //MessageBox.Show("dang nhap thanh cong");
                        this.Hide();
                        frmNhanVien nv = new frmNhanVien();
                        txtMatKhau.Text = txtTenDangNhap.Text = "";
                        nv.Show();
                    }
                    else
                        MessageBox.Show("sai tài khoản hoặc mật khẩu");
                    
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ket noi" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            lblLoiTenDN.Text = "";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            lblLoiMK.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool ckeck = checkBox1.Checked;
            if (ckeck)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKi dk = new frmDangKi();
            dk.Show();
        }
    }
}
