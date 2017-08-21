namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStocktoMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Quantity");
        }
    }
}
