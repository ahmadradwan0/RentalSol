using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rental.Models.ViewModels
{
    public class MembershipTypeViewModel
    {
        public byte Id { get; set; }

        [Display(Name = "Plan Type Name")]
        public string SubscribtionName { get; set; }

        [Display(Name = "Fixed Price")]
        public int Price { get; set; }
    }
}