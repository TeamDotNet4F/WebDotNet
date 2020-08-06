using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Project.Models
{
    public class DonHang
    {
        [Key]
        public int idDonHang { get; set; }
        public int idKhachHang { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public double giaTriDon { get; set; }
    }
}