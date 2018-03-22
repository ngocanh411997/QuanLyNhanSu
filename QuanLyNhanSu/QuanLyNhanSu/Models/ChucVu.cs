using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Models
{
    class ChucVu
    {
        public string MaChucVu { get; set; }

        public string TenChucVu { get; set; }

        public ChucVu()
        {
            MaChucVu = "";
            TenChucVu = "";
        }
        public ChucVu(string _MaChucVu, string _TenChucVu)
        {
            MaChucVu = _MaChucVu;
            TenChucVu = _TenChucVu;
        }
    }
}
