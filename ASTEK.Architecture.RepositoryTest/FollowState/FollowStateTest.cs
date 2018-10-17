using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.FollowState
{
    [TestClass]
    public class FollowStateTest
    {
        [TestMethod]
        public void Insert()
        {
            var state = new Domain.Entity.FollowState.FollowState
            {
                FLSWORDING = "FINISHED"
            };

            EFDbContext context = new EFDbContext();
            var rep = new EFFollowStateRepository(context);
            rep.Add(state);
        }
    }
}
