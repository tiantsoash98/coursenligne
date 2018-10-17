using System;
using System.Linq;
using System.Linq.Expressions;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class ExpressionUtilitiesTest
    {
        [TestMethod]
        public void Concat()
        {
            var ctx = new EFDbContext();
            var rep = new EFLessonFollowedRepository(ctx);

            Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> exp1 = u => u.LSNID.Equals(new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE"));
            Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> exp2 = u => u.LSFDATE < DateTime.Now;
            Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> exp3 = u => u.ACCID.Equals(new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE"));

            var lambda = ExpressionUtilities.AndAlso(exp1, exp2);

            var result = rep.FindBy(new Specification<Domain.Entity.LessonFollowed.LessonFollowed>(lambda)).ToList();

            result.ForEach(x =>
            {
                Console.WriteLine(x.LSNID + " " + x.ACCID + " " + x.LSFDATE);
            });

            lambda = ExpressionUtilities.AndAlso(lambda, exp3);

            result = rep.FindBy(new Specification<Domain.Entity.LessonFollowed.LessonFollowed>(lambda)).ToList();

            Console.WriteLine("**Result 2");

            result.ForEach(x =>
            {
                Console.WriteLine(x.LSNID + " " + x.ACCID + " " + x.LSFDATE);
            });
        }
    }
}
