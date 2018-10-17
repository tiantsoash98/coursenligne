using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.Culture
{
    [TestClass]
    public class CultureTest
    {
        [TestMethod]
        public void FindAll()
        {
            var context = new EFDbContext();
            var rep = new EFCultureRepository(context);

            var list = rep.FindAll();

            foreach(var item in list)
            {
                Console.WriteLine(item.CLTCODE + " " + item.CLTWORDING);
            }
        }
    }
}
