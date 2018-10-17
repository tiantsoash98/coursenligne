using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class CountChapterGroupByLessonRequest: Request
    {
        public Guid LessonId { get; set; }
    }
}