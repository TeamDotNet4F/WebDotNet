using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class GioHang
    {
        [Key]
        public int idGioHang { get; set; }
        public int soLuong { get; set; }
    }
}