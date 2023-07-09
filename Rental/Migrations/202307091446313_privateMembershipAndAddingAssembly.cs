namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class privateMembershipAndAddingAssembly : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypes");
            DropIndex("dbo.MovieRentalCustomers", new[] { "MembershipTypezId" });
            DropTable("dbo.MembershipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.MovieRentalCustomers", "MembershipTypezId");
            AddForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
