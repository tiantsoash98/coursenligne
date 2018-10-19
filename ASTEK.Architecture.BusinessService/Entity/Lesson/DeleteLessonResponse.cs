using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class DeleteLessonResponse: Response
    {
        public Domain.Entity.Lesson.Lesson Lesson { get; set; } 
    }
}
