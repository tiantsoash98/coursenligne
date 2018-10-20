using ASTEK.Architecture.Domain.Entity.CommentAnswer;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFCommentAnswerRepository: EFRepository<CommentAnswer, Guid>, ICommentAnswerRepository
    {
        public EFCommentAnswerRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
