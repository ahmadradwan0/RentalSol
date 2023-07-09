namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
            DropTable("dbo.BlueRayMovies");
            DropTable("dbo.Customers");
        }
    }
}
