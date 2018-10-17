using System;
using ASTEK.Architecture.Infrastructure.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void DateToLong()
        {
            var date = new TimeSpan(0, 30, 0);
            long toLong = date.Ticks;

            Console.WriteLine(toLong);
        }

        [TestMethod]
        public void LongToDate()
        {
            long duration = 90000000000;

            var timeSpan = new TimeSpan(duration);

            Assert.AreEqual(2, timeSpan.Hours);
        }

        [TestMethod]
        public void TimeSpan()
        {
            var timeSpan = new TimeSpan(0, -5, -10);

            Console.WriteLine(timeSpan.Ticks);
        }

        [TestMethod]
        public void GetMonday()
        {
            DateTime monday = DateTimeUtilities.GetMondayOfWeekFrom(DateTime.Now);

            Console.WriteLine(monday.ToString("dd-MM-yyyy"));
        }

        [TestMethod]
        public void GetDate()
        {
            DateTime monday = DateTime.Now.Date;

            Console.WriteLine(monday.ToString("dd-MM-yyyy hh-mm-ss"));
        }
    }
}
