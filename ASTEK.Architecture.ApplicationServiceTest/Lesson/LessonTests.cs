using System;
using System.Threading.Tasks;
using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.ApplicationServiceTest.Lesson
{
    [TestClass]
    public class LessonTests
    {
        [TestMethod]
        public void Create()
        {
            var input = new CreateLessonInputModel()
            {
                AccountId = new Guid("9eeedeac-91af-e811-8222-2c600c6934be"),
                Confidentiality = "7CCAF4E2-CF9E-E811-8220-2C600C6934BE",
                Title = "Comprendre le sens de la vie",
                Description = "Ce cours vous aidera à comprendre le sens de la vie et d'en percer ses mystères",
                Study = "DE237780-1DA1-E811-8221-2C600C6934BE",
                Targets = "Percer les mystères de la vie|Se sentir bien intérieurement"
            };

            var service = new LessonAppService();

            CreateLessonOutputModel output = service.Create(input);

            Console.WriteLine(output.Response.Exception);

            Assert.IsTrue(output.Response.Success);
        }

        [TestMethod]
        public void GetBestByStudy()
        {
            var input = new GetBestLessonByStudyInputModel()
            {
                StudyCode = "8CDE8A70-9B9C-E811-8220-2C600C6934BE",
                Page = 1,
                Count = 8,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var service = new LessonAppService();

            GetBestLessonByStudyOutputModel output = service.GetBestByStudy(input);

            Console.WriteLine(output.Response.Exception);

            Console.WriteLine(output.Response.Lessons.Count);
           

            Assert.IsTrue(output.Response.Success);
        }

        [TestMethod]
        public void GetMayLike()
        {
            var input = new GetLessonMayLikeInputModel
            {
                StudyCode = "F79B7A04-1EA1-E811-8221-2C600C6934BE",
                Level = 3,
                Page = 1,
                Count = 8,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var service = new LessonAppService();

            GetLessonMayLikeOutputModel output = service.GetMayLike(input);

            Assert.IsTrue(output.Response.Success);
        }

        [TestMethod]
        public async Task Search()
        {
            var input = new SearchLessonInputModel()
            {
                 Query = "a",
                 Page = 0,
                 Count = 8
            };

            var service = new LessonAppService();

            SearchLessonOutputModel output = await service.SearchAsync(input);

            output.Response.Lessons.ForEach(x =>
            {
                Console.WriteLine(x.LSNTITLE);
            });

            Assert.IsTrue(output.Response.Success);
        }

        [TestMethod]
        public void Update()
        {
            var input = new UpdateLessonInputModel()
            {
                LessonId = "07615C20-00BC-E811-8225-2C600C6934BE",
                Confidentiality = "7CCAF4E2-CF9E-E811-8220-2C600C6934BE",
                Description = "Modif description réussie!!!!",
                Study = "F79B7A04-1EA1-E811-8221-2C600C6934BE",
                Targets = "Modif target",
                Title = "Modif lesson réussie!!"
            };

            var service = new LessonAppService();
            var output = service.Update(input);

            Console.WriteLine(output.Response.Exception);

            if (output.Response.ValidationFailures != null)
            {
                output.Response.ValidationFailures.ForEach(x =>
                {
                    Console.WriteLine(x.PropertyName + " " + x.ErrorMessage);
                });
            }

            Assert.IsTrue(output.Response.Success);
        }
    }
}
