using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{

    // TO BE edited ADD INTERFACE 
    public class BlueRayMovie : IRentableMovie
    {
        int IMovie.Duration { get; set; }
        double IMovie.Rating {get;set;}
        int IItem.ID {get;set;}
        string IItem.Title {get;set;}
        string IItem.Description {get;set;}
        DateTime IRentable.BorrowingDate {get;set;}
        int IRentable.BorrowerID {get;set;}
    }
}