using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Infrastructure.Domain;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class StringUtilitiesTest
    {
        [TestMethod]
        public void EnumToString()
        {
            var toString = UserRole.Admin.ToString();
            Console.WriteLine(toString.ToUpper());
        }
    }
}
