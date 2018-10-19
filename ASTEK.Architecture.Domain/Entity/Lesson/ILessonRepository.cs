using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Navigation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Domain.Entity.Lesson
{
    public interface ILessonRepository: IRepository<Lesson, Guid>
    {
        Lesson Delete(Guid accountId, Guid lessonId);
        List<Lesson> GetBestByStudy(Guid studyCode);
        int GetChapterCount(Guid lessonId);
        int GetChapterCount(Lesson lesson);
        int GetExerciceCount(Guid lessonId);
        int GetExerciceCount(Lesson lesson);
        Lesson GetAllContent(Guid lessonId);
        LessonNavigation GetLessonNavigation(Guid lessonId);
        List<Lesson> GetMayLike();
        List<Lesson> GetByState(Guid accountId, string state);
        void Publish(Guid accountId, Guid lessonId);   
        Task<List<Lesson>> SearchAsync(string query);
        Lesson Update(Guid lessonId, Lesson entity);
    }
}
