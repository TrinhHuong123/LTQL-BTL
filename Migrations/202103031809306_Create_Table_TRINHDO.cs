namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TRINHDO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TRINHDOs",
                c => new
                    {
                        TenTrinhDo = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaTrinhDo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenTrinhDo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TRINHDOs");
        }
    }
}
