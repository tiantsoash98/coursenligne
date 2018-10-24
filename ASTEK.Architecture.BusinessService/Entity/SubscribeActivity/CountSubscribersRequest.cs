using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class CountSubscribersRequest: Request
    {
        public Guid AccountId { get; set; }
    }
}
