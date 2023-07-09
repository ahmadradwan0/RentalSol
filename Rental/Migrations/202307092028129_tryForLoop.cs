namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryForLoop : DbMigration
    {
        public override void Up()
        {
            for (int i = 10; i < 20; i++)
            {
                Sql($"INSERT INTO MembershipTypeBasics (Id,SignUpFee, DurationInMonths, DiscountRate,TotalMoviesAllowed) VALUES ({i},{i},{i},{i},{i})");
            }
        }
        
        public override void Down()
        {
        }
    }
}
