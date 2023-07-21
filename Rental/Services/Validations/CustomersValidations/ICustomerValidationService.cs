using Rental.Models.ViewModels;

namespace Rental.Validations.CustomersValidations
{
    public interface ICustomerValidationService
    {
        bool IsCustomerValid(testCustomerViewModel customer);

        bool IsCustomerAuthorized(int customerId, string authUserId);
    }
}