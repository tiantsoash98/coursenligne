using System;
using System.Linq.Expressions;
using ASTEK.Architecture.BusinessService.Entity.LessonFollowed;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.BusinessServicesTest.LessonFollowed
{
    [TestClass]
    public class LessonFollowedTests
    {
        [TestMethod]
        public void FinishPart()
        {
            var accountId = new Guid("0BA7A6DA-76BD-E811-8224-2C600C6934BE");
            var lessonId = new Guid("A2F9BC01-CAB1-E811-8222-2C600C6934BE");

            var request = new FinishPartRequest()
            {
                AccountId = accountId,
                LessonId = lessonId,
                ChapterNumber = 3,
                PartNumber = 2
            };

            var businessService = new LessonFollowedBusinessService();
            var response = businessService.FinishPart(request);

            Console.WriteLine(response.Exception);

            Assert.IsTrue(response.Success);
        }
    }
}
