using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Project.Models
{
    public class KhachHang
    {
        [Key]
        public int idKhachHang { get; set; }
        public int MyProperty { get; set; }
    }
}