﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Models
{
    internal interface ISellableMovie : ISellable , IMovie
    {
    }
}
