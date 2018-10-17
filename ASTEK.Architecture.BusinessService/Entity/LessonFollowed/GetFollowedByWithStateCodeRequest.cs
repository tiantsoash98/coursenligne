using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class GetFollowedByWithStateCodeRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid StateCode { get; set; }
    }
}
