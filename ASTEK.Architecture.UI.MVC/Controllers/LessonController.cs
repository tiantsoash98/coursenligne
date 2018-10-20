using ASTEK.Architecture.ApplicationService.Entity.Exercice;
using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.ApplicationService.Entity.LessonChapter;
using ASTEK.Architecture.ApplicationService.Entity.LessonFollowed;
using ASTEK.Architecture.ApplicationService.Entity.LessonPart;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.UI.MVC.Models;
using ASTEK.Architecture.UI.MVC.Models.Lesson;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [Authorize]
    public class LessonController : BaseController
    {
        // GET: Lesson
        [AllowAnonymous]
        public ActionResult Index(string lessonId)
        {
            if (string.IsNullOrWhiteSpace(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }
               

            var appService = new LessonAppService();

            GetLessonOutputModel output = appService.Get(new GetLessonInputModel() { Id = lessonId, GetAlternativePicture = true });

            if (!output.Response.Success)
            {
                return LessonNotFound(lessonId, output.Response.Exception);
            }

            var lesson = output.Response.Lesson;

            var chapterAppService = new LessonChapterAppService();
            CountChapterGroupByLessonOutputModel chapterCountOutput = chapterAppService.Count(new CountChapterGroupByLessonInputModel() { LessonId = lessonId });

            var exerciceAppService = new ExerciceAppService();
            CountExerciceGroupByLessonOutputModel exerciceCountOutput = exerciceAppService.Count(new CountExerciceGroupByLessonInputModel() { LessonId = lessonId });

            var followAppService = new LessonFollowedAppService();
            CountByLessonOutputModel followCountOutput = followAppService.CountByLesson(new CountByLessonInputModel() { LessonId = lessonId });

            char targetSeparator = ConfigurationManager.AppSettings.Get("TargetSeparator")[0];

            var summaryVM = new LessonIndexViewModel()
            {
                Lesson = lesson,
                Targets = lesson.LSNTARGET.Split(targetSeparator),
                ChapterCount = (int)chapterCountOutput.Response.Count,
                ExerciceCount = (int)exerciceCountOutput.Response.Count,
                FollowCount = (int)followCountOutput.Response.Count,
                BreadCrumbs = GetBreadCrumbs(lesson.LSNTITLE, lessonId)          
            };

            return View(summaryVM);
        }

        [AllowAnonymous]
        public PartialViewResult CountFollow(string lessonId, DateTime? fromDate, DateTime? toDate)
        {
            var service = new LessonFollowedAppService();
            var input = new CountByLessonInputModel
            {
                LessonId = lessonId,
                FromDate = fromDate,
                ToDate = toDate
            };

            var output = service.CountByLesson(input);

            return PartialView("_CountResult", output.Response.Count);
        }

        [AllowAnonymous] 
        public PartialViewResult GetProgression(string lessonId, short chapterNumber, short? partNumber)
        {
            var service = new LessonAppService();
            var input = new GetLessonNavigationInputModel
            {
                LessonId = lessonId
            };

            var output = service.GetNavigation(input);

            int progression = output.Response.Navigation.GetProgression(chapterNumber, partNumber);

            var progressVM = new ProgressBarViewModel
            {
                ProgressionValue = progression
            };
         
            return PartialView("_ProgressionBar", progressVM);
        }

        [AllowAnonymous]
        public PartialViewResult GetProgressionByValue(int value)
        {     
            var progressVM = new ProgressBarViewModel
            {
                ProgressionValue = value
            };

            return PartialView("_ProgressionBar", progressVM);
        }

        public ActionResult StartLesson(string lessonId)
        {
            var followInput = new FollowLessonInputModel()
            {
                AccountId = GetAccountLogged().Id.ToString(),
                LessonId = lessonId
            };

            var followAppService = new LessonFollowedAppService();
            var followOutput = followAppService.Follow(followInput);

            if (!followOutput.Response.Success)
            {
                ViewBag.Exception = followOutput.Response.Exception;
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Chapter", new { lessonId });
        }

        public ActionResult Chapter(string lessonId, short? chapterNumber)
        {   
            if (!chapterNumber.HasValue)
            {
                return RedirectToAction("Chapter", new { lessonId, chapterNumber = 1 });
            }
                

            short number = chapterNumber.Value;

            var appService = new LessonAppService();

            GetLessonOutputModel output = appService.Get(new GetLessonInputModel() { Id = lessonId, GetAlternativePicture = true });

            if (!output.Response.Success)
            {
                return LessonNotFound(lessonId, output.Response.Exception);
            }

            var lesson = output.Response.Lesson;

            var chapterAppService = new LessonChapterAppService();

            GetChapterByNumberOutputModel chapterOutput = chapterAppService.GetByNumber(new GetChapterByNumberInputModel() { LessonId = lessonId, Number = number });

            if (!chapterOutput.Response.Success)
            {
                return ChapterNotFound(lessonId, number, output.Response.Exception);
            }

            var chapter = chapterOutput.Response.Chapter;

            var partAppService = new LessonPartAppService();
            CountPartGroupByChapterOutputModel partCountOutput = partAppService.Count(new CountPartGroupByChapterInputModel() { ChapterCode = chapter.LSCCODE.ToString() });

            GetLessonNavigationOutputModel navigationOutput = appService.GetNavigation(new GetLessonNavigationInputModel() { LessonId = lessonId });

            var navigation = navigationOutput.Response.Navigation;
            var navigationVM = new LessonNavigationViewModel
            {
                LessonId = lessonId,
                Navigation = navigation,
                CurrentChapter = number
            };

            GetLessonNextStepOutputModel nextOutputModel = 
                appService.GetNextStep(new GetLessonNextStepInputModel() {
                                                                            Navigation = navigation,
                                                                            CurrentChapter = number,
                                                                            CurrentPart = 0,
                                                                            LessonId = lessonId
                                                                    });

            var chapterVM = new LessonChapterViewModel()
            {
                Lesson = lesson,
                Chapter = chapter,
                CountParts = (int)partCountOutput.Response.Count,
                Navigation = navigationVM,
                NextStep = nextOutputModel,
                BreadCrumbs = GetBreadCrumbs(lesson.LSNTITLE, lessonId, chapter.LSCTITLE, chapter.LSCNUMBER)
            };

            return View(chapterVM);
        }

        public ActionResult Part(string lessonId, short chapterNumber, short? partNumber)
        {
            if (!partNumber.HasValue)
                return RedirectToAction("Part", new { lessonId, chapterNumber, partNumber = 1 });

            short number = partNumber.Value;

            var appService = new LessonAppService();

            GetLessonOutputModel output = appService.Get(new GetLessonInputModel() { Id = lessonId, GetAlternativePicture = true });

            if (!output.Response.Success)
            {
                return LessonNotFound(lessonId, output.Response.Exception);
            }

            var lesson = output.Response.Lesson;

            var partAppService = new LessonPartAppService();

            GetPartByNumberOutputModel partOutput = partAppService.GetByNumber(new GetPartByNumberInputModel() {
                                                                                                    LessonId = lessonId,
                                                                                                    ChapterNumber = chapterNumber,
                                                                                                    Number = number
                                                                                                });

            if (!partOutput.Response.Success)
            {
                return PartNotFound(lessonId, chapterNumber, number, output.Response.Exception);
            }

            var part = partOutput.Response.Part;

            GetLessonNavigationOutputModel navigationOutput = appService.GetNavigation(new GetLessonNavigationInputModel() { LessonId = lessonId });

            var navigation = navigationOutput.Response.Navigation;
            var navigationVM = new LessonNavigationViewModel
            {
                LessonId = lessonId,
                Navigation = navigation,
                CurrentChapter = chapterNumber,
                CurrentPart = number
            };

            GetLessonNextStepOutputModel nextOutputModel =
                appService.GetNextStep(new GetLessonNextStepInputModel()
                {
                    Navigation = navigation,
                    CurrentChapter = chapterNumber,
                    CurrentPart = number,
                    LessonId = lessonId
                });


            var chapterAppService = new LessonChapterAppService();

            GetChapterTitleOutputModel titleOutputModel = chapterAppService.GetTitle(new GetChapterTitleInputModel() { LessonId = lessonId, ChapterNumber = chapterNumber });

            var partVM = new LessonPartViewModel()
            {
                Lesson = lesson,
                Part = part,
                Navigation = navigationVM,
                NextStep = nextOutputModel,
                BreadCrumbs = GetBreadCrumbs(lesson.LSNTITLE, lessonId, titleOutputModel.Response.Title, chapterNumber, part.LSPTITLE, part.LSPNUMBER)
            };

            return View(partVM);
        }

        public ActionResult Next(string type, string lessonId, short chapterNumber, short? partNumber, short currentChapter, short currentPart)
        {
            var service = new LessonFollowedAppService();

            var finishInputModel = new FinishPartInputModel()
            {
                AccountId = GetAccountLogged().Id.ToString(),
                LessonId = lessonId,
                ChapterNumber = currentChapter,
                PartNumber = currentPart
            };

            var finishOutput = service.FinishPart(finishInputModel);

            if (!finishOutput.Response.Success)
            {
                ViewBag.Exception = finishOutput.Response.Exception;
                return View("Error");
            }

            if (type.Equals("Chapter"))
            {          
                return RedirectToAction("Chapter", "Lesson", new { lessonId, chapterNumber });
            }
            else if (type.Equals("Part"))
            {
                return RedirectToAction("Part", "Lesson", new { lessonId, chapterNumber, partNumber = partNumber.Value });
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult End(string lessonId)
        {
            var service = new LessonFollowedAppService();

            var finishInputModel = new FinishLessonInputModel()
            {
                AccountId = GetAccountLogged().Id.ToString(),
                LessonId = lessonId
            };

            var finishOutput = service.FinishLesson(finishInputModel);

            if (!finishOutput.Response.Success)
            {
                ViewBag.Exception = finishOutput.Response.Exception;
                return View("Error");
            }

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public async Task<ActionResult> Search(string query, int? page)
        {
            if (string.IsNullOrEmpty(query))
            {
                return RedirectToAction("Index", "Home");
            }

            int _page = page ?? 1;

            if(_page <= 0)
            {
                return RedirectToAction("Search", new { query, page = 1 });
            }

            var searchInput = new SearchLessonInputModel()
            {
                Query = query,
                Page = _page,
                Count = 8,
                GetAlternativePicture = true,
                GetThumbnailPicture = true
            };

            var service = new LessonAppService();
            SearchLessonOutputModel searchOutput = await service.SearchAsync(searchInput);

            var searchVM = new LessonSearchViewModel()
            {
                Query = query,
                Page = _page,
                Lessons = searchOutput.Response.Lessons,
                TotalPages = searchOutput.Response.TotalPages,
            };

            return View(searchVM);
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Add()
        {
            var addVM = new LessonAddViewModel();

            InitAddLessonViewModel(addVM);

            return View(addVM);
        }

        [Authorize(Roles = "TEACHER")]
        [HttpPost]
        public ActionResult Add(LessonAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                InitAddLessonViewModel(model);
                return View(model);
            }

            model.Input.AccountId = GetAccountLogged().Id;
            model.Input.Confidentiality = "7CCAF4E2-CF9E-E811-8220-2C600C6934BE";

            var service = new LessonAppService();
            CreateLessonOutputModel output = service.Create(model.Input);

            if (!output.Response.Success)
            {
                if(output.Response.Exception != null)
                {
                    ModelState.AddModelError("ValidatorErrors", output.Response.Exception);
                }
                if(output.Response.ValidationErrors != null)
                {
                    foreach(var validationError in output.Response.ValidationErrors)
                    {
                        ModelState.AddModelError("", validationError.ErrorMessage);
                    }
                }
                             

                InitAddLessonViewModel(model);
                return View(model);
            }

            return RedirectToAction("AddChapter", new { lessonId = output.Response.Lesson.Id });
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult AddChapter(string lessonId, int? chapterNumber, string source)
        {
            if (string.IsNullOrWhiteSpace(lessonId))
                return RedirectToAction("Index", "Home");

            int number = chapterNumber ?? 1;

            var appService = new LessonAppService();
            var navigationOutput = appService.GetNavigation(new GetLessonNavigationInputModel { LessonId = lessonId });

            var navigation = navigationOutput.Response.Navigation;

            var addVM = new LessonAddChapterViewModel
            {
                LessonId = lessonId,
                ChapterNumber = number,
                Navigation = navigation,
                PartsInput = new List<CreateLessonPartInputModel>()
            };

            return View(addVM);
        }

        [Authorize(Roles = "TEACHER")]
        [HttpPost, ValidateInput(false)]
        public ActionResult AddChapter(LessonAddChapterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.ChapterInput.LessonId = model.LessonId;

            var service = new LessonChapterAppService();
            CreateLessonChapterOutputModel output = service.Create(model.ChapterInput);

            if (!output.Response.Success)
            {
                if (output.Response.Exception != null)
                {
                    ModelState.AddModelError("Errors", output.Response.Exception.Message);
                }

                if (output.Response.ValidationErrors != null)
                {
                    foreach (var error in output.Response.ValidationErrors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }
                }

                InitAddLessonChapterViewModel(model);
                return View(model);
            }

            if(model.PartsInput != null && model.PartsInput.Count > 0)
            {
                var createAllInputModel = new CreateAllLessonPartInputModel()
                {
                    ChapterCode = output.Response.Chapter.LSCCODE.ToString(),
                    PartsInput = model.PartsInput
                };

                var partService = new LessonPartAppService();
                CreateAllLessonPartOutputModel partOutput = partService.CreateAll(createAllInputModel);

                if (!partOutput.Response.Success)
                {
                    if (partOutput.Response.Exception != null)
                    {
                        ModelState.AddModelError("PartErrors", partOutput.Response.Exception.Message);
                    }

                    if (partOutput.Response.ValidationErrors != null)
                    {
                        foreach (var error in partOutput.Response.ValidationErrors)
                        {
                            ModelState.AddModelError("ValidatorPartErrors", error.ErrorMessage);
                        }
                    }

                    InitAddLessonChapterViewModel(model);
                    return View(model);
                }
            }      

            if (model.Type.Equals("next"))
            {
                int nextNumber = output.Response.Chapter.LSCNUMBER + 1;
                return RedirectToAction("AddChapter", new { lessonId = model.LessonId, chapterNumber = nextNumber });
            }

            return RedirectToAction("AddDetails", "Lesson", new { lessonId = model.LessonId });
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult AddDetails(string lessonId, string source)
        {
            if (string.IsNullOrWhiteSpace(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }              

            var addVM = new LessonAddDetailsViewModels
            {
                LessonId = lessonId,
                Source = source
            };

            return View(addVM);
        }

        [Authorize(Roles = "TEACHER")]
        [HttpPost]
        public ActionResult AddDetails(string lessonId, HttpPostedFileBase image)
        {
            var service = new LessonAppService();

            if(image != null && image.ContentLength > 0)
            {
                var imageInput = new UploadLessonImageInputModel()
                {
                    Stream = image.InputStream,
                    ContentLength = image.ContentLength,
                    ContentType = image.ContentType,
                    FileName = image.FileName,
                    LessonId = lessonId
                };

                var imageOutput = service.UploadImage(imageInput);

                if (!imageOutput.Response.Success)
                {
                    if(imageOutput.Response.Exception != null)
                    {
                        ModelState.AddModelError("Error", imageOutput.Response.Exception);
                    }
                    
                    if(imageOutput.Response.ValidationFailures != null)
                    {
                        foreach (var error in imageOutput.Response.ValidationFailures)
                        {
                            ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                        }
                    }

                    var addVM = new LessonAddDetailsViewModels()
                    {
                        LessonId = lessonId
                    };

                    return View(addVM);
                }
            }         

            return RedirectToAction("Index", "Lesson", new { lessonId });
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult GetAllContent(string lessonId)
        {
            if (string.IsNullOrEmpty(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                var lessonVM = GetAllContentLessonViewModel(lessonId);          
                return View(lessonVM);
            }
            catch(Exception ex)
            {
                return LessonNotFound(lessonId, ex);
            }
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Update(string lessonId, string status) 
        {
            if (string.IsNullOrEmpty(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }

            var service = new LessonAppService();

            var infosInput = new GetLessonInputModel
            {
                Id = lessonId
            };

            var infosOutput = service.Get(infosInput);

            if (!infosOutput.Response.Success)
            {
                ViewBag.Exception = infosOutput.Response.Exception;
                return View("Error");
            }

            var lesson = infosOutput.Response.Lesson;

            var updateInput = new UpdateLessonInputModel
            {
                LessonId = lessonId,
                Title = lesson.LSNTITLE,
                Description = lesson.LSNDESCRIPTION,
                Targets = StringUtilities.GetListFromFormated(lesson.LSNTARGET),
                Study = lesson.STDCODE.ToString(),
                Confidentiality = lesson.DCFCODE.ToString()
            };

            var updateVM = new UpdateLessonViewModel
            {
                Input = updateInput,
                Status = status
            };

            return View(updateVM);
        }

        [Authorize(Roles = "TEACHER")]
        [HttpPost]
        public ActionResult Update(UpdateLessonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = new LessonAppService();
            var output = service.Update(model.Input);

            if (!output.Response.Success)
            {
                if (output.Response.Exception != null)
                {
                    ModelState.AddModelError("Error", output.Response.Exception.Message);
                }

                if (output.Response.ValidationFailures != null)
                {
                    foreach (var error in output.Response.ValidationFailures)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }
                }

                return View(model);
            }

            return RedirectToAction("Update", new { lessonId = model.Input.LessonId, status = "success" });
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult UpdateChapter(string lessonId, short? chapterNumber, string status)
        {
            if (string.IsNullOrEmpty(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }

            short _chapterNumber = chapterNumber ?? 1;

            var service = new LessonChapterAppService();

            var infosInput = new GetChapterByNumberInputModel
            {
                LessonId = lessonId,
                Number = _chapterNumber,
                LoadChildren = true
            };

            var infosOutput = service.GetByNumber(infosInput);

            if (!infosOutput.Response.Success)
            {
                ViewBag.Exception = infosOutput.Response.Exception;
                return View("Error");
            }

            var chapter = infosOutput.Response.Chapter;

            var updateInput = new UpdateLessonChapterInputModel
            {
                Title = chapter.LSCTITLE,
                Description = chapter.LSCDESCRIPTION,
                Content = chapter.LSCCONTENT
            };

            if (chapter.LSCDURATION.HasValue)
            {
                var duration = new TimeSpan(chapter.LSCDURATION.Value);
                updateInput.Hours = duration.Hours;
                updateInput.Minutes = duration.Minutes;
            }

            var partsInput = GetUpdateLessonPartViewModels(chapter.LessonParts.ToList());

            var updateVM = new UpdateLessonChapterViewModel
            {
                ChapterInput = updateInput,
                Status = status,
                LessonId = lessonId,
                ChapterNumber = _chapterNumber  ,
                PartsInput = partsInput
            };

            InitUpdateLessonChapterViewModel(updateVM);

            return View(updateVM);
        }

        [Authorize(Roles = "TEACHER")]
        [HttpPost, ValidateInput(false)]
        public ActionResult UpdateChapter(UpdateLessonChapterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                InitUpdateLessonChapterViewModel(model);
                return View(model);
            }

            model.ChapterInput.LessonId = model.LessonId;
            model.ChapterInput.ChapterNumber = model.ChapterNumber;

            var service = new LessonChapterAppService();
            var output = service.Update(model.ChapterInput);

            if (!output.Response.Success)
            {
                if (output.Response.Exception != null)
                {
                    ModelState.AddModelError("Error", output.Response.Exception.Message);
                }

                if (output.Response.ValidationFailures != null)
                {
                    foreach (var error in output.Response.ValidationFailures)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }
                }

                InitUpdateLessonChapterViewModel(model);
                return View(model);
            }

            if (model.PartsInput != null && model.PartsInput.Count > 0)
            {
                var updateAllInputModel = new UpdateAllLessonPartInputModel
                {
                    ChapterCode = output.Response.Updated.LSCCODE.ToString(),
                    PartsInput = model.PartsInput
                };

                var partService = new LessonPartAppService();
                UpdateAllLessonPartOutputModel partOutput = partService.UpdateAll(updateAllInputModel);

                if (!partOutput.Response.Success)
                {
                    if (partOutput.Response.Exception != null)
                    {
                        ModelState.AddModelError("PartErrors", partOutput.Response.Exception.Message);
                    }

                    if (partOutput.Response.ValidationFailures != null)
                    {
                        foreach (var error in partOutput.Response.ValidationFailures)
                        {
                            ModelState.AddModelError("ValidatorPartErrors", error.ErrorMessage);
                        }
                    }

                    InitUpdateLessonChapterViewModel(model);
                    return View(model);
                }
            }

            return RedirectToAction("UpdateChapter", new { lessonId = model.LessonId, chapterNumber = model.ChapterNumber, status = "success" });
        }

        [Authorize(Roles = "TEACHER")]
        public PartialViewResult EditLessonModal(string lessonId, string type, string hasImage)
        {
            bool _hasImage = !string.IsNullOrEmpty(hasImage) && hasImage.ToLower().Equals("true");

            var editVM = new EditLessonViewModel
            {
                LessonId = lessonId,
                HasImage = _hasImage
            };

            if (type.Equals("unpublished"))
            {
                editVM.Editable = true;
                editVM.Deletable = true;
            }

            return PartialView("_EditLessonModal", editVM);
        }

        [AllowAnonymous]
        public PartialViewResult GetAlternativePicture(string lessonId, bool thumbnail)
        {
            var service = new LessonAppService();

            var input = new GetLessonAlternativePictureInputModel
            {
                LessonId = lessonId,
                GetThumbnailPicture = thumbnail
            };

            var output = service.GetAlternativePicture(input);

            var alternativeVM = new LessonAlternativePictureViewModel
            {
                IsAlternative = output.Response.IsAlternative,
                LessonTitle = output.Response.LessonTitle,
                PicturePath = output.Response.PicturePath,
                StudyName = output.Response.StudyName
            };

            return PartialView("_LessonAlternativePicture", alternativeVM);
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult ExportPDF(string lessonId)
        {
            if (string.IsNullOrEmpty(lessonId))
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                var lessonVM = GetAllContentLessonViewModel(lessonId);

                return new Rotativa.ViewAsPdf("GetAllContent", lessonVM)
                {
                    FileName = string.Concat(lessonVM.Lesson.LSNTITLE, ".pdf"),
                    PageMargins = new Rotativa.Options.Margins
                    {
                        Top = 25,
                        Bottom = 10
                    },
                    CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 6",
                    PageSize = Rotativa.Options.Size.A4,                 
                };
            }
            catch (Exception ex)
            {
                return LessonNotFound(lessonId, ex);
            }       
        }

        [Authorize(Roles = "TEACHER")]
        public ActionResult Delete(string lessonId)
        {
            var deleteInput = new DeleteLessonInputModel
            {
                LessonId = lessonId,
                AccountId = GetAccountLogged().Id.ToString()
            };

            var deleteOutput = new LessonAppService().Delete(deleteInput);

            if (!deleteOutput.Response.Success)
            {
                ViewBag.Exception = deleteOutput.Response.Exception;
                return View("Error");
            }

            return RedirectToAction("Index", "Dashboard");
        }

        private AllContentLessonViewModel GetAllContentLessonViewModel(string lessonId)
        {
            var service = new LessonAppService();

            var input = new GetAllContentLessonInputModel
            {
                LessonId = lessonId
            };

            var output = service.GetAllContent(input);

            if (!output.Response.Success)
            {
                throw output.Response.Exception;
            }

            char targetSeparator = ConfigurationManager.AppSettings.Get("TargetSeparator")[0];

            return new AllContentLessonViewModel
            {
                Lesson = output.Response.Lesson,
                Targets = output.Response.Lesson.LSNTARGET.Split(targetSeparator)
            };
        }
        private void InitAddLessonViewModel(LessonAddViewModel viewModel)
        {
            // In case there are values that need to be initialized again
        }
        private void InitAddLessonChapterViewModel(LessonAddChapterViewModel viewModel)
        {
            var appService = new LessonAppService();
            var navigationOutput = appService.GetNavigation(new GetLessonNavigationInputModel { LessonId = viewModel.LessonId });

            var navigation = navigationOutput.Response.Navigation;
            viewModel.Navigation = navigation;
        }
        private void InitUpdateLessonChapterViewModel(UpdateLessonChapterViewModel viewModel)
        {
            var appService = new LessonAppService();
            var navigationOutput = appService.GetNavigation(new GetLessonNavigationInputModel { LessonId = viewModel.LessonId });

            var navigation = navigationOutput.Response.Navigation;
            viewModel.Navigation = navigation;
        }
        private List<UpdateLessonPartInputModel> GetUpdateLessonPartViewModels(List<Domain.Entity.LessonPart.LessonPart> lessonParts)
        {
            List<UpdateLessonPartInputModel> partsInput = new List<UpdateLessonPartInputModel>();

            foreach(var part in lessonParts)
            {
                partsInput.Add(new UpdateLessonPartInputModel
                {
                    ChapterCode = part.LSCCODE.ToString(),
                    Title = part.LSPTITLE,
                    Content = part.LSPCONTENT
                });
            }

            return partsInput;
        }

        #region BreadCrumbsHelper 
        private List<BreadCrumbViewModel> GetBreadCrumbs(string lessonTitle, string lessonId, bool isCurrent = true)
        {
            return new List<BreadCrumbViewModel>()
            {
                new BreadCrumbViewModel() {
                    Action = "Index",
                    Controller = "Home",
                    Title = "Accueil",
                    IsCurrent = false
                },
                new BreadCrumbViewModel() {
                    Action = "Index",
                    Controller = "Lesson",
                    Title = lessonTitle,
                    RouteValues = new RouteValueDictionary { {"lessonId", lessonId } },
                    IsCurrent = isCurrent
                }
            };
        }

        private List<BreadCrumbViewModel> GetBreadCrumbs(string lessonTitle, string lessonId, string chapterTitle, short chapterNumber, bool isCurrent = true)
        {
            var bc = new BreadCrumbViewModel()
            {
                Action = "Chapter",
                Controller = "Lesson",
                Title = chapterTitle,
                RouteValues = new RouteValueDictionary { { "lessonId", lessonId }, {"chapterNumber", chapterNumber } },
                IsCurrent = isCurrent
            };

            var list = GetBreadCrumbs(lessonTitle, lessonId, false);
            list.Add(bc);

            return list;
        }

        private List<BreadCrumbViewModel> GetBreadCrumbs(string lessonTitle, string lessonId, string chapterTitle, short chapterNumber, string partTitle, short partNumber, bool isCurrent = true)
        {
            var bc = new BreadCrumbViewModel()
            {
                Action = "Part",
                Controller = "Lesson",
                Title = partTitle,
                RouteValues = new RouteValueDictionary { { "lessonId", lessonId }, { "chapterNumber", chapterNumber }, {"partNumber", partNumber } },
                IsCurrent = isCurrent
            };

            var list = GetBreadCrumbs(lessonTitle, lessonId, chapterTitle, chapterNumber, false);
            list.Add(bc);

            return list;
        }

        #endregion
    }
}