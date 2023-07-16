using Rental.Models.ViewModels;

namespace Rental.Validations.CustomersValidations
{
    public interface ICustomerValidationService
    {
        bool IsCustomerValid(CustomerViewModel customer);

        bool IsCustomerAuthorized(int customerId, string authUserId);
    }
}