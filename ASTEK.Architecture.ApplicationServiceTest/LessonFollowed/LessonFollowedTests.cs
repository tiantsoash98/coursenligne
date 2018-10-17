using System;
using ASTEK.Architecture.ApplicationService.Entity.LessonFollowed;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.ApplicationServiceTest.LessonFollowed
{
    [TestClass]
    public class LessonFollowedTests
    {
        [TestMethod]
        public void Follow()
        {
            var input = new FollowLessonInputModel()
            {
                AccountId = "BBF094E2-42B3-E811-8222-2C600C6934BE",
                LessonId = "A2F9BC01-CAB1-E811-8222-2C600C6934BE"
            };

            var service = new LessonFollowedAppService();

            FollowLessonOutputModel output = service.Follow(input);

            Console.WriteLine(output.Response.Exception);

            Assert.IsTrue(output.Response.Success);
        }

        [TestMethod]
        public void CountByLesson()
        {
            var input = new CountByLessonInputModel()
            {
                LessonId = "7CCE715F-F7A1-E811-8221-2C600C6934BE"
            };

            var service = new LessonFollowedAppService();

            CountByLessonOutputModel output = service.CountByLesson(input);

            Assert.AreEqual(2, output.Response.Count);
        }

         [TestMethod]
        public void FinishPart()
        {
            var service = new LessonFollowedAppService();

            var finishInputModel = new FinishPartInputModel()
            {
                AccountId = "E8BC0C1E-BB9F-E811-8220-2C600C6934BE",
                LessonId = "A2F9BC01-CAB1-E811-8222-2C600C6934BE",
                ChapterNumber = 2,
                PartNumber = 0
            };

            var finishOutput = service.FinishPart(finishInputModel);

            Console.WriteLine(finishOutput.Response.Exception);

            Assert.IsTrue(finishOutput.Response.Success);
        }
    }
}
