using ASTEK.Architecture.ApplicationService.Entity.Account;
using ASTEK.Architecture.ApplicationService.Entity.Culture;
using ASTEK.Architecture.Domain.Entity.Account;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.UI.MVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];

            if (languageCookie != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(languageCookie.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCookie.Value);
            }

            base.Initialize(requestContext);
        }

        protected string CurrentCultureCode
        {
            get { return Thread.CurrentThread.CurrentCulture.Name; }
        }

        protected ApplicationUser GetUserLogged()
        {
            return HttpContext.GetOwinContext()
                                .GetUserManager<ApplicationUserManager>()
                                .FindById(User.Identity.GetUserId());
        }

        protected Account GetAccountLogged()
        {
            if (!User.Identity.IsAuthenticated)
            {
                throw new NotLoggedException();
            }

            ApplicationUser userLogged = GetUserLogged();

            var appService = new AccountAppService();
            var output = appService.GetByEmail(new GetAccountByEmailInputModel() { Email = userLogged.Email });

            return output.Response.Account;
        }


        protected UserRole GetUserLoggedRole()
        {
            if (User.IsInRole(UserRoleUtilities.RoleToString(UserRole.Student)))
            {
                return UserRole.Student;
            }
            else if (User.IsInRole(UserRoleUtilities.RoleToString(UserRole.Teacher)))
            {
                return UserRole.Teacher;
            }
            
            return UserRole.Admin;       
        }


        protected ActionResult RedirectToUserRoleHomePage(UserRole role, string source = "all")
        {
            switch (role)
            {
                case UserRole.Student:
                    return RedirectToAction("Student", "Home");
                case UserRole.Teacher:
                    if (source.Equals("Login"))
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }

                    return RedirectToAction("Teacher", "Home");
                case UserRole.Admin:
                default:
                    return RedirectToAction("Login", "Account");
            }
        }

        protected ActionResult RedirectToUserRoleDashboardPage(UserRole role)
        {
            switch (role)
            {
                case UserRole.Student:
                    return RedirectToAction("Student", "Dashboard");
                case UserRole.Teacher:
                    return RedirectToAction("Teacher", "Dashboard");
                case UserRole.Admin:
                default:
                    return RedirectToAction("Login", "Account");
            }
        }

        [AllowAnonymous]
        public ActionResult ChangeCulture(string culture, string returnUrl)
        {
            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];

            if (languageCookie == null)
            {
                languageCookie = new HttpCookie("Language");
            }

#pragma warning disable S2255 // Storing personal data in cookies is security-sensitive
            languageCookie.Value = culture;
#pragma warning restore S2255 // Storing personal data in cookies is security-sensitive
            languageCookie.Expires = DateTime.Now.AddDays(10);

            Response.SetCookie(languageCookie);

            return Redirect(returnUrl);
        }

        [AllowAnonymous]
        public PartialViewResult Culture()
        {
            var service = new CultureAppService();

            var output = service.GetAll(new GetAllCultureInputModel());

            var cultureVM = new CultureViewModel
            {
                CurrentCulture = Thread.CurrentThread.CurrentCulture.Name,
                Cultures = output.Response.Cultures
            };

            return PartialView("_Culture", cultureVM);
        }

        protected ActionResult StudyNotFound(string studyCode, Exception exception)
        {
            TempData["exception"] = exception;
            ViewBag.Id = studyCode;
            return RedirectToAction("Index", "Home");
        }

        protected ActionResult LessonNotFound(string lessonId, Exception exception)
        {
            TempData["exception"] = exception;
            ViewBag.Id = lessonId;
            return RedirectToAction("Index", "Home");
        }

        protected ActionResult ChapterNotFound(string lessonId, short number, Exception exception)
        {
            TempData["exception"] = exception;
            ViewBag.Id = lessonId;
            ViewBag.ChapterNumber = number;
            return RedirectToAction("Index", "Home");
        }

        protected ActionResult PartNotFound(string lessonId, short chapterNumber, short number, Exception exception)
        {
            TempData["exception"] = exception;
            ViewBag.Id = lessonId;
            ViewBag.ChapterNumber = chapterNumber;
            ViewBag.PartNumber = number;
            return RedirectToAction("Index", "Home");
        }
    }
}