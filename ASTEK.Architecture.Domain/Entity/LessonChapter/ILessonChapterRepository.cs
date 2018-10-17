using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.LessonChapter
{
    public interface ILessonChapterRepository: IRepository<LessonChapter, Guid>
    {
        short GetNextChapterNumber(Guid lessonId);
        LessonChapter GetByNumber(Guid lessonId, short number, bool loadChildren = false);
        string GetChapterTitle(Guid lessonId, short number);
        int Count(Guid lessonId);
        LessonChapter Update(LessonChapter entity);
    }
}
