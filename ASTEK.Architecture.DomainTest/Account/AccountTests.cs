using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Domain.Entity.Account;
using ASTEK.Architecture.Domain.Validator;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.DomainTest.Account
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void GetValidator()
        {
            var account = new Domain.Entity.Account.Account()
            {
                ACCEMAIL = "jean@itu",
                ACCPASSWORD = "hahhaha"
            };

            AccountValidator validator = new AccountValidator(Infrastructure.Domain.ValidationType.Get);
            ValidationResult result = validator.Validate(account);
            IEnumerable<ValidationFailure> errors = result.Errors;

            foreach(var error in errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }
    }
}
