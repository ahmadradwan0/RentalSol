using System;

namespace Rental.Models
{
    public interface IRentable
    {
        DateTime BorrowingDate { get; set; }

        int BorrowerID { get; set; }


    }
}