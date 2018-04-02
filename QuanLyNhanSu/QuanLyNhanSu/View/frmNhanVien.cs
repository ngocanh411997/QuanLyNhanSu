using Dapper;
using QuanLyNhanSu.Controller;
using QuanLyNhanSu.helper;
using QuanLyNhanSu.Models;
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private List<NhanVien> lstNV;
        private int CurCl = 0, CurR = 0;
        private string IDmember;
        public void Hienthi()
        {
            lstNV = NhanVienController.getAllDataNV();
            DataTable dt = ViewHelper.ToDataTable<NhanVien>(lstNV);
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaNV"].ColumnName = "Mã NV";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["DanToc"].ColumnName = "Dân Tộc";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ/nam ✓)";
            dt.Columns["SDT"].ColumnName = "SDT";
            dt.Columns["QueQuan"].ColumnName = "Quê Quán";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["MaTDHV"].ColumnName = "Mã TĐHV";
            dt.Columns["MaPB"].ColumnName = "Mã PB";
            dt.Columns["BacLuong"].ColumnName = "Bậc Lương";

            int i = 0;
            foreach (DataGridViewColumn col in dgvNhanVien.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgvNhanVien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            ///Thao tac ma phòng ban
            ///1. Get all ma pb
            ///
            using (var db = setupConnection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                List<PhongBan> list = db.Query<PhongBan>("SELECT MaPB FROM dbo.PhongBan").ToList();
                for (int j = 0; j < list.Count; j++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = list[j].MaPB.ToString();
                    item.Value = list[j].MaPB.ToString();
                    cbMaPB.Items.Add(item);

                }
            }



            dgvNhanVien.Refresh();

        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        int i;
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            CurCl = dgvNhanVien.CurrentCell.ColumnIndex;
            CurR = dgvNhanVien.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaNV.Text = lstNV[i].MaNV;
            txtHoTen.Text = lstNV[i].HoTen;
            txtDanToc.Text = lstNV[i].DanToc;
            if (lstNV[i].GioiTinh)
            {
                radNam.Checked = true;

            }
            else
            {
                radNu.Checked = true;

            }
            txtSDT.Text = lstNV[i].SDT;
            txtQueQuan.Text = lstNV[i].QueQuan;
            dtNgaySinh.Value = lstNV[i].NgaySinh;
            txtMaTDHV.Text = lstNV[i].MaTDHV;
            cbMaPB.Text = lstNV[i].MaPB;
            txtBacLuong.Text= lstNV[i].BacLuong.ToString();
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtBacLuong.Text = "";
            txtDanToc.Text = "";
            txtHoTen.Text = "";
            txtMaTDHV.Text = "";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            foreach (NhanVien nv in lstNV)
            {
                if (nv.MaNV == txtMaNV.Text.Trim().ToUpper())
                {
                    MessageBox.Show("Trùng Mã ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // lấy giới tính
            bool gt = true;
            if (radNam.Checked)
            {
                gt = true;
            }
            else gt = false;

            int _luong;
            int.TryParse(txtBacLuong.Text, out _luong);

            // Thêm học sinh
            NhanVienController.ThemNV(txtMaNV.Text.Trim().ToUpper(), txtHoTen.Text.Trim(), txtDanToc.Text.Trim(), gt, txtSDT.Text.Trim(), txtQueQuan.Text.Trim(), dtNgaySinh.Value, txtMaTDHV.Text.Trim(), cbMaPB.Text, _luong);
            MessageBox.Show("Đã Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool gt = true;
            if (radNam.Checked)
            {
                gt = true;
            }
            else gt = false;

            int _luong;
            int.TryParse(txtBacLuong.Text, out _luong);
            //Xử lý comb
            // Thêm học sinh
            NhanVienController.SuaNV(txtMaNV.Text.Trim().ToUpper(), txtHoTen.Text.Trim(), txtDanToc.Text.Trim(), gt, txtSDT.Text.Trim(), txtQueQuan.Text.Trim(), dtNgaySinh.Value, txtMaTDHV.Text.Trim(), cbMaPB.Text, _luong);
            MessageBox.Show("Đã Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("Vui lòng chọn 1 trường", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                if (NhanVienController.Xoa(IDmember))
                {
                    MessageBox.Show("Đã Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Hienthi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "" || txtTimKiem.Text.Trim().Length > 50)
            {
                MessageBox.Show("Lỗi Từ khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienthiKQTimKiem();

        }
        public void HienthiKQTimKiem()
        {
            List<NhanVien> lstTimKiem = NhanVienController.TimKiem(cbTimKiem.SelectedIndex, txtTimKiem.Text.Trim());
            DataTable dt = ViewHelper.ToDataTable<NhanVien>(lstTimKiem);
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaNV"].ColumnName = "Mã NV";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["DanToc"].ColumnName = "Dân Tộc";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ/nam ✓)";
            dt.Columns["SDT"].ColumnName = "SDT";
            dt.Columns["QueQuan"].ColumnName = "Quê Quán";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["MaTDHV"].ColumnName = "Mã TĐHV";
            dt.Columns["MaPB"].ColumnName = "Mã PB";
            dt.Columns["BacLuong"].ColumnName = "Bậc Lương";

            int i = 0;
            foreach (DataGridViewColumn col in dgvNhanVien.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgvNhanVien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Hienthi();
        }


        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn Chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
    }
}

