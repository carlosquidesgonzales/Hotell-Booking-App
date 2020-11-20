namespace HotellbookingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInvoice : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoices", "Booking_Id", "dbo.Bookings");
            DropIndex("dbo.Invoices", new[] { "Booking_Id" });
            RenameColumn(table: "dbo.Invoices", name: "Booking_Id", newName: "BookingId");
            AlterColumn("dbo.Invoices", "BookingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Invoices", "BookingId");
            AddForeignKey("dbo.Invoices", "BookingId", "dbo.Bookings", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "BookingId", "dbo.Bookings");
            DropIndex("dbo.Invoices", new[] { "BookingId" });
            AlterColumn("dbo.Invoices", "BookingId", c => c.Int());
            RenameColumn(table: "dbo.Invoices", name: "BookingId", newName: "Booking_Id");
            CreateIndex("dbo.Invoices", "Booking_Id");
            AddForeignKey("dbo.Invoices", "Booking_Id", "dbo.Bookings", "Id");
        }
    }
}
