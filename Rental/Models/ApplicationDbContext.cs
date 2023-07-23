using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        //public DbSet<RentableMovie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Specify that the Name, Email, and Password properties are required in the database
            modelBuilder.Entity<Customer.Customer>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Customer.Customer>()
                .Property(c => c.Email)
                .IsRequired();

            modelBuilder.Entity<Customer.Customer>()
                .Property(c => c.Password)
                .IsRequired();
        }

        public DbSet<DataBase.MembershipType> MembershipTypes { get; set; }  

        public DbSet<Movie.Movie> Movies { get; set; }


        

    }
}