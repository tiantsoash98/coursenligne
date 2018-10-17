using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class UpdateAllPartsResponse: Response
    {
        public List<Domain.Entity.LessonPart.LessonPart> Updated { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
