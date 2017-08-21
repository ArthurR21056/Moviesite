namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeofMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieStatus", "AgeOfMovie", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieStatus", "AgeOfMovie");
        }
    }
}
