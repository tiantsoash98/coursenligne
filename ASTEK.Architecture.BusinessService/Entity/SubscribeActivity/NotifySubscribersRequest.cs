using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class NotifySubscribersRequest: Request
    {
        public Guid AccountId { get ; set; }
        public Guid LessonId { get; set; }
        public NotificationSource NotificationSource { get; set; }
        public string UrlPath { get; set; }
    }
}
