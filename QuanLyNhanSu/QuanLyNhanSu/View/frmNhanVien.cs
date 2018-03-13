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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = NGOCANH\NGOCANH; Initial Catalog = QLNhanSu; Integrated Security = True");
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from NhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgNhanVien.DataSource = dt;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void dtgNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("ThemNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaNV", txtMaNV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@HoTen", txtHoTen.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DanToc", txtDanToc.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SDT", txtSDT.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgaySinh", txtNgaySinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaTDHV", txtMaTDHV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@BacLuong", txtBacLuong.Text);
                cmd.Parameters.Add(p);

                // Thực thi thủ tục
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Thêm Nhân Viên Thành Công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thêm được dữ liệu!");
                }
            }
            else
            {
                this.Close();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn sửa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("_SuaNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaNV", txtMaNV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@HoTen", txtHoTen.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DanToc", txtDanToc.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SDT", txtSDT.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgaySinh", txtNgaySinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaTDHV", txtMaTDHV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@BacLuong", txtBacLuong.Text);
                cmd.Parameters.Add(p);

                //thực thi thủ tục
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    LoadData();
                }
                else
                    MessageBox.Show("Không sửa được nhân viên");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên ?" +txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("_XoaNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaNV", txtMaNV.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

    }
}

