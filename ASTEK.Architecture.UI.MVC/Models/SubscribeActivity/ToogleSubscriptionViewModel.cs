using System;

namespace ASTEK.Architecture.UI.MVC.Models.SubscribeActivity
{
    public class ToogleSubscriptionViewModel
    {
        public string SubscriberId { get; set; }
        public string SubscribedId { get; set; }
        public bool Success { get; set; }
        public bool IsSubscribed { get; set; }
        public Exception Exception { get; set; }
    }
}