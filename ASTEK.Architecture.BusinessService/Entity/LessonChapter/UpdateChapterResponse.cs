using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class UpdateChapterResponse: Response
    {
        public Domain.Entity.LessonChapter.LessonChapter Updated { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
