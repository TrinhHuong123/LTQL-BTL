using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("TRINHDOs")]
    public class TRINHDO
    {
        public string MaTrinhDo { get; set; }
        [Key]
        [StringLength(20)]
        public string TenTrinhDo { get; set; }
    }
}