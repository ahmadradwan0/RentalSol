namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "SignUpFee");
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
            DropColumn("dbo.MembershipTypes", "DiscountRate");
            DropColumn("dbo.MembershipTypes", "TotalMoviesAllowed");
            DropColumn("dbo.MembershipTypes", "TotalDiscountsAllowed");
            DropColumn("dbo.MembershipTypes", "Extratest");
            DropColumn("dbo.MembershipTypes", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.MembershipTypes", "Extratest", c => c.Int());
            AddColumn("dbo.MembershipTypes", "TotalDiscountsAllowed", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "TotalMoviesAllowed", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
        }
    }
}
