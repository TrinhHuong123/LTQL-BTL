namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHUCVU : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUCVUs",
                c => new
                    {
                        TenChucVu = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaChucVu = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenChucVu);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CHUCVUs");
        }
    }
}
