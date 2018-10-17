using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.RepositoryTest.AccountStudent
{
    [TestClass]
    public class AccountStudentTest
    {
        [TestMethod]
        public void FindAll()
        {
            EFDbContext context = new EFDbContext();
            EFAccountStudentRepository rep = new EFAccountStudentRepository(context);

            Assert.AreEqual(1, rep.Count());
        }

        [TestMethod]
        public void Insert()
        {
            EFDbContext context = new EFDbContext();

            var accountStudent = new Domain.Entity.AccountStudent.AccountStudent()
            {
                ACCID = new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE"),
                ACSBIRTHDAY = DateTime.Now.AddYears(-20),
                ACSFIRSTNAME = "Etudiant",
                ACSNAME = "Premier",
                GENCODE = new Guid("234EEDBD-CC9B-E811-8220-2C600C6934BE")
            };

            var repAccStud = new EFAccountStudentRepository(context);
            repAccStud.Add(accountStudent);
        }

        [TestMethod]
        public void Update()
        {
            var account = new Domain.Entity.AccountStudent.AccountStudent
            {
                ACCID = new Guid("DAB3E636-90BE-E811-8225-2C600C6934BE"),
                ACSFIRSTNAME = "Sympa",
                ACSNAME = "Etudiante",
                ACSBIRTHDAY = new DateTime(1992, 02, 01),
                GENCODE = new Guid("244EEDBD-CC9B-E811-8220-2C600C6934BE"),
                Account = new Domain.Entity.Account.Account
                {
                    Id = new Guid("DAB3E636-90BE-E811-8225-2C600C6934BE"),
                    CTRCODE = new Guid("A7E8FAC3-9F91-E811-821F-2C600C6934BE"),
                    ACCPHONECONTACT = "+261 23 23 233 23"
                }
            };

            var context = new EFDbContext();
            var rep = new EFAccountStudentRepository(context);

            account = rep.UpdateInformations(account);

            Assert.AreEqual("Sympa", account.ACSFIRSTNAME);
        }
    }
}
