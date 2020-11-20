namespace HotellbookingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInvoiceModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "DatePaid", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "DatePaid");
        }
    }
}
