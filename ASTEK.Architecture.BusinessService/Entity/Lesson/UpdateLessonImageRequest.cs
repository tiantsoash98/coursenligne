using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class UpdateLessonImageRequest: Request
    {
        public Guid LessonId { get; set; }
        public string ImageName { get; set; }
    }
}
