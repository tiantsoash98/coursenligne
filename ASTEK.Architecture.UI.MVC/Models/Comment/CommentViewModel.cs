using ASTEK.Architecture.ApplicationService.Entity.CommentAnswer;
using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Comment
{
    public class CommentViewModel: BaseViewModel
    {
        public Domain.Entity.Comment.Comment Comment { get; set; }
        public List<Domain.Entity.CommentAnswer.CommentAnswer> Answers { get; set; }
        public AddCommentAnswerInputModel AnswerInput { get; set; }
        public string LessonId { get; set; }
    }
}