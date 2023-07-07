using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models.Movie
{

    // TO BE edited ADD INTERFACE 
    public class BlueRayMovie : IRentableMovie
    {
        public int Duration { get; set; }
        public double Rating {get;set;}
        public int ID {get;set;}
        public string Title {get;set;}
        public  string Description {get;set;}
        public DateTime BorrowingDate {get;set;}
        public int BorrowerID {get;set;}
    }
}