using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Models.Movie;
using Rental.Models.Customer;

namespace Rental.Models.ViewModels
{
    public class RandomMovieViewModel
    {
        public RentableMovie movie { set; get; }

        public List<Models.Customer.Customer> Customers { get; set; }






    }
}