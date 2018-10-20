using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.CommentAnswer
{
    [TestClass]
    public class CommentAnswerTest
    {
        [TestMethod]
        public void Insert()
        {
            var comment = new Domain.Entity.CommentAnswer.CommentAnswer
            {
                CANDATE = DateTime.Now,
                COMID = new Guid("3BCC1004-39D4-E811-822A-2C600C6934BE"),
                CANCONTENT = "Phasellus sed nibh ut ipsum porta rhoncus. Morbi semper leo vel nunc hendrerit rhoncus. Integer vel elementum nunc. Nam vel diam bibendum, pretium metus molestie, viverra risus. Vivamus dignissim blandit tincidunt. Pellentesque at augue ac nulla aliquam viverra. Vestibulum a diam urna. Fusce mollis ipsum et hendrerit varius. Mauris faucibus ipsum eu ligula congue, ut laoreet justo dapibus. Aliquam mi neque, ultricies id semper et, molestie quis odio. Integer vitae feugiat nisl. Aenean vel lectus quis felis auctor finibus maximus vitae diam. Suspendisse vitae vestibulum enim. Donec lacinia, enim eu auctor rhoncus, mauris justo pulvinar ex, vitae ultrices augue arcu at mauris. Duis congue placerat eleifend.",
                ACCID = new Guid("DAB3E636-90BE-E811-8225-2C600C6934BE"),
                DCSCODE = new Guid("03529C5E-3FBA-E811-8225-2C600C6934BE")
            };

            var context = new EFDbContext();
            var repository = new EFCommentAnswerRepository(context);
            repository.Add(comment);
        }
    }
}
