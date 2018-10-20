using ASTEK.Architecture.ApplicationService.Entity.Comment;

namespace ASTEK.Architecture.UI.MVC.Models.Comment
{
    public class CommentSectionViewModel: BaseViewModel
    {
        public AddCommentInputModel AddCommentInput { get; set; }
        public ListCommentViewModel Comments { get; set; }
        public string LessonId { get; set; }
    }
}