using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("KHENTHUONGKYLUATs")]
    public class KHENTHUONGKYLUAT
    {
        public string MaNV { get; set; }
        [Key]
        [StringLength(30)]
        public string KhenThuong { get; set; }
        public string Lydo{ get; set; }

    }
}