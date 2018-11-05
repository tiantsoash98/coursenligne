using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class HasPostedRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid LessonId { get; set; }
    }
}
