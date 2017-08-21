namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDoubletoPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieStatus", "PriceOfMovie", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieStatus", "PriceOfMovie", c => c.Short(nullable: false));
        }
    }
}
