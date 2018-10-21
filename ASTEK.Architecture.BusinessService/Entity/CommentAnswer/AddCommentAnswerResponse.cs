using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.CommentAnswer
{
    public class AddCommentAnswerResponse: Response
    {
        public Domain.Entity.CommentAnswer.CommentAnswer CommentAnswer { get; set; }
        public List<ValidationFailure> ValidationFailures { get; set; }
    }
}
