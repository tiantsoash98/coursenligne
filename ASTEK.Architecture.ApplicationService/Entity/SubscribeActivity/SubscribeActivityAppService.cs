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

        public CountSubscribersOutputModel CountSubscribers(CountSubscribersInputModel input)
        {
            var request = new CountSubscribersRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId)
            };

            CountSubscribersResponse response = _service.CountSubscribers(request);

            var output = new CountSubscribersOutputModel
            {
                Response = response
            };

            return output;
        }

        public GetAllSubscribersOutputModel GetAllSubscribers(GetAllSubscribersInputModel input)
        {
            var request = new GetAllSubscribersRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                Page = input.Page,
                Count = input.Count
            };

            GetAllSubscribersResponse response = _service.GetAllSubscribers(request);

            var output = new GetAllSubscribersOutputModel
            {
                Response = response
            };

            return output;
        }

        public GetAllSubscribedOutputModel GetAllSubscribed(GetAllSubscribedInputModel input)
        {
            var request = new GetAllSubscribedRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                Page = input.Page,
                Count = input.Count
            };

            GetAllSubscribedResponse response = _service.GetAllSubscribed(request);

            var output = new GetAllSubscribedOutputModel
            {
                Response = response
            };

            return output;
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

        public IsSubscribedOutputModel IsSubscribed(IsSubscribedInputModel input)
        {
            var request = new IsSubscribedRequest
            {
                SubscriberId = GuidUtilities.TryParse(input.SubscriberId),
                SubscribedId = GuidUtilities.TryParse(input.SubscribedId)
            };

            IsSubscribedResponse response = _service.IsSubscribed(request);

            var output = new IsSubscribedOutputModel
            {
                Response = response
            };

            return output;
        }
    }
}
