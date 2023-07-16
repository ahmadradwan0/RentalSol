using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Models.Customer;
using Rental.Models.DataBase;

namespace Rental.Models.ViewModels
{
    public class CustomerMembershipTypeViewModel 
    {
        public List<CustomerViewModel> Customers { get; set; }


        public List<MembershipTypeViewModel> MembershipTypes { get; set; }



    }
}