using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class GetAllSubscribersRequest: Request
    {
        public Guid AccountId { get; set; }
    }
}
