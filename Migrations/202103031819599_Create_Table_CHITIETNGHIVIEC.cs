namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHITIETNGHIVIEC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHITIETNGHIVIECs",
                c => new
                    {
                        MaNghiViec = c.String(nullable: false, maxLength: 30, unicode: false),
                        MaNV = c.String(unicode: false),
                        NgayNghi = c.DateTime(nullable: false),
                        ThoiGianNghi = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaNghiViec);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CHITIETNGHIVIECs");
        }
    }
}
