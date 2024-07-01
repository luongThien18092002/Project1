using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project1.Models
{
    [Table("DaiLy")]
    public class DaiLy : HeThongPhanPhoi
    {
        [Key]
        public string MaHTPP{ get; set; }
        public string MaDaiLy{ get; set; }
        public string TenDaiLy{ get; set; }
        public string DiaChia{ get; set; }
        public string  NguoiDaiDien{ get; set; }
        public string DienThoai{ get; set; }
    }
}