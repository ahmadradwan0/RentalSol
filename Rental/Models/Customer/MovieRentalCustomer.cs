using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models.Customer
{
    public class MovieRentalCustomer : ICustomer
    { 
        public int Id { set; get; }
        public string Name {set; get; }

        public string Email { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //IMembershipType ICustomer.MembershipType { get ; set; }

        public IMembershipType MembershipType { get; set; }

        //Get the foriegn Key .. 

        public byte MembershipTypeId { get; set; }
    }
}