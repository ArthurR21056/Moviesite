namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMonthToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Month", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Month");
        }
    }
}
