namespace HotellbookingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedRoomSize : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "RoomSizeId", "dbo.RoomSizes");
            DropIndex("dbo.Rooms", new[] { "RoomSizeId" });
            AddColumn("dbo.Rooms", "RoomSize", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "RoomSizeId");
            DropTable("dbo.RoomSizes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RoomSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rooms", "RoomSizeId", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "RoomSize");
            CreateIndex("dbo.Rooms", "RoomSizeId");
            AddForeignKey("dbo.Rooms", "RoomSizeId", "dbo.RoomSizes", "Id");
        }
    }
}
