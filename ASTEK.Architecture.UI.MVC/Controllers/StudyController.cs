using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.ApplicationService.Entity.Study;
using ASTEK.Architecture.UI.MVC.Models.Study;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    public class StudyController : BaseController
    {
        // GET: Study
        public ActionResult Index(string id, int? page)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }

            int _page = page ?? 1;
          
            var bestInput = new GetBestLessonByStudyInputModel()
            {
                StudyCode = id,
                Page = 1,
                Count = _page * 8,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var studyAppService = new StudyAppService();
            var studyOutput = studyAppService.Get(new GetStudyInputModel() { Code = id, Culture = CurrentCultureCode });

            if (!studyOutput.Response.Success)
            {
                return StudyNotFound(id, studyOutput.Response.Exception);
            }

            var lessonAppService = new LessonAppService();
            var bestOutput = lessonAppService.GetBestByStudy(bestInput);

            var studyVM = new StudyViewModel()
            {
                Id = id,
                Study = studyOutput.Response.Study,
                Page = _page,
                BestLessons = bestOutput.Response.Lessons
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