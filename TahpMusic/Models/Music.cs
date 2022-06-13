using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TahpMusic.Models
{
    public class Music
    {
        public long MusicID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên ca khúc")]
        public string TenCaKhuc { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên ca sĩ")]
        public string CaSi { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage = "Vui lòng nhập giá tiền")]
        public decimal Gia { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thể loại")]
        public string TheLoai { get; set; }
        
    }
}

