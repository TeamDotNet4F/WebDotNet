using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ThongSo
    {
        [Key]
        public int idThongSo { get; set; }
        public string HeDieuHanh { get; set;}
        public string LoaiManHinh { get; set; }
        public string DoPhanGiai { get; set; }
        public string ManHinhRong { get; set; }
        public string CameraTruoc { get; set; }

        public string CameraSau { get; set; }
        public string QuayPhim { get; set; }
        public string TocDoCPU { get; set; }
        public string ChipSet { get; set; }
        public string Ram { get; set; }
        public string ChipDoHoa { get; set; }
        public string Rom { get; set; }
        public string TheNhoNgoai { get; set; }
        public string TrongLuong { get; set; }
        public string DungLuongPIN { get; set; }
        public string Bluetooth { get; set; }
        public string Wifi { get; set; }
        public string Mang { get; set; }
        public string LoaiSIM { get; set; }

        public ThongSo()
        {
            
        }
    }
}