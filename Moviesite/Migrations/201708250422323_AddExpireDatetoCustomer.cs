namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExpireDatetoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ExpirationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ExpirationDate");
        }
    }
}
