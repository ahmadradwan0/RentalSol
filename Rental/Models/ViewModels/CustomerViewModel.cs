using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Models.Customer;
using Rental.Models.DataBase;

namespace Rental.Models.ViewModels
{
    public class CustomerViewModel 
    {
        public List<Customer.Customer> Customers { get; set; }


        public List<MembershipType> MembershipType { get; set; }



    }
}