using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.AnswerExercice
{
    public interface IAnswerExerciceRepository: IRepository<AnswerExercice, Guid>
    {
        AnswerExercice Upload(AnswerExercice answer);
        List<AnswerExercice> GetAllUnmarkedTeacher(Guid accountId, Guid? lessonId);
        List<AnswerExercice> GetAllMarkedTeacher(Guid accountId, Guid? lessonId);
        List<AnswerExercice> GetAllUnmarkedStudent(Guid accountId);
        List<AnswerExercice> GetAllMarkedStudent(Guid accountId);
        bool HasPosted(Guid accountId, Guid lessonId);
    }
}
