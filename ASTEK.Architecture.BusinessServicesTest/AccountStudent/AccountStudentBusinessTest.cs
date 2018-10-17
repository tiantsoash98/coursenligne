using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.BusinessService.Entity.AccountStudent;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessServicesTest.AccountStudent
{
    [TestClass]
    public class AccountStudentBusinessTest
    {
        [TestMethod]
        public void Create()
        {
            CreateAccountStudentRequest request = new CreateAccountStudentRequest
            {
                FirstName = "Paul02",
                Name = "Jea @n",
                BirthDay = DateTime.Now,
                Gender = new Guid("234EEDBD-CC9B-E811-8220-2C600C6934BE"),
                Email = "jeanpaul@itu.local",
                Password = "Jeanpaul8",
                ConfirmPassword = "Jeanpaul98"   
            };

            var service = new AccountStudentBusinessService();
            var response = service.Create(request);

            if (!response.Success)
            {
                List<ValidationFailure> errors = response.Errors;

                foreach (var error in errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }         

            Assert.IsFalse(response.Success);
        }
    }
}
