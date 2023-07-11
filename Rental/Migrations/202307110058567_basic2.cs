namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class basic2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Extratest", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Extratest");
        }
    }
}
