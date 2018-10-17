using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.BusinessService.Entity.Account;
using ASTEK.Architecture.BusinessService.Validator;
using ASTEK.Architecture.Repository.Concrete;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Infrastructure.Validator;
using FluentValidation.Results;

namespace ASTEK.Architecture.BusinessServicesTest
{
    [TestClass]
    public class AccountBusinessTest
    {
        [TestMethod]
        public void Login()
        {
            var request = new LoginAccountRequest()
            {
                Email = "",
            };

            AccountBusinessService service = new AccountBusinessService();
            LoginAccountResponse response = service.Login(request);
            Console.WriteLine(response.Exception.Message);

            Assert.IsFalse(response.Success);
        }

        [TestMethod]
        public void SignUpSingleEmailValidator()
        {
            var account = new Domain.Entity.Account.Account()
            {
                ACCEMAIL = "jean@itu.local"
            };

            var context = new EFDbContext();
            var repository = new EFAccountRepository(context);

            SignUpAccountValidator validator = new SignUpAccountValidator(repository, account);
            ValidationResult result = validator.Validate();

            foreach(var message in result.Errors)
            {
                Console.WriteLine(message.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void AccountIsValid()
        {
            var account = new Domain.Entity.Account.Account()
            {
                ACCEMAIL = "aa",
                ACCPASSWORD = "hah aha"
            };

            try
            {
                AccountBusinessService service = new AccountBusinessService();
                service.ThrowExceptionIfIsInvalid(account, Infrastructure.Domain.ValidationType.All);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GetByEmail()
        {
            var request = new GetAccountByEmailRequest()
            {
                Email = "prof2@itu.local"
            };

            var service = new AccountBusinessService();
            var response = service.GetByEmail(request);

            Assert.AreEqual(new Guid("9eeedeac-91af-e811-8222-2c600c6934be"), response.Account.Id);
        }
    }
}
