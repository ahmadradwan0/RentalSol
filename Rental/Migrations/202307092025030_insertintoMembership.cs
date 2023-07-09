namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertintoMembership : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypeBasics (Id,SignUpFee, DurationInMonths, DiscountRate,TotalMoviesAllowed) VALUES (2,0,0,0,5)");
            Sql("INSERT INTO MembershipTypeBasics (Id,SignUpFee, DurationInMonths, DiscountRate,TotalMoviesAllowed) VALUES (3,5,4,7,5)");
            Sql("INSERT INTO MembershipTypeBasics (Id,SignUpFee, DurationInMonths, DiscountRate,TotalMoviesAllowed) VALUES (4,12,1,20,5)");
            Sql("INSERT INTO MembershipTypeBasics (Id,SignUpFee, DurationInMonths, DiscountRate,TotalMoviesAllowed) VALUES (5,5,8,9,5)");
            Sql("INSERT INTO MembershipTypeBasics (Id,SignUpFee, DurationInMonths, DiscountRate,TotalMoviesAllowed) VALUES (6,5,4,8,15)");

            
        }
        
        public override void Down()
        {
        }
    }
}
