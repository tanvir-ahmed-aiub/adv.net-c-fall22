namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoomHotelTAblesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        Rent = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
            DropTable("dbo.Hotels");
        }
    }
}
