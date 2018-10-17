using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ASTEK.Architecture.RepositoryTest.LessonFollowed
{
    [TestClass]
    public class LessonFollowedTests
    {
        [TestMethod]
        public void Follow()
        {
            var accountId = new Guid("9AB7771D-F69F-E811-8220-2C600C6934BE");
            var lessonId = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");


            var ctx = new EFDbContext();
            var rep = new EFLessonFollowedRepository(ctx);

            rep.Follow(accountId, lessonId);
        }

        [TestMethod]
        public void Update()
        {
            var accountId = new Guid("0BA7A6DA-76BD-E811-8224-2C600C6934BE");
            var lessonId = new Guid("A2F9BC01-CAB1-E811-8222-2C600C6934BE");


            var ctx = new EFDbContext();

            var follow = ctx.LessonFolloweds.FirstOrDefault(f => f.ACCID.Equals(accountId) && f.LSNID.Equals(lessonId));

            follow.LSFCHAPTER = 2;
            follow.LSFPART = 1;

            ctx.SaveChanges();
        }

        [TestMethod]
        public void GetFollowedBy()
        {
            var accountId = new Guid("0BA7A6DA-76BD-E811-8224-2C600C6934BE");

            var ctx = new EFDbContext();
            var rep = new EFLessonFollowedRepository(ctx);

            var lessons = rep.GetFollowedBy(accountId);

            lessons.ForEach(x =>
            {
                Console.WriteLine(x.FollowState.FLSWORDING + " " +  x.Lesson.LSNTITLE);
            });
        }
    }
}
