using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.LessonPart
{
    public interface ILessonPartRepository: IRepository<LessonPart, Guid>
    {
        void AddWithoutSaving(LessonPart lessonPart);
        void AddAll(Guid chapterCode, IEnumerable<LessonPart> parts);
        short GetNextPartNumber(Guid chapterCode);
        LessonPart FindByNumber(Guid lessonId, short chapterNumber, short number);
        int Count(Guid chapterCode);
        LessonPart AddOrUpdate(LessonPart lessonPart);
        List<LessonPart> UpdateRange(Guid chapterCode, IEnumerable<LessonPart> parts);
    }
}
