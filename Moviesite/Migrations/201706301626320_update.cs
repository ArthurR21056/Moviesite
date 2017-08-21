namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieStatusId", "dbo.MovieStatus");
            DropIndex("dbo.Movies", new[] { "MovieStatusId" });
            AddColumn("dbo.Movies", "PriceOfMovie", c => c.Double(nullable: false));
            DropColumn("dbo.Movies", "IsPopular");
            DropColumn("dbo.Movies", "MovieStatusId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieStatusId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "IsPopular", c => c.Boolean(nullable: false));
            DropColumn("dbo.Movies", "PriceOfMovie");
            CreateIndex("dbo.Movies", "MovieStatusId");
            AddForeignKey("dbo.Movies", "MovieStatusId", "dbo.MovieStatus", "Id", cascadeDelete: true);
        }
    }
}
