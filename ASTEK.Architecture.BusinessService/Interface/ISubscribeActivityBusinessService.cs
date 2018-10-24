using ASTEK.Architecture.BusinessService.Entity.SubscribeActivity;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ISubscribeActivityBusinessService
    {
        CountSubscribersResponse CountSubscribers(CountSubscribersRequest request);
        GetAllSubscribersResponse GetAllSubscribers(GetAllSubscribersRequest request);
        GetAllSubscribedResponse GetAllSubscribed(GetAllSubscribedRequest request);
        IsSubscribedResponse IsSubscribed(IsSubscribedRequest request);
        NotifySubscribersResponse NotifySubscribers(NotifySubscribersRequest request);
        ToogleSubscriptionResponse ToogleSubscription(ToogleSubscriptionRequest request);
    }
}
