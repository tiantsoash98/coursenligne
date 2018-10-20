using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Comment
{
    public class ListCommentViewModel: BaseViewModel
    {
        public List<CommentViewModel> Comments { get; set; }
    }
}