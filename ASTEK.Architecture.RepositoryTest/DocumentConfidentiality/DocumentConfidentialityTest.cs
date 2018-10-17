using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.RepositoryTest.DocumentConfidentiality
{
    [TestClass]
    public class DocumentConfidentialityTest
    {
        [TestMethod]
        public void FindAll()
        {
            EFDbContext context = new EFDbContext();
            var rep = new EFDocumentConfidentialityRepository(context);
            IEnumerable<Domain.Entity.DocumentConfidentiality.DocumentConfidentiality> enumerable = rep.FindAll();

            Assert.AreEqual(0, enumerable.Count());
        }

        [TestMethod]
        public void Insert()
        {
            var doc = new Domain.Entity.DocumentConfidentiality.DocumentConfidentiality
            {
                DCFWORDING = "PUBLIC"
            };

            EFDbContext context = new EFDbContext();
            var rep = new EFDocumentConfidentialityRepository(context);
            rep.Add(doc);
        }
    }
}
