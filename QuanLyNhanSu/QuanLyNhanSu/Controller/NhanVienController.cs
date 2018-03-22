using Dapper;
using QuanLyNhanSu.helper;
using QuanLyNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.Controller
{
    internal class NhanVienController
    {
        public static List<NhanVien> getAllDataNV()
        {
            using (var db = setupConnection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<NhanVien>("SELECT * FROM dbo.NhanVien").ToList();
            }
        }
        public static bool ThemNV(string _MaNV, string _HoTen, string _DanToc, bool _GT, string _SDT, string _QueQuan, DateTime _NgaySinh, string _MaTDHV, string _MaPB, long _BacLuong)
        {
            if (checkInputNV( _MaNV,  _HoTen,  _DanToc,  _GT,  _SDT,  _QueQuan,  _NgaySinh,  _MaTDHV,  _MaPB,  _BacLuong))
            {
                int Insert_NV = -1;
                using (var db = setupConnection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_NV = db.Execute("ThemNV",new
                               {
                                   MaNV = _MaNV,
                            HoTen = _HoTen,
                            DanToc = _DanToc,
                            GioiTinh = _GT,
                            SDT = _SDT,
                            QueQuan = _QueQuan,
                            NgaySinh = _NgaySinh,
                            MaTDHV = _MaTDHV,
                            MaPB = _MaPB,
                            BacLuong = _BacLuong,
                        },
                               commandType: CommandType.StoredProcedure,
                               transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                    }
                }
                if (Insert_NV == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool SuaNV(string _MaNV, string _HoTen, string _DanToc, bool _GT, string _SDT, string _QueQuan, DateTime _NgaySinh, string _MaTDHV, string _MaPB, long _BacLuong)
        {
            if (checkInputNV( _MaNV,  _HoTen,  _DanToc,  _GT,  _SDT,  _QueQuan,  _NgaySinh,  _MaTDHV,  _MaPB,  _BacLuong))
            {
                int Insert_NV = -1;
                using (var db = setupConnection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_NV = db.Execute("SuaNhanVien",
                               new
                               {
                                   MaNV = _MaNV,
                                    HoTen = _HoTen,
                            DanToc = _DanToc,
                            GioiTinh = _GT,
                            SDT = _SDT,
                            QueQuan = _QueQuan,
                            NgaySinh = _NgaySinh,
                            MaTDHV = _MaTDHV,
                            MaPB = _MaPB,
                            BacLuong = _BacLuong,
                        },
                               commandType: CommandType.StoredProcedure,
                               transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                    }
                }
                if (Insert_NV == 1) return true;
                else return false;
            }
            return false;
        }
        public static bool Xoa(string _MaNV)
        {
            if (_MaNV != null)
            {
                int Del_NV = -1;
                using (var db = setupConnection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Del_NV = db.Execute("_XoaNV",
                               new
                               {
                                   MaNV = _MaNV,
                               },
                               commandType: CommandType.StoredProcedure,
                               transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                    }
                }
                if (Del_NV == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool checkInputNV(string _MaNV, string _HoTen, string _DanToc, bool _GT, string _SDT, string _QueQuan, DateTime _NgaySinh, string _MaTDHV, string _MaPB, long _BacLuong)
        {
            string errMS = "";
            if (_MaNV == "") { errMS = "Trống mã nhân viên"; }
            if (_HoTen == "") { errMS += "\nTrống họ tên"; }
            if (_DanToc == "") { errMS += "\nTrống dân tộc"; }
            if (_SDT == "") { errMS += "\nTrống số điện thoại"; }
            if (_QueQuan == "") { errMS += "\nTrống quê quán"; }
            if (_NgaySinh.Year > DateTime.Now.Year) { errMS += "\nLỗi ngày sinh"; }
            if (_MaTDHV == "") { errMS += "\nTrống mã trình độ học vấn"; }
            if (_MaPB == "") { errMS += "\nTrống mã phòng ban"; }
            
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // Hiển Thị Danh Sách Tìm Kiếm
        public static List<NhanVien> TimKiem(int type, string TuKhoa)
        {
            using (var db = setupConnection.ConnectionFactory())
            {
                string query = "";
                if (db.State == ConnectionState.Closed)
                    db.Open();
                switch (type)
                {
                    case 0:

                        query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNV LIKE '%{0}%'", TuKhoa);
                        return db.Query<NhanVien>(query).ToList();
                    case 1:

                        query = string.Format("SELECT * FROM dbo.NhanVien WHERE HoTen LIKE N'%{0}%'", TuKhoa);
                        return db.Query<NhanVien>(query).ToList();
                    case 2:
                        query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaPB LIKE '%{0}%'", TuKhoa);
                        return db.Query<NhanVien>(query).ToList();
                    case 3:
                        query = string.Format("SELECT * FROM dbo.NhanVien WHERE QueQuan LIKE N'%{0}%'", TuKhoa);
                        return db.Query<NhanVien>(query).ToList();
                }
                return db.Query<NhanVien>("SELECT * FROM dbo.NhanVien").ToList();
            }
        }

    }
}
