using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.CommentAnswer
{
    public class GetAllCommentAnswerResponse: Response
    {
        public List<Domain.Entity.CommentAnswer.CommentAnswer> CommentAnswers { get; set; }
    }
}
