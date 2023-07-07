using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Models.Movie
{
    internal interface ISellableMovie : ISellable , IMovie
    {
    }
}
