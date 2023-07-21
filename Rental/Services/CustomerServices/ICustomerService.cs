using Rental.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Services.CustomerServices
{
    public interface ICustomerService
    {
        List<testCustomerViewModel> GetCustomerViewModelList();
        string GetMembershipNameForCustomer(int customerId);
    }
}