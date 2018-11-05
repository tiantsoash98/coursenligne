using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;
using ASTEK.Architecture.UI.MVC.Models.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [Authorize]
    public class StatsController : BaseController
    {
        public ActionResult Index(string accountId, string studyCode,  int? level)
        {
            var statsVM = new StatsIndexViewModel
            {
                StudyCode = studyCode
                
            };

            return View(statsVM);
        }

        public JsonResult StudentMarks(string accountId, string studyCode, int level)
        {
            var answerAppService = new AnswerExerciceAppService();

            var marksInput = new GetMarksOfStudentInputModel
            {
                AccountId = accountId,
                StudyCode = studyCode,
                Level = level
            };

            var marksOutput = answerAppService.GetMarksOfStudent(marksInput);

            if (!marksOutput.Response.Success)
            {
                return Json(new { success = false, exception = marksOutput.Response.Exception });
            }

            List<StatsMarkStudent> marks = marksOutput.Response.MarksList.Select(x => new StatsMarkStudent
            {
                LessonTitle = x.Lesson.LSNTITLE,
                Mark = x.ANSMARK.GetValueOrDefault()
            }).ToList();


            var statsVM = new StatsMarksStudentJsonViewModel
            {
                Marks = marks
            };

            return Json(statsVM);
        }
    }
}