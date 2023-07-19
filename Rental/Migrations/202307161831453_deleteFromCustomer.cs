namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteFromCustomer : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "MembershipTypezId", newName: "MembershipTypeId");
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipTypezId", newName: "IX_MembershipTypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipTypeId", newName: "IX_MembershipTypezId");
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MembershipTypezId");
        }
    }
}
