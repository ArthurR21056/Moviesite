namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteExpireDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "ExpirationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ExpirationDate", c => c.DateTime(nullable: false));
        }
    }
}
