using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class UpdateAllPartsRequest: Request
    {
        public Guid ChapterCode { get; set; }
        public List<Domain.Entity.LessonPart.LessonPart> Parts { get; set; }
    }
}
