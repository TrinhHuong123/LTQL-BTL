namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NGHIVIEC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NGHIVIECs",
                c => new
                    {
                        Lydo = c.String(nullable: false, maxLength: 30, unicode: false),
                        MaNghiViec = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Lydo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NGHIVIECs");
        }
    }
}
