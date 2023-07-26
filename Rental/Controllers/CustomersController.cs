using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using Rental.Models.ViewModels.Customer;
using Rental.Services.CustomerServices;
using Rental.Services.Validations.PasswordsValidations;
using Rental.Validations.CustomersValidations;

namespace Rental.Controllers
{
    public class CustomersController : Controller
    {
        //. . . . . 
        private ApplicationDbContext _DbContext;

        private ICustomerService _customerService; 
        private ICustomerRepository _CustomerRepository;
        private IMembershipTypesRepository _MembershipTypesRepository;
        private ICustomerValidationService _customerValidationService;
        private IPasswordHelper _passwordHelper;

        private CustomerMembershipTypeViewModel _CustomerViewModel;
        //private NewCustomerViewModel _NewCustomerViewModel;



        public CustomersController(ApplicationDbContext dbcontext, 
            ICustomerRepository customerRepository,
            IMembershipTypesRepository membershipTypeRepository,
            ICustomerValidationService customerValidationService,
            ICustomerService customerService,
            IPasswordHelper passwordHelper
            )
        {
            _DbContext = dbcontext;
            _CustomerRepository = customerRepository;
            _MembershipTypesRepository = membershipTypeRepository;
            _customerValidationService = customerValidationService;
            _customerService = customerService;
            _passwordHelper = passwordHelper;
            _CustomerViewModel = new CustomerMembershipTypeViewModel();
            
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
        //Fix this and to customer view models 
        public ActionResult AllCustomers()
        {

            //Better Solution ....
            _CustomerViewModel.Customers = _customerService.GetCustomerViewModelList();
            

            return View(_CustomerViewModel);
        }

        [HttpGet]
        public ActionResult RegisterCustomerForm()
        {


            //By creating a new instance of NewCustomerViewModel inside the RegisterCustomerForm action, you ensure that each request to the form gets its own unique instance of the view model ... 
            var _NewCustomerViewModel = new NewCustomerViewModel
            {
                MembershipTypes = _MembershipTypesRepository.GetAllMembershipTypes()
            };
            return View(_NewCustomerViewModel);
        }


        //[ValidateAntiForgeryToken] is to validate the token in the form inside the view ...
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterCustomer(NewCustomerViewModel _newCustomerView)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = _newCustomerView;
                //viewmodel.Customer = _newCustomerView.Customer;
                viewmodel.MembershipTypes = _MembershipTypesRepository.GetAllMembershipTypes();
                
                return View("RegisterCustomerForm", viewmodel);
            }

            var customer = _newCustomerView.Customer;
            var selectedMembership = _newCustomerView.Customer.SelectedMembershipTypeId;
           
            _CustomerRepository.AddCustomer(new Customer
            {
                Email = customer.Email,
                Name = customer.Name,
                IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter,
                Password = customer.Password,
                MembershipTypeId = customer.SelectedMembershipTypeId,

                
        });

            return RedirectToAction("AllCustomers");
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