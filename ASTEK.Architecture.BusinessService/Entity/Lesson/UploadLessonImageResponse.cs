using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class UploadLessonImageResponse: Response
    {
        public string FileName { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
