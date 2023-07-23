using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rental.Models.Customer;

namespace Rental.Services.Validations.CustomDataAnnotationValidations
{
    public class PasswordValidation : ValidationAttribute
    {
        private const string SpecialCharacters = @"!@#$%^&*()-_=+[]{}|;:'""<>,.?/";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (string.IsNullOrEmpty(password))
            {
                return new ValidationResult("The password field is required.");
            }

            if (password.Length < 8)
            {
                return new ValidationResult("The password must be at least 8 characters long.");
            }

            if (!password.Any(char.IsDigit))
            {
                return new ValidationResult("The password must contain at least one number.");
            }

            if (!password.Any(char.IsUpper))
            {
                return new ValidationResult("The password must contain at least one capitalized alphabet.");
            }

            if (!password.Any(c => SpecialCharacters.Contains(c)))
            {
                return new ValidationResult("The password must contain at least one special character.");
            }

            return ValidationResult.Success;
        }
    }
}