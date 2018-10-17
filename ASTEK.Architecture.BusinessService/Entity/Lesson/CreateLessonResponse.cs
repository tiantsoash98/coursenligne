using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class CreateLessonResponse: Response
    {
        public Domain.Entity.Lesson.Lesson Lesson { get; set; }
        public List<ValidationFailure> ValidationErrors { get; set; }
    }
}