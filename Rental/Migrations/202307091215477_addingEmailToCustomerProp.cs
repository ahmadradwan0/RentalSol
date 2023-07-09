﻿namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingEmailToCustomerProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Email");
        }
    }
}