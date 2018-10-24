using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class GetAllSubscribedResponse: Response
    {
        public List<Domain.Entity.SubscribeActivity.SubscribeActivity> Subscribed { get; set; }
    }
}
