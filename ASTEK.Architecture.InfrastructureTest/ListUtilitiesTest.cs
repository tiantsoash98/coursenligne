using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class ListUtilitiesTest
    {
        [TestMethod]
        public void GetTotalPagesCount()
        {
            int listCount = 0;
            int pageSize = 20;

            int total = Infrastructure.Utility.ListUtilities.GetTotalPagesCount(listCount, pageSize);

            Assert.AreEqual(1, total);
        }
    }
}
