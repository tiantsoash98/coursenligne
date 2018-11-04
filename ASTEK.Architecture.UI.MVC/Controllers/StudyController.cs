using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.ApplicationService.Entity.Study;
using ASTEK.Architecture.UI.MVC.Models.Study;
using System.Web.Mvc;
using System.Linq;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    public class StudyController : BaseController
    {
        // GET: Study
        public ActionResult Index(string id, int? page, int? recentPage)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }

            int _page = page ?? 1;
            int _recentPage = recentPage ?? 1;
          
            
            var studyAppService = new StudyAppService();
            var studyOutput = studyAppService.Get(new GetStudyInputModel() { Code = id, Culture = CurrentCultureCode });

            if (!studyOutput.Response.Success)
            {
                return StudyNotFound(id, studyOutput.Response.Exception);
            }

            var account = GetAccountLogged();
            int? _level = account.AccountStudents?.FirstOrDefault()?.ACSLEVEL;

            var lessonAppService = new LessonAppService();

            var bestInput = new GetBestLessonByStudyInputModel
            {
                StudyCode = id,
                Page = _page,
                Count = 8,
                GetAlternativePicture = true,
                GetThumbnailPicture = true,
                Level = _level.GetValueOrDefault()
            };

            
            var bestOutput = lessonAppService.GetBestByStudy(bestInput);

            var recentsInput = new GetLessonRecentInputModel
            {
                Page = _recentPage,
                Count = 6,
                StudyCode = id,
                Level = _level.GetValueOrDefault()
            };

            var recentOutput = lessonAppService.GetLessonRecent(recentsInput);

            if (!recentOutput.Response.Success)
            {
                ViewBag.Exception = recentOutput.Response.Exception;
                return View("Error");
            }

            var studyVM = new StudyViewModel
            {
                Id = id,
                Study = studyOutput.Response.Study,
                Page = _page,
                BestLessons = bestOutput.Response.Lessons,
                RecentLessons = recentOutput.Response.Lessons,
                TotalPage = bestOutput.Response.TotalPages,
                TotalRecentsPage = recentOutput.Response.TotalPages,
                RecentPage = _recentPage
            };

            return View(studyVM);
        }

        [AllowAnonymous]
        public PartialViewResult StudyName(string code)
        {
            var studyAppService = new StudyAppService();
            var studyOutput = studyAppService.Get(new GetStudyInputModel() { Code = code, Culture = CurrentCultureCode });

            return PartialView("_StudyName", studyOutput.Response.Study.STDNAME);
        }
    }
}