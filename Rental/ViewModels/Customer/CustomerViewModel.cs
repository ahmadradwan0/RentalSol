using System.ComponentModel.DataAnnotations;
using Rental.Models.Customer;
using Rental.Models.DataBase;
using Rental.Services.Validations.CustomDataAnnotationValidations;

namespace Rental.Models.ViewModels.Customer
{
    public class CustomerViewModel : ICustomer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Required Field")]
        [MaxLength(59, ErrorMessage = "Too Long ... (less than 60 letters)")]
        [Display(Name = "Full Name")]
        public string Name {get;set;}

        [Required(ErrorMessage = "* Required Field")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email {get;set;}

        
        [Display(Name = "Active Plan")]
        public bool IsSubscribedToNewsLetter {get;set;}

        [PasswordValidation]
        public string Password { get; set; }
        public MembershipType MembershipType {get;set;}

        [Required(ErrorMessage = "* Required Field")]
        [Display(Name = "Membership Type")]
        public byte SelectedMembershipTypeId { get; set; }
    }
}