using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Rental.Models.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "Subscribed to Newsletter")]
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Active Plan")]
        public string MembershipName { set;get; }
    }
}