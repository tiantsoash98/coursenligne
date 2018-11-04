using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using ASTEK.Architecture.Infrastructure.Domain;
using FluentValidation.Results;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.Navigation;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.BusinessService.Validator;
using ASTEK.Architecture.BusinessService.Entity.Study;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ASTEK.Architecture.BusinessService.Entity.SubscribeActivity;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class LessonBusinessService : EntityServiceBase<Domain.Entity.Lesson.Lesson>, ILessonBusinessService
    {
        private readonly EFLessonRepository _repository;

        public LessonBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFLessonRepository(context);
        }

        public CreateLessonResponse Create(CreateLessonRequest request)
        {
            try
            {
                var lesson = AssignAvailablePropertiesToDomain(request);

                List<ValidationFailure> errors = new List<ValidationFailure>();

                errors.AddRange(GetErrors(lesson, ValidationType.Add));

                var validator = new CreateLessonValidator(_repository, lesson);
                ValidationResult result = validator.Validate();

                errors.AddRange(result.Errors);

                if (errors.Any())
                {
                    return new CreateLessonResponse
                    {
                        Success = false,
                        ValidationErrors = errors
                    };
                }

                _repository.Add(lesson);

                return new CreateLessonResponse
                {
                    Success = true,
                    Lesson = lesson
                };
            }
            catch (Exception e)
            {
                return new CreateLessonResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public GetLessonResponse Get(GetLessonRequest request)
        {
            try
            {
                var lesson = _repository.FindBy(request.LessonId);

                if (lesson == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
                }

                if (request.GetAlternativePicture)
                {
                    var studyRequest = new GetStudyRequest
                    {
                        Code = lesson.STDCODE
                    };

                    var studyResponse = new StudyBusinessService().Get(studyRequest);

                    if (string.IsNullOrEmpty(lesson.LSNPICTURE))
                    {
                        lesson.LSNPICTURE = string.Concat(ConfigurationManager.AppSettings.Get("StudyFolder"), studyResponse.Study.STDPICTURE);
                    }
                    else
                    {
                        lesson.LSNPICTURE = string.Concat(ConfigurationManager.AppSettings.Get("LessonFolder"), lesson.LSNPICTURE);
                    }
                }

                return new GetLessonResponse
                {
                    Success = true,
                    Lesson = lesson
                };
            }
            catch (Exception ex)
            {
                return new GetLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }


        }

        public GetLessonChapterCountResponse GetChapterCount(GetLessonChapterCountRequest request)
        {
            try
            {
                return new GetLessonChapterCountResponse
                {
                    Success = true,
                    ChapterCount = _repository.GetChapterCount(request.LessonId)
                };
            }
            catch (Exception ex)
            {
                return new GetLessonChapterCountResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetLessonExerciceCountResponse GetExerciceCount(GetLessonExerciceCountRequest request)
        {
            try
            {
                return new GetLessonExerciceCountResponse
                {
                    Success = true,
                    ExcerciceCount = _repository.GetExerciceCount(request.LessonId)
                };
            }
            catch (Exception ex)
            {
                return new GetLessonExerciceCountResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetLessonMayLikeResponse GetMayLike(GetLessonMayLikeRequest request)
        {
            try
            {
                var lessons = _repository.GetMayLike(request.Level);

                if(lessons == null)
                {
                    return new GetLessonMayLikeResponse
                    {
                        Success = true,
                        Lessons = new List<Domain.Entity.Lesson.Lesson>(),
                        Page = request.Page,
                        Count = request.Count,
                        TotalPages = 1
                    };
                }

                int totalPages = ListUtilities.GetTotalPagesCount(lessons.Count, request.Count);

                List<Domain.Entity.Lesson.Lesson> pagedList = lessons
                                                                        .Skip((request.Page - 1) * request.Count)
                                                                        .Take(request.Count)
                                                                        .ToList();

                //if (request.GetAlternativePicture)
                //{
                //    AssignAlternativeImage(lessons, request.GetThumbnailPicture);
                //}

                return new GetLessonMayLikeResponse
                {
                    Success = true,
                    Lessons = pagedList,
                    Page = request.Page,
                    Count = request.Count,
                    TotalPages = totalPages
                };
            }
            catch (Exception ex)
            {
                return new GetLessonMayLikeResponse
                {
                    Success = false,
                    Exception = ex
                };
            }

        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.Lesson.Lesson entity, ValidationType validationType)
        {
            return new LessonValidator(validationType).Validate(entity).Errors.ToList();
        }

        public GetLessonNavigationResponse GetNavigation(GetLessonNavigationRequest request)
        {
            try
            {
                LessonNavigation navigation = _repository.GetLessonNavigation(request.LessonId);

                var response = new GetLessonNavigationResponse
                {
                    Success = true,
                    Navigation = navigation
                };

                return response;
            }
            catch (Exception ex)
            {
                var response = new GetLessonNavigationResponse
                {
                    Success = false,
                    Exception = ex
                };

                return response;
            }
        }

        public GetLessonNextStepResponse GetNextStep(GetLessonNextStepRequest request)
        {
            try
            {
                LessonNavigation navigation = request.Navigation;

                if (request.CurrentChapter == 0)
                {
                    if (navigation.Chapters.Count > 0)
                    {
                        return new GetLessonNextStepResponse
                        {
                            Exist = true,
                            Type = "Chapter",
                            NextChapterNumber = 1,
                            Title = navigation.Chapters.FirstOrDefault().Title,
                            LessonId = request.LessonId,
                            CurrentChapterNumber = request.CurrentChapter,
                            CurrentPartNumber = request.CurrentPart
                        };
                    }

                    return new GetLessonNextStepResponse
                    {
                        Exist = false,
                        LessonId = request.LessonId
                    };                   
                }

                // Finds the index of the current chapter
                int currChapterIndex = navigation.Chapters.FindIndex(c => c.Number == request.CurrentChapter);

                // Throw exception if not found
                if (currChapterIndex == -1)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter);
                }


                ChapterNavigation currentChapter = navigation.Chapters[currChapterIndex];

                int currentPartIndex = 0;

                // If at the beginning of a chapter
                if (request.CurrentPart == 0)
                {
                    currentPartIndex = -1;
                }
                else
                {
                    // Finds the index of the current part
                    currentPartIndex = currentChapter.Parts.FindIndex(p => p.Number == request.CurrentPart);

                    // Throw exception if not found
                    if (currentPartIndex == -1)
                    {
                        throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Part);
                    }
                }

                // If has next part
                if (ListUtilities.HasIndex(currentPartIndex + 1, currentChapter.Parts))
                {
                    PartNavigation nextPart = currentChapter.Parts[currentPartIndex + 1];

                    return new GetLessonNextStepResponse
                    {
                        Exist = true,
                        Type = "Part",
                        Title = nextPart.Title,
                        NextChapterNumber = currentChapter.Number,
                        NextPartNumber = nextPart.Number,
                        LessonId = request.LessonId,
                        CurrentChapterNumber = request.CurrentChapter,
                        CurrentPartNumber = request.CurrentPart
                    };
                }
                else
                {
                    // If has next chapter
                    if (ListUtilities.HasIndex(currChapterIndex + 1, navigation.Chapters))
                    {
                        ChapterNavigation nextChapter = navigation.Chapters[currChapterIndex + 1];

                        return new GetLessonNextStepResponse
                        {
                            Exist = true,
                            Type = "Chapter",
                            Title = nextChapter.Title,
                            NextChapterNumber = nextChapter.Number,
                            LessonId = request.LessonId,
                            CurrentChapterNumber = request.CurrentChapter,
                            CurrentPartNumber = request.CurrentPart
                        };
                    }
                    else
                    {
                        return new GetLessonNextStepResponse
                        {
                            Exist = false,
                            LessonId = request.LessonId
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new GetLessonNextStepResponse
                {
                    Success = false,
                    Exception = ex,
                    LessonId = request.LessonId
                };
            }
        }

        private Domain.Entity.Lesson.Lesson AssignAvailablePropertiesToDomain(CreateLessonRequest request)
        {
            var lesson = new Domain.Entity.Lesson.Lesson
            {
                ACCID = request.AccountId,
                LSNTITLE = request.Title,
                STDCODE = request.Study,
                LSNDESCRIPTION = request.Description,
                LSNTARGET = StringUtilities.GetListFormated(request.Target),
                LSNDURATION = request.Duration,
                LSNDATE = DateTime.Now,
                DCFCODE = request.Confidentiality,
                LSNLEVEL = request.Level        
            };

            return lesson;
        }

        public UploadLessonImageResponse UploadImage(UploadLessonImageRequest request)
        {
            try
            {
                string currentfileExtension = Path.GetExtension(request.FileName);

                int maxImageLength = Convert.ToInt32(ConfigurationManager.AppSettings.Get("MaxImageLength"));

                var validator = new UploadImageValidator(request.Stream, currentfileExtension, request.ContentLength, maxImageLength);
                ValidationResult result = validator.Validate();

                if (result.Errors.Any())
                {
                    return new UploadLessonImageResponse
                    {
                        Success = false,
                        ValidationFailures = result.Errors.ToList()
                    };
                }

                string pathToSave = Path.Combine(ConfigurationManager.AppSettings.Get("AbsoluteFileUrl"),
                                                        ConfigurationManager.AppSettings.Get("ImageFolder"),
                                                            ConfigurationManager.AppSettings.Get("LessonFolder"));

                string thumbnailPath = Path.Combine(ConfigurationManager.AppSettings.Get("AbsoluteFileUrl"),
                                                        ConfigurationManager.AppSettings.Get("ImageFolder"),
                                                            ConfigurationManager.AppSettings.Get("ThumbnailFolder"),
                                                                ConfigurationManager.AppSettings.Get("LessonFolder"));


                var img = Image.FromStream(request.Stream);
                var resizedImg = ImageUtilities.ResizeImageByWidth(img, Convert.ToInt32(ConfigurationManager.AppSettings.Get("LessonImageWidth")));
                var thumbnail = ImageUtilities.ResizeImageByWidth(img, Convert.ToInt32(ConfigurationManager.AppSettings.Get("LessonThumbnailImageWidth")));

                string fileNameToSave = string.Concat(request.LessonId.ToString(), ConfigurationManager.AppSettings.Get("ImageExtension"));
                string savedFileName = Path.Combine(pathToSave, fileNameToSave);
                string savedThumbnailFileName = Path.Combine(thumbnailPath, fileNameToSave);

                resizedImg.Save(savedFileName);
                thumbnail.Save(savedThumbnailFileName);

                thumbnail.Dispose();
                resizedImg.Dispose();
                img.Dispose();

                var updateRequest = new UpdateLessonImageRequest()
                {
                    LessonId = request.LessonId,
                    ImageName = fileNameToSave
                };



                var updateResponse = UpdateImage(updateRequest);

                if (!updateResponse.Success)
                {
                    throw updateResponse.Exception;
                }

                return new UploadLessonImageResponse
                {
                    Success = true,
                    FileName = savedFileName
                };
            }
            catch (Exception e)
            {
                return new UploadLessonImageResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public UpdateLessonImageResponse UpdateImage(UpdateLessonImageRequest request)
        {
            try
            {
                var lesson = _repository.FindBy(request.LessonId);

                if (lesson == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
                }

                lesson.LSNPICTURE = request.ImageName;

                _repository.Save(lesson);

                return new UpdateLessonImageResponse
                {
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new UpdateLessonImageResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public GetBestLessonByStudyResponse GetBestByStudy(GetBestLessonByStudyRequest request)
        {
            try
            {
                var lessons = _repository.GetBestByStudy(request.StudyCode, request.Level);

                int totalPages = ListUtilities.GetTotalPagesCount(lessons.Count, request.Count);

                List<Domain.Entity.Lesson.Lesson> pagedList = lessons.OrderByDescending(l => l.LSNDATE)
                                                                        .Skip((request.Page - 1) * request.Count)
                                                                        .Take(request.Count)
                                                                        .ToList();

                //if (request.GetAlternativePicture)
                //{
                //    AssignAlternativeImage(lessons, request.GetThumbnailPicture);
                //}

                return new GetBestLessonByStudyResponse
                {
                    Success = true,
                    Lessons = pagedList,
                    Page = request.Page,
                    TotalPages = totalPages,
                    Count = request.Count
                };
            }
            catch (Exception ex)
            {
                return new GetBestLessonByStudyResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        private void AssignAlternativeImage(List<Domain.Entity.Lesson.Lesson> lessons, bool getThumbnailPicture)
        {
            var studyRequest = new GetAllStudyRequest();
            var studyResponse = new StudyBusinessService().GetAll(studyRequest);

            string studyFolder = ConfigurationManager.AppSettings.Get("StudyFolder");
            string lessonFolder = ConfigurationManager.AppSettings.Get("LessonFolder");
            string thumbnailFolder = ConfigurationManager.AppSettings.Get("ThumbnailFolder");

            lessons.ForEach(x =>
            {
                var _study = studyResponse.Studies.FirstOrDefault(study => study.STDCODE.Equals(x.STDCODE));

                if (string.IsNullOrEmpty(x.LSNPICTURE))
                {
                    x.LSNPICTURE = Path.Combine(studyFolder, _study.STDPICTURE);
                }
                else
                {
                    if (getThumbnailPicture)
                    {
                        x.LSNPICTURE = Path.Combine(thumbnailFolder, lessonFolder, x.LSNPICTURE);
                    }
                    else
                    {
                        x.LSNPICTURE = Path.Combine(lessonFolder, x.LSNPICTURE);
                    }
                }
            });
        }

        public async Task<SearchLessonResponse> SearchAsync(SearchLessonRequest request)
        {
            try
            {
                List<Domain.Entity.Lesson.Lesson> lessons = await _repository.SearchAsync(request.Query);

                int totalPages = ListUtilities.GetTotalPagesCount(lessons.Count, request.Count);

                List<Domain.Entity.Lesson.Lesson> pagedList = lessons.OrderByDescending(l => l.LSNDATE)
                                                                        .Skip((request.Page - 1) * request.Count)
                                                                        .Take(request.Count)
                                                                        .ToList();

                //if (request.GetAlternativePicture)
                //{
                //    AssignAlternativeImage(lessons, request.GetThumbnailPicture);
                //}

                return new SearchLessonResponse
                {
                    Success = true,
                    Lessons = pagedList,
                    TotalPages = totalPages,
                    Count = request.Count,
                    Page = request.Page
                };
            }
            catch (Exception ex)
            {
                return new SearchLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetLessonByStateResponse GetByState(GetLessonByStateRequest request)
        {
            try
            {
                List<Domain.Entity.Lesson.Lesson> lessons = _repository.GetByState(request.AccountId, request.State);

                int totalPages = ListUtilities.GetTotalPagesCount(lessons.Count, request.Count);

                List<Domain.Entity.Lesson.Lesson> pagedList = lessons.OrderByDescending(l => l.LSNDATE)
                                                                        .Skip((request.Page - 1) * request.Count)
                                                                        .Take(request.Count)
                                                                        .ToList();

                return new GetLessonByStateResponse
                {
                    Success = true,
                    Lessons = pagedList,
                    TotalPages = totalPages,
                    Page = request.Page,
                    Count = request.Count
                };
            }
            catch (Exception ex)
            {
                return new GetLessonByStateResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public CountLessonPostedByResponse CountPostedBy(CountLessonPostedByRequest request)
        {
            try
            {
                Expression<Func<Domain.Entity.Lesson.Lesson, bool>> expression = l => l.ACCID.Equals(request.AccountId) && l.DocumentState.DCSWORDING.Equals("VALID");

                if (request.FromDate.HasValue)
                {
                    Expression<Func<Domain.Entity.Lesson.Lesson, bool>> fromDateExp = l => l.LSNDATE >= request.FromDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, fromDateExp);
                }
                if (request.ToDate.HasValue)
                {
                    Expression<Func<Domain.Entity.Lesson.Lesson, bool>> toDateExp = l => l.LSNDATE <= request.ToDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, toDateExp);
                }

                int count = _repository.Count(new Specification<Domain.Entity.Lesson.Lesson>(expression));

                return new CountLessonPostedByResponse
                {
                    Success = true,
                    Count = count
                };
            }
            catch (Exception ex)
            {
                return new CountLessonPostedByResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public IsLessonLastPartResponse IsLastPart(IsLessonLastPartRequest request)
        {
            try
            {
                LessonNavigation navigation = _repository.GetLessonNavigation(request.LessonId);

                bool isLast = false;

                var lastChapter = navigation.Chapters.Last();

                if (request.ChapterNumber > lastChapter.Number)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter);
                }

                if (request.ChapterNumber == lastChapter.Number)
                {
                    if (lastChapter.Parts.Any() && request.PartNumber.HasValue)
                    {
                        var lastPart = lastChapter.Parts.Last();

                        if (request.PartNumber.Value > lastPart.Number)
                        {
                            throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Part);
                        }

                        if (lastPart.Number == request.PartNumber.Value)
                        {
                            isLast = true;
                        }
                    }
                    else
                    {
                        isLast = true;
                    }
                }

                return new IsLessonLastPartResponse
                {
                    Success = true,
                    IsLastPart = isLast
                };
            }
            catch (Exception ex)
            {
                var response = new IsLessonLastPartResponse
                {
                    Success = false,
                    Exception = ex
                };

                return response;
            }
        }

        public GetAllContentLessonResponse GetAllContent(GetAllContentLessonRequest request)
        {
            try
            {
                var lesson = _repository.GetAllContent(request.LessonId);

                if(lesson == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
                }

                return new GetAllContentLessonResponse
                {
                    Success = true,
                    Lesson = lesson
                };
            }
            catch (Exception ex)
            {
                return new GetAllContentLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public PublishLessonResponse Publish(PublishLessonRequest request)
        {
            try
            {
                var lesson = _repository.GetAllContent(request.LessonId);

                if(lesson == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
                }

                var validator = new PublishLessonValidator(lesson);
                ValidationResult result = validator.Validate();

                if (!result.IsValid)
                {
                    return new PublishLessonResponse
                    {
                        Success = false,
                        ValidationFailures = result.Errors.ToList()
                    };
                }

                _repository.Publish(request.AccountId, request.LessonId);

                var notifyRequest = new NotifySubscribersRequest
                {
                    AccountId = request.AccountId,
                    LessonId = request.LessonId,
                    NotificationSource = NotificationSource.Publish,
                    UrlPath = request.UrlPath
                };

                new SubscribeActivityBusinessService().NotifySubscribers(notifyRequest);

                return new PublishLessonResponse
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new PublishLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public UpdateLessonResponse Update(UpdateLessonRequest request)
        {
            try
            {
                List<ValidationFailure> errors = new List<ValidationFailure>();

                var lesson = new Domain.Entity.Lesson.Lesson
                {
                    Id = request.LessonId,
                    DCFCODE = request.Confidentiality,
                    LSNTITLE = request.Title,
                    LSNDESCRIPTION = request.Description,
                    LSNTARGET = StringUtilities.GetListFormated(request.Targets),
                    STDCODE = request.Study,
                    LSNLEVEL = request.Level
                };

                errors.AddRange(GetErrors(lesson, ValidationType.Update));

                if (errors.Any())
                {
                    return new UpdateLessonResponse
                    {
                        Success = false,
                        ValidationFailures = errors
                    };
                }

                var updated = _repository.Update(request.LessonId, lesson);

                return new UpdateLessonResponse
                {
                    Success = true,
                    Updated = updated
                };
            }
            catch (Exception ex)
            {
                return new UpdateLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetLessonAlternativePictureResponse GetAlternativePicture(GetLessonAlternativePictureRequest request)
        {
            var lesson = _repository.FindBy(request.LessonId);

            if(lesson == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
            }

            string studyFolder = ConfigurationManager.AppSettings.Get("StudyFolder");
            string lessonFolder = ConfigurationManager.AppSettings.Get("LessonFolder");
            string thumbnailFolder = ConfigurationManager.AppSettings.Get("ThumbnailFolder");

            if (string.IsNullOrEmpty(lesson.LSNPICTURE))
            {
                var studyRequest = new GetStudyRequest
                {
                    Code = lesson.STDCODE
                };

                var studyResponse = new StudyBusinessService().Get(studyRequest);

                return new GetLessonAlternativePictureResponse
                {
                    Success = true,
                    IsAlternative = true,
                    LessonTitle = lesson.LSNTITLE,
                    StudyName = studyResponse.Study.STDNAME,
                    PicturePath = Path.Combine(studyFolder, studyResponse.Study.STDPICTURE)      
                };
            }

            string picturePath = request.GetThumbnailPicture ?
                                    Path.Combine(thumbnailFolder, lessonFolder, lesson.LSNPICTURE) :
                                    Path.Combine(lessonFolder, lesson.LSNPICTURE);

            return new GetLessonAlternativePictureResponse
            {
                Success = true,
                IsAlternative = false,
                LessonTitle = lesson.LSNPICTURE,
                PicturePath = picturePath,
                StudyName = lesson.Study.STDNAME
            };
        }

        public DeleteLessonResponse Delete(DeleteLessonRequest request)
        {
            try
            {
                var lesson = _repository.Delete(request.AccountId, request.LessonId);

                return new DeleteLessonResponse
                {
                    Success = true,
                    Lesson = lesson
                };
            }
            catch (Exception ex)
            {
                return new DeleteLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetLessonRecentResponse GetRecent(GetLessonRecentRequest request)
        {
            try
            {
                var lessons = _repository.GetAllRecent(request.StudyCode, request.Level);

                int totalPages = ListUtilities.GetTotalPagesCount(lessons.Count, request.Count);

                List<Domain.Entity.Lesson.Lesson> pagedList = lessons.OrderByDescending(l => l.LSNDATE)
                                                                        .Skip((request.Page - 1) * request.Count)
                                                                        .Take(request.Count)
                                                                        .ToList();

                return new GetLessonRecentResponse
                {
                    Success = true,
                    Lessons = pagedList,
                    TotalPages = totalPages
                };
            }
            catch (Exception ex)
            {
                return new GetLessonRecentResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public UpdateAttachedFilesResponse UpdateAttachedFiles(UpdateAttachedFilesRequest request)
        {
            try
            {
                var lesson = _repository.FindBy(request.LessonId);

                if (lesson == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
                }


                if (!string.IsNullOrEmpty(request.VideoFile))
                {
                    lesson.LSNATTACHEDVIDEO = request.VideoFile;
                }

                if (!string.IsNullOrEmpty(request.SoundFile))
                {
                    lesson.LSNATTACHEDSOUND = request.SoundFile;
                }

                if (!string.IsNullOrEmpty(request.DocumentFile))
                {
                    lesson.LSNATTACHEDDOC = request.DocumentFile;
                }

                if (!string.IsNullOrEmpty(request.ExerciceFile))
                {
                    lesson.LSNATTACHEDEXC = request.ExerciceFile;
                }

                _repository.Save(lesson);

                return new UpdateAttachedFilesResponse
                {
                    Updated = lesson,
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new UpdateAttachedFilesResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }
    }
}
