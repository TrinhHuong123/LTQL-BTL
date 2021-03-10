using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("CONGTACs")]
    public class CONGTAC
    {
        public string MaNV { get; set; }
        [Key]
        [StringLength(30)]
        public string Ngaylamviec { get; set; }
        public string CongViec { get; set; }
        public string PhongBan { get; set; }
        public string NoiLamViec { get; set; }
    }
}