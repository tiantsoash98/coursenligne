using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.UI.MVC.Models.Home;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [RequireHttps]
    [Authorize]
    public class HomeController : BaseController
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToUserRoleHomePage(GetUserLoggedRole());
            }

            var mayLikeInput = new GetLessonMayLikeInputModel()
            {
                Page = 1,
                Count = 16,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var lessonAppService = new LessonAppService();
            var mayLikeOutput = lessonAppService.GetMayLike(mayLikeInput);

            var homeVM = new HomeViewModel()
            {
                MayLike = mayLikeOutput.Response.Lessons
            };
            
            return View(homeVM);
        }

        [Authorize(Roles = "STUDENT")]
        public ActionResult Student()
        {
            var mayLikeInput = new GetLessonMayLikeInputModel()
            {
                Page = 1,
                Count = 16,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var lessonAppService = new LessonAppService();
            var mayLikeOutput = lessonAppService.GetMayLike(mayLikeInput);

            var homeVM = new HomeStudentViewModel()
            {
                MayLike = mayLikeOutput.Response.Lessons
            };

            return View(homeVM);
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Teacher()
        {
            var mayLikeInput = new GetLessonMayLikeInputModel()
            {
                Page = 1,
                Count = 16,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var lessonAppService = new LessonAppService();
            var mayLikeOutput = lessonAppService.GetMayLike(mayLikeInput);

            var homeVM = new HomeTeacherViewModel()
            {
                MayLike = mayLikeOutput.Response.Lessons
            };

            return View(homeVM);
        }
    }
}