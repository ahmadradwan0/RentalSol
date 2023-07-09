﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Rental.Models.DataBase;

[assembly: InternalsVisibleTo("ApplicationDbContext")]
namespace Rental.Models.Customer
{
    public class MovieRentalCustomer : ICustomer
    { 
        public int Id { set; get; }
        public string Name {set; get; }

        public string Email { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //IMembershipType ICustomer.MembershipType { get ; set; }

        [NotMapped]
        public IMembershipType MembershipType { get; set; }

        public MembershipTypeBasic MembershipTypez
        {
            get;
            set;
        }
        //Get the foriegn Key .. 

        public byte MembershipTypezId { get; set; }
    }
}