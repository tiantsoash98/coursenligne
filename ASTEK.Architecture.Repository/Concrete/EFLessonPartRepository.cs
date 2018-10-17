using System;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System.Linq;
using ASTEK.Architecture.Domain.Entity.LessonPart;
using ASTEK.Architecture.Infrastructure.Specification;
using System.Collections.Generic;
using ASTEK.Architecture.Infrastructure.Exception;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFLessonPartRepository : EFRepository<LessonPart, Guid>, ILessonPartRepository
    {
        public EFLessonPartRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public new void Add(LessonPart entity)
        {
            entity.LSPNUMBER = GetNextPartNumber(entity.LSCCODE);
            base.Add(entity);
        }

        public short GetNextPartNumber(Guid chapterCode)
        {
            var last = Context.LessonParts
                                .Where(part => part.LSCCODE.Equals(chapterCode))
                                .OrderByDescending(e => e.LSPNUMBER)
                                .FirstOrDefault();

            if (last == null)
                return 1;

            return (short)(last.LSPNUMBER + 1);
        }

        public LessonPart FindByNumber(Guid lessonId, short chapterNumber, short number)
        {
            return Context.LessonChapters
                            .Where(chapter => chapter.LSNID.Equals(lessonId) && chapter.LSCNUMBER == chapterNumber)
                            .Select(c => c.LessonParts
                                            .FirstOrDefault(p => p.LSPNUMBER == number))
                            .FirstOrDefault();
        }

        public int Count(Guid chapterCode)
        {
            return Count(new Specification<LessonPart>(e => e.LSCCODE.Equals(chapterCode)));
        }

        public void AddWithoutSaving(LessonPart lessonPart)
        {
            Context.LessonParts.Add(lessonPart);
        }

        public void AddAll(Guid chapterCode, IEnumerable<LessonPart> parts)
        {
            var chapter = Context.LessonChapters
                                    .FirstOrDefault(c => c.LSCCODE.Equals(chapterCode));

            if(chapter == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter);
            }

            short nextPartNumber = GetNextPartNumber(chapterCode);

            foreach (var part in parts){
                part.LSPNUMBER = nextPartNumber;

                chapter.LessonParts.Add(part);
                nextPartNumber++;
            }       

            Context.SaveChanges();
        }

        public LessonPart AddOrUpdate(LessonPart lessonPart)
        {
            var part = Context.LessonParts.FirstOrDefault(c => c.LSCCODE.Equals(lessonPart) && c.LSPNUMBER.Equals(lessonPart.LSPNUMBER));

            if(part is null)
            {
                Add(lessonPart);
                return lessonPart;
            }

            part.LSPTITLE = lessonPart.LSPTITLE;
            part.LSPCONTENT = lessonPart.LSPCONTENT;

            Save(part);

            return part;
        }

        public List<LessonPart> UpdateRange(Guid chapterCode, IEnumerable<LessonPart> parts)
        {  
            var chapter = Context.LessonChapters.FirstOrDefault(c => c.LSCCODE.Equals(chapterCode));

            if (chapter is null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter);
            }

            Context.Database.ExecuteSqlCommand("Delete LessonPart where LSCCODE = {0}", new object[] { chapterCode });

            short partNumber = 1;

            foreach(var part in parts)
            {
                part.LSPNUMBER = partNumber;
                chapter.LessonParts.Add(part);

                partNumber++;
            }

            Context.SaveChanges();

            return chapter.LessonParts.ToList();
        }
    }
}