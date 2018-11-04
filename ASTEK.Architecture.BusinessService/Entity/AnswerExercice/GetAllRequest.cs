using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class GetAllRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid? LessonId { get; set; }
        public string Type { get; set; }
        public bool Marked { get; set; }
    }
}
