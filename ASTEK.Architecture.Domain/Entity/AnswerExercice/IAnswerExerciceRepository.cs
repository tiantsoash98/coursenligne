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
        int CountUnmarkedTeacher(Guid accountId, Guid? lessonId);
        int CountMarkedTeacher(Guid accountId, Guid? lessonId);
        int CountUnmarkedStudent(Guid accountId);
        int CountMarkedStudent(Guid accountId);
        AnswerExercice GetLowestMarkOfStudent(Guid accountId, Guid studyCode, int level);
        AnswerExercice GetHighestMarkOfStudent(Guid accountId, Guid studyCode, int level);
        decimal GetAverageMarkOfStudent(Guid accountId, Guid studyCode, int level);
        List<AnswerExercice> GetMarksOfStudent(Guid accountId, Guid studyCode, int level);
    }
}
