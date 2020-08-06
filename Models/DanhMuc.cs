using System.ComponentModel.DataAnnotations;

namespace Project.Models

{
    public class DanhMuc
    {
        [Key]
        public int idDanhMuc { get; set; }
        public string LoaiSanPham { get; set; }
        public string HangSanXuat { get; set; }
    }
}