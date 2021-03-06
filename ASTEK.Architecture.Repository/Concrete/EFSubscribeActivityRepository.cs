﻿using ASTEK.Architecture.Domain.Entity.SubscribeActivity;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFSubscribeActivityRepository : EFRepository<SubscribeActivity, Guid>, ISubscribeActivityRepository
    {
        public EFSubscribeActivityRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public List<SubscribeActivity> GetAllSubscribed(Guid accountId)
        {
            Context.SubscribeActivities.Include(s => s.Subscribed.AccountStudents).ToList();
            Context.SubscribeActivities.Include(s => s.Subscribed.AccountTeachers).ToList();

            return Context.SubscribeActivities
                            .Where(s => s.ACCSUBSCRIBER.Equals(accountId))
                            .ToList();
        }

        public List<SubscribeActivity> GetAllSubscribers(Guid accountId)
        {
            Context.SubscribeActivities.Include(s => s.Subscriber.AccountStudents).ToList();
            Context.SubscribeActivities.Include(s => s.Subscriber.AccountTeachers).ToList();

            return Context.SubscribeActivities
                            .Where(s => s.ACCSUBSCRIBED.Equals(accountId))
                            .ToList();
        }

        public bool IsSubscribedTo(Guid subscriberId, Guid subscribedId)
        {
            return Context.SubscribeActivities.Any(s => s.ACCSUBSCRIBER.Equals(subscriberId) && s.ACCSUBSCRIBED.Equals(subscribedId));
        }

        public void Subscribe(Guid subscriberId, Guid subscribedId)
        {
            var exist = Context.SubscribeActivities.FirstOrDefault(s => s.ACCSUBSCRIBER.Equals(subscriberId) && s.ACCSUBSCRIBED.Equals(subscribedId));

            if(exist == null)
            {
                var subscription = new SubscribeActivity
                {
                    ACCSUBSCRIBER = subscriberId,
                    ACCSUBSCRIBED = subscribedId,
                    SUBDATE = DateTime.Now
                };

                Add(subscription);
            }
        }

        public void Unsubscribe(Guid subscriberId, Guid subscribedId)
        {
            var exist = Context.SubscribeActivities.FirstOrDefault(s => s.ACCSUBSCRIBER.Equals(subscriberId) && s.ACCSUBSCRIBED.Equals(subscribedId));

            if(exist != null)
            {
                Remove(exist);
            }
        }
    }
}
