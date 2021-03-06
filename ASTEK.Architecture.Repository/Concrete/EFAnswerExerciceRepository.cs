﻿using ASTEK.Architecture.Domain.Entity.AnswerExercice;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFAnswerExerciceRepository : EFRepository<AnswerExercice, Guid>, IAnswerExerciceRepository
    {
        public EFAnswerExerciceRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public AnswerExercice Upload(AnswerExercice answer)
        {
            var exist = Context.AnswerExercices.FirstOrDefault(l => l.ACCID.Equals(answer.ACCID) && l.LSNID.Equals(answer.LSNID));

            if(exist != null)
            {
                throw new InvalidOperationException();
            }

            Add(answer);

            return answer;
        }

        public new AnswerExercice FindBy(Guid id)
        {
            Context.AnswerExercices.Include(a => a.Account.AccountStudents).ToList();
            Context.AnswerExercices.Include(a => a.Account.AccountTeachers).ToList();
            Context.AnswerExercices.Include(a => a.Lesson.Study).ToList();

            return Context.AnswerExercices.Find(id);
        }

        public List<AnswerExercice> GetAllUnmarkedTeacher(Guid accountId, Guid? lessonId)
        {
            Context.AnswerExercices.Include(a => a.Account.AccountStudents).ToList();
            Context.AnswerExercices.Include(a => a.Account.AccountTeachers).ToList();
            Context.AnswerExercices.Include(a => a.Lesson.Study).ToList();

            var answers = Context.AnswerExercices.Where(a => a.Lesson.ACCID.Equals(accountId) && !a.ANSISCORRECTED);

            if (lessonId.HasValue)
            {
                answers = answers.Where(a => a.LSNID.Equals(lessonId.Value));
            }

            return answers.ToList();
        }

        public List<AnswerExercice> GetAllMarkedTeacher(Guid accountId, Guid? lessonId)
        {
            Context.AnswerExercices.Include(a => a.Account.AccountStudents).ToList();
            Context.AnswerExercices.Include(a => a.Account.AccountTeachers).ToList();
            Context.AnswerExercices.Include(a => a.Lesson.Study).ToList();

            var answers = Context.AnswerExercices.Where(a => a.Lesson.ACCID.Equals(accountId) && a.ANSISCORRECTED);

            return answers.ToList();
        }

        public List<AnswerExercice> GetAllUnmarkedStudent(Guid accountId)
        {
            Context.AnswerExercices.Include(a => a.Account.AccountStudents).ToList();
            Context.AnswerExercices.Include(a => a.Account.AccountTeachers).ToList();
            Context.AnswerExercices.Include(a => a.Lesson.Study).ToList();

            var answers = Context.AnswerExercices.Where(a => a.ACCID.Equals(accountId) && !a.ANSISCORRECTED);

            return answers.ToList();
        }

        public List<AnswerExercice> GetAllMarkedStudent(Guid accountId)
        {
            Context.AnswerExercices.Include(a => a.Account.AccountStudents).ToList();
            Context.AnswerExercices.Include(a => a.Account.AccountTeachers).ToList();
            Context.AnswerExercices.Include(a => a.Lesson.Study).ToList();

            var answers = Context.AnswerExercices.Where(a => a.ACCID.Equals(accountId) && a.ANSISCORRECTED);

            return answers.ToList();
        }

        public bool HasPosted(Guid accountId, Guid lessonId)
        {
            return Context.AnswerExercices.Any(a => a.ACCID.Equals(accountId) && a.LSNID.Equals(lessonId));
        }

        public int CountUnmarkedTeacher(Guid accountId, Guid? lessonId)
        {
            var list =  Context.AnswerExercices.Where(a => a.Lesson.ACCID.Equals(accountId) && !a.ANSISCORRECTED);

            if (lessonId.HasValue)
            {
                list = list.Where(a => a.LSNID.Equals(lessonId));
            }

            return list.Count();
        }

        public int CountMarkedTeacher(Guid accountId, Guid? lessonId)
        {
            var list = Context.AnswerExercices.Where(a => a.Lesson.ACCID.Equals(accountId) && a.ANSISCORRECTED);

            if (lessonId.HasValue)
            {
                list = list.Where(a => a.LSNID.Equals(lessonId));
            }

            return list.Count();
        }

        public int CountUnmarkedStudent(Guid accountId)
        {
            return Context.AnswerExercices.Count(a => a.ACCID.Equals(accountId) && !a.ANSISCORRECTED);
        }

        public int CountMarkedStudent(Guid accountId)
        {
            return Context.AnswerExercices.Count(a => a.ACCID.Equals(accountId) && a.ANSISCORRECTED);
        }

        public AnswerExercice GetLowestMarkOfStudent(Guid accountId, Guid studyCode, int level)
        {
            var marks = Context.AnswerExercices
                                    .Where(a => a.ACCID.Equals(accountId) && a.Lesson.STDCODE.Equals(studyCode) && a.Lesson.LSNLEVEL.Equals(level) && a.ANSISCORRECTED)
                                    .OrderBy(a => a.ANSMARK.GetValueOrDefault());

            return marks?.FirstOrDefault();
        }

        public AnswerExercice GetHighestMarkOfStudent(Guid accountId, Guid studyCode, int level)
        {
            var marks = Context.AnswerExercices
                                    .Where(a => a.ACCID.Equals(accountId) && a.Lesson.STDCODE.Equals(studyCode) && a.Lesson.LSNLEVEL.Equals(level) && a.ANSISCORRECTED)
                                    .OrderByDescending(a => a.ANSMARK.GetValueOrDefault());

            return marks?.FirstOrDefault();
        }

        public decimal GetAverageMarkOfStudent(Guid accountId, Guid studyCode, int level)
        {
            return Context.AnswerExercices
                                    .Where(a => a.ACCID.Equals(accountId) && a.Lesson.STDCODE.Equals(studyCode) && a.Lesson.LSNLEVEL.Equals(level) && a.ANSISCORRECTED)
                                    .Average(a => a.ANSMARK.GetValueOrDefault());
        }

        public List<AnswerExercice> GetMarksOfStudent(Guid accountId, Guid studyCode, int level)
        {
            Context.AnswerExercices.Include(a => a.Account.AccountStudents).ToList();
            Context.AnswerExercices.Include(a => a.Account.AccountTeachers).ToList();
            Context.AnswerExercices.Include(a => a.Lesson.Study).ToList();

            return Context.AnswerExercices
                                    .Where(a => a.ACCID.Equals(accountId) && a.Lesson.STDCODE.Equals(studyCode) && a.Lesson.LSNLEVEL.Equals(level) && a.ANSISCORRECTED)
                                    .OrderByDescending(a => a.ANSDATEPOSTED)
                                    .ToList();
        }
    }
}
