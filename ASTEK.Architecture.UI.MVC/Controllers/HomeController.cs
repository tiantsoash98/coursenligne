using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.ApplicationService.Entity.LessonFollowed;
using ASTEK.Architecture.UI.MVC.Models.Home;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [RequireHttps]
    [Authorize]
    public class HomeController : BaseController
    {
        [AllowAnonymous]
        public ActionResult Index(int? recentPage)
        {
            int _recentPage = recentPage ?? 1;

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToUserRoleHomePage(GetUserLoggedRole());
            }

            var lessonAppService = new LessonAppService();

            var mayLikeInput = new GetLessonMayLikeInputModel
            {
                Page = 1,
                Count = 12,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };
        
            var mayLikeOutput = lessonAppService.GetMayLike(mayLikeInput);

            if (!mayLikeOutput.Response.Success)
            {
                ViewBag.Exception = mayLikeOutput.Response.Exception;
                return View("Error");
            }

            var recentsInput = new GetLessonRecentInputModel
            {
                Page = _recentPage,
                Count = 6,
            };

            var recentOutput = lessonAppService.GetLessonRecent(recentsInput);

            if (!recentOutput.Response.Success)
            {
                ViewBag.Exception = recentOutput.Response.Exception;
                return View("Error");
            }

            var homeVM = new HomeViewModel
            {
                MayLike = mayLikeOutput.Response.Lessons,
                Recents = recentOutput.Response.Lessons,
                TotalRecentsPage = recentOutput.Response.TotalPages,
                RecentPage = _recentPage
            };
            
            return View(homeVM);
        }

        [Authorize]
        public ActionResult Lessons(int? recentPage)
        {
            int _recentPage = recentPage ?? 1;

            var accountLogged = GetAccountLogged();

            var mayLikeInput = new GetLessonMayLikeInputModel
            {
                Page = 1,
                Count = 16,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var lessonAppService = new LessonAppService();
            var mayLikeOutput = lessonAppService.GetMayLike(mayLikeInput);

            var followedAppService = new LessonFollowedAppService();
            var followedInputModel = new GetFollowedByWithStateInputModel
            {
                AccountId = accountLogged.Id.ToString(),
                State = "STARTED",
                Page = 1,
                Count = 8,              
            };

            var followedOutputModel = followedAppService.GetFollowedWithStateCode(followedInputModel);

            if (!followedOutputModel.Response.Success)
            {
                ViewBag.Exception = followedOutputModel.Response.Exception;
                return View("Error");
            }

            var recentsInput = new GetLessonRecentInputModel
            {
                Page = _recentPage,
                Count = 6,
            };

            var recentOutput = lessonAppService.GetLessonRecent(recentsInput);

            if (!recentOutput.Response.Success)
            {
                ViewBag.Exception = recentOutput.Response.Exception;
                return View("Error");
            }

            var homeVM = new HomeStudentViewModel
            {
                MayLike = mayLikeOutput.Response.Lessons,
                LessonsFollowed = followedOutputModel.Response.Followed,
                Recents = recentOutput.Response.Lessons,
                TotalRecentsPage = recentOutput.Response.TotalPages,
                RecentPage = _recentPage
            };

            return View(homeVM);
        }

        //[Authorize(Roles = "TEACHER")]
        //public ActionResult Teacher()
        //{
        //    var mayLikeInput = new GetLessonMayLikeInputModel()
        //    {
        //        Page = 1,
        //        Count = 16,
        //        GetAlternativePicture = true,
        //        GetThumbnailPicture = true
        //    };

        //    var lessonAppService = new LessonAppService();
        //    var mayLikeOutput = lessonAppService.GetMayLike(mayLikeInput);

        //    var homeVM = new HomeTeacherViewModel()
        //    {
        //        MayLike = mayLikeOutput.Response.Lessons
        //    };

        //    return View(homeVM);
        //}
    }
}