using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Domain.Entity.LessonFollowed
{
    public interface ILessonFollowedRepository: IRepository<LessonFollowed, Guid>
    {
        List<LessonFollowed> GetByLesson(Guid lessonId);
        int CountByLesson(Guid lessonId);
        int CountByLesson(Guid lessonId, DateTime fromDate, DateTime toDate);
        int CountTotalViewsOfAccount(Guid accountId);
        int CountTotalViewsOfAccount(Guid accountId, DateTime fromDate, DateTime toDate);
        void Follow(Guid accountId, Guid lessonId);
        void Follow(Guid accountId, Guid lessonId, short chapterNumber, short? partNumber);
        void FinishPart(Guid accountId, Guid lessonId, short chapterNumber, short? partNumber);
        void FinishLesson(Guid accountId, Guid lessonId, short? chapterNumber, short? partNumber);
        List<LessonFollowed> GetFollowedBy(Guid accountId);
        List<LessonFollowed> GetFollowedBy(Guid accountId, string state);
    }
}
