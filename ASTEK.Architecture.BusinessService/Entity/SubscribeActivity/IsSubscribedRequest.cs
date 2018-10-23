using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class IsSubscribedRequest: Request
    {
        public Guid SubscriberId { get; set; }
        public Guid SubscribedId { get; set; }
    }
}
