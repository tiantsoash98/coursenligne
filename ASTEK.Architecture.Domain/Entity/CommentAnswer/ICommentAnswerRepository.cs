using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.CommentAnswer
{
    public interface ICommentAnswerRepository: IRepository<CommentAnswer, Guid>
    {
    }
}
