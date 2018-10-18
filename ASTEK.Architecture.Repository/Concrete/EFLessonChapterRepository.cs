using ASTEK.Architecture.Domain.Entity.LessonChapter;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Linq;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFLessonChapterRepository : EFRepository<LessonChapter, Guid>, ILessonChapterRepository
    {
        public EFLessonChapterRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public new void Add(LessonChapter entity)
        {
            entity.LSCNUMBER = GetNextChapterNumber(entity.LSNID);
            base.Add(entity);
        }

        public short GetNextChapterNumber(Guid lessonId)
        {
            var last = Context.LessonChapters
                                .Where(chapter => chapter.LSNID.Equals(lessonId))
                                .OrderByDescending(e => e.LSCNUMBER)
                                .FirstOrDefault();

            if (last == null)
                return 1;

            return (short)(last.LSCNUMBER + 1);
        }

        public LessonChapter GetByNumber(Guid lessonId, short number, bool loadChildren = false)
        {
            if (loadChildren)
            {
                Context.LessonChapters.Include(c => c.LessonParts).ToList();
            }

            return Context.LessonChapters
                    .Where(chapter => chapter.LSNID.Equals(lessonId) && chapter.LSCNUMBER == number)
                    .FirstOrDefault();
        }

        public string GetChapterTitle(Guid lessonId, short number)
        {
             return Context.LessonChapters
                            .Where(chapter => chapter.LSNID.Equals(lessonId) && chapter.LSCNUMBER == number)
                            .Select(chapter => chapter.LSCTITLE)
                            .FirstOrDefault();
        }

        public int Count(Guid lessonId)
        {
            return Count(new Specification<LessonChapter>(e => e.LSNID.Equals(lessonId)));
        }

        public LessonChapter Update(LessonChapter entity)
        {
            var chapter = Context.LessonChapters.FirstOrDefault(c => c.LSNID.Equals(entity.LSNID) && c.LSCNUMBER.Equals(entity.LSCNUMBER));

            if(chapter == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter);
            }

            chapter.LSCTITLE = entity.LSCTITLE;
            chapter.LSCDESCRIPTION = entity.LSCDESCRIPTION;
            chapter.LSCCONTENT = entity.LSCCONTENT;
            chapter.LSCDURATION = entity.LSCDURATION;

            Context.SaveChanges();

            return chapter;
        }
    }
}
