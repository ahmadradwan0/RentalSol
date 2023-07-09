using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Rental.Models.Customer
{
    public class IMembershipType
    {
        
        byte Id { get; set; }
        short SignUpFee { get; set; }
        byte DurationInMonths { get; set;}
        byte DiscountRate { get; set; }

    }
}