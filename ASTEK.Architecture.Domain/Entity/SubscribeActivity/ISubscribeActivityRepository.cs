using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.SubscribeActivity
{
    public interface ISubscribeActivityRepository : IRepository<SubscribeActivity, Guid>
    {
        List<SubscribeActivity> GetAllSubscribers(Guid accountId);
        List<SubscribeActivity> GetAllSubscribed(Guid accountId);
        void Subscribe(Guid subscriberId, Guid subscribedId);
        void Unsubscribe(Guid subscriberId, Guid subscribedId);
        bool IsSubscribedTo(Guid subscriberId, Guid subscribedId);
    }
}
