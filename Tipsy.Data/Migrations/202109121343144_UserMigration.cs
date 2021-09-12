namespace Tipsy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "PaymentId", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "OrderUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Order", "UserFullName");
            DropColumn("dbo.Order", "DrinkId");
            DropColumn("dbo.Order", "DrinkName");
            DropColumn("dbo.Order", "OrderSubTotal");
            DropColumn("dbo.Order", "OrderTax");
            DropColumn("dbo.Order", "OrderTotal");
            DropColumn("dbo.Order", "CreatedUtc");
            DropColumn("dbo.Order", "ModifiedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Order", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Order", "OrderTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Order", "OrderTax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Order", "OrderSubTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Order", "DrinkName", c => c.String(nullable: false));
            AddColumn("dbo.Order", "DrinkId", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "UserFullName", c => c.String(nullable: false));
            DropColumn("dbo.Order", "OrderUtc");
            DropColumn("dbo.Order", "PaymentId");
            DropColumn("dbo.Order", "CustomerId");
            DropColumn("dbo.Order", "Quantity");
        }
    }
}
