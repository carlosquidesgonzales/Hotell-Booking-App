namespace HotellbookingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedInvoiceModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "BookingDateStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Bookings", "BookingDateEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Bookings", "NumberOfPerson", c => c.Int(nullable: false));
            DropColumn("dbo.Bookings", "IsBooked");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "IsBooked", c => c.Boolean(nullable: false));
            DropColumn("dbo.Bookings", "NumberOfPerson");
            DropColumn("dbo.Bookings", "BookingDateEnd");
            DropColumn("dbo.Bookings", "BookingDateStart");
        }
    }
}
