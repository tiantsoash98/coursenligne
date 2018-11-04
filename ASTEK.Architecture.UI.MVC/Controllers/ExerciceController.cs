using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;
using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.UI.MVC.Models.Exercice;
using System;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [Authorize]
    public class ExerciceController : BaseController
    {        
        public ActionResult Answer(string lessonId)
        {
            if (string.IsNullOrWhiteSpace(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }

            var appService = new LessonAppService();

            GetLessonOutputModel output = appService.Get(new GetLessonInputModel() { Id = lessonId, GetAlternativePicture = true });

            if (!output.Response.Success)
            {
                throw output.Response.Exception;
            }

            var lesson = output.Response.Lesson;

            if (string.IsNullOrEmpty(lesson.LSNATTACHEDEXC))
            {
                return RedirectToAction("Index", "Lesson", new { lessonId });
            }

            var answerVM = new AnswerViewModel
            {
                Input = new UploadAnswerInputModel
                {
                    LessonId = lessonId
                }
            };

            return View(answerVM);
        }

        [HttpPost]
        public ActionResult Answer(AnswerViewModel model, HttpPostedFileBase file)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            var account = GetAccountLogged();

            if(file != null && file.ContentLength > 0)
            {
                string baseFileUrl = Server.MapPath(ConfigurationManager.AppSettings.Get("BaseFileUrl"));
                string answerFolder = ConfigurationManager.AppSettings.Get("AnswerFolder");

                string extension = Path.GetExtension(file.FileName);
                var fileName = string.Concat(account.Id, DateTime.Now.ToString("ddMMyyyyhhmm"));
                var fullName = string.Concat(baseFileUrl, answerFolder, fileName.ToString(), extension);

                file.SaveAs(fullName);

                var service = new AnswerExerciceAppService();

                model.Input.AccountId = account.Id.ToString();
                model.Input.FileName = string.Concat(fileName, extension);

                var uploadOutput = service.Upload(model.Input);

                if (!uploadOutput.Response.Success)
                {
                    ViewBag.Exception = uploadOutput.Response.Exception;
                    return View("Error");
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Veuillez importer un fichier!");
                return View(model);
            }

            return RedirectToAction("Index", "Dashboard");
        }
    }
}