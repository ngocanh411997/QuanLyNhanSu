using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Models
{
    class TrinhDoHocVan
    {
        public string MaTDHV { get; set; }

        public string TenTrinhDo { get; set; }

        public string ChuyenNganh { get; set; }

        public TrinhDoHocVan()
        {
            MaTDHV = "";
            TenTrinhDo = "";
            ChuyenNganh = "";
        }

        public TrinhDoHocVan(string _MaTDHV, string _TenTrinhDo, string _ChuyenNganh)
        {
            MaTDHV = _MaTDHV;
            TenTrinhDo = _TenTrinhDo;
            ChuyenNganh = _ChuyenNganh;
        }
    }
}
