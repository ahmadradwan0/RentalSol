using Rental.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Data.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}