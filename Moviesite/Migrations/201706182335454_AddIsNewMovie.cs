namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsNewMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "IsNewMovie", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "IsNewMovie");
        }
    }
}
