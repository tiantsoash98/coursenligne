using System;
using ASTEK.Architecture.ApplicationService.Entity.LessonPart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.ApplicationServiceTest.LessonPart
{
    [TestClass]
    public class LessonPartTests
    {
        [TestMethod]
        public void Create()
        {
            var input = new CreateLessonPartInputModel()
            {
                ChapterCode = new Guid("28095A63-7EBA-E811-8225-2C600C6934BE"),
                Title = "Test 2",
                Content = "<p style=\"margin - left:0cm; margin - right:0cm; text - align:justify\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis interdum, odio a consectetur lacinia, sem ante sagittis eros, sed fermentum risus ligula vel quam. Etiam ex mauris, faucibus a posuere sed, vulputate eget lectus. Sed sed felis dolor. Proin at fringilla nunc. Quisque scelerisque orci ut nulla vestibulum, eget accumsan est venenatis. Cras consectetur neque gravida venenatis malesuada. Nulla vitae sapien eu ligula ultricies gravida. Vestibulum eu vulputate erat. Praesent mi justo, scelerisque vel dictum at, bibendum vestibulum lorem. Proin scelerisque nunc dolor, sit amet placerat libero euismod a. Ut non nibh ac nunc tincidunt pellentesque. Curabitur non mi arcu.</p>"
            };

            var service = new LessonPartAppService();

            CreateLessonPartOutputModel output = service.Create(input);

            Console.WriteLine(output.Response.Exception);

            var validators = output.Response.ValidationErrors;

            validators.ForEach(x =>
            {
                Console.WriteLine(x.PropertyName + " " + x.ErrorMessage);
            });

            Assert.IsTrue(output.Response.Success);
        }
    }
}
