using System;
using ASTEK.Architecture.ApplicationService.Entity.AccountStudent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.ApplicationServiceTest.AccountStudent
{
    [TestClass]
    public class AccountStudentTests
    {
        [TestMethod]
        public void Update()
        {
            var input = new UpdateAccountStudentInputModel()
            {
                AccountId = "E8BC0C1E-BB9F-E811-8220-2C600C6934BE",
                Name = "Paul",
                FirstName = "Georges",
                Gender = "234EEDBD-CC9B-E811-8220-2C600C6934BE",
                Country = "A7E8FAC3-9F91-E811-821F-2C600C6934BE",
                BirthDay = new DateTime(1990, 02, 05)
            };

            var service = new AccountStudentAppService();
            var output = service.Update(input);

            Console.WriteLine(output.Response.Exception);

            if(output.Response.ValidatorErrors != null)
            {
                output.Response.ValidatorErrors.ForEach(x =>
                {
                    Console.WriteLine(x.PropertyName + " " + x.ErrorMessage);
                });
            }
            
            Assert.IsTrue(output.Response.Success);
        }
    }
}
