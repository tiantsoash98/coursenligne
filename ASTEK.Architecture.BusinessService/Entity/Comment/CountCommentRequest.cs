using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Comment
{
    public class CountCommentRequest: Request
    {
        public Guid LessonId { get; set; }
    }
}
