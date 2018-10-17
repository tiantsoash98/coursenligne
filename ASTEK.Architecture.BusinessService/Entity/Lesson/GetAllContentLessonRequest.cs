using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetAllContentLessonRequest: Request
    {
        public Guid LessonId { get; set; }
    }
}
