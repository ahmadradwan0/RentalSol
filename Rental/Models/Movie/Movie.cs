using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models.Movie
{

    public class Movie : IMovie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }


        public int Duration { get; set; }

        public double Rating { get; set; }
    }
}