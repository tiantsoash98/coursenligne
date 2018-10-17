using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class CreateAllLessonPartRequest: Request
    {
        public Guid ChapterCode { get; set; }
        public List<CreateLessonPartRequest> Parts { get; set; }
    }
}
