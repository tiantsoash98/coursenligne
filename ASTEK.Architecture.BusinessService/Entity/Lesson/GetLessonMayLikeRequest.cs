using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonMayLikeRequest: Request
    {
        public bool GetAlternativePicture { get; set; }
        public bool GetThumbnailPicture { get; set; }
        public int Level { get; set; }
        public Guid? StudyCode { get; set; }
    }
}
