using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonRecentRequest: Request
    {
        public Guid? StudyCode { get; set; }
        public int Level { get; set; }
    }
}
