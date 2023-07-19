using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rental.Models.Customer;
using Rental.Models.DataBase;

namespace Rental.Models.ViewModels.Customer
{
    public class NewCustomerViewModel : ICustomer
    {
        int ICustomer.Id { get; set; }

        [Required]
        [MaxLength(59)]
        string ICustomer.Name {get;set;}

        [Required]
        [EmailAddress]
        string ICustomer.Email {get;set;}

        [Required]
        bool ICustomer.IsSubscribedToNewsLetter {get;set;}

        [Required]
        MembershipType ICustomer.MembershipType {get;set;}
    }
}