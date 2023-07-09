using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Rental.Models.Customer;
using Rental.Models.Movie;


namespace Rental.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public DbSet<Customer.Customer> Customers { get; set; }
        public DbSet<BlueRayMovie> Movies { get; set; }


    }
}