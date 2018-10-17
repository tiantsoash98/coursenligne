using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.RepositoryTest.Country
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void CountryFindBy()
        {
            EFDbContext context = new EFDbContext();
            EFCountryRepository rep = new EFCountryRepository(context);
            IEnumerable<Domain.Entity.Country.Country> enumerable = rep.FindAll();
            var list = new List<Domain.Entity.Country.Country>();

            foreach (var item in enumerable)
            {
                list.Add(item);
            }

            Console.WriteLine(list[0].CTRNAME);
        }
    }
}
