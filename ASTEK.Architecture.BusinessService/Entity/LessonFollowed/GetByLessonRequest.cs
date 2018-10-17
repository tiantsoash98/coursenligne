using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class GetByLessonRequest: Request
    {
        public Guid LessonId { get; set; }
    }
}
