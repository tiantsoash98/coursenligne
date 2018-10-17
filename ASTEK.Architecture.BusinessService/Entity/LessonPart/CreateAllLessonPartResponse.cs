using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class CreateAllLessonPartResponse: Response
    {
        public List<ValidationFailure> ValidationErrors { get; set; }
    }
}
