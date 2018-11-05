using ASTEK.Architecture.ApplicationService.Entity.Account;
using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;
using ASTEK.Architecture.Domain.Entity.AnswerExercice;
using ASTEK.Architecture.Infrastructure.Utility;
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
        public ActionResult Index(string accountId, string studyCode, int? level)
        {
            var accountInput = new GetAllInformationsAccountInputModel
            {
                AccountId = accountId
            };

            var accountOutput = new AccountAppService().GetAllInformations(accountInput);

            if (!accountOutput.Response.Success)
            {
                ViewBag.Exception = accountOutput.Response.Exception;
                return View("Error");
            }

            var account = accountOutput.Response.Account;

            if (string.IsNullOrEmpty(studyCode))
            {
                studyCode = account.AccountStudents?.FirstOrDefault()?.STDCODE.ToString();

                if (string.IsNullOrEmpty(studyCode))
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }

            int? _level = level ?? account.AccountStudents?.FirstOrDefault()?.ACSLEVEL;

            var answerAppService = new AnswerExerciceAppService();

            var marksInput = new GetMarksOfStudentInputModel
            {
                AccountId = accountId,
                StudyCode = studyCode,
                Level = _level ?? 1
            };

            var marksOutput = answerAppService.GetMarksOfStudent(marksInput);

            if (!marksOutput.Response.Success)
            {
                ViewBag.Exception = marksOutput.Response.Exception;
                return View("Error");
            }

            decimal average = marksOutput.Response.MarksList.Average(a => a.ANSMARK).GetValueOrDefault();
            AnswerExercice highest = marksOutput.Response.MarksList.OrderByDescending(a => a.ANSMARK).FirstOrDefault();
            AnswerExercice lowest = marksOutput.Response.MarksList.OrderBy(a => a.ANSMARK).FirstOrDefault();

            decimal? prev = null;

            if (_level.HasValue && _level.Value > 1)
            {
                var marksInputPrev = new GetMarksOfStudentInputModel
                {
                    AccountId = accountId,
                    StudyCode = studyCode,
                    Level = _level.Value - 1
                };

                var marksOutputPrev = answerAppService.GetMarksOfStudent(marksInputPrev);

                if (!marksOutputPrev.Response.Success)
                {
                    ViewBag.Exception = marksOutputPrev.Response.Exception;
                    return View("Error");
                }

                decimal? _prev = marksOutputPrev.Response.MarksList.Average(a => a.ANSMARK).GetValueOrDefault();


                if(_prev.HasValue && _prev.Value != 0)
                {
                    prev = _prev;
                }
            }
           

            var statsVM = new StatsIndexViewModel
            {
                StudyCode = studyCode,
                Marks = marksOutput.Response.MarksList,
                Account = account,
                Average = average,
                Highest = highest,
                Lowest = lowest,
                Level = _level,
                PreviousAverage = prev
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
                return Json(new { success = false, exception = marksOutput.Response.Exception }, JsonRequestBehavior.AllowGet);
            }

            List<string> labels = marksOutput.Response.MarksList.Select(x => StringUtilities.LimitTextLength(x.Lesson.LSNTITLE, 60)).ToList();
            List<decimal> data = marksOutput.Response.MarksList.Select(x => x.ANSMARK.GetValueOrDefault()).ToList();

            List<DataSets> datasets = new List<DataSets>();
            datasets.Add(new DataSets
            {
                data = data,
                label = "Note",
                fill = false,
                borderColor = "#3e95cd"
            });

            var statsVM = new StatsMarksStudentJsonViewModel
            {
                datasets = datasets,
                labels = labels
            };

            return Json(statsVM, JsonRequestBehavior.AllowGet);
        }
    }
}