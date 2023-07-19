using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Rental.Models.DataBase;

[assembly: InternalsVisibleTo("ApplicationDbContext")]
namespace Rental.Models.Customer
{
    public class Customer : ICustomer
    { 
        public int Id { set; get; }
        public string Name {set; get; }

        public string Email { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //IMembershipType ICustomer.MembershipTypes { get ; set; }
        // . . dot 


        public MembershipType MembershipType { get; set; }

        
        //Used To add a foreign key from MemberShipType Table ... 
        public byte MembershipTypeId { get; set; }
        
    }
}