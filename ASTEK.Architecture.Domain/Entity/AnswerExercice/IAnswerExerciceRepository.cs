using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.AnswerExercice
{
    public interface IAnswerExerciceRepository: IRepository<AnswerExercice, Guid>
    {
        AnswerExercice Upload(AnswerExercice answer);
    }
}
