using ASTEK.Architecture.Domain.Entity.Comment;
using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Validator
{
    public class CommentValidator : ValidatorDomainBase<Comment, Guid>
    {
        public CommentValidator(ValidationType validationType): base(validationType)
        {
            //if(validationType == ValidationType.Add)
            //{

            //}
        }
    }
}
