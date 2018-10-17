using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using ASTEK.Architecture.Infrastructure.Specification;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ASTEK.Architecture.Infrastructure.Domain;

namespace ASTEK.Architecture.RepositoryTest.Account
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void Insert()
        {
            var account = new Domain.Entity.Account.Account()
            {
                CTRCODE = new Guid("A7E8FAC3-9F91-E811-821F-2C600C6934BE"),
                ATPCODE = new Guid("09EE69AF-A191-E811-821F-2C600C6934BE"),
                ACCEMAIL = "user2@itu.local",
                ACCPASSWORD = "testmdp",
                ACCPHONECONTACT = "0333333333",
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            EFDbContext context = new EFDbContext();
            EFAccountRepository rep = new EFAccountRepository(context);
            rep.Add(account);

            Assert.AreEqual("user2@itu.local", account.ACCEMAIL);
        }

        [TestMethod]
        public void AccountFindBy()
        {
            Expression<Func<Domain.Entity.Account.Account, bool>> expression = e => e.ACCEMAIL.Equals("jean@itu.local");
            Specification<Domain.Entity.Account.Account> spec = new Specification<Domain.Entity.Account.Account>(expression);

            EFDbContext context = new EFDbContext();
            EFAccountRepository rep = new EFAccountRepository(context);
            IEnumerable<Domain.Entity.Account.Account> enumerable = rep.FindBy(spec);
            var list = new List<Domain.Entity.Account.Account>();

            foreach (var item in enumerable)
            {
                list.Add(item);
            }

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void FindByWithCountryName()
        {
            Expression<Func<Domain.Entity.Account.Account, bool>> expression = e => e.ACCEMAIL.Equals("etudiant1@itu.local");
            Specification<Domain.Entity.Account.Account> spec = new Specification<Domain.Entity.Account.Account>(expression);

            EFDbContext context = new EFDbContext();
            EFAccountRepository rep = new EFAccountRepository(context);
            IEnumerable<Domain.Entity.Account.Account> enumerable = rep.FindBy(spec);
            var list = new List<Domain.Entity.Account.Account>();

            foreach (var item in enumerable)
            {
                list.Add(item);
            }

            Console.WriteLine(list[0].Country.CTRNAME);

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void InsertWithStudentInfo()
        {
            EFDbContext context = new EFDbContext();
            EFAccountRepository rep = new EFAccountRepository(context);

            var accountNew = new Domain.Entity.Account.Account()
            {
                CTRCODE = new Guid("a8e8fac3-9f91-e811-821f-2c600c6934be"),
                ATPCODE = new Guid("09EE69AF-A191-E811-821F-2C600C6934BE"),
                ACCEMAIL = "soa@itu.local",
                ACCPASSWORD = "soasoasoa",
                ACCPHONECONTACT = "03444444",
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            var accountStudent = new Domain.Entity.AccountStudent.AccountStudent()
            {
                ACSBIRTHDAY = DateTime.Now.AddYears(-20),
                ACSFIRSTNAME = "Soa",
                ACSNAME = "Rabe",
                GENCODE = new Guid("244EEDBD-CC9B-E811-8220-2C600C6934BE")
            };

            accountNew.AccountStudents.Add(accountStudent);
            rep.Add(accountNew);
        }

        [TestMethod]
        public void InsertWithTeacherInfo()
        {
            EFDbContext context = new EFDbContext();
            EFAccountRepository rep = new EFAccountRepository(context);

            var accountNew = new Domain.Entity.Account.Account()
            {
                CTRCODE = new Guid("a8e8fac3-9f91-e811-821f-2c600c6934be"),
                ATPCODE = new Guid("4650653e-e49a-e811-821f-2c600c6934be"),
                ACCEMAIL = "prof1@itu.local",
                ACCPASSWORD = "profprof",
                ACCPHONECONTACT = "0322222222",
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            var accountTeacher = new Domain.Entity.AccountTeacher.AccountTeacher()
            {
                ACTADDRESS = "Chez le prof",
                ACTBIRTHDAY = DateTime.Now.AddYears(-45),
                ACTFIRSTNAME = "Prof", 
                ACTNAME = "Sympa",
                GENCODE = new Guid("234EEDBD-CC9B-E811-8220-2C600C6934BE"),
                ACTPOSTALCODE = "101",
                ACTTOWN = "Madagascar"
            };

            accountNew.AccountTeachers.Add(accountTeacher);
            rep.Add(accountNew);
        }

        [TestMethod]
        public void EagerLoading()
        {
            var context = new EFDbContext();

            var account = new EFAccountRepository(context).FindBy(new Guid("e8bc0c1e-bb9f-e811-8220-2c600c6934be"));

            Console.WriteLine(account.Id + " " + account.ACCEMAIL);
            Console.WriteLine(account.AccountStudents.Count);

            Console.WriteLine(account.AccountStudents.ElementAt(0).ACSFIRSTNAME);
        }

        [TestMethod]
        public void FindByEmail()
        {
            var context = new EFDbContext();

            var account = new EFAccountRepository(context).FindByEmail("prof2@itu.local");

            Assert.AreEqual(new Guid("9eeedeac-91af-e811-8222-2c600c6934be"), account.Id);
        }
    }
}
