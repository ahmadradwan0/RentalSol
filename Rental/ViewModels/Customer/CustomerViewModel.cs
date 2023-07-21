using System.ComponentModel.DataAnnotations;
using Rental.Models.Customer;
using Rental.Models.DataBase;

namespace Rental.Models.ViewModels.Customer
{
    public class CustomerViewModel : ICustomer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Required Field")]
        [MaxLength(59, ErrorMessage = "Too Long ... (less than 60 letters)")]
        [Display(Name = "Full Name")]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email {get;set;}

        [Required]
        [Display(Name = "Active Plan")]
        public bool IsSubscribedToNewsLetter {get;set;}

        [Required(ErrorMessage = "Membership Type is required")]
        public MembershipType MembershipType {get;set;}
    }
}