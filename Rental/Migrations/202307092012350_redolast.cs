namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class redolast : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypeBasics",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        TotalMoviesAllowed = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.MovieRentalCustomers", "MembershipTypezId");
            AddForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypeBasics", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypeBasics");
            DropIndex("dbo.MovieRentalCustomers", new[] { "MembershipTypezId" });
            DropTable("dbo.MembershipTypeBasics");
        }
    }
}
