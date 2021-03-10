namespace BTL_LTQL_1721050522_Trinh_Thu_Huong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CONGTAC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CONGTACs",
                c => new
                    {
                        Ngaylamviec = c.String(nullable: false, maxLength: 30, unicode: false),
                        MaNV = c.String(unicode: false),
                        CongViec = c.String(unicode: false),
                        PhongBan = c.String(unicode: false),
                        NoiLamViec = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Ngaylamviec);
            
            DropTable("dbo.THANNHANs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.THANNHANs",
                c => new
                    {
                        HoTen = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaNV = c.String(unicode: false),
                        Moiquanhe = c.String(unicode: false),
                        NoiDung = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.HoTen);
            
            DropTable("dbo.CONGTACs");
        }
    }
}
