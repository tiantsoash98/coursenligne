using ASTEK.Architecture.Domain.Entity.LessonFollowed;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFLessonFollowedRepository : EFRepository<LessonFollowed, Guid>, ILessonFollowedRepository
    {
        public EFLessonFollowedRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public int CountTotalViewsOfAccount(Guid accountId)
        {
            return Context.LessonFolloweds.Count(l => l.Lesson.ACCID.Equals(accountId));
        }

        public int CountTotalViewsOfAccount(Guid accountId, DateTime fromDate, DateTime toDate)
        {
            return Context.LessonFolloweds.Count(l => l.ACCID.Equals(accountId) && l.LSFDATE >= fromDate && l.LSFDATE <= toDate);
        }

        public int CountByLesson(Guid lessonId)
        {
            return Context.LessonFolloweds.Count(l => l.LSNID.Equals(lessonId));
        }

        public int CountByLesson(Guid lessonId, DateTime fromDate, DateTime toDate)
        {
            return Context.LessonFolloweds.Count(l => l.LSNID.Equals(lessonId) && l.LSFDATE >= fromDate && l.LSFDATE <= toDate);
        }

        public void FinishLesson(Guid accountId, Guid lessonId, short? chapterNumber, short? partNumber)
        {
            var exist = Context.LessonFolloweds.FirstOrDefault(l => l.ACCID.Equals(accountId) && l.LSNID.Equals(lessonId));

            if (exist != null)
            {
                var finished = Context.FollowStates.FirstOrDefault(f => f.FLSWORDING.Equals("FINISHED"));

                if (finished == null)
                {
                    throw new InvalidOperationException();
                }

                exist.FLSCODE = finished.FLSCODE;

                if (chapterNumber.HasValue)
                {
                    exist.LSFCHAPTER = chapterNumber.Value;
                }
                if (partNumber.HasValue)
                {
                    exist.LSFPART = partNumber.Value;
                }

                Context.SaveChanges();
            }
        }

        public void FinishPart(Guid accountId, Guid lessonId, short chapterNumber, short? partNumber)
        {
            var follow = Context.LessonFolloweds.FirstOrDefault(f => f.ACCID.Equals(accountId) && f.LSNID.Equals(lessonId));

            if (follow == null)
            {
                Follow(accountId, lessonId, chapterNumber, partNumber);
            }
            else
            {
                follow.LSFCHAPTER = chapterNumber;
                follow.LSFPART = partNumber;

                Context.SaveChanges();
            }
        }

        public void Follow(Guid accountId, Guid lessonId)
        {
            Follow(accountId, lessonId, 1, null);
        }

        public void Follow(Guid accountId, Guid lessonId, short chapterNumber, short? partNumber)
        {
            var lesson = Context.Lessons.FirstOrDefault(l => l.Id.Equals(lessonId));

            if (lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            if (!lesson.ACCID.Equals(accountId))
            {
                var exist = Context.LessonFolloweds.FirstOrDefault(l => l.ACCID.Equals(accountId) && l.LSNID.Equals(lessonId));

                if (exist == null)
                {
                    var started = Context.FollowStates.FirstOrDefault(f => f.FLSWORDING.Equals("STARTED"));

                    if (started == null)
                    {
                        throw new InvalidOperationException();
                    }

                    var follow = new LessonFollowed()
                    {
                        ACCID = accountId,
                        LSNID = lessonId,
                        FLSCODE = started.FLSCODE,
                        LSFDATE = DateTime.Now,
                        LSFCHAPTER = chapterNumber,
                        LSFPART = partNumber
                    };

                    Add(follow);
                }
            }
        }

        public List<LessonFollowed> GetFollowedBy(Guid accountId)
        {
            Context.LessonFolloweds.Include(f => f.FollowState).ToList();
            Context.LessonFolloweds.Include(f => f.Lesson.Study).ToList();

            return Context.LessonFolloweds
                            .Where(f => f.ACCID.Equals(accountId))
                            .ToList();
        }

        public List<LessonFollowed> GetByLesson(Guid lessonId)
        {
            Context.LessonFolloweds.Include(f => f.Account.AccountStudents).ToList();
            Context.LessonFolloweds.Include(f => f.Account.AccountTeachers).ToList();

            return Context.LessonFolloweds.Where(l => l.LSNID.Equals(lessonId)).ToList();
        }

        public List<LessonFollowed> GetFollowedBy(Guid accountId, Guid stateCode)
        {
            Context.LessonFolloweds
                .Include(f => f.Lesson.Account.AccountTeachers)
                .ToList();

            Context.LessonFolloweds
                .Include(f => f.Lesson.Study)
                .ToList();

            return Context.LessonFolloweds
                    .Where(f => f.ACCID.Equals(accountId) && f.FLSCODE.Equals(stateCode))
                    .ToList();
        }
    }
}