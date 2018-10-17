using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.AccountTeacher
{
    public class UpdateAccountTeacherResponse: Response
    {
        public Domain.Entity.AccountTeacher.AccountTeacher Updated { get; set; }
        public List<ValidationFailure> ValidatorErrors { get; set; }
    }
}
