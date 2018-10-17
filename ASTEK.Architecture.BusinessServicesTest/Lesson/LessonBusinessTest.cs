using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.BusinessService.Entity.Lesson;

namespace ASTEK.Architecture.BusinessServicesTest.Lesson
{
    [TestClass]
    public class LessonBusinessTest
    {
        [TestMethod]
        public void GetMayLike()
        {
            var businessService = new LessonBusinessService();
            GetLessonMayLikeResponse response = businessService.GetMayLike(new GetLessonMayLikeRequest());

            Assert.AreEqual(2, response.Lessons.Count);
        }

        [TestMethod]
        public void GetChapterCount()
        {
            var request = new GetLessonChapterCountRequest()
            {
                LessonId = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE")
            };

            var businessService = new LessonBusinessService();
            GetLessonChapterCountResponse response = businessService.GetChapterCount(request);

            Assert.AreEqual(0, response.Count);
        }

        [TestMethod]
        public void GetExcerciceCount()
        {
            var request = new GetLessonExerciceCountRequest()
            {
                LessonId = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE")
            };

            var businessService = new LessonBusinessService();
            GetLessonExerciceCountResponse response = businessService.GetExerciceCount(request);

            Assert.AreEqual(0, response.Count);
        }

        [TestMethod]
        public void GetNextStep()
        {
            var reqNav = new GetLessonNavigationRequest()
            {
                LessonId = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE")
            };

            var businessService = new LessonBusinessService();

            GetLessonNavigationResponse resNav = businessService.GetNavigation(reqNav);

            var request = new GetLessonNextStepRequest()
            {
                Navigation = resNav.Navigation,
                CurrentChapter = 2,
                CurrentPart = 1,
                LessonId = "7CCE715F - F7A1 - E811 - 8221 - 2C600C6934BE"
            };

            GetLessonNextStepResponse response = businessService.GetNextStep(request);

            Console.WriteLine(response.Exist);
            Console.WriteLine(response.Type + " " + response.NextChapterNumber + " " + response.NextPartNumber);
        }

        [TestMethod]
        public void Create()
        {
            var request = new CreateLessonRequest()
            {
                AccountId = new Guid("9AB7771D-F69F-E811-8220-2C600C6934BE"),
                Title = "Le marketing international",
                Study = new Guid("E97DC2F7-9B9C-E811-8220-2C600C6934BE"), // MARKETING
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt

                                ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet,
                consectetur

                                Ut enim ad minim veniam",
                Target = "Comprendre ce qu'est le marketing visuel|Apprehender sa place dans la société actuelle",
                Confidentiality = new Guid("7CCAF4E2-CF9E-E811-8220-2C600C6934BE")
            };

            var businessService = new LessonBusinessService();
            var response = businessService.Create(request);

            Console.WriteLine(response.Exception);

            response.ValidationErrors.ForEach(x =>
            {
                Console.WriteLine(x.PropertyName + ": " + x.ErrorMessage);
            });

            Assert.IsTrue(response.Success);
        }

        [TestMethod]
        public void CreateWithInvalidValues()
        {
            var request = new CreateLessonRequest()
            {
                AccountId = new Guid("9AB7771D-F69F-E811-8220-2C600C6934BE"),
                Title = "abc",
                Study = new Guid("E97DC2F7-9B9C-E811-8220-2C600C6934BE"), // MARKETING
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt

                                ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet,
                consectetur

                                Ut enim ad minim veniam",
                Target = "Comprendre ce qu'est le marketing visuel|Apprehender sa place dans la société actuelle",
                Confidentiality = new Guid("7CCAF4E2-CF9E-E811-8220-2C600C6934BE")
            };

            var businessService = new LessonBusinessService();
            var response = businessService.Create(request);

            Console.WriteLine(response.Exception);

            response.ValidationErrors.ForEach(x =>
            {
                Console.WriteLine(x.PropertyName + ": " + x.ErrorMessage);
            });

            Assert.IsFalse(response.Success);
        }

        [TestMethod]
        public void Update()
        {
            var request = new UpdateLessonImageRequest()
            {
                LessonId = new Guid("E8A172B7-37B1-E811-8222-2C600C6934BE"),
                ImageName = null
            };

            var businessService = new LessonBusinessService();
            var response = businessService.UpdateImage(request);

            Assert.IsTrue(response.Success);
        }

        [TestMethod]
        public void IsLastPart()
        {
            var request = new IsLessonLastPartRequest()
            {
                LessonId = new Guid("A2F9BC01-CAB1-E811-8222-2C600C6934BE"),
                ChapterNumber = 2,
                PartNumber = 1
            };

            var businessService = new LessonBusinessService();
            var response = businessService.IsLastPart(request);

            Assert.IsTrue(response.IsLastPart);
        }
    }
}
