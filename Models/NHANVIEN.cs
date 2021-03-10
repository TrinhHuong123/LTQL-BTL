using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    [Table("NHANVIENs")]
    public class NHANVIEN
    {
        public string MaNV { get; set; }
        [Key]
        [StringLength(50)]
       
        public string MaCV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string DanToc { get; set; }
        public DateTime NgayKyHopDong { get; set; }
        public string HanHopDong{ get; set; }
        public string MaPhongBan{ get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }


    } 
}