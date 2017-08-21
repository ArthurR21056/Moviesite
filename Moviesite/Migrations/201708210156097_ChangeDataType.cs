namespace Moviesite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Double(nullable: false));
        }
    }
}
