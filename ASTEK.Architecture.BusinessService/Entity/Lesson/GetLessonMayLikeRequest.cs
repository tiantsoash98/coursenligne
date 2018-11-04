using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonMayLikeRequest: Request
    {
        public bool GetAlternativePicture { get; set; }
        public bool GetThumbnailPicture { get; set; }
        public int Level { get; set; }
    }
}
