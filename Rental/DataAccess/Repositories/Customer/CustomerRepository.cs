using Rental.Models.Customer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Rental.Models;

namespace Rental.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _dbContext;
        public CustomerRepository(ApplicationDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        void ICustomerRepository.AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        void ICustomerRepository.DeleteCustomer(int id)
        {
            var customerToBeDeleted = _dbContext.Customers.Find(id);
            _dbContext.Customers.Remove(customerToBeDeleted);
            _dbContext.SaveChanges();
        }

        List<Customer> ICustomerRepository.GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        Customer ICustomerRepository.GetCustomerById(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        void ICustomerRepository.UpdateCustomer(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}