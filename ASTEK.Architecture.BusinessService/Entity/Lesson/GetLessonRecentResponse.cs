using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonRecentResponse: Response
    {
        public List<Domain.Entity.Lesson.Lesson> Lessons { get; set; }
    }
}
