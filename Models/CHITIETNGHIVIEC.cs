using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("CHITIETNGHIVIECs")]
    public class CHITIETNGHIVIEC
    {
        public string MaNV { get; set; }
        [Key]
        [StringLength(30)]
        public string MaNghiViec { get; set; }
        public DateTime NgayNghi { get; set; }
        public float ThoiGianNghi { get; set; }
    }
}
