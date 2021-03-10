using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("NGHIVIECs")]
    public class NGHIVIEC
    {
        public string MaNghiViec { get; set; }
        [Key]
        [StringLength(30)]
        public string Lydo { get; set; }

    }
}