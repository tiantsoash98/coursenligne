using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class UploadAccountImageResponse: Response
    {
        public string FileName { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
