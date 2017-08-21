namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateForRelease : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "Year");
            DropColumn("dbo.Movies", "Month");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Month", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Year", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
