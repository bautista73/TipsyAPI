namespace Tipsy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        DrinkId = c.Int(nullable: false, identity: true),
                        DrinkName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.DrinkId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        Amount = c.Single(nullable: false),
                        PaymentType = c.Int(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            AddColumn("dbo.Order", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "OrderUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Order", "UserId");
            DropColumn("dbo.Order", "UserFullName");
            DropColumn("dbo.Order", "DrinkName");
            DropColumn("dbo.Order", "OrderSubTotal");
            DropColumn("dbo.Order", "OrderTax");
            DropColumn("dbo.Order", "OrderTotal");
            DropColumn("dbo.Order", "IsComplete");
            DropColumn("dbo.Order", "OrderNotes");
            DropColumn("dbo.Order", "CreatedUtc");
            DropColumn("dbo.Order", "ModifiedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Order", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Order", "OrderNotes", c => c.String(nullable: false));
            AddColumn("dbo.Order", "IsComplete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Order", "OrderTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Order", "OrderTax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Order", "OrderSubTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Order", "DrinkName", c => c.String(nullable: false));
            AddColumn("dbo.Order", "UserFullName", c => c.String(nullable: false));
            AddColumn("dbo.Order", "UserId", c => c.Guid(nullable: false));
            DropColumn("dbo.Order", "OrderUtc");
            DropColumn("dbo.Order", "Quantity");
            DropTable("dbo.Payment");
            DropTable("dbo.Drinks");
        }
    }
}
