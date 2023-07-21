using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rental.Models.Customer;
using Rental.Models.DataBase;

namespace Rental.Models.ViewModels.Customer
{
    public class NewCustomerViewModel 
    {
        
        public CustomerViewModel Customer { get; set; }

        [Required]
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}