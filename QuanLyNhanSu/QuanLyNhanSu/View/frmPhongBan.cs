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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = NGOCANH\NGOCANH; Initial Catalog = QLNhanSu; Integrated Security = True");
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from PhongBan", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgPhongBan.DataSource = dt;
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dtgPhongBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgPhongBan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("_ThemPB", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenPB", txtTenPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SDT", txtSDT.Text);
                cmd.Parameters.Add(p);
               
                // Thực thi thủ tục
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Thêm Phòng Ban Thành Công");
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
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("_SuaPB", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenPB", txtTenPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SDT", txtSDT.Text);
                cmd.Parameters.Add(p);
                //thực thi thủ tục
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Sửa phòng ban thành công");
                    LoadData();
                }
                else
                    MessageBox.Show("Không sửa được phòng ban");
            }
           
            else
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = NGOCANH\NGOCANH; Initial Catalog = QLNhanSu; Integrated Security = True");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "_XoaPB";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MaPB", txtMaPB.Text);               
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa Thành Công!");
                LoadData();

            }            
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được!");
            }
            // đóng kết nối
            
            
        }
    }
}
