﻿using ASTEK.Architecture.ApplicationService.Entity.Lesson;
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
            var followedInputModel = new GetFollowedByWithStateCodeInputModel
            {
                AccountId = accountLogged.Id.ToString(),
                StateCode = "7ABD2A4E-52B7-E811-8225-2C600C6934BE",
                Page = 1,
                Count = 8,              
            };

            var followedOutputModel = followedAppService.GetFollowedWithStateCode(followedInputModel);

            if (!followedOutputModel.Response.Success)
            {
                ViewBag.Exception = followedOutputModel.Response.Exception;
                return View("Error");
            }

            var homeVM = new HomeStudentViewModel()
            {
                MayLike = mayLikeOutput.Response.Lessons,
                LessonsFollowed = followedOutputModel.Response.Followed
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