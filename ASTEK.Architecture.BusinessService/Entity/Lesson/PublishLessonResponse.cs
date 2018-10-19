using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class PublishLessonResponse: Response
    {
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
