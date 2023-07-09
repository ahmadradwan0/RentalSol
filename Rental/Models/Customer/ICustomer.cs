using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Models.Customer
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }

        string Email { get; set; }

        bool IsSubscribedToNewsLetter { get; set; }

        IMembershipType MembershipType { get; set; }
    }
}
