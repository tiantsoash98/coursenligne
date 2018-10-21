using ASTEK.Architecture.Domain.Entity.CommentAnswer;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFCommentAnswerRepository: EFRepository<CommentAnswer, Guid>, ICommentAnswerRepository
    {
        public EFCommentAnswerRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public new void Add(CommentAnswer entity)
        {
            var state = Context.DocumentStates.FirstOrDefault(d => d.DCSWORDING.Equals("VALID"));

            if (state == null)
            {
                throw new InvalidOperationException();
            }

            entity.DCSCODE = state.DCSCODE;

            base.Add(entity);
        }

        public List<CommentAnswer> FindAll(Guid commentId)
        {
            Context.CommentAnswers.Include(c => c.Account.AccountStudents).ToList();
            Context.CommentAnswers.Include(c => c.Account.AccountTeachers).ToList();

            return Context.CommentAnswers.Where(c => c.COMID.Equals(commentId) && c.DocumentState.DCSWORDING.Equals("VALID"))
                                    .OrderByDescending(c => c.CANDATE)
                                    .ToList();
        }
    }
}
