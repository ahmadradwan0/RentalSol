using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models.Customer
{
    public class Customer : ICustomer
    { 
        public int Id { set; get; }
        public string Name {set; get; }
    }
}