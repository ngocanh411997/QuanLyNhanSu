using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Models
{
    public class PhongBan
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public PhongBan()
        {
            MaPB = "";
            TenPB = "";
            DiaChi = "";
            SDT = "";
        }
        public PhongBan(string _MaPB, string _TenPB, string _DiaChi, string _SDT)
        {
            MaPB = _MaPB;
            TenPB = _TenPB;
            DiaChi = _DiaChi;
            SDT = _SDT;
        }
    }
}
