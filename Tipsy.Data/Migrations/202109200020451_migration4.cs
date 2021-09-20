namespace Tipsy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drinks", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Order", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Payment", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Payment", "OrderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Drinks", "Price", c => c.Single(nullable: false));
            CreateIndex("dbo.Order", "DrinkId");
            CreateIndex("dbo.Payment", "OrderId");
            AddForeignKey("dbo.Order", "DrinkId", "dbo.Drinks", "DrinkId", cascadeDelete: true);
            AddForeignKey("dbo.Payment", "OrderId", "dbo.Order", "OrderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payment", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "DrinkId", "dbo.Drinks");
            DropIndex("dbo.Payment", new[] { "OrderId" });
            DropIndex("dbo.Order", new[] { "DrinkId" });
            AlterColumn("dbo.Drinks", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Payment", "OrderId");
            DropColumn("dbo.Payment", "UserId");
            DropColumn("dbo.Order", "UserId");
            DropColumn("dbo.Drinks", "UserId");
        }
    }
}
