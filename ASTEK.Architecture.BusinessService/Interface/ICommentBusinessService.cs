using ASTEK.Architecture.BusinessService.Entity.Comment;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ICommentBusinessService
    {
        AddCommentResponse Add(AddCommentRequest request);
    }
}
