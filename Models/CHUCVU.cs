

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("CHUCVUs")]
    public class CHUCVU
    {
        public string MaChucVu { get; set; }
        [Key]
        [StringLength(20)]
        public string TenChucVu { get; set; }
    }
}