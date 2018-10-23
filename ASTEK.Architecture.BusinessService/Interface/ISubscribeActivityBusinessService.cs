using ASTEK.Architecture.BusinessService.Entity.SubscribeActivity;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ISubscribeActivityBusinessService
    {
        NotifySubscribersResponse NotifySubscribers(NotifySubscribersRequest request);
        ToogleSubscriptionResponse ToogleSubscription(ToogleSubscriptionRequest request);
    }
}
