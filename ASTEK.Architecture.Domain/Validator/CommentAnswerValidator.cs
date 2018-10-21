using ASTEK.Architecture.Domain.Entity.CommentAnswer;
using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Validator
{
    public class CommentAnswerValidator : ValidatorDomainBase<CommentAnswer, Guid>
    {
        public CommentAnswerValidator(ValidationType validationType) : base(validationType)
        {
            //if(validationType == ValidationType.Add)
            //{

            //}
        }
    }
}
