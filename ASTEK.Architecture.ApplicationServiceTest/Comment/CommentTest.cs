using System;
using ASTEK.Architecture.ApplicationService.Entity.Comment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.ApplicationServiceTest.Comment
{
    [TestClass]
    public class CommentTest
    {
        [TestMethod]
        public void Add()
        {
            var input = new AddCommentInputModel()
            {
                AccountId = "9eeedeac-91af-e811-8222-2c600c6934be",
                LessonId = "D2A6D649-ABAF-E811-8222-2C600C6934BE",
                Content = "Vestibulum imperdiet, arcu ac fermentum vestibulum, massa arcu congue eros, non commodo libero nisl ac erat. Aliquam dapibus libero nibh, eu faucibus est rhoncus nec. Suspendisse quis neque et est pulvinar pulvinar. Quisque consectetur rhoncus consequat. Donec cursus imperdiet luctus. Quisque libero nibh, faucibus vel aliquet sit amet, lobortis ut est. Quisque in tellus ullamcorper, fringilla mi ac, tincidunt eros. Cras luctus libero non neque congue, vitae placerat nisi ornare. Aliquam lectus quam, rhoncus ut nisi in, mollis dignissim nunc."
            };

            var service = new CommentAppService();

            var output = service.Add(input);

            Assert.IsTrue(output.Response.Success);
        }
    }
}
