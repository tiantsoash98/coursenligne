using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.Comment
{
    public interface ICommentRepository : IRepository<Comment, Guid>
    {
        List<Comment> FindAll(Guid lessonId);
    }
}
