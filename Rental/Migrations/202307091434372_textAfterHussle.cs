namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class textAfterHussle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieRentalCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        IsSubscribedToNewsLetter = c.Boolean(nullable: false),
                        MembershipTypezId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypezId, cascadeDelete: true)
                .Index(t => t.MembershipTypezId);
            
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
            
            CreateTable(
                "dbo.BlueRayMovies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Duration = c.Int(nullable: false),
                        Rating = c.Double(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        BorrowingDate = c.DateTime(nullable: false),
                        BorrowerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieRentalCustomers", "MembershipTypezId", "dbo.MembershipTypes");
            DropIndex("dbo.MovieRentalCustomers", new[] { "MembershipTypezId" });
            DropTable("dbo.BlueRayMovies");
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.MovieRentalCustomers");
        }
    }
}
