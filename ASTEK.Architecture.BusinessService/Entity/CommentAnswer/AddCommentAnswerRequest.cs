using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.CommentAnswer
{
    public class AddCommentAnswerRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid CommentId { get; set; }
        public string Content { get; set; }
    }
}
