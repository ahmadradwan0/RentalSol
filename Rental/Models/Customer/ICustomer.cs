using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rental.Models.DataBase;

namespace Rental.Models.Customer
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }

        string Email { get; set; }

        bool IsSubscribedToNewsLetter { get; set; }

        string Password { get; set; }

        MembershipType MembershipType { get; set; }
    }
}
