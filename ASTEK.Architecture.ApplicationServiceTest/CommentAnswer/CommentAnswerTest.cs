using System;
using ASTEK.Architecture.ApplicationService.Entity.CommentAnswer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.ApplicationServiceTest.CommentAnswer
{
    [TestClass]
    public class CommentAnswerTest
    {
        [TestMethod]
        public void Add()
        {
            var input = new AddCommentAnswerInputModel()
            {
                AccountId = "9eeedeac-91af-e811-8222-2c600c6934be",
                CommentId = "E95771FE-70D4-E811-822A-2C600C6934BE",
                Content = "Voici la deuxième réponse"
            };

            var service = new CommentAnswerAppService();

            var output = service.Add(input);

            Assert.IsTrue(output.Response.Success);
        }
    }
}
