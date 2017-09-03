﻿namespace BankSystemComplex.Data.Validators
{
    using Models;

    // Main class for validation on entity "CheckingAccount".
    public class CheckingAccountValidator
    {
        // Checks whether given account is valid on predefined requirements.
        public ValidationResult IsValid(CheckingAccount account)
        {
            ValidationResult result = new ValidationResult();

            if (account == null)
            {
                result.IsValid = false;
                result.ValidationErrors.Add("Account cant be null!");
                return result;
            }

            if (account.AccountNumber.Length != 10)
            {
                result.IsValid = false;
                result.ValidationErrors.Add("Account number length should be exactly 10 symbols!");
            }

            if (account.Balance < 0)
            {
                result.IsValid = false;
                result.ValidationErrors.Add("Account balance should be non-negative!");
            }

            if (account.Fee < 0)
            {
                result.IsValid = false;
                result.ValidationErrors.Add("Account fee should be non-negative!");
            }

            return result;
        }
    }
}