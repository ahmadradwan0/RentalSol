using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Data.Repositories;
using Rental.DataAccess.Repositories.MembershipTypes;
using Rental.Models.Customer;
using Rental.Models.ViewModels;

namespace Rental.Services.CustomerServices
{


    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        private IMembershipTypesRepository _membershipTypesRepository;

        public CustomerService(ICustomerRepository customerRepository, IMembershipTypesRepository membershipTypesRepository)
        {
            _customerRepository = customerRepository;
            _membershipTypesRepository = membershipTypesRepository;
        }

        public List<testCustomerViewModel> GetCustomerViewModelList()
        {
            var customerList = _customerRepository.GetAllCustomers();

            List<testCustomerViewModel> customerViewModels = customerList.Select(c => new testCustomerViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                IsSubscribedToNewsletter = c.IsSubscribedToNewsLetter,
                MembershipName = GetMembershipNameForCustomer(c.Id)
            }).ToList();

            return customerViewModels;
        }

        public string GetMembershipNameForCustomer(int customerId)
        {
            // Perform any business logic to determine the membership name for the customer
            // For example, retrieve the membership from the repository and return its name

            var membership = _membershipTypesRepository.GetMemberShipNameToSpecificCustomerById(customerId);
            return membership;
        }
    }


}