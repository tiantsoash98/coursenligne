using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class NumberUtilitiesTest
    {
        [TestMethod]
        public void ToRoman()
        {
            int number = 1;

            Console.WriteLine(NumberUtilities.ToRoman(number));
        }

        [TestMethod]
        public void Format()
        {
            int number = 1;

            Console.WriteLine(NumberUtilities.Format(number, 2));
        }
    }
}
