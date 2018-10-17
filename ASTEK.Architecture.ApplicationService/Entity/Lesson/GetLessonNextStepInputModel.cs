using ASTEK.Architecture.Infrastructure.Navigation;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class GetLessonNextStepInputModel
    {
        public LessonNavigation Navigation { get; set; }
        public short CurrentChapter { get; set; }
        public short CurrentPart { get; set; }
        public string LessonId { get; set; }
    }
}