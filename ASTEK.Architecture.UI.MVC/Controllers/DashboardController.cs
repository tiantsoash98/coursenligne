using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.ApplicationService.Entity.LessonFollowed;
using ASTEK.Architecture.Domain.Entity.LessonFollowed;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.UI.MVC.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return RedirectToUserRoleDashboardPage(GetUserLoggedRole());
        }

        public ActionResult Student(int? page)
        {
            int _page = page ?? 1;

            var loggedId = GetAccountLogged().Id;

            DateTime toDate = DateTime.Now;
            DateTime fromDate = DateTimeUtilities.GetMondayOfWeekFrom(DateTime.Now.Date);

            var followedAppService = new LessonFollowedAppService();

            var followedInput = new GetFollowedByInputModel
            {
                AccountId = loggedId.ToString(),
                Page = _page,
                Count = 8
            };

            var followedOutput = followedAppService.GetFollowedBy(followedInput);

            var countFollowedInput = new CountByAccountInputModel
            {
                AccountId = loggedId.ToString()
            };

            var lessonFollowedAppService = new LessonFollowedAppService();
            var countFollowedOutput = lessonFollowedAppService.CountByAccount(countFollowedInput);


            var dashboardVM = new DashboardStudentViewModel
            {
                FollowedOutput = followedOutput,
                Page = _page,
                FollowedCount = (int)countFollowedOutput.Response.Count,
                FromDate = fromDate,
                ToDate = toDate
            };

            return View(dashboardVM);
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Teacher(int? page, int? unpublishedPage)
        {
            int _page = page ?? 1;
            int _unpublishedPage = unpublishedPage ?? 1;

            var loggedId = GetAccountLogged().Id;

            DateTime toDate = DateTime.Now;
            DateTime fromDate = DateTimeUtilities.GetMondayOfWeekFrom(DateTime.Now.Date);

            var lessonAppService = new LessonAppService();

            var postedInput = new GetLessonByStateInputModel
            {
                AccountId = loggedId.ToString(),
                State = "VALID",
                Page = _page,
                Count = 8
            };

            var postedOutput = lessonAppService.GetByState(postedInput);

            var countPostedInput = new CountLessonPostedByInputModel
            {
                AccountId = loggedId.ToString()
            };

            var countPostedOutput = lessonAppService.CountPostedBy(countPostedInput);

            var lessonFollowedAppService = new LessonFollowedAppService();

            var totalViewInput = new CountTotalViewsOfAccountInputModel
            {
                AccountId = loggedId.ToString(),
            };

            var totalViewsOutput = lessonFollowedAppService.CountTotalViewsOfAccount(totalViewInput);

            var unpublishedInput = new GetLessonByStateInputModel
            {
                AccountId = loggedId.ToString(),
                State = "WRITING",
                Page = _unpublishedPage,
                Count = 8
            };

            var unpublishedOutput = lessonAppService.GetByState(unpublishedInput);


            var dashboardVM = new DashboardTeacherViewModel
            {
                Page = _page,
                UnpublishedPage = _unpublishedPage,
                PostedOutput = postedOutput,
                PostedCount = (int)countPostedOutput.Response.Count,
                TotalViewCount = (int)totalViewsOutput.Response.Count,
                UnpublishedOutput = unpublishedOutput,
                FromDate = fromDate,
                ToDate = toDate,
            };

            return View(dashboardVM);
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Publish(string lessonId)
        {
            var accountId = GetAccountLogged().Id;

            var input = new PublishLessonInputModel
            {
                AccountId = accountId.ToString(),
                LessonId = lessonId
            };

            var service = new LessonAppService();
            var output = service.Publish(input);

            if (!output.Response.Success)
            {
                ViewBag.Exception = output.Response.Exception;
                return View("Error");
            }

            return RedirectToAction("Teacher");
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult ExportExcelStudentProgression(string lessonId)
        {
            if (string.IsNullOrEmpty(lessonId))
            {
                return RedirectToAction("Index");
            }

            var appService = new LessonAppService();

            GetLessonOutputModel output = appService.Get(new GetLessonInputModel
            {
                Id = lessonId
            });

            if (!output.Response.Success)
            {
                return LessonNotFound(lessonId, output.Response.Exception);
            }

            var lesson = output.Response.Lesson;

            List<FollowerProgressionViewModel> followersVM = GetListFollowersProgressionViewModel(lessonId);

            var gv = new GridView();
            gv.DataSource = followersVM.Select(x => new{
                                                    x.Name,
                                                    Chapter = x.Follower.LSFCHAPTER,
                                                    Part = x.Follower.LSFPART,
                                                    Progression = x.Progression + "%",
                                                    Date = x.Follower.LSFDATE
                                                });

            gv.DataBind();

            string fileName = string.Concat(lesson.LSNTITLE, "-progr", DateTime.Today.ToString("jjMMyyyy"), ".xls");

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";

            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);

            gv.RenderControl(objHtmlTextWriter);
            Response.Output.Write(objStringWriter.ToString());

            Response.Flush();
            Response.End();

            return View("Index");
        }

        public PartialViewResult StudentsProgression(string lessonId)
        {
            List<FollowerProgressionViewModel> followersVM = GetListFollowersProgressionViewModel(lessonId);

            var progressionVM = new StudentsProgressionViewModel
            {
                LessonId = lessonId,
                //Navigation = output.Response.Navigation,
                Followers = followersVM
            };

            return PartialView("_StudentsProgressionModal", progressionVM);
        }

        private string GetName(LessonFollowed follow)
        {
            if (follow.Account.AccountStudents.Any())
            {
                var account = follow.Account.AccountStudents.FirstOrDefault();
                return StringUtilities.UserName(account.ACSFIRSTNAME, account.ACSNAME);
            }

            if (follow.Account.AccountTeachers.Any())
            {
                var account = follow.Account.AccountTeachers.FirstOrDefault();
                return StringUtilities.UserName(account.ACTFIRSTNAME, account.ACTFIRSTNAME);
            }

            return "Anonyme";
        }

        private List<FollowerProgressionViewModel> GetListFollowersProgressionViewModel(string lessonId)
        {
            var service = new LessonAppService();
            var input = new GetLessonNavigationInputModel
            {
                LessonId = lessonId
            };

            var output = service.GetNavigation(input);

            var lessonFollowedService = new LessonFollowedAppService();
            var followersInput = new GetByLessonInputModel
            {
                LessonId = lessonId
            };

            var followersOutput = lessonFollowedService.GetByLesson(followersInput);

            List<FollowerProgressionViewModel> followersVM = new List<FollowerProgressionViewModel>();

            followersOutput.Response.Followers.ForEach(follower =>
            {
                followersVM.Add(new FollowerProgressionViewModel
                {
                    Follower = follower,
                    Name = GetName(follower),
                    Progression = output.Response.Navigation.GetProgression(follower.LSFCHAPTER.Value, follower.LSFPART)
                });
            });

            return followersVM;
        }
    }
}