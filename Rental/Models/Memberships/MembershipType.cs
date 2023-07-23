using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rental.Models.Customer;

namespace Rental.Models.DataBase
{

    public class MembershipType : IMembershipType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        public string SubscribtionName { get; set; }

        public int Price { get; set; }
    }

 

}