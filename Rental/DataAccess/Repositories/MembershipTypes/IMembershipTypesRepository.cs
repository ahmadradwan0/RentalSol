using Rental.Models.DataBase;
using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.DataAccess.Repositories.MembershipTypes
{
    public interface IMembershipTypesRepository
    {
        List<MembershipType> GetAllMembershipTypes();

    }
}
