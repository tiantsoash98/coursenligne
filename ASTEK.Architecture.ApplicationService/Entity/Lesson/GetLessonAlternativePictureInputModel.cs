using System;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class GetLessonAlternativePictureInputModel
    {
        public string LessonId { get; set; }
        public bool GetThumbnailPicture { get; set; }
    }
}
