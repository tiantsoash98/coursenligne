using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class GetFollowedByWithStateRequest: Request
    {
        public Guid AccountId { get; set; }
        public string State { get; set; }
    }
}
