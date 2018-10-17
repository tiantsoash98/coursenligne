using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class GetChapterByNumberRequest: Request
    {
        public Guid LessonId { get; set; }
        public short Number { get; set; }
        public bool LoadChildren { get; set; }
    }
}
