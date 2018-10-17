using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.ApplicationService.Entity.Account;

namespace ASTEK.Architecture.ApplicationServiceTest
{
    [TestClass]
    public class AccountAppTest
    {
        [TestMethod]
        public void LoginWithIncorrectValues()
        {
            var input = new LoginAccountInputModel()
            {
                Email = "jean@itu",
                Password = "jean jean"
            };

            var service = new AccountAppService();
            LoginAccountOutputModel output = service.Login(input);
            Console.WriteLine(output.Response.Exception);

            Assert.IsFalse(output.Response.Success);
        }
    }
}
