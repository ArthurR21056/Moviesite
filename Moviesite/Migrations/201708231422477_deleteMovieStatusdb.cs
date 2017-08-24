namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteMovieStatusdb : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MovieStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MovieStatus",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        AgeOfMovie = c.Int(nullable: false),
                        PriceOfMovie = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
