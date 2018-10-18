using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonAlternativePictureRequest: Request
    {
        public Guid LessonId { get; set; }
        public bool GetThumbnailPicture { get; set; }
    }
}
