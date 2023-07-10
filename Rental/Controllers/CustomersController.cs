using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Rental.Models;
using Rental.Models.Customer;
using Rental.Models.DataBase;
using Rental.Models.ViewModels;

namespace Rental.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _DbContext;
        private CustomerViewModel CustomerViewModel;

        public CustomersController()
        {
            _DbContext = new ApplicationDbContext();
            
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

        public ActionResult Index()
        {
            ///  /// /// ... 
            List<Customer> customers = _DbContext.Customers.ToList();
            List<MembershipType> types = _DbContext.MembershipType.ToList();
            
            CustomerViewModel = new CustomerViewModel();
            CustomerViewModel.Customers = customers;
            CustomerViewModel.MembershipType = types;


            return View(CustomerViewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _DbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
       
    }
}