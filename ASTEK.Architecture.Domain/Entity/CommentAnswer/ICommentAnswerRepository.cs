using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.CommentAnswer
{
    public interface ICommentAnswerRepository: IRepository<CommentAnswer, Guid>
    {
        List<CommentAnswer> FindAll(Guid commentId);
    }
}
