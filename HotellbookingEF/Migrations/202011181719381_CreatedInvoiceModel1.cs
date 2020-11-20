namespace HotellbookingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedInvoiceModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        InvoiceStatus = c.String(),
                        Total = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id)
                .Index(t => t.Booking_Id);           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "Booking_Id", "dbo.Bookings");
            DropIndex("dbo.Invoices", new[] { "Booking_Id" });
            DropTable("dbo.Invoices");
        }
    }
}
