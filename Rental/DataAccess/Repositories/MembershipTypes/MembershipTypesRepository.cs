using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Models;
using Rental.Models.Customer;
using Rental.Models.DataBase;


namespace Rental.DataAccess.Repositories.MembershipTypes
{
    public class MembershipTypesRepository : IMembershipTypesRepository
    {
        private readonly ApplicationDbContext _dbContext; 

        public MembershipTypesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<MembershipType> GetAllMembershipTypes()
        {
            return _dbContext.MembershipTypes.ToList();
        }

        public string GetMemberShipNameToSpecificCustomerById(int customerId)
        {
            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == customerId);
            return _dbContext.MembershipTypes.SingleOrDefault(M => M.Id == customer.MembershipTypeId).SubscribtionName.ToString();
        }
    }
}