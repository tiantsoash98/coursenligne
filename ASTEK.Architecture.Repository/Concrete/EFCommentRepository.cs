﻿using ASTEK.Architecture.Domain.Entity.Comment;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFCommentRepository: EFRepository<Comment, Guid>, ICommentRepository
    {
        public EFCommentRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public new void Add(Comment entity)
        {
            var state = Context.DocumentStates.FirstOrDefault(d => d.DCSWORDING.Equals("VALID"));

            if(state == null)
            {
                throw new InvalidOperationException();
            }

            entity.DCSCODE = state.DCSCODE;

            base.Add(entity);
        }

        public List<Comment> FindAll(Guid lessonId)
        {
            Context.Comments.Include(c => c.Account.AccountStudents).ToList();
            Context.Comments.Include(c => c.Account.AccountTeachers).ToList();

            return Context.Comments.Where(c => c.LSNID.Equals(lessonId) && c.DocumentState.DCSWORDING.Equals("VALID")).ToList();
        }
    }
}