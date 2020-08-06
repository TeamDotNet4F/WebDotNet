using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class KhuyenMai
    {
        [Key]
        public int idKhuyenMai { get; set; }
        public string noiDungKhuyenMai { get; set; }
        public double phanTramgia { get; set; }
    }
}