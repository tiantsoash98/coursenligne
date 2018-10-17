using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class CreateLessonPartRequest: Request
    {
        public Guid ChapterCode { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
