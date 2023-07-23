using Rental.Models.Customer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Rental.Models;
using Rental.Services.Encryptions;
using Rental.Services.Validations.PasswordsValidations;

namespace Rental.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _dbContext;
        private IPasswordHelper _passwordHelper;
        public CustomerRepository(ApplicationDbContext dbContext,IPasswordHelper passwordHelper)
        {
            _dbContext = dbContext;
            _passwordHelper = passwordHelper;

        }
        void ICustomerRepository.AddCustomer(Customer customer)
        {
            customer.Password = _passwordHelper.EncryptPassword(customer.Password);
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