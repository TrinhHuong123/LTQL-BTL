namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KHENTHUONGKYLUAT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KHENTHUONGKYLUATs",
                c => new
                    {
                        KhenThuong = c.String(nullable: false, maxLength: 30, unicode: false),
                        MaNV = c.String(unicode: false),
                        Lydo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.KhenThuong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KHENTHUONGKYLUATs");
        }
    }
}
