using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.Comment
{
    [TestClass]
    public class CommentTests
    {
        [TestMethod]
        public void Insert()
        {
            var comment = new Domain.Entity.Comment.Comment
            {
                COMDATE = DateTime.Now,
                LSNID = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE"),
                COMCONTENT = "Vestibulum imperdiet, arcu ac fermentum vestibulum, massa arcu congue eros, non commodo libero nisl ac erat. Aliquam dapibus libero nibh, eu faucibus est rhoncus nec. Suspendisse quis neque et est pulvinar pulvinar. Quisque consectetur rhoncus consequat. Donec cursus imperdiet luctus. Quisque libero nibh, faucibus vel aliquet sit amet, lobortis ut est. Quisque in tellus ullamcorper, fringilla mi ac, tincidunt eros. Cras luctus libero non neque congue, vitae placerat nisi ornare. Aliquam lectus quam, rhoncus ut nisi in, mollis dignissim nunc.",
                ACCID = new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE"),
                DCSCODE = new Guid("03529C5E-3FBA-E811-8225-2C600C6934BE")
            };

            var context = new EFDbContext();
            var repository = new EFCommentRepository(context);
            repository.Add(comment);
        }
    }
}
