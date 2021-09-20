namespace Tipsy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payment", "PaymentDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Payment", "PaymentDate", c => c.DateTime(nullable: false));
        }
    }
}
