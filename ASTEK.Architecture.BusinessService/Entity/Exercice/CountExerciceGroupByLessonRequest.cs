using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Exercice
{
    public class CountExerciceGroupByLessonRequest: Request
    {
        public Guid LessonId { get; set; }
    }
}