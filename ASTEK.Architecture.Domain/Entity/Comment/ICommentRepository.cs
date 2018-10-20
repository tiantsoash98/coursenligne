using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.Comment
{
    public interface ICommentRepository : IRepository<Comment, Guid>
    {
    }
}
