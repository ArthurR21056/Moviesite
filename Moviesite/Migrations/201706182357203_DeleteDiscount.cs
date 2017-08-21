namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDiscount : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MovieStatus", "DiscountPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieStatus", "DiscountPrice", c => c.Byte(nullable: false));
        }
    }
}
