using ASTEK.Architecture.BusinessService.Entity.CommentAnswer;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ICommentAnswerBusinessService
    {
        AddCommentAnswerResponse Add(AddCommentAnswerRequest request);
        GetAllCommentAnswerResponse GetAll(GetAllCommentAnswerRequest request);
    }
}
