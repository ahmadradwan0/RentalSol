namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addconstaitnsonId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypeBasics");
            DropPrimaryKey("dbo.MembershipTypeBasics");
            AlterColumn("dbo.MembershipTypeBasics", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.MembershipTypeBasics", "Id");
            AddForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypeBasics", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypeBasics");
            DropPrimaryKey("dbo.MembershipTypeBasics");
            AlterColumn("dbo.MembershipTypeBasics", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MembershipTypeBasics", "Id");
            AddForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypeBasics", "Id", cascadeDelete: true);
        }
    }
}
