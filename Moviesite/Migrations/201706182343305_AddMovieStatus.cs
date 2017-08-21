namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieStatus",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        PriceOfMovie = c.Short(nullable: false),
                        DiscountPrice = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MovieStatusId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "MovieStatusId");
            AddForeignKey("dbo.Movies", "MovieStatusId", "dbo.MovieStatus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieStatusId", "dbo.MovieStatus");
            DropIndex("dbo.Movies", new[] { "MovieStatusId" });
            DropColumn("dbo.Movies", "MovieStatusId");
            DropTable("dbo.MovieStatus");
        }
    }
}
