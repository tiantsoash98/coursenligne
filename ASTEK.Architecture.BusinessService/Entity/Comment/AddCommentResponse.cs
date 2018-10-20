using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Comment
{
    public class AddCommentResponse: Response
    {
        public Domain.Entity.Comment.Comment Comment { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
