using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Comment
{
    public class GetAllCommentResponse: Response
    {
        public List<Domain.Entity.Comment.Comment> Comments { get; set; }
    }
}
