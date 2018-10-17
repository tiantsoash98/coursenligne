using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.AccountStudent
{
    public class UpdateAccountStudentResponse: Response
    {
        public Domain.Entity.AccountStudent.AccountStudent  Updated { get; set; }
        public List<ValidationFailure> ValidatorErrors { get; set; }
    }
}
