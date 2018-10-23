using ASTEK.Architecture.BusinessService.Entity.SubscribeActivity;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.SubscribeActivity
{
    public class SubscribeActivityAppService
    {
        private readonly ISubscribeActivityBusinessService _service;

        public SubscribeActivityAppService()
        {
            _service = new SubscribeActivityBusinessService();
        }

        public ToogleSubscriptionOutputModel ToogleSubscription(ToogleSubscriptionInputModel input)
        {
            var request = new ToogleSubscriptionRequest
            {
                SubscriberId = GuidUtilities.TryParse(input.SubscriberId),
                SubscribedId = GuidUtilities.TryParse(input.SubscribedId)
            };

            ToogleSubscriptionResponse response = _service.ToogleSubscription(request);

            var output = new ToogleSubscriptionOutputModel
            {
                Response = response
            };

            return output;
        }
    }
}
