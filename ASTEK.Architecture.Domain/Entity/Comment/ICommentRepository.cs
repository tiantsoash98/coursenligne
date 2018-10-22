using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.Comment
{
    public interface ICommentRepository : IRepository<Comment, Guid>
    {
        int Count(Guid LessonId);
        List<Comment> FindAll(Guid lessonId, bool loadAnswers = false);
    }
}
