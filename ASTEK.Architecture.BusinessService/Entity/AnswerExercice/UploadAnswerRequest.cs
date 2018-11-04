using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class UploadAnswerRequest: Request
    {
        public string FileName { get; set; }
        public Guid AccountId { get; set; }
        public Guid LessonId { get; set; }
        public string Comment { get; set; }
    }
}
