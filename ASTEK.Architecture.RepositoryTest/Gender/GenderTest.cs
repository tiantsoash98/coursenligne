using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.Gender
{
    [TestClass]
    public class GenderTest
    {
        [TestMethod]
        public void FindAllWithCulture()
        {
            var context = new EFDbContext();
            var rep = new EFGenderRepository(context);

            var list = rep.FindAll();

            foreach (var item in list)
            {
                Console.WriteLine(item.GENCODE + " " + item.GENWORDING);

                foreach(var strings in item.EntityStrings)
                {
                    Console.WriteLine("\t" + strings.CLTCODE + ": " + strings.ESTWORDING);
                }
            }
        }
    }
}
