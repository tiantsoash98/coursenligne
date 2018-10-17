using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonRequest: Request
    {
        public Guid LessonId { get; set; }
        public bool GetAlternativePicture { get; set; }
    }
}