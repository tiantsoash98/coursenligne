using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class UpdateChapterRequest: Request
    {
        public Guid LessonId { get; set; }
        public short ChapterNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public long Duration { get; set; }
    }
}
