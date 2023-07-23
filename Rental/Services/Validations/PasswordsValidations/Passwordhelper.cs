using Rental.Services.Encryptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Services.Validations.PasswordsValidations
{
    public class PasswordHelper : IPasswordHelper
    {
        public string EncryptPassword(string password)
        {
            return Encryptor.HashPasswordSHA1(password);
        }

        public bool VerifyPassword(string storedHashedPassword, string passwordToCheck)
        {
            return storedHashedPassword == Encryptor.HashPasswordSHA1(passwordToCheck) ? true : false;
        }
    }
}