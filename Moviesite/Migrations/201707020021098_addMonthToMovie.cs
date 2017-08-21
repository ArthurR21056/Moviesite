namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMonthToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Month", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
        }
    }
}
