using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmNhanVien : Form
    {
        /* public void LoadData()
         {
             txtMaNV.DataBindings.Clear();
             txtMaNV.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaNV");

             txtHoTen.DataBindings.Clear();
             txtHoTen.DataBindings.Add("Text", dtgNhanVien.DataSource, "HoTen");

             txtMaPB.DataBindings.Clear();
             txtMaPB.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaPB");

             txtDanToc.DataBindings.Clear();
             txtDanToc.DataBindings.Add("Text", dtgNhanVien.DataSource, "DanToc");

             txtGioiTinh.DataBindings.Clear();
             txtGioiTinh.DataBindings.Add("Text", dtgNhanVien.DataSource, "GioiTinh");

             txtSDT.DataBindings.Clear();
             txtSDT.DataBindings.Add("Text", dtgNhanVien.DataSource, "SDT");

             txtNgaySinh.DataBindings.Clear();
             txtNgaySinh.DataBindings.Add("Text", dtgNhanVien.DataSource, "NgaySinh");

             txtQueQuan.DataBindings.Clear();
             txtQueQuan.DataBindings.Add("Text", dtgNhanVien.DataSource, "QueQuan");

             txtBacLuong.DataBindings.Clear();
             txtBacLuong.DataBindings.Add("Text", dtgNhanVien.DataSource, "BacLuong");

             txtMaTDHV.DataBindings.Clear();
             txtMaTDHV.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaTDHV");

         }*/
       
        private void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP - LU4NK9A\SQLEXPRESS01; Initial Catalog = QLNhanSu; Integrated Security = True");
                //MessageBox.Show("Tess");
                conn.Open();
                
                string sql = "Select * from NhanVien";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                DataAdapter.Fill(table);
                dtgNhanVien.DataSource = table;
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu!" + ex.Message);
            }
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            KetNoi();
           // dtgNhanVien_CellContentClick();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string them;
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP - LU4NK9A\SQLEXPRESS01; Initial Catalog = QLNhanSu; Integrated Security = True");
                conn.Open();
                them = " insert into NhanVien(MaNV,MaPB,HoTen,DanToc,GioiTinh,SDT,NgaySinh,QueQuan,BacLuong,MaTDHV) values ('" + txtMaNV.Text + "','" + txtMaPB.Text + "','" + txtHoTen.Text + "','" + txtDanToc.Text + "','" + txtGioiTinh.Text + "','" + txtSDT.Text + "','" + txtNgaySinh.Text + "','" + txtQueQuan.Text + "','" + txtBacLuong.Text + "','" + txtMaTDHV.Text + "')";
                SqlCommand commandThem = new SqlCommand(them, conn);
                commandThem.ExecuteNonQuery();
                KetNoi();
               // dtgNhanVien_CellContentClick();
                MessageBox.Show("Đã Thêm!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, Không thêm được!" + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sua;
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP - LU4NK9A\SQLEXPRESS01; Initial Catalog = QLNhanSu; Integrated Security = True");
                conn.Open();
                sua = "update NhanVien set MaPB = '"+txtMaPB.Text+ "',HoTen = '" + txtHoTen.Text + "',DanToc = '" + txtDanToc.Text + "',GioiTinh = '" + txtGioiTinh.Text + "',SDT = '" + txtSDT.Text + "',NgaySinh = '" + txtNgaySinh.Text + "',QueQuan = '" + txtQueQuan.Text + "',BacLuong = '" + txtBacLuong.Text + "',MaTDHV = '" + txtMaTDHV.Text + "'";
                SqlCommand commandSua = new SqlCommand(sua, conn);
                commandSua.ExecuteNonQuery();
                KetNoi();
               // dtgNhanVien_CellContentClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi, không sửa được" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoa;
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP - LU4NK9A\SQLEXPRESS01; Initial Catalog = QLNhanSu; Integrated Security = True");
                conn.Open();
                xoa = " Delete from NhanVien Where MaNV = '" + txtMaNV.Text + "'";
                SqlCommand commandXoa = new SqlCommand(xoa, conn);
                commandXoa.ExecuteNonQuery();
                KetNoi();
               // dtgNhanVien_CellContentClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi, Không xóa được" + ex.Message);
            }

        }

      
    }
}
