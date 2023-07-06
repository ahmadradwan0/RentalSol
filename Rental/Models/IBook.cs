using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Models
{
    internal interface IBook : IItem
    {
        /*
        int ID { get; set; }

        string Title { get; set; }

        string Description { get; set; }
        */

        // Its own ...
        int pages { get; set; }

        string Auther { get; set; }

    }
}
