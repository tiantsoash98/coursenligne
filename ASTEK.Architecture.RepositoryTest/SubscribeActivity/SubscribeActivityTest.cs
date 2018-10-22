using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.SubscribeActivity
{
    [TestClass]
    public class SubscribeActivityTest
    {
        [TestMethod]
        public void Insert()
        {
            var subscription = new Domain.Entity.SubscribeActivity.SubscribeActivity
            {
                ACCSUBSCRIBER = new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE"),
                ACCSUBSCRIBED = new Guid("9EEEDEAC-91AF-E811-8222-2C600C6934BE"),
                SUBDATE = DateTime.Now
            };

            EFDbContext context = new EFDbContext();
            var rep = new EFSubscribeActivityRepository(context);
            rep.Add(subscription);
        }

        [TestMethod]
        public void Subscribe()
        {
            var subscriber = new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE");
            var subscribed = new Guid("9EEEDEAC-91AF-E811-8222-2C600C6934BE");


            EFDbContext context = new EFDbContext();
            var rep = new EFSubscribeActivityRepository(context);
            rep.Subscribe(subscriber, subscribed);
        }

        [TestMethod]
        public void Unsubscribe()
        {
            var subscriber = new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE");
            var subscribed = new Guid("9EEEDEAC-91AF-E811-8222-2C600C6934BE");


            EFDbContext context = new EFDbContext();
            var rep = new EFSubscribeActivityRepository(context);
            rep.Unsubscribe(subscriber, subscribed);
        }

        [TestMethod]
        public void IsSubscribedTo()
        {
            var subscriber = new Guid("E8BC0C1E-BB9F-E811-8220-2C600C6934BE");
            var subscribed = new Guid("9EEEDEAC-91AF-E811-8222-2C600C6934BE");

            EFDbContext context = new EFDbContext();
            var rep = new EFSubscribeActivityRepository(context);
            Assert.IsFalse(rep.IsSubscribedTo(subscriber, subscribed));
        }
    }
}
