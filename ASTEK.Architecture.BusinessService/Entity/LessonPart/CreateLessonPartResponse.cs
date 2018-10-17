using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class CreateLessonPartResponse: Response
    {
        public Domain.Entity.LessonPart.LessonPart Part { get; set; }
        public List<ValidationFailure> ValidationErrors { get; set; }
    }
}
