using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Comment
{
    public class GetAllCommentRequest: Request
    {
        public Guid LessonId { get; set; }
        public bool LoadAnswers { get; set; }
    }
}
