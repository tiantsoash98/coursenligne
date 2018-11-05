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
using ASTEK.Architecture.ApplicationService.Entity.SubscribeActivity;
using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;

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

        public ActionResult Student(int? page, int? subscribedPage, int? unmarkedPage, int? markedPage)
        {
            int _page = page ?? 1;
            int _subscribedPage = subscribedPage ?? 1;
            int _unmarkedPage = unmarkedPage ?? 1;
            int _markedPage = markedPage ?? 1;

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

            var subscribeAppService = new SubscribeActivityAppService();

            var subscribedInput = new GetAllSubscribedInputModel
            {
                AccountId = loggedId.ToString(),
                Page = _subscribedPage,
                Count = 8
            };

            var subscribedOutput = subscribeAppService.GetAllSubscribed(subscribedInput);

            var answerExerciceAppService = new AnswerExerciceAppService();

            var unmarkedInput = new GetAllInputModel
            {
                AccountId = loggedId.ToString(),
                Marked = false,
                Page = _unmarkedPage,
                Count = 8,
                Type = "Student"
            };

            var unmarkedOutput = answerExerciceAppService.GetAll(unmarkedInput);

            if (!unmarkedOutput.Response.Success)
            {
                ViewBag.Exception = unmarkedOutput.Response.Exception;
                return View("Error");
            }

            var markedInput = new GetAllInputModel
            {
                AccountId = loggedId.ToString(),
                Marked = true,
                Page = _markedPage,
                Count = 8,
                Type = "Student"
            };

            var markedOutput = answerExerciceAppService.GetAll(markedInput);

            if (!markedOutput.Response.Success)
            {
                ViewBag.Exception = markedOutput.Response.Exception;
                return View("Error");
            }

            var countUnmarkedInput = new CountAnswerInputModel
            {
                AccountId = loggedId.ToString(),
                Marked = false,
                Type = "Student"
            };

            var countUnmarkedOutput = answerExerciceAppService.CountAnswer(countUnmarkedInput);

            var dashboardVM = new DashboardStudentViewModel
            {
                FollowedOutput = followedOutput,
                Page = _page,
                FollowedCount = (int)countFollowedOutput.Response.Count,
                SubscribedOutput = subscribedOutput,
                GetAllUnmarkedOutput = unmarkedOutput,
                GetAllMarkedOutput = markedOutput,
                TotalMarked = (int)markedOutput.Response.Count,
                TotalUnmarked = (int)unmarkedOutput.Response.Count,
                UnmarkedCount = (int)countUnmarkedOutput.Response.Count,
                FromDate = fromDate,
                ToDate = toDate
            };

            return View(dashboardVM);
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Teacher(int? page, int? unpublishedPage, int? subscribersPage, int? markedPage, int? unmarkedPage)
        {
            int _page = page ?? 1;
            int _unpublishedPage = unpublishedPage ?? 1;
            int _subscribersPage = subscribersPage ?? 1;
            int _markedPage = markedPage ?? 1;
            int _unmarkedPage = unmarkedPage ?? 1;

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

            var subscribeAppService = new SubscribeActivityAppService();

            var subscribersInput = new GetAllSubscribersInputModel
            {
                AccountId = loggedId.ToString(),
                Page = _subscribersPage,
                Count = 8
            };

            var subscribersOutput = subscribeAppService.GetAllSubscribers(subscribersInput);

            var countSubscribersInput = new CountSubscribersInputModel
            {
                AccountId = loggedId.ToString()
            };

            var countSubscribersOutput = subscribeAppService.CountSubscribers(countSubscribersInput);

            var unpublishedInput = new GetLessonByStateInputModel
            {
                AccountId = loggedId.ToString(),
                State = "WRITING",
                Page = _unpublishedPage,
                Count = 8
            };

            var unpublishedOutput = lessonAppService.GetByState(unpublishedInput);

            var answerExerciceAppService = new AnswerExerciceAppService();

            var unmarkedInput = new GetAllInputModel
            {
                AccountId = loggedId.ToString(),
                Marked = false,
                Page = _unmarkedPage,
                Count = 8,
                Type = "Teacher"
            };

            var unmarkedOutput = answerExerciceAppService.GetAll(unmarkedInput);

            if (!unmarkedOutput.Response.Success)
            {
                ViewBag.Exception = unmarkedOutput.Response.Exception;
                return View("Error");
            }

            var markedInput = new GetAllInputModel
            {
                AccountId = loggedId.ToString(),
                Marked = true,
                Page = _markedPage,
                Count = 8,
                Type = "Teacher"
            };

            var markedOutput = answerExerciceAppService.GetAll(markedInput);

            if (!markedOutput.Response.Success)
            {
                ViewBag.Exception = markedOutput.Response.Exception;
                return View("Error");
            }

            var countUnmarkedInput = new CountAnswerInputModel
            {
                AccountId = loggedId.ToString(),
                Marked = false,
                Type = "Teacher"
            };

            var countUnmarkedOutput = answerExerciceAppService.CountAnswer(countUnmarkedInput);

            var dashboardVM = new DashboardTeacherViewModel
            {
                Page = _page,
                UnpublishedPage = _unpublishedPage,
                PostedOutput = postedOutput,
                PostedCount = (int)countPostedOutput.Response.Count,
                TotalViewCount = (int)totalViewsOutput.Response.Count,
                UnpublishedOutput = unpublishedOutput,
                SubscribersOutput = subscribersOutput,
                SubscribersCount = (int)countSubscribersOutput.Response.Count,
                GetAllUnmarkedOutput = unmarkedOutput,
                GetAllMarkedOutput = markedOutput,
                TotalMarked = (int)markedOutput.Response.Count,
                TotalUnmarked = (int)unmarkedOutput.Response.Count,
                UnmarkedCount = (int)countUnmarkedOutput.Response.Count,
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
                LessonId = lessonId,
                UrlPath = Url.Action("Index", "Lesson", new { lessonId }, protocol: Request.Url.Scheme)
            };

            var service = new LessonAppService();
            var output = service.Publish(input);

            if (!output.Response.Success)
            {
                if(output.Response.Exception != null)
                {
                    TempData["exception"] = output.Response.Exception;  
                }
                
                if(output.Response.ValidationFailures != null && output.Response.ValidationFailures.Any())
                {
                    TempData["validationFailures"] = output.Response.ValidationFailures;
                }

                return RedirectToAction("Index");
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

            string fileName = string.Concat(lesson.LSNTITLE, "-progression", DateTime.Today.ToString("ddMMyyyy"), ".xls");

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

        public PartialViewResult MarkedAnswerModal(string answerId)
        {
            var markedInput = new GetAnswerExerciceInputModel
            {
                AnswerId = answerId
            };

            var appService = new AnswerExerciceAppService();

            var output = appService.Get(markedInput);

            var markedVM = new MarkedAnswerViewModel
            {
                AnswerOutput = output
            };

            return PartialView("_MarkedAnswerModal", markedVM);
        }

        public PartialViewResult UnmarkedAnswerModal(string answerId)
        {
            var markedInput = new GetAnswerExerciceInputModel
            {
                AnswerId = answerId
            };

            var appService = new AnswerExerciceAppService();

            var output = appService.Get(markedInput);

            var markedVM = new UnmarkedAnswerViewModel
            {
                AnswerOutput = output,
                IsTeacher = User.IsInRole("TEACHER")
            };

            return PartialView("_UnmarkedAnswerModal", markedVM);
        }

        public PartialViewResult AddAnswer(string lessonId)
        {
            bool canAdd = true;

            var appService = new LessonAppService();

            GetLessonOutputModel output = appService.Get(new GetLessonInputModel
            {
                Id = lessonId
            });

            var lesson = output.Response.Lesson;

            canAdd = !string.IsNullOrEmpty(lesson.LSNATTACHEDEXC);
            bool getCorrection = false;

            var hasPostedInput = new HasPostedInputModel
            {
                AccountId = GetAccountLogged().Id.ToString(),
                LessonId = lessonId
            };

            var answerAppService = new AnswerExerciceAppService();

            var hasPostedOutput = answerAppService.HasPosted(hasPostedInput);

            if (hasPostedOutput.Response.HasPosted)
            {
                getCorrection = true;
            }

            var answerVM = new AddAnswerViewModel
            {
                LessonId = lessonId,
                Addable = canAdd,
                GetCorrection = getCorrection
            };

            return PartialView("_AddAnswerButton", answerVM);
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
                return StringUtilities.UserName(account.ACTFIRSTNAME, account.ACTNAME);
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