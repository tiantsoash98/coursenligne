using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.CommentAnswer
{
    public class GetAllCommentAnswerRequest: Request
    {
        public Guid CommentId { get; set; }
    }
}
