namespace Rental.Services.Validations.PasswordsValidations
{
    public interface IPasswordHelper
    {
        string EncryptPassword(string password);

        bool VerifyPassword(string storedHashedPassword, string passwordToCheck);
    }
}