using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class UpdateLessonRequest: Request
    {
        public Guid LessonId { get; set; }
        public Guid Study { get; set; }
        public Guid Confidentiality { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Targets { get; set; }
    }
}
