using ASTEK.Architecture.BusinessService.Entity.SubscribeActivity;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ISubscribeActivityBusinessService
    {
        IsSubscribedResponse IsSubscribed(IsSubscribedRequest request);
        NotifySubscribersResponse NotifySubscribers(NotifySubscribersRequest request);
        ToogleSubscriptionResponse ToogleSubscription(ToogleSubscriptionRequest request);
    }
}
