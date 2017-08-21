namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPopular : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberOfRentalThisYear", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "IsPopular", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "IsPopular");
            DropColumn("dbo.Movies", "NumberOfRentalThisYear");
        }
    }
}
