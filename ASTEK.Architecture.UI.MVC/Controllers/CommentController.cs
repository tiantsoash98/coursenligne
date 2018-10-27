using ASTEK.Architecture.ApplicationService.Entity.Comment;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{

    public class CommentController : BaseController
    {
        // GET: Comment
        [AllowAnonymous]
        public PartialViewResult Count(string lessonId)
        {
            var service = new CommentAppService();

            var input = new CountCommentInputModel
            {
                LessonId = lessonId
            };

            var output = service.Count(input);

            return PartialView("_CountResult", output.Response.Count);
        }
    }
}