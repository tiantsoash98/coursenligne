using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class LessonUtilitiesTest
    {
        [TestMethod]
        public void HasIndex()
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(10);
            list.Add(23);
            list.Add(17);

            Assert.IsTrue(ListUtilities.HasIndex(3, list));
        }
    }
}
