using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.POJO
{
    public class SanPham
    {
        public int id { get; set; }
        public String mauSac { get; set; }
        public String TenSanPham { get; set; }
        public double Gia { get; set; }
        public ThongSo ThongSo { get; set; }
        public  DanhMuc DanhMuc { get; set; }
        public String HinhAnhSanPham { get; set; }

        public SanPham()
        {
        }
    }
}