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
using Rental.Models.ViewModels.Customer;
using Rental.Services.CustomerServices;
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

        private CustomerMembershipTypeViewModel _CustomerViewModel;
        //private NewCustomerViewModel _NewCustomerViewModel;



        public CustomersController(ApplicationDbContext dbcontext, 
            ICustomerRepository customerRepository,
            IMembershipTypesRepository membershipTypeRepository,
            ICustomerValidationService customerValidationService,
            ICustomerService customerService
            )
        {
            _DbContext = dbcontext;
            _CustomerRepository = customerRepository;
            _MembershipTypesRepository = membershipTypeRepository;
            _customerValidationService = customerValidationService;
            _customerService = customerService;
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

        public ActionResult AllCustomers()
        {
            ///  /// /// ... 
            //List<Customer> customers = _CustomerRepository.GetAllCustomers();

            //List<MembershipType> types = _MembershipTypesRepository.GetAllMembershipTypes();



            
            // Feeding The ViewModel 
            //_CustomerViewModel.Customers = customers.Select(c => new CustomerViewModel
            //{
            //    Id = c.Id,
            //    Name = c.Name,
            //    Email = c.Email,
            //    IsSubscribedToNewsletter = c.IsSubscribedToNewsLetter,
            //    MembershipName = _MembershipTypesRepository.GetMemberShipNameToSpecificCustomerById(c)
            //}).ToList();    

            //_CustomerViewModel.MembershipTypes = types.Select(t => new MembershipTypeViewModel
            //{
            //    Id = t.Id,
            //    SubscribtionName = t.SubscribtionName,
            //    Price = t.Price
            //}).ToList();


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

        [HttpPost]
        public ActionResult RegisterCustomer(NewCustomerViewModel _newCustomerView)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = _newCustomerView;
                //viewmodel.Customer = _newCustomerView.Customer;
                viewmodel.MembershipTypes = _MembershipTypesRepository.GetAllMembershipTypes();
                
                return View("RegisterCustomerForm", viewmodel);
            }



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