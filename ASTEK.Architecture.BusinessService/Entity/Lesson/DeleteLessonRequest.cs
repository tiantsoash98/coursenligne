using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class DeleteLessonRequest: Request
    {
        public Guid LessonId { get; set; }
        public Guid AccountId { get; set; }
    }
}
