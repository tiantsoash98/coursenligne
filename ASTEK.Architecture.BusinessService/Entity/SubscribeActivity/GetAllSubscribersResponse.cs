using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class GetAllSubscribersResponse: Response
    {
        public List<Domain.Entity.SubscribeActivity.SubscribeActivity> Subscribers { get; set; }
    }
}
