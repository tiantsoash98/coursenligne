using ASTEK.Architecture.Domain.Entity.Lesson;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.Navigation;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFLessonRepository : EFRepository<Lesson, Guid>, ILessonRepository
    {
        public EFLessonRepository(IUnitOfWork uow)
            : base(uow)
        {
            Context.Lessons
                .Include(lesson => lesson.Account)
                .ToList();

            Context.Lessons
                .Include(lesson => lesson.Account.AccountTeachers)
                .ToList();

            Context.Lessons
                .Include(lesson => lesson.Study)
                .ToList();
        }

        public new void Add(Lesson entity)
        {
            var writingState = Context.DocumentStates.FirstOrDefault(state => state.DCSWORDING.Equals("WRITING"));

            if(writingState == null)
            {
                throw new InvalidOperationException();
            }

            entity.DCSCODE = writingState.DCSCODE;
            base.Add(entity);
        }

        public Lesson GetAllContent(Guid lessonId)
        {
            Context.Lessons
                    .Include(lesson => lesson.LessonChapters)
                    .ToList();

            Context.Lessons
                    .Include(lesson => lesson.LessonChapters
                        .Select(chapter => chapter.LessonParts))
                        .ToList();

            return Context.Lessons.FirstOrDefault(l => l.Id.Equals(lessonId));
        }

        public List<Lesson> GetBestByStudy(Guid studyCode, int level = 0)
        {
            var lessons =  Context.Lessons
                                //.Include(l => l.LessonFolloweds)
                                .Where(l => l.STDCODE.Equals(studyCode) && l.DocumentState.DCSWORDING.Equals("VALID"))
                                //.OrderBy(l => l.LessonFolloweds.Count(x => x.LSNID.Equals(l.LSNID)))
                                .ToList();

            if(level != 0)
            {
                lessons = lessons.PreferLevel(level);
            }

            return lessons;
        }

        public int GetChapterCount(Guid lessonId)
        {
            var lesson = Context.Lessons.First(e => e.Id.Equals(lessonId));

            // If the entity was not found then throw exception
            if (lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            return GetChapterCount(lesson);
        }

        public int GetChapterCount(Lesson lesson)
        {
            // Count the chapters associated
            return Context.Entry(lesson)
                                    .Collection(b => b.LessonChapters)
                                    .Query()
                                    .Count();
        }

        public int GetExerciceCount(Guid lessonId)
        {
            var lesson = Context.Lessons.First(e => e.Id.Equals(lessonId));

            // If the entity was not found then throw exception
            if (lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            return GetExerciceCount(lesson);
        }

        public int GetExerciceCount(Lesson lesson)
        {
            // Count the chapters associated
            return Context.Entry(lesson)
                                    .Collection(b => b.Exercices)
                                    .Query()
                                    .Count();
        }

        public LessonNavigation GetLessonNavigation(Guid lessonId)
        {

            List<ChapterNavigation> chapters =
                Context.LessonChapters
                        .Where(c => c.LSNID.Equals(lessonId))
                        .Select(c => new ChapterNavigation
                        {
                            Title = c.LSCTITLE,
                            Number = c.LSCNUMBER,
                            Parts = c.LessonParts
                                            .Select(p => new PartNavigation
                                            {
                                                Number = p.LSPNUMBER,
                                                Title = p.LSPTITLE
                                            })
                                            .OrderBy(p => p.Number)
                                            .ToList()
                        })
                        .OrderBy(c => c.Number)
                        .ToList();

            return new LessonNavigation
            {
                LessonId = lessonId,
                Chapters = chapters
            };
        }

        public List<Lesson> GetMayLike(int level = 0)
        {
            var lessons = Context.Lessons.Where(l => l.DocumentState.DCSWORDING.Equals("VALID"))
                                    .ToList();

            if (level != 0)
            {
                lessons = lessons.PreferLevel(level);
            }

            return lessons;
        }

        public List<Lesson> GetByState(Guid accountId, string state)
        {
            return Context.Lessons.Where(l => l.ACCID.Equals(accountId) && l.DocumentState.DCSWORDING.Equals(state))
                                    .ToList();
        }

        public async Task<List<Lesson>> SearchAsync(string query)
        {
            return await Context.Lessons.Where(l => l.LSNTITLE.ToLower().Contains(query.ToLower()) && l.DocumentState.DCSWORDING.Equals("VALID"))
                                    .ToListAsync();
        }

        public void Publish(Guid accountId, Guid lessonId)
        {
            var lesson = Context.Lessons.FirstOrDefault(l => l.Id.Equals(lessonId));

            if(lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            if(lesson.ACCID != accountId)
            {
                throw new InvalidOperationException();
            }

            var state = Context.DocumentStates.FirstOrDefault(s => s.DCSWORDING.Equals("VALID"));

            if(state == null)
            {
                throw new InvalidOperationException();
            }

            lesson.DCSCODE = state.DCSCODE;

            Save(lesson);
        }

        public Lesson Update(Guid lessonId, Lesson entity)
        {
            var lesson = Context.Lessons.FirstOrDefault(m => m.Id.Equals(lessonId));

            if(lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            lesson.LSNTITLE = entity.LSNTITLE;
            lesson.LSNDESCRIPTION = entity.LSNDESCRIPTION;
            lesson.LSNTARGET = entity.LSNTARGET;
            lesson.STDCODE = entity.STDCODE;
            lesson.DCFCODE = entity.DCFCODE;
            lesson.LSNDURATION = entity.LSNDURATION;
            lesson.LSNLEVEL = entity.LSNLEVEL;
            
            Save(lesson);

            return lesson;
        }

        public Lesson Delete(Guid accountId, Guid lessonId)
        {
            var lesson = Context.Lessons.FirstOrDefault(l => l.Id.Equals(lessonId));

            if (lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            if (lesson.ACCID != accountId)
            {
                throw new InvalidOperationException();
            }

            var state = Context.DocumentStates.FirstOrDefault(s => s.DCSWORDING.Equals("DELETED"));

            if (state == null)
            {
                throw new InvalidOperationException();
            }

            lesson.DCSCODE = state.DCSCODE;

            Save(lesson);

            return lesson;
        }

        public List<Lesson> GetAllRecent(Guid? studyCode, int level = 0)
        {
            var lessons = Context.Lessons
                                    .Where(l => l.DocumentState.DCSWORDING.Equals("VALID"))
                                    .OrderByDescending(l => l.LSNDATE).ToList();

            if (studyCode.HasValue)
            {
                lessons = lessons.Where(l => l.STDCODE.Equals(studyCode.Value)).ToList();
            }

            if(level != 0)
            {
                lessons = lessons.PreferLevel(level);
            }

            return lessons;
        }

        public List<Lesson> GetMayLike(Guid studyCode, int level = 0)
        {
            var lessons = Context.Lessons.Where(l => l.DocumentState.DCSWORDING.Equals("VALID"))
                                    .ToList();

            if (level != 0)
            {
                lessons = lessons.PreferLevel(studyCode, level);
            }
            else
            {
                lessons = lessons.PreferLevel(studyCode);
            }
            

            return lessons;
        }
    }
}
