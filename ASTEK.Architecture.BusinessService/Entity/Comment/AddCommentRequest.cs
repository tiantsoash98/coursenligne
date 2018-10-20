using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Comment
{
    public class AddCommentRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid LessonId { get; set; }
        public string Content { get; set; }
    }
}
