using System;
using System.Data.Entity.Validation;
using ASTEK.Architecture.BusinessService.Entity.LessonChapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.BusinessServicesTest.LessonChapter
{
    [TestClass]
    public class LessonChapterBusinessTests
    {
        [TestMethod]
        public void Create()
        {
            var request = new CreateLessonChapterRequest()
            {
                LessonId = new Guid("D2A6D649-ABAF-E811-8222-2C600C6934BE"),
                Title = "Introduction",
                Content = "La conscience consiste dans la faculté qui me permet de prendre connaissance de mes actes, et en particulier de l'activité de mon esprit. Elle se définirait donc comme une forme de connaissance. C'est ce que semble confirmer l'étymologie: \"cum sciens signifie \"avec connaissance, accompagné de savoir. De même, les expressions \"perdre conscience\" ou \"perdre connaissance\", que l'on emploie indifféremment, témoignent d'une proximité entre conscience et connaissance.",
            };

            var businessService = new LessonChapterBusinessService();
            var response = businessService.Create(request);

            Assert.IsTrue(response.Success);
        }

        [TestMethod]
        public void CreateWithInvalidValues()
        {
            var request = new CreateLessonChapterRequest()
            {
                LessonId = new Guid("D2A6D649-ABAF-E811-8222-2C600C6934BE"),
                Title = "aa",
                Content = "La conscience consiste dans la faculté qui me permet de prendre connaissance de mes actes, et en particulier de l'activité de mon esprit. Elle se définirait donc comme une forme de connaissance. C'est ce que semble confirmer l'étymologie: \"cum sciens signifie \"avec connaissance, accompagné de savoir. De même, les expressions \"perdre conscience\" ou \"perdre connaissance\", que l'on emploie indifféremment, témoignent d'une proximité entre conscience et connaissance.",
            };

            var businessService = new LessonChapterBusinessService();
            var response = businessService.Create(request);

            Console.WriteLine(response.Exception);

            response.ValidationErrors.ForEach(x =>
            {
                Console.WriteLine(x.PropertyName + ": " + x.ErrorMessage);
            });

            Assert.IsFalse(response.Success);
        }
    }
}
