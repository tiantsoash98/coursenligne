using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class GetPartByNumberRequest: Request
    {
        public Guid LessonId { get; set; }
        public short ChapterNumber { get; set; }
        public short Number { get; set; }
    }
}