using Rental.Models;
using Rental.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Models.ViewModels;

namespace Rental.Validations.CustomersValidations
{
    public class CustomerValidationService : ICustomerValidationService
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerValidationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsCustomerValid(CustomerViewModel customer)
        {
            // Implement your validation logic here
            // Check if the customer data satisfies your validation rules
            // Return true if the customer is valid, false otherwise
            // Example validation: Ensure the customer's name is not empty
            return !string.IsNullOrEmpty(customer.Name);
        }

        public bool IsCustomerAuthorized(int customerId, string authUserId)
        {
            // Implement your authorization logic here
            // Check if the user with the given userId is authorized to access or modify the customer with the specified customerId
            // Return true if the user is authorized, false otherwise
            // Example authorization: Check if the user is the owner of the customer
            var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == customerId);
            return customer != null; //&& customer.UserId == userId;
        }
    }
}