using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Rental.Data.Repositories;
using Rental.DataAccess.Repositories.MembershipTypes;
using Rental.Models;
using Rental.Models.Customer;
using Rental.Models.DataBase;
using Rental.Models.Movie;
using Rental.Models.ViewModels;
using Rental.Validations.CustomersValidations;

namespace Rental.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _DbContext;
        private ICustomerRepository _CustomerRepository;
        private IMembershipTypesRepository _MembershipTypesRepository;
        private ICustomerValidationService _customerValidationService;
        private CustomerMembershipTypeViewModel _CustomerViewModel;


        public CustomersController()
        {
            _DbContext = new ApplicationDbContext();
            _CustomerRepository = new CustomerRepository(_DbContext);
            _MembershipTypesRepository = new MembershipTypesRepository(_DbContext);
            _CustomerViewModel = new CustomerMembershipTypeViewModel();
            _customerValidationService = new CustomerValidationService(_DbContext);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _DbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: Customers  

        public ActionResult AllCustomers()
        {
            ///  /// /// ... 
            List<Customer> customers = _CustomerRepository.GetAllCustomers();

            List<MembershipType> types = _MembershipTypesRepository.GetAllMembershipTypes();




            // Feeding The ViewModel 
            _CustomerViewModel.Customers = customers.Select(c => new CustomerViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                IsSubscribedToNewsletter = c.IsSubscribedToNewsLetter
            }).ToList();    

            _CustomerViewModel.MembershipTypes = types.Select(t => new MembershipTypeViewModel
            {
                Id = t.Id,
                SubscribtionName = t.SubscribtionName,
                Price = t.Price
            }).ToList();


            return View(_CustomerViewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _DbContext.Customers.Add(customer);
            }
            else
            {
                var customerInDataBase = _DbContext.Customers.Single(c => c.Id == customer.Id);

                TryUpdateModel(customerInDataBase);
            }



            return View(_CustomerViewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _CustomerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
       
    }


  
}