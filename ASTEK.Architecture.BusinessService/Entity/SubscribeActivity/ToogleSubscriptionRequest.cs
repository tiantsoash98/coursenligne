using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class ToogleSubscriptionRequest: Request
    {
        public Guid SubscriberId { get; set; }
        public Guid SubscribedId { get; set; }
    }
}
