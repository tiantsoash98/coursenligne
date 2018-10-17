using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.AccountTeacher
{
    [TestClass]
    public class AccountTeacherTest
    {
        [TestMethod]
        public void Insert()
        {
            EFDbContext context = new EFDbContext();

            var accountTeacher = new Domain.Entity.AccountTeacher.AccountTeacher()
            {
                ACCID = new Guid("BBF094E2-42B3-E811-8222-2C600C6934BE"),
                ACTBIRTHDAY = DateTime.Now.AddYears(-28).AddDays(14).AddMonths(1),
                ACTFIRSTNAME = "Jean",
                ACTNAME = "Maitre",
                GENCODE = new Guid("234EEDBD-CC9B-E811-8220-2C600C6934BE"),
                ACTTOWN = "Antananarivo",
                ACTPOSTALCODE = "102",
                ACTADDRESS = "Chez Jean"         
            };

            var repAccStud = new EFAccountTeacherRepository(context);
            repAccStud.Add(accountTeacher);
        }
    }
}
