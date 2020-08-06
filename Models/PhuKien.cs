using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class PhuKien
    {
        [Key]
        public int idPhuKien { get; set; }
        public KhuyenMai khuyenMai { get; set; }
        public DanhMuc danhMuc { get; set; }
        public string moTa { get; set; }
        public double giaTien { get; set; }
        public string hinhAnhSanPham { get; set; }
    }
}