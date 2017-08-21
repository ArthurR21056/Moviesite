namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieStaus : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieStatus (Id, PriceOfMOvie, AgeOfMovie) VALUES (1, 20, 0)");
            Sql("INSERT INTO MovieStatus (Id, PriceOfMOvie, AgeOfMovie) VALUES (2, 18, 1)");
            Sql("INSERT INTO MovieStatus (Id, PriceOfMOvie, AgeOfMovie) VALUES (3, 16, 2)");
            Sql("INSERT INTO MovieStatus (Id, PriceOfMOvie, AgeOfMovie) VALUES (4, 14, 3)");
            Sql("INSERT INTO MovieStatus (Id, PriceOfMOvie, AgeOfMovie) VALUES (5, 12, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
