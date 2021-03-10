namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NHANVIEN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        MaCV = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(unicode: false),
                        HoTen = c.String(unicode: false),
                        GioiTinh = c.String(unicode: false),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(unicode: false),
                        DanToc = c.String(),
                        NgayKyHopDong = c.DateTime(nullable: false),
                        HanHopDong = c.String(unicode: false),
                        MaPhongBan = c.String(unicode: false),
                        MaChucVu = c.String(),
                        TenChucVu = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaCV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NHANVIENs");
        }
    }
}
