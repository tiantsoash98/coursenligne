using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Repository.Concrete;
using ASTEK.Architecture.Repository;

namespace ASTEK.Architecture.TestUnit
{
    [TestClass]
    public class DomainTest
    {
        [TestMethod]
        public void AccountTest()
        {
            Account account = new Account()
            {
                CTRCODE = 1,
                ATPCODE = 1,
                ACCEMAIL = "jean@itu.local",
                ACCPASSWORD = "jeanjean",
                ACCPHONECONTACT = "0333333333",
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            EFDbContext ctx = new EFDbContext();
            EFAccountRepository rep = new EFAccountRepository(ctx);
            rep.Save(account);

            Assert.AreEqual(account.ACCID, 1);
        }
    }
}
