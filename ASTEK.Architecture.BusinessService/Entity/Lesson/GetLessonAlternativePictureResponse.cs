using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonAlternativePictureResponse : Response
    {
        public string PicturePath { get; set; }
        public string LessonTitle { get; set; }
        public string StudyName { get; set; }
        public bool IsAlternative { get; set; }
    }
}
