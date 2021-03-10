using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CONGTAC> CONGTACs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaNV)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaCV)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.HoTen)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.GioiTinh)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.NgaySinh);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.QueQuan)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.NgayKyHopDong);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.HanHopDong)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaPhongBan)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaCV)
               .IsUnicode(false);
            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.TenChucVu)
               .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
               .Property(e => e.MaChucVu)
               .IsUnicode(false);
            modelBuilder.Entity<CHUCVU>()
               .Property(e => e.TenChucVu)
               .IsUnicode(false);

            modelBuilder.Entity<TRINHDO>()
               .Property(e => e.MaTrinhDo)
               .IsUnicode(false);
            modelBuilder.Entity<TRINHDO>()
               .Property(e => e.TenTrinhDo)
               .IsUnicode(false);

            modelBuilder.Entity<KHENTHUONGKYLUAT>()
               .Property(e => e.MaNV)
               .IsUnicode(false);
            modelBuilder.Entity<KHENTHUONGKYLUAT>()
               .Property(e => e.KhenThuong)
               .IsUnicode(false);
            modelBuilder.Entity<KHENTHUONGKYLUAT>()
               .Property(e => e.Lydo)
               .IsUnicode(false);

            modelBuilder.Entity<CHITIETNGHIVIEC>()
               .Property(e => e.MaNV)
               .IsUnicode(false);
            modelBuilder.Entity<CHITIETNGHIVIEC>()
               .Property(e => e.MaNghiViec)
               .IsUnicode(false);
            modelBuilder.Entity<CHITIETNGHIVIEC>()
               .Property(e => e.NgayNghi);
            modelBuilder.Entity<CHITIETNGHIVIEC>()
               .Property(e => e.ThoiGianNghi);

            modelBuilder.Entity<NGHIVIEC>()
              .Property(e => e.MaNghiViec)
              .IsUnicode(false);
            modelBuilder.Entity<NGHIVIEC>()
              .Property(e => e.Lydo)
              .IsUnicode(false);

            modelBuilder.Entity<CONGTAC>()
              .Property(e => e.MaNV)
              .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
              .Property(e => e.Ngaylamviec)
              .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
              .Property(e => e.CongViec)
              .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
              .Property(e => e.PhongBan)
              .IsUnicode(false);
            modelBuilder.Entity<CONGTAC>()
              .Property(e => e.NoiLamViec)
              .IsUnicode(false);
        }
    }
}
