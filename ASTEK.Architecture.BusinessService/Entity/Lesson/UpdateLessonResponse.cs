using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class UpdateLessonResponse: Response
    {
        public Domain.Entity.Lesson.Lesson Updated { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
