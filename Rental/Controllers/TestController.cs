﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental.Models.Customer;
using Rental.Models.Movie;
using Rental.Models.ViewModels;

namespace Rental.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [Route("movie/random")]
        public ActionResult Random()
        {

            var moviez = new BlueRayMovie() { ID = 1, Title = "Zombieees" };
            var customers = new List<MovieRentalCustomer>()
            {
                new MovieRentalCustomer { Id = 1111, Name = "Ahmad" },
                new MovieRentalCustomer { Id = 1112, Name = "Sami" },
                new MovieRentalCustomer { Id = 1113, Name = "kal" ,Email = "ahmad@yahoo.com", IsSubscribedToNewsLetter = true,
                    MembershipType = new MovieRentalCustomerMembeshipType(){DiscountRate = 5,DurationInMonths = 6,Id = 1,SignUpFee = 10}},
                
            };

            // Now we Create a view model Object ... to Pass it ... 
            var ViewModelObject = new RandomMovieViewModel { Customers = customers, movie = moviez };

            return View(ViewModelObject);
        }
    }
}